using nf_xml_api.Models;

public interface TotalNotaService
{
    void SalvarTotalNota(ImportacaoNotaXml nota, nfeProc dto, string chave, string hash);
}