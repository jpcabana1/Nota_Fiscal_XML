using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nf_xml_api.Models;

namespace nf_xml_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportacaoNotaXmlController : ControllerBase
    {

        private readonly NotaFiscalContext _context;

        public ImportacaoNotaXmlController(NotaFiscalContext context)
        {
            _context = context;
        }

        [HttpPost]
        public string testeImportacao()
        {
            var file = Request.Form.Files[0];
            string chave = Request.Form["chave"];
            string hash = Request.Form["hash"];

            var docXml = new XmlDocument();
            docXml.Load(file.OpenReadStream());

            var docValidate = new XDocument();
            using (var nodeReader = new XmlNodeReader(docXml))
            {
                nodeReader.MoveToContent();
                docValidate = XDocument.Load(nodeReader);
            }

            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add("http://www.portalfiscal.inf.br/nfe", "https://dfe-portal.svrs.rs.gov.br/Schemas/PRNFH/procNFe_v4.00.xsd");
            schema.Add("http://www.portalfiscal.inf.br/nfe", "https://dfe-portal.svrs.rs.gov.br/Schemas/PRNFH/nfe_v4.00.xsd");
            schema.Add("http://www.portalfiscal.inf.br/nfe", "https://dfe-portal.svrs.rs.gov.br/Schemas/PRNFH/leiauteNFe_v4.00.xsd");
            schema.Add("http://www.portalfiscal.inf.br/nfe", "https://dfe-portal.svrs.rs.gov.br/Schemas/PRNFH/tiposBasico_v4.00.xsd");
            schema.Add("http://www.w3.org/2000/09/xmldsig#", "https://dfe-portal.svrs.rs.gov.br/Schemas/PRNF3E/xmldsig-core-schema_v1.01.xsd");
            docValidate.Validate(schema, ValidationEventHandler);

            // XmlReaderSettings Settings = new XmlReaderSettings();
            // Settings.Schemas.Add("http://www.portalfiscal.inf.br/nfe", "https://dfe-portal.svrs.rs.gov.br/Schemas/PRNFH/procNFe_v4.00.xsd");
            // Settings.Schemas.Add("http://www.portalfiscal.inf.br/nfe", "https://dfe-portal.svrs.rs.gov.br/Schemas/PRNFH/nfe_v4.00.xsd");
            // Settings.Schemas.Add("http://www.portalfiscal.inf.br/nfe", "https://dfe-portal.svrs.rs.gov.br/Schemas/PRNFH/leiauteNFe_v4.00.xsd");
            // Settings.Schemas.Add("http://www.portalfiscal.inf.br/nfe", "https://dfe-portal.svrs.rs.gov.br/Schemas/PRNFH/tiposBasico_v4.00.xsd");
            // Settings.Schemas.Add("http://www.w3.org/2000/09/xmldsig#", "https://dfe-portal.svrs.rs.gov.br/Schemas/PRNF3E/xmldsig-core-schema_v1.01.xsd");
            // Settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
            // Settings.ValidationType = ValidationType.Schema;
            // try
            // {
            //     XmlReader validator = XmlReader.Create(XmlReader.Create(file.OpenReadStream()), Settings);
            // }
            // catch (Exception EX)
            // {
            //     string ex = EX.ToString();
            // }

            if (docXml.DocumentElement != null)
            {
                using (var reader = new StringReader(docXml.DocumentElement.OuterXml))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(nfeProc));
                    nfeProc objDes = (nfeProc)serializer.Deserialize(reader);

                    _context.ImportacaoNotaXmls.Add(new ImportacaoNotaXml()
                    {
                        XChave = chave,
                        XHash = hash,
                        XStatusImportacao = "PROCESSANDO",
                        XmlNota = docXml.DocumentElement.OuterXml
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

                return docXml.DocumentElement.OuterXml;
            }
            else
            {
                return "Falha";
            }

        }

        // void ValidationCallBack(object sender, ValidationEventArgs args)
        // {
        //     if (args.Severity == XmlSeverityType.Warning)
        //         Console.WriteLine("\tWarning: Matching schema not found.  No validation occurred." + args.Message);
        //     else
        //         Console.WriteLine("\tValidation error: " + args.Message);
        // }
        void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            XmlSeverityType type = XmlSeverityType.Warning;
            if (Enum.TryParse<XmlSeverityType>("Error", out type))
            {
                if (type == XmlSeverityType.Error) throw new Exception(e.Message);
            }
        }
    }
}

