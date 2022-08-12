using Microsoft.AspNetCore.Mvc;
using nf_xml_api.Models;

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
        public object importarNota(string chave, string hash, DateTime dtProducao, IFormFile arquivoXml)
        {
            IFormFile arquivo = arquivoXml;
            var xmlDoc = xmlNotaService.converterXmlNotaRequest(arquivo);
            var xDocValidar = xmlNotaService.converterXmlNotaParaValidacao(xmlDoc);
            List<string> errosValidacao = xmlNotaService.validarSchemaProcNFe_v4_00(xDocValidar);

            importacaoService.importarNotaXml(xmlDoc, chave, hash);

            ImportacaoNotaXml nota = importacaoService.findNotaPorChaveEHash(chave, hash);
            TNfeProc notaDto = xmlNotaService.converterXmlParaDto(xmlDoc);

            produtoService.salvarProdutosNota(nota, notaDto, chave, hash);
            totalNotaService.SalvarTotalNota(nota, notaDto, chave, hash);

            return Ok(new
            {
                mensagem = "Nota Fiscal importada com sucesso!",
                validacoesSchema = errosValidacao
            });
        }
    }
}

