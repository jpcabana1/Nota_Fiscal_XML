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
        private readonly ImportacaoServiceImpl importacaoService;
        private readonly ProdutoServiceImpl produtoService;
        private readonly TotalNotaServiceImpl totalNotaService;
        private readonly XmlNotaServiceImpl xmlNotaService;

        public ImportacaoNotaXmlController(NotaFiscalContext context, ImportacaoServiceImpl importacaoService, ProdutoServiceImpl produtoService, TotalNotaServiceImpl totalNotaService, XmlNotaServiceImpl xmlNotaService)
        {
            _context = context;
            this.importacaoService = importacaoService;
            this.produtoService = produtoService;
            this.totalNotaService = totalNotaService;
            this.xmlNotaService = xmlNotaService;
        }

        [HttpPost]
        public object testeImportacao()
        {
            IFormFile arquivo = Request.Form.Files[0];
            string chave = Request.Form["chave"];
            string hash = Request.Form["hash"];

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(arquivo.OpenReadStream());

            var xDocValidar = new XDocument();
            using (var nodeReader = new XmlNodeReader(xmlDoc))
            {
                nodeReader.MoveToContent();
                xDocValidar = XDocument.Load(nodeReader);
            }

            var uri = new Uri(Environment.CurrentDirectory + "/PL_009_V4_00_NT_2018_005_v1.10");
            erros.Clear();
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add("http://www.portalfiscal.inf.br/nfe", uri.AbsolutePath + "/procNFe_v4.00.xsd");
            schema.Add("http://www.portalfiscal.inf.br/nfe", uri.AbsolutePath + "/nfe_v4.00.xsd");
            schema.Add("http://www.portalfiscal.inf.br/nfe", uri.AbsolutePath + "/leiauteNFe_v4.00.xsd");
            schema.Add("http://www.portalfiscal.inf.br/nfe", uri.AbsolutePath + "/tiposBasico_v4.00.xsd");
            schema.Add("http://www.w3.org/2000/09/xmldsig#", uri.AbsolutePath + "/xmldsig-core-schema_v1.01.xsd");
            xDocValidar.Validate(schema, ValidationEventHandler);

            if (xmlDoc.DocumentElement != null && erros.Count == 0)
            {
                using (var reader = new StringReader(xmlDoc.DocumentElement.OuterXml))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(nfeProc));
                    nfeProc objDes = (nfeProc)serializer.Deserialize(reader);

                    _context.ImportacaoNotaXmls.Add(new ImportacaoNotaXml()
                    {
                        XChave = chave,
                        XHash = hash,
                        XStatusImportacao = "PROCESSANDO",
                        XmlNota = xmlDoc.DocumentElement.OuterXml
                    });

                    _context.SaveChanges();

                    var queryNota = from importacaoNota in _context.ImportacaoNotaXmls
                                    where importacaoNota.XChave == chave && importacaoNota.XHash == hash
                                    select importacaoNota;

                    ImportacaoNotaXml nota = queryNota.FirstOrDefault();

                    foreach (var item in objDes.proc.nfeProc.NFe.infNFe.det)
                    {
                        _context.ProdutoNota.Add(new ProdutoNotum()
                        {
                            CEan = Int64.TryParse(item.prod.cEAN, out long number) ? number : -1,
                            CEantrib = item.prod.cEANTrib,
                            Cest = unchecked((int)item.prod.CEST),
                            Cfop = item.prod.CFOP,
                            CProd = unchecked((long)item.prod.cProd),
                            IndTot = item.prod.indTot,
                            Ncm = unchecked((int)item.prod.NCM),
                            QCom = item.prod.qCom,
                            QTrib = item.prod.qTrib,
                            UCom = item.prod.uCom,
                            UTrib = item.prod.uTrib,
                            VProd = item.prod.vProd,
                            VUnCom = item.prod.vUnCom,
                            VUnTrib = item.prod.vUnTrib,
                            XProd = item.prod.xProd,
                            IdNota = nota.IdNota,
                            XChave = chave,
                            XHash = hash
                        });
                    }

                    _context.TotalNota.Add(new TotalNotum()
                    {
                        IdNota = nota.IdNota,
                        XChave = chave,
                        XHash = hash,
                        VBc = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vBC,
                        VBcst = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vBCST,
                        VCofins = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vCOFINS,
                        VDesc = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vDesc,
                        VFcp = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vFCP,
                        VFcpst = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vFCPST,
                        VFcpstret = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vFCPSTRet,
                        VFrete = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vFrete,
                        VIcms = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vICMS,
                        VIcmsdeson = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vICMSDeson,
                        VIi = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vII,
                        VIpi = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vIPI,
                        VIpidevol = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vIPIDevol,
                        VNf = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vNF,
                        VOutro = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vOutro,
                        VPis = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vPIS,
                        VProd = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vProd,
                        VSeg = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vSeg,
                        VSt = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vST,
                        VTotTrib = objDes.proc.nfeProc.NFe.infNFe.total.ICMSTot.vTotTrib
                    });

                    _context.SaveChangesAsync();

                }

                return xmlDoc.DocumentElement.OuterXml;
            }
            else if (erros.Count > 0)
            {
                return erros;
            }
            else
            {
                return "Falha";
            }

        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            XmlSeverityType type = XmlSeverityType.Warning;
            if (Enum.TryParse<XmlSeverityType>("Error", out type))
            {
                if (type == XmlSeverityType.Error)
                {
                    erros.Add(e.Message);
                }
            }
        }


        [HttpPost("/importarNota")]
        public object importarNota(string chave, string hash, IFormFile file)
        {
            try
            {
                //IFormFile arquivo = Request.Form.Files[0];
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
            catch (Exception e)
            {

                return new
                {
                    status = 500,
                    mensagem = "Erro ao importar nota: " + e.Message
                };
            }
        }
    }
}

