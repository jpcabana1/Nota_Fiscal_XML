
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
public partial class nfeProc
{

    private object erroField;

    private byte consultaField;

    private string dataHoraField;

    private string urlConsultaField;

    private nfeProcProc procField;

    private string[] textField;

    /// <remarks/>
    public object erro
    {
        get
        {
            return this.erroField;
        }
        set
        {
            this.erroField = value;
        }
    }

    /// <remarks/>
    public byte consulta
    {
        get
        {
            return this.consultaField;
        }
        set
        {
            this.consultaField = value;
        }
    }

    /// <remarks/>
    public string dataHora
    {
        get
        {
            return this.dataHoraField;
        }
        set
        {
            this.dataHoraField = value;
        }
    }

    /// <remarks/>
    public string urlConsulta
    {
        get
        {
            return this.urlConsultaField;
        }
        set
        {
            this.urlConsultaField = value;
        }
    }

    /// <remarks/>
    public nfeProcProc proc
    {
        get
        {
            return this.procField;
        }
        set
        {
            this.procField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProc
{

    private nfeProcProcNfeProc nfeProcField;

    private string schemaField;

    private uint nSUField;

    private string endIPField;

    /// <remarks/>
    public nfeProcProcNfeProc nfeProc
    {
        get
        {
            return this.nfeProcField;
        }
        set
        {
            this.nfeProcField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string schema
    {
        get
        {
            return this.schemaField;
        }
        set
        {
            this.schemaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint NSU
    {
        get
        {
            return this.nSUField;
        }
        set
        {
            this.nSUField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string endIP
    {
        get
        {
            return this.endIPField;
        }
        set
        {
            this.endIPField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProc
{

    private nfeProcProcNfeProcNFe nFeField;

    private nfeProcProcNfeProcProtNFe protNFeField;

    private decimal versaoField;

    /// <remarks/>
    public nfeProcProcNfeProcNFe NFe
    {
        get
        {
            return this.nFeField;
        }
        set
        {
            this.nFeField = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcProtNFe protNFe
    {
        get
        {
            return this.protNFeField;
        }
        set
        {
            this.protNFeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal versao
    {
        get
        {
            return this.versaoField;
        }
        set
        {
            this.versaoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFe
{

    private nfeProcProcNfeProcNFeInfNFe infNFeField;

    private nfeProcProcNfeProcNFeInfNFeSupl infNFeSuplField;

    private Signature signatureField;

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFe infNFe
    {
        get
        {
            return this.infNFeField;
        }
        set
        {
            this.infNFeField = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeSupl infNFeSupl
    {
        get
        {
            return this.infNFeSuplField;
        }
        set
        {
            this.infNFeSuplField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public Signature Signature
    {
        get
        {
            return this.signatureField;
        }
        set
        {
            this.signatureField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFe
{

    private nfeProcProcNfeProcNFeInfNFeIde ideField;

    private nfeProcProcNfeProcNFeInfNFeEmit emitField;

    private nfeProcProcNfeProcNFeInfNFeDet[] detField;

    private nfeProcProcNfeProcNFeInfNFeTotal totalField;

    private nfeProcProcNfeProcNFeInfNFeTransp transpField;

    private nfeProcProcNfeProcNFeInfNFeDetPag[] pagField;

    private nfeProcProcNfeProcNFeInfNFeInfRespTec infRespTecField;

    private string idField;

    private decimal versaoField;

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeIde ide
    {
        get
        {
            return this.ideField;
        }
        set
        {
            this.ideField = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeEmit emit
    {
        get
        {
            return this.emitField;
        }
        set
        {
            this.emitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("det")]
    public nfeProcProcNfeProcNFeInfNFeDet[] det
    {
        get
        {
            return this.detField;
        }
        set
        {
            this.detField = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeTotal total
    {
        get
        {
            return this.totalField;
        }
        set
        {
            this.totalField = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeTransp transp
    {
        get
        {
            return this.transpField;
        }
        set
        {
            this.transpField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("detPag", IsNullable = false)]
    public nfeProcProcNfeProcNFeInfNFeDetPag[] pag
    {
        get
        {
            return this.pagField;
        }
        set
        {
            this.pagField = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeInfRespTec infRespTec
    {
        get
        {
            return this.infRespTecField;
        }
        set
        {
            this.infRespTecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal versao
    {
        get
        {
            return this.versaoField;
        }
        set
        {
            this.versaoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeIde
{

    private byte cUFField;

    private uint cNFField;

    private string natOpField;

    private byte modField;

    private byte serieField;

    private uint nNFField;

    private System.DateTime dhEmiField;

    private byte tpNFField;

    private byte idDestField;

    private uint cMunFGField;

    private byte tpImpField;

    private byte tpEmisField;

    private byte cDVField;

    private byte tpAmbField;

    private byte finNFeField;

    private byte indFinalField;

    private byte indPresField;

    private byte indIntermedField;

    private byte procEmiField;

    private byte verProcField;

    /// <remarks/>
    public byte cUF
    {
        get
        {
            return this.cUFField;
        }
        set
        {
            this.cUFField = value;
        }
    }

    /// <remarks/>
    public uint cNF
    {
        get
        {
            return this.cNFField;
        }
        set
        {
            this.cNFField = value;
        }
    }

    /// <remarks/>
    public string natOp
    {
        get
        {
            return this.natOpField;
        }
        set
        {
            this.natOpField = value;
        }
    }

    /// <remarks/>
    public byte mod
    {
        get
        {
            return this.modField;
        }
        set
        {
            this.modField = value;
        }
    }

    /// <remarks/>
    public byte serie
    {
        get
        {
            return this.serieField;
        }
        set
        {
            this.serieField = value;
        }
    }

    /// <remarks/>
    public uint nNF
    {
        get
        {
            return this.nNFField;
        }
        set
        {
            this.nNFField = value;
        }
    }

    /// <remarks/>
    public System.DateTime dhEmi
    {
        get
        {
            return this.dhEmiField;
        }
        set
        {
            this.dhEmiField = value;
        }
    }

    /// <remarks/>
    public byte tpNF
    {
        get
        {
            return this.tpNFField;
        }
        set
        {
            this.tpNFField = value;
        }
    }

    /// <remarks/>
    public byte idDest
    {
        get
        {
            return this.idDestField;
        }
        set
        {
            this.idDestField = value;
        }
    }

    /// <remarks/>
    public uint cMunFG
    {
        get
        {
            return this.cMunFGField;
        }
        set
        {
            this.cMunFGField = value;
        }
    }

    /// <remarks/>
    public byte tpImp
    {
        get
        {
            return this.tpImpField;
        }
        set
        {
            this.tpImpField = value;
        }
    }

    /// <remarks/>
    public byte tpEmis
    {
        get
        {
            return this.tpEmisField;
        }
        set
        {
            this.tpEmisField = value;
        }
    }

    /// <remarks/>
    public byte cDV
    {
        get
        {
            return this.cDVField;
        }
        set
        {
            this.cDVField = value;
        }
    }

    /// <remarks/>
    public byte tpAmb
    {
        get
        {
            return this.tpAmbField;
        }
        set
        {
            this.tpAmbField = value;
        }
    }

    /// <remarks/>
    public byte finNFe
    {
        get
        {
            return this.finNFeField;
        }
        set
        {
            this.finNFeField = value;
        }
    }

    /// <remarks/>
    public byte indFinal
    {
        get
        {
            return this.indFinalField;
        }
        set
        {
            this.indFinalField = value;
        }
    }

    /// <remarks/>
    public byte indPres
    {
        get
        {
            return this.indPresField;
        }
        set
        {
            this.indPresField = value;
        }
    }

    /// <remarks/>
    public byte indIntermed
    {
        get
        {
            return this.indIntermedField;
        }
        set
        {
            this.indIntermedField = value;
        }
    }

    /// <remarks/>
    public byte procEmi
    {
        get
        {
            return this.procEmiField;
        }
        set
        {
            this.procEmiField = value;
        }
    }

    /// <remarks/>
    public byte verProc
    {
        get
        {
            return this.verProcField;
        }
        set
        {
            this.verProcField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeEmit
{

    private ulong cNPJField;

    private string xNomeField;

    private string xFantField;

    private nfeProcProcNfeProcNFeInfNFeEmitEnderEmit enderEmitField;

    private uint ieField;

    private byte cRTField;

    /// <remarks/>
    public ulong CNPJ
    {
        get
        {
            return this.cNPJField;
        }
        set
        {
            this.cNPJField = value;
        }
    }

    /// <remarks/>
    public string xNome
    {
        get
        {
            return this.xNomeField;
        }
        set
        {
            this.xNomeField = value;
        }
    }

    /// <remarks/>
    public string xFant
    {
        get
        {
            return this.xFantField;
        }
        set
        {
            this.xFantField = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeEmitEnderEmit enderEmit
    {
        get
        {
            return this.enderEmitField;
        }
        set
        {
            this.enderEmitField = value;
        }
    }

    /// <remarks/>
    public uint IE
    {
        get
        {
            return this.ieField;
        }
        set
        {
            this.ieField = value;
        }
    }

    /// <remarks/>
    public byte CRT
    {
        get
        {
            return this.cRTField;
        }
        set
        {
            this.cRTField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeEmitEnderEmit
{

    private string xLgrField;

    private ushort nroField;

    private string xBairroField;

    private uint cMunField;

    private string xMunField;

    private string ufField;

    private uint cEPField;

    private ushort cPaisField;

    private string xPaisField;

    /// <remarks/>
    public string xLgr
    {
        get
        {
            return this.xLgrField;
        }
        set
        {
            this.xLgrField = value;
        }
    }

    /// <remarks/>
    public ushort nro
    {
        get
        {
            return this.nroField;
        }
        set
        {
            this.nroField = value;
        }
    }

    /// <remarks/>
    public string xBairro
    {
        get
        {
            return this.xBairroField;
        }
        set
        {
            this.xBairroField = value;
        }
    }

    /// <remarks/>
    public uint cMun
    {
        get
        {
            return this.cMunField;
        }
        set
        {
            this.cMunField = value;
        }
    }

    /// <remarks/>
    public string xMun
    {
        get
        {
            return this.xMunField;
        }
        set
        {
            this.xMunField = value;
        }
    }

    /// <remarks/>
    public string UF
    {
        get
        {
            return this.ufField;
        }
        set
        {
            this.ufField = value;
        }
    }

    /// <remarks/>
    public uint CEP
    {
        get
        {
            return this.cEPField;
        }
        set
        {
            this.cEPField = value;
        }
    }

    /// <remarks/>
    public ushort cPais
    {
        get
        {
            return this.cPaisField;
        }
        set
        {
            this.cPaisField = value;
        }
    }

    /// <remarks/>
    public string xPais
    {
        get
        {
            return this.xPaisField;
        }
        set
        {
            this.xPaisField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeDet
{

    private nfeProcProcNfeProcNFeInfNFeDetProd prodField;

    private nfeProcProcNfeProcNFeInfNFeDetImposto impostoField;

    private byte nItemField;

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeDetProd prod
    {
        get
        {
            return this.prodField;
        }
        set
        {
            this.prodField = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeDetImposto imposto
    {
        get
        {
            return this.impostoField;
        }
        set
        {
            this.impostoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte nItem
    {
        get
        {
            return this.nItemField;
        }
        set
        {
            this.nItemField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeDetProd
{

    private ulong cProdField;

    private string cEANField;

    private string xProdField;

    private uint nCMField;

    private uint cESTField;

    private ushort cFOPField;

    private string uComField;

    private decimal qComField;

    private decimal vUnComField;

    private decimal vProdField;

    private string cEANTribField;

    private string uTribField;

    private decimal qTribField;

    private decimal vUnTribField;

    private decimal vDescField;

    private bool vDescFieldSpecified;

    private byte indTotField;

    /// <remarks/>
    public ulong cProd
    {
        get
        {
            return this.cProdField;
        }
        set
        {
            this.cProdField = value;
        }
    }

    /// <remarks/>
    public string cEAN
    {
        get
        {
            return this.cEANField;
        }
        set
        {
            this.cEANField = value;
        }
    }

    /// <remarks/>
    public string xProd
    {
        get
        {
            return this.xProdField;
        }
        set
        {
            this.xProdField = value;
        }
    }

    /// <remarks/>
    public uint NCM
    {
        get
        {
            return this.nCMField;
        }
        set
        {
            this.nCMField = value;
        }
    }

    /// <remarks/>
    public uint CEST
    {
        get
        {
            return this.cESTField;
        }
        set
        {
            this.cESTField = value;
        }
    }

    /// <remarks/>
    public ushort CFOP
    {
        get
        {
            return this.cFOPField;
        }
        set
        {
            this.cFOPField = value;
        }
    }

    /// <remarks/>
    public string uCom
    {
        get
        {
            return this.uComField;
        }
        set
        {
            this.uComField = value;
        }
    }

    /// <remarks/>
    public decimal qCom
    {
        get
        {
            return this.qComField;
        }
        set
        {
            this.qComField = value;
        }
    }

    /// <remarks/>
    public decimal vUnCom
    {
        get
        {
            return this.vUnComField;
        }
        set
        {
            this.vUnComField = value;
        }
    }

    /// <remarks/>
    public decimal vProd
    {
        get
        {
            return this.vProdField;
        }
        set
        {
            this.vProdField = value;
        }
    }

    /// <remarks/>
    public string cEANTrib
    {
        get
        {
            return this.cEANTribField;
        }
        set
        {
            this.cEANTribField = value;
        }
    }

    /// <remarks/>
    public string uTrib
    {
        get
        {
            return this.uTribField;
        }
        set
        {
            this.uTribField = value;
        }
    }

    /// <remarks/>
    public decimal qTrib
    {
        get
        {
            return this.qTribField;
        }
        set
        {
            this.qTribField = value;
        }
    }

    /// <remarks/>
    public decimal vUnTrib
    {
        get
        {
            return this.vUnTribField;
        }
        set
        {
            this.vUnTribField = value;
        }
    }

    /// <remarks/>
    public decimal vDesc
    {
        get
        {
            return this.vDescField;
        }
        set
        {
            this.vDescField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool vDescSpecified
    {
        get
        {
            return this.vDescFieldSpecified;
        }
        set
        {
            this.vDescFieldSpecified = value;
        }
    }

    /// <remarks/>
    public byte indTot
    {
        get
        {
            return this.indTotField;
        }
        set
        {
            this.indTotField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeDetImposto
{

    private decimal vTotTribField;

    private nfeProcProcNfeProcNFeInfNFeDetImpostoICMS iCMSField;

    private nfeProcProcNfeProcNFeInfNFeDetImpostoPIS pISField;

    private nfeProcProcNfeProcNFeInfNFeDetImpostoCOFINS cOFINSField;

    /// <remarks/>
    public decimal vTotTrib
    {
        get
        {
            return this.vTotTribField;
        }
        set
        {
            this.vTotTribField = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeDetImpostoICMS ICMS
    {
        get
        {
            return this.iCMSField;
        }
        set
        {
            this.iCMSField = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeDetImpostoPIS PIS
    {
        get
        {
            return this.pISField;
        }
        set
        {
            this.pISField = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeDetImpostoCOFINS COFINS
    {
        get
        {
            return this.cOFINSField;
        }
        set
        {
            this.cOFINSField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeDetImpostoICMS
{

    private nfeProcProcNfeProcNFeInfNFeDetImpostoICMSICMS40 iCMS40Field;

    private nfeProcProcNfeProcNFeInfNFeDetImpostoICMSICMS60 iCMS60Field;

    private nfeProcProcNfeProcNFeInfNFeDetImpostoICMSICMS00 iCMS00Field;

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeDetImpostoICMSICMS40 ICMS40
    {
        get
        {
            return this.iCMS40Field;
        }
        set
        {
            this.iCMS40Field = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeDetImpostoICMSICMS60 ICMS60
    {
        get
        {
            return this.iCMS60Field;
        }
        set
        {
            this.iCMS60Field = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeDetImpostoICMSICMS00 ICMS00
    {
        get
        {
            return this.iCMS00Field;
        }
        set
        {
            this.iCMS00Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeDetImpostoICMSICMS40
{

    private byte origField;

    private byte cSTField;

    /// <remarks/>
    public byte orig
    {
        get
        {
            return this.origField;
        }
        set
        {
            this.origField = value;
        }
    }

    /// <remarks/>
    public byte CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeDetImpostoICMSICMS60
{

    private byte origField;

    private byte cSTField;

    private decimal vBCSTRetField;

    private decimal pSTField;

    private decimal vICMSSTRetField;

    /// <remarks/>
    public byte orig
    {
        get
        {
            return this.origField;
        }
        set
        {
            this.origField = value;
        }
    }

    /// <remarks/>
    public byte CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }

    /// <remarks/>
    public decimal vBCSTRet
    {
        get
        {
            return this.vBCSTRetField;
        }
        set
        {
            this.vBCSTRetField = value;
        }
    }

    /// <remarks/>
    public decimal pST
    {
        get
        {
            return this.pSTField;
        }
        set
        {
            this.pSTField = value;
        }
    }

    /// <remarks/>
    public decimal vICMSSTRet
    {
        get
        {
            return this.vICMSSTRetField;
        }
        set
        {
            this.vICMSSTRetField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeDetImpostoICMSICMS00
{

    private byte origField;

    private byte cSTField;

    private byte modBCField;

    private decimal vBCField;

    private decimal pICMSField;

    private decimal vICMSField;

    /// <remarks/>
    public byte orig
    {
        get
        {
            return this.origField;
        }
        set
        {
            this.origField = value;
        }
    }

    /// <remarks/>
    public byte CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }

    /// <remarks/>
    public byte modBC
    {
        get
        {
            return this.modBCField;
        }
        set
        {
            this.modBCField = value;
        }
    }

    /// <remarks/>
    public decimal vBC
    {
        get
        {
            return this.vBCField;
        }
        set
        {
            this.vBCField = value;
        }
    }

    /// <remarks/>
    public decimal pICMS
    {
        get
        {
            return this.pICMSField;
        }
        set
        {
            this.pICMSField = value;
        }
    }

    /// <remarks/>
    public decimal vICMS
    {
        get
        {
            return this.vICMSField;
        }
        set
        {
            this.vICMSField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeDetImpostoPIS
{

    private nfeProcProcNfeProcNFeInfNFeDetImpostoPISPISNT pISNTField;

    private nfeProcProcNfeProcNFeInfNFeDetImpostoPISPISAliq pISAliqField;

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeDetImpostoPISPISNT PISNT
    {
        get
        {
            return this.pISNTField;
        }
        set
        {
            this.pISNTField = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeDetImpostoPISPISAliq PISAliq
    {
        get
        {
            return this.pISAliqField;
        }
        set
        {
            this.pISAliqField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeDetImpostoPISPISNT
{

    private byte cSTField;

    /// <remarks/>
    public byte CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeDetImpostoPISPISAliq
{

    private byte cSTField;

    private decimal vBCField;

    private decimal pPISField;

    private decimal vPISField;

    /// <remarks/>
    public byte CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }

    /// <remarks/>
    public decimal vBC
    {
        get
        {
            return this.vBCField;
        }
        set
        {
            this.vBCField = value;
        }
    }

    /// <remarks/>
    public decimal pPIS
    {
        get
        {
            return this.pPISField;
        }
        set
        {
            this.pPISField = value;
        }
    }

    /// <remarks/>
    public decimal vPIS
    {
        get
        {
            return this.vPISField;
        }
        set
        {
            this.vPISField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeDetImpostoCOFINS
{

    private nfeProcProcNfeProcNFeInfNFeDetImpostoCOFINSCOFINSNT cOFINSNTField;

    private nfeProcProcNfeProcNFeInfNFeDetImpostoCOFINSCOFINSAliq cOFINSAliqField;

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeDetImpostoCOFINSCOFINSNT COFINSNT
    {
        get
        {
            return this.cOFINSNTField;
        }
        set
        {
            this.cOFINSNTField = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeDetImpostoCOFINSCOFINSAliq COFINSAliq
    {
        get
        {
            return this.cOFINSAliqField;
        }
        set
        {
            this.cOFINSAliqField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeDetImpostoCOFINSCOFINSNT
{

    private byte cSTField;

    /// <remarks/>
    public byte CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeDetImpostoCOFINSCOFINSAliq
{

    private byte cSTField;

    private decimal vBCField;

    private decimal pCOFINSField;

    private decimal vCOFINSField;

    /// <remarks/>
    public byte CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }

    /// <remarks/>
    public decimal vBC
    {
        get
        {
            return this.vBCField;
        }
        set
        {
            this.vBCField = value;
        }
    }

    /// <remarks/>
    public decimal pCOFINS
    {
        get
        {
            return this.pCOFINSField;
        }
        set
        {
            this.pCOFINSField = value;
        }
    }

    /// <remarks/>
    public decimal vCOFINS
    {
        get
        {
            return this.vCOFINSField;
        }
        set
        {
            this.vCOFINSField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeTotal
{

    private nfeProcProcNfeProcNFeInfNFeTotalICMSTot iCMSTotField;

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeTotalICMSTot ICMSTot
    {
        get
        {
            return this.iCMSTotField;
        }
        set
        {
            this.iCMSTotField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeTotalICMSTot
{

    private decimal vBCField;

    private decimal vICMSField;

    private decimal vICMSDesonField;

    private decimal vFCPField;

    private decimal vBCSTField;

    private decimal vSTField;

    private decimal vFCPSTField;

    private decimal vFCPSTRetField;

    private decimal vProdField;

    private decimal vFreteField;

    private decimal vSegField;

    private decimal vDescField;

    private decimal vIIField;

    private decimal vIPIField;

    private decimal vIPIDevolField;

    private decimal vPISField;

    private decimal vCOFINSField;

    private decimal vOutroField;

    private decimal vNFField;

    private decimal vTotTribField;

    /// <remarks/>
    public decimal vBC
    {
        get
        {
            return this.vBCField;
        }
        set
        {
            this.vBCField = value;
        }
    }

    /// <remarks/>
    public decimal vICMS
    {
        get
        {
            return this.vICMSField;
        }
        set
        {
            this.vICMSField = value;
        }
    }

    /// <remarks/>
    public decimal vICMSDeson
    {
        get
        {
            return this.vICMSDesonField;
        }
        set
        {
            this.vICMSDesonField = value;
        }
    }

    /// <remarks/>
    public decimal vFCP
    {
        get
        {
            return this.vFCPField;
        }
        set
        {
            this.vFCPField = value;
        }
    }

    /// <remarks/>
    public decimal vBCST
    {
        get
        {
            return this.vBCSTField;
        }
        set
        {
            this.vBCSTField = value;
        }
    }

    /// <remarks/>
    public decimal vST
    {
        get
        {
            return this.vSTField;
        }
        set
        {
            this.vSTField = value;
        }
    }

    /// <remarks/>
    public decimal vFCPST
    {
        get
        {
            return this.vFCPSTField;
        }
        set
        {
            this.vFCPSTField = value;
        }
    }

    /// <remarks/>
    public decimal vFCPSTRet
    {
        get
        {
            return this.vFCPSTRetField;
        }
        set
        {
            this.vFCPSTRetField = value;
        }
    }

    /// <remarks/>
    public decimal vProd
    {
        get
        {
            return this.vProdField;
        }
        set
        {
            this.vProdField = value;
        }
    }

    /// <remarks/>
    public decimal vFrete
    {
        get
        {
            return this.vFreteField;
        }
        set
        {
            this.vFreteField = value;
        }
    }

    /// <remarks/>
    public decimal vSeg
    {
        get
        {
            return this.vSegField;
        }
        set
        {
            this.vSegField = value;
        }
    }

    /// <remarks/>
    public decimal vDesc
    {
        get
        {
            return this.vDescField;
        }
        set
        {
            this.vDescField = value;
        }
    }

    /// <remarks/>
    public decimal vII
    {
        get
        {
            return this.vIIField;
        }
        set
        {
            this.vIIField = value;
        }
    }

    /// <remarks/>
    public decimal vIPI
    {
        get
        {
            return this.vIPIField;
        }
        set
        {
            this.vIPIField = value;
        }
    }

    /// <remarks/>
    public decimal vIPIDevol
    {
        get
        {
            return this.vIPIDevolField;
        }
        set
        {
            this.vIPIDevolField = value;
        }
    }

    /// <remarks/>
    public decimal vPIS
    {
        get
        {
            return this.vPISField;
        }
        set
        {
            this.vPISField = value;
        }
    }

    /// <remarks/>
    public decimal vCOFINS
    {
        get
        {
            return this.vCOFINSField;
        }
        set
        {
            this.vCOFINSField = value;
        }
    }

    /// <remarks/>
    public decimal vOutro
    {
        get
        {
            return this.vOutroField;
        }
        set
        {
            this.vOutroField = value;
        }
    }

    /// <remarks/>
    public decimal vNF
    {
        get
        {
            return this.vNFField;
        }
        set
        {
            this.vNFField = value;
        }
    }

    /// <remarks/>
    public decimal vTotTrib
    {
        get
        {
            return this.vTotTribField;
        }
        set
        {
            this.vTotTribField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeTransp
{

    private byte modFreteField;

    /// <remarks/>
    public byte modFrete
    {
        get
        {
            return this.modFreteField;
        }
        set
        {
            this.modFreteField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeDetPag
{

    private byte indPagField;

    private byte tPagField;

    private string xPagField;

    private decimal vPagField;

    private nfeProcProcNfeProcNFeInfNFeDetPagCard cardField;

    /// <remarks/>
    public byte indPag
    {
        get
        {
            return this.indPagField;
        }
        set
        {
            this.indPagField = value;
        }
    }

    /// <remarks/>
    public byte tPag
    {
        get
        {
            return this.tPagField;
        }
        set
        {
            this.tPagField = value;
        }
    }

    /// <remarks/>
    public string xPag
    {
        get
        {
            return this.xPagField;
        }
        set
        {
            this.xPagField = value;
        }
    }

    /// <remarks/>
    public decimal vPag
    {
        get
        {
            return this.vPagField;
        }
        set
        {
            this.vPagField = value;
        }
    }

    /// <remarks/>
    public nfeProcProcNfeProcNFeInfNFeDetPagCard card
    {
        get
        {
            return this.cardField;
        }
        set
        {
            this.cardField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeDetPagCard
{

    private byte tpIntegraField;

    private ulong cNPJField;

    private byte tBandField;

    private uint cAutField;

    /// <remarks/>
    public byte tpIntegra
    {
        get
        {
            return this.tpIntegraField;
        }
        set
        {
            this.tpIntegraField = value;
        }
    }

    /// <remarks/>
    public ulong CNPJ
    {
        get
        {
            return this.cNPJField;
        }
        set
        {
            this.cNPJField = value;
        }
    }

    /// <remarks/>
    public byte tBand
    {
        get
        {
            return this.tBandField;
        }
        set
        {
            this.tBandField = value;
        }
    }

    /// <remarks/>
    public uint cAut
    {
        get
        {
            return this.cAutField;
        }
        set
        {
            this.cAutField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeInfRespTec
{

    private ulong cNPJField;

    private string xContatoField;

    private string emailField;

    private uint foneField;

    /// <remarks/>
    public ulong CNPJ
    {
        get
        {
            return this.cNPJField;
        }
        set
        {
            this.cNPJField = value;
        }
    }

    /// <remarks/>
    public string xContato
    {
        get
        {
            return this.xContatoField;
        }
        set
        {
            this.xContatoField = value;
        }
    }

    /// <remarks/>
    public string email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
        }
    }

    /// <remarks/>
    public uint fone
    {
        get
        {
            return this.foneField;
        }
        set
        {
            this.foneField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcNFeInfNFeSupl
{

    private string qrCodeField;

    private string urlChaveField;

    /// <remarks/>
    public string qrCode
    {
        get
        {
            return this.qrCodeField;
        }
        set
        {
            this.qrCodeField = value;
        }
    }

    /// <remarks/>
    public string urlChave
    {
        get
        {
            return this.urlChaveField;
        }
        set
        {
            this.urlChaveField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public partial class Signature
{

    private SignatureSignedInfo signedInfoField;

    private string signatureValueField;

    private SignatureKeyInfo keyInfoField;

    /// <remarks/>
    public SignatureSignedInfo SignedInfo
    {
        get
        {
            return this.signedInfoField;
        }
        set
        {
            this.signedInfoField = value;
        }
    }

    /// <remarks/>
    public string SignatureValue
    {
        get
        {
            return this.signatureValueField;
        }
        set
        {
            this.signatureValueField = value;
        }
    }

    /// <remarks/>
    public SignatureKeyInfo KeyInfo
    {
        get
        {
            return this.keyInfoField;
        }
        set
        {
            this.keyInfoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureSignedInfo
{

    private SignatureSignedInfoCanonicalizationMethod canonicalizationMethodField;

    private SignatureSignedInfoSignatureMethod signatureMethodField;

    private SignatureSignedInfoReference referenceField;

    /// <remarks/>
    public SignatureSignedInfoCanonicalizationMethod CanonicalizationMethod
    {
        get
        {
            return this.canonicalizationMethodField;
        }
        set
        {
            this.canonicalizationMethodField = value;
        }
    }

    /// <remarks/>
    public SignatureSignedInfoSignatureMethod SignatureMethod
    {
        get
        {
            return this.signatureMethodField;
        }
        set
        {
            this.signatureMethodField = value;
        }
    }

    /// <remarks/>
    public SignatureSignedInfoReference Reference
    {
        get
        {
            return this.referenceField;
        }
        set
        {
            this.referenceField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureSignedInfoCanonicalizationMethod
{

    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Algorithm
    {
        get
        {
            return this.algorithmField;
        }
        set
        {
            this.algorithmField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureSignedInfoSignatureMethod
{

    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Algorithm
    {
        get
        {
            return this.algorithmField;
        }
        set
        {
            this.algorithmField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureSignedInfoReference
{

    private SignatureSignedInfoReferenceTransform[] transformsField;

    private SignatureSignedInfoReferenceDigestMethod digestMethodField;

    private string digestValueField;

    private string uRIField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
    public SignatureSignedInfoReferenceTransform[] Transforms
    {
        get
        {
            return this.transformsField;
        }
        set
        {
            this.transformsField = value;
        }
    }

    /// <remarks/>
    public SignatureSignedInfoReferenceDigestMethod DigestMethod
    {
        get
        {
            return this.digestMethodField;
        }
        set
        {
            this.digestMethodField = value;
        }
    }

    /// <remarks/>
    public string DigestValue
    {
        get
        {
            return this.digestValueField;
        }
        set
        {
            this.digestValueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string URI
    {
        get
        {
            return this.uRIField;
        }
        set
        {
            this.uRIField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureSignedInfoReferenceTransform
{

    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Algorithm
    {
        get
        {
            return this.algorithmField;
        }
        set
        {
            this.algorithmField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureSignedInfoReferenceDigestMethod
{

    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Algorithm
    {
        get
        {
            return this.algorithmField;
        }
        set
        {
            this.algorithmField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureKeyInfo
{

    private SignatureKeyInfoX509Data x509DataField;

    /// <remarks/>
    public SignatureKeyInfoX509Data X509Data
    {
        get
        {
            return this.x509DataField;
        }
        set
        {
            this.x509DataField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureKeyInfoX509Data
{

    private string x509CertificateField;

    /// <remarks/>
    public string X509Certificate
    {
        get
        {
            return this.x509CertificateField;
        }
        set
        {
            this.x509CertificateField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcProtNFe
{

    private nfeProcProcNfeProcProtNFeInfProt infProtField;

    private decimal versaoField;

    /// <remarks/>
    public nfeProcProcNfeProcProtNFeInfProt infProt
    {
        get
        {
            return this.infProtField;
        }
        set
        {
            this.infProtField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal versao
    {
        get
        {
            return this.versaoField;
        }
        set
        {
            this.versaoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProcNfeProcProtNFeInfProt
{

    private byte tpAmbField;

    private string verAplicField;

    private string chNFeField;

    private System.DateTime dhRecbtoField;

    private ulong nProtField;

    private string digValField;

    private byte cStatField;

    private string xMotivoField;

    /// <remarks/>
    public byte tpAmb
    {
        get
        {
            return this.tpAmbField;
        }
        set
        {
            this.tpAmbField = value;
        }
    }

    /// <remarks/>
    public string verAplic
    {
        get
        {
            return this.verAplicField;
        }
        set
        {
            this.verAplicField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string chNFe
    {
        get
        {
            return this.chNFeField;
        }
        set
        {
            this.chNFeField = value;
        }
    }

    /// <remarks/>
    public System.DateTime dhRecbto
    {
        get
        {
            return this.dhRecbtoField;
        }
        set
        {
            this.dhRecbtoField = value;
        }
    }

    /// <remarks/>
    public ulong nProt
    {
        get
        {
            return this.nProtField;
        }
        set
        {
            this.nProtField = value;
        }
    }

    /// <remarks/>
    public string digVal
    {
        get
        {
            return this.digValField;
        }
        set
        {
            this.digValField = value;
        }
    }

    /// <remarks/>
    public byte cStat
    {
        get
        {
            return this.cStatField;
        }
        set
        {
            this.cStatField = value;
        }
    }

    /// <remarks/>
    public string xMotivo
    {
        get
        {
            return this.xMotivoField;
        }
        set
        {
            this.xMotivoField = value;
        }
    }
}

