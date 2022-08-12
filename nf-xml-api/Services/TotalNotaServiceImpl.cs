using nf_xml_api.Models;

public class TotalNotaServiceImpl : TotalNotaService
{
    private readonly NotaFiscalContext _context;
    public TotalNotaServiceImpl(NotaFiscalContext context)
    {
        _context = context;

    }
    public void SalvarTotalNota(ImportacaoNotaXml nota, TNfeProc dto, string chave, string hash)
    {
        _context.TotalNota.Add(new TotalNotum()
        {
            IdNota = nota.IdNota,
            XChave = chave,
            XHash = hash,
            VBc = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vBC, out decimal VBc) ? VBc : 0,
            VBcst = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vBCST, out decimal VBcst) ? VBcst : 0,
            VCofins = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vCOFINS, out decimal VCofins) ? VCofins : 0,
            VDesc = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vDesc, out decimal VDesc) ? VDesc : 0,
            VFcp = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vFCP, out decimal VFcp) ? VFcp : 0,
            VFcpst = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vFCPST, out decimal VFcpst) ? VFcpst : 0,
            VFcpstret = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vFCPSTRet, out decimal VFcpstret) ? VFcpstret : 0,
            VFrete = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vFrete, out decimal VFrete) ? VFrete : 0,
            VIcms = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vICMS, out decimal VIcms) ? VIcms : 0,
            VIcmsdeson = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vICMSDeson, out decimal VIcmsdeson) ? VIcmsdeson : 0,
            VIi = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vII, out decimal VIi) ? VIi : 0,
            VIpi = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vIPI, out decimal VIpi) ? VIpi : 0,
            VIpidevol = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vIPIDevol, out decimal VIpidevol) ? VIpidevol : 0,
            VNf = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vNF, out decimal VNf) ? VNf : 0,
            VOutro = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vOutro, out decimal VOutro) ? VOutro : 0,
            VPis = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vPIS, out decimal VPis) ? VPis : 0,
            VProd = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vProd, out decimal VProd) ? VProd : 0,
            VSeg = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vSeg, out decimal VSeg) ? VSeg : 0,
            VSt = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vST, out decimal VSt) ? VSt : 0,
            VTotTrib = decimal.TryParse(dto.NFe.infNFe.total.ICMSTot.vTotTrib, out decimal VTotTrib) ? VTotTrib : 0
        });

        _context.SaveChangesAsync();
    }
}