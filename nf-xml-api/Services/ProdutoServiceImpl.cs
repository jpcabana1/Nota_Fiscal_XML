using nf_xml_api.Models;

public class ProdutoServiceImpl : ProdutoService
{
    private readonly NotaFiscalContext _context;
    private readonly static int CodigoInvalido = -1;
    public ProdutoServiceImpl(NotaFiscalContext context)
    {
        _context = context;

    }

    public void salvarProdutosNota(ImportacaoNotaXml nota, TNfeProc dto, string chave, string hash)
    {

        foreach (var item in dto.NFe.infNFe.det)
        {
            _context.ProdutoNota.Add(new ProdutoNotum()
            {
                CEan = Int64.TryParse(item.prod.cEAN, out long number) ? number : CodigoInvalido,
                CEantrib = item.prod.cEANTrib,
                Cest = int.TryParse(item.prod.CEST, out int Cest) ? Cest : CodigoInvalido,
                Cfop = int.TryParse(item.prod.CFOP, out int Cfop) ? Cfop : CodigoInvalido,
                CProd = Int64.TryParse(item.prod.cProd, out long CProd) ? CProd : CodigoInvalido,
                IndTot = ((int)item.prod.indTot),
                Ncm = int.TryParse(item.prod.NCM, out int Ncm) ? Ncm : 0,
                QCom = decimal.TryParse(item.prod.qCom, out decimal QCom) ? QCom : 0,
                QTrib = decimal.TryParse(item.prod.qTrib, out decimal QTrib) ? QTrib : 0,
                UCom = item.prod.uCom,
                UTrib = item.prod.uTrib,
                VProd = decimal.TryParse(item.prod.vProd, out decimal VProd) ? VProd : 0,
                VUnCom = decimal.TryParse(item.prod.vUnCom, out decimal VUnCom) ? VUnCom : 0,
                VUnTrib = decimal.TryParse(item.prod.vUnTrib, out decimal VUnTrib) ? VUnTrib : 0,
                XProd = item.prod.xProd,
                IdNota = nota.IdNota,
                XChave = chave,
                XHash = hash
            });
        }
        _context.SaveChanges();
    }
}