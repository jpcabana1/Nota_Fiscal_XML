using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
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
            var files = Request.Form.Files[0];
            string chave = Request.Form["chave"];
            string hash = Request.Form["hash"];

            var doc = new XmlDocument();
            doc.Load(files.OpenReadStream());

            if (doc.DocumentElement != null)
            {
                using (TextReader sr = new StringReader(doc.DocumentElement.OuterXml))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(nfeProc));
                    nfeProc objDes = (nfeProc)serializer.Deserialize(sr);

                    _context.ImportacaoNotaXmls.Add(new ImportacaoNotaXml()
                    {
                        XChave = chave,
                        XHash = hash,
                        XStatusImportacao = "PROCESSANDO",
                        XmlNota = doc.DocumentElement.OuterXml
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
                    _context.SaveChanges();

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
                    _context.SaveChanges();
                }
                return doc.DocumentElement.OuterXml;
            }
            else
            {
                return "Falha";
            }

        }
    }
}
