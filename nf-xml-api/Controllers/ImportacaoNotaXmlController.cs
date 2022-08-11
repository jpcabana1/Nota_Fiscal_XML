using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using nf_xml_api.Models;
using nf_xml_api.Services;

namespace nf_xml_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportacaoNotaXmlController : ControllerBase
    {

        static List<string> erros = new List<string>();
        private readonly NotaFiscalContext _context;
        private readonly ImportacaoService importacaoService;
        private readonly ProdutoService produtoService;
        private readonly TotalNotaService totalNotaService;
        private readonly XmlNotaService xmlNotaService;

        public ImportacaoNotaXmlController(NotaFiscalContext context, ImportacaoService importacaoService,
                                ProdutoService produtoService, TotalNotaService totalNotaService, XmlNotaService xmlNotaService)
        {
            _context = context;
            this.importacaoService = importacaoService;
            this.produtoService = produtoService;
            this.totalNotaService = totalNotaService;
            this.xmlNotaService = xmlNotaService;
        }

        [HttpPost("/importarNota")]
        public object importarNota(string chave, string hash, DateTime dtProducao, IFormFile file)
        {
            IFormFile arquivo = file;
            var xmlDoc = xmlNotaService.converterXmlNotaRequest(arquivo);
            var xDocValidar = xmlNotaService.converterXmlNotaParaValidacao(xmlDoc);
            List<string> errosValidacao = xmlNotaService.validarSchemaProcNFe_v4_00(xDocValidar);

            importacaoService.importarNotaXml(xmlDoc, chave, hash);

            ImportacaoNotaXml nota = importacaoService.findNotaPorChaveEHash(chave, hash);
            nfeProc notaDto = xmlNotaService.converterXmlParaDto(xmlDoc);

            produtoService.salvarProdutosNota(nota, notaDto, chave, hash);
            totalNotaService.SalvarTotalNota(nota, notaDto, chave, hash);

            return new
            {
                status = 200,
                mensagem = "Nota Fiscal importada com sucesso!",
                erros = errosValidacao
            };
        }
    }
}

