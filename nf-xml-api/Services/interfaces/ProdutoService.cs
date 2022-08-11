using nf_xml_api.Models;

public interface ProdutoService
{
    void salvarProdutosNota(ImportacaoNotaXml nota, nfeProc dto, string chave, string hash);
}