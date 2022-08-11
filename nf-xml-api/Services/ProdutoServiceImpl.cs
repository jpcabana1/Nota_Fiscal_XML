using nf_xml_api.Models;

public class ProdutoServiceImpl : ProdutoService
{
    private readonly NotaFiscalContext _context;
    public ProdutoServiceImpl(NotaFiscalContext context)
    {
        _context = context;

    }
    
    public void salvarProdutosNota(ImportacaoNotaXml nota, nfeProc dto, string chave, string hash)
    {

        foreach (var item in dto.proc.nfeProc.NFe.infNFe.det)
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
    }
}