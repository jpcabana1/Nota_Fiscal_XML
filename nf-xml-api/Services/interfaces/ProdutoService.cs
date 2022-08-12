using nf_xml_api.Models;

public interface ProdutoService
{
    void salvarProdutosNota(ImportacaoNotaXml nota, TNfeProc dto, string chave, string hash);
}