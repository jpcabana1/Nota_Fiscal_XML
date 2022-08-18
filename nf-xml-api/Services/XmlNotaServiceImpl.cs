using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

public class XmlNotaServiceImpl : XmlNotaService
{
    static List<string> erros = new List<string>();
    public XmlDocument converterXmlNotaRequest(IFormFile arquivo)
    {
        var xmlDoc = new XmlDocument();
        xmlDoc.Load(arquivo.OpenReadStream());
        if(xmlDoc.GetElementsByTagName("nfeProc").Count < 2){
            throw new Exception("XML não reconhecido!");
        }
        xmlDoc.LoadXml(xmlDoc.GetElementsByTagName("nfeProc")[1].OuterXml);
        return xmlDoc;
    }
    public XDocument converterXmlNotaParaValidacao(XmlDocument xmlNota)
    {
        var xDocValidar = new XDocument();
        using (var nodeReader = new XmlNodeReader(xmlNota))
        {
            nodeReader.MoveToContent();
            xDocValidar = XDocument.Load(nodeReader);
        }
        return xDocValidar;
    }
    public List<string> validarSchemaProcNFe_v4_00(XDocument xDocValidar)
    {
        var uri = new Uri(Environment.CurrentDirectory + "/SchemasNFE");
        erros.Clear();
        XmlSchemaSet schema = new XmlSchemaSet();
        schema.Add("http://www.portalfiscal.inf.br/nfe", uri.AbsolutePath + "/procNFe_v4.00.xsd");
        schema.Add("http://www.portalfiscal.inf.br/nfe", uri.AbsolutePath + "/nfe_v4.00.xsd");
        schema.Add("http://www.portalfiscal.inf.br/nfe", uri.AbsolutePath + "/leiauteNFe_v4.00.xsd");
        schema.Add("http://www.portalfiscal.inf.br/nfe", uri.AbsolutePath + "/tiposBasico_v4.00.xsd");
        schema.Add("http://www.w3.org/2000/09/xmldsig#", uri.AbsolutePath + "/xmldsig-core-schema_v1.01.xsd");
        xDocValidar.Validate(schema, ValidationEventHandler);
        return erros;
    }
    private static void ValidationEventHandler(object sender, ValidationEventArgs e)
    {
        XmlSeverityType type = XmlSeverityType.Warning;
        if (Enum.TryParse<XmlSeverityType>("Error", out type))
        {
            if (type == XmlSeverityType.Error)
            {
                erros.Add(e.Message);
            }
        }
    }
    public TNfeProc converterXmlParaDto(XmlDocument xmlDoc)
    {
        TNfeProc objDes = null;
        if (xmlDoc.DocumentElement != null)
        {
            using (var reader = new StringReader(xmlDoc.DocumentElement.OuterXml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(TNfeProc));
                objDes = (TNfeProc)serializer.Deserialize(reader);
            }
        }
        return objDes;
    }
}