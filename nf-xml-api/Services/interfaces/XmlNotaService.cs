using System.Xml;
using System.Xml.Linq;
public interface XmlNotaService
{
    XmlDocument converterXmlNotaRequest(IFormFile arquivo);
    XDocument converterXmlNotaParaValidacao(XmlDocument xmlNota);
    List<string> validarSchemaProcNFe_v4_00(XDocument xDocValidar);
    TNfeProc converterXmlParaDto(XmlDocument xmlDoc);
}