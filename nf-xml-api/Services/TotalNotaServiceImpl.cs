using nf_xml_api.Models;

public class TotalNotaServiceImpl : TotalNotaService
{
    private readonly NotaFiscalContext _context;
    public TotalNotaServiceImpl(NotaFiscalContext context)
    {
        _context = context;

    }
    public void SalvarTotalNota(ImportacaoNotaXml nota, nfeProc dto, string chave, string hash)
    {
        _context.TotalNota.Add(new TotalNotum()
                    {
                        IdNota = nota.IdNota,
                        XChave = chave,
                        XHash = hash,
                        VBc = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vBC,
                        VBcst = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vBCST,
                        VCofins = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vCOFINS,
                        VDesc = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vDesc,
                        VFcp = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vFCP,
                        VFcpst = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vFCPST,
                        VFcpstret = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vFCPSTRet,
                        VFrete = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vFrete,
                        VIcms = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vICMS,
                        VIcmsdeson = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vICMSDeson,
                        VIi = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vII,
                        VIpi = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vIPI,
                        VIpidevol = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vIPIDevol,
                        VNf = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vNF,
                        VOutro = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vOutro,
                        VPis = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vPIS,
                        VProd = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vProd,
                        VSeg = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vSeg,
                        VSt = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vST,
                        VTotTrib = dto.proc.nfeProc.NFe.infNFe.total.ICMSTot.vTotTrib
                    });

                    _context.SaveChangesAsync();
    }
}