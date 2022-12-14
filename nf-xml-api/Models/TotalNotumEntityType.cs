// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using nf_xml_api.Models;

#pragma warning disable 219, 612, 618
#nullable enable

namespace NotaFiscal
{
    internal partial class TotalNotumEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType? baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "nf_xml_api.Models.TotalNotum",
                typeof(TotalNotum),
                baseEntityType);

            var idTotal = runtimeEntityType.AddProperty(
                "IdTotal",
                typeof(long),
                propertyInfo: typeof(TotalNotum).GetProperty("IdTotal", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<IdTotal>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw);
            idTotal.AddAnnotation("Relational:ColumnName", "idTotal");
            idTotal.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var idNota = runtimeEntityType.AddProperty(
                "IdNota",
                typeof(long),
                propertyInfo: typeof(TotalNotum).GetProperty("IdNota", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<IdNota>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            idNota.AddAnnotation("Relational:ColumnName", "idNota");
            idNota.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vBc = runtimeEntityType.AddProperty(
                "VBc",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VBc", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VBc>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vBc.AddAnnotation("Relational:ColumnName", "vBC");
            vBc.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vBc.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vBcst = runtimeEntityType.AddProperty(
                "VBcst",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VBcst", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VBcst>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vBcst.AddAnnotation("Relational:ColumnName", "vBCST");
            vBcst.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vBcst.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vCofins = runtimeEntityType.AddProperty(
                "VCofins",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VCofins", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VCofins>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vCofins.AddAnnotation("Relational:ColumnName", "vCOFINS");
            vCofins.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vCofins.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vDesc = runtimeEntityType.AddProperty(
                "VDesc",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VDesc", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VDesc>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vDesc.AddAnnotation("Relational:ColumnName", "vDesc");
            vDesc.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vDesc.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vFcp = runtimeEntityType.AddProperty(
                "VFcp",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VFcp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VFcp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vFcp.AddAnnotation("Relational:ColumnName", "vFCP");
            vFcp.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vFcp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vFcpst = runtimeEntityType.AddProperty(
                "VFcpst",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VFcpst", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VFcpst>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vFcpst.AddAnnotation("Relational:ColumnName", "vFCPST");
            vFcpst.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vFcpst.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vFcpstret = runtimeEntityType.AddProperty(
                "VFcpstret",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VFcpstret", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VFcpstret>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vFcpstret.AddAnnotation("Relational:ColumnName", "vFCPSTRet");
            vFcpstret.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vFcpstret.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vFrete = runtimeEntityType.AddProperty(
                "VFrete",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VFrete", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VFrete>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vFrete.AddAnnotation("Relational:ColumnName", "vFrete");
            vFrete.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vFrete.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vIcms = runtimeEntityType.AddProperty(
                "VIcms",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VIcms", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VIcms>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vIcms.AddAnnotation("Relational:ColumnName", "vICMS");
            vIcms.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vIcms.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vIcmsdeson = runtimeEntityType.AddProperty(
                "VIcmsdeson",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VIcmsdeson", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VIcmsdeson>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vIcmsdeson.AddAnnotation("Relational:ColumnName", "vICMSDeson");
            vIcmsdeson.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vIcmsdeson.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vIi = runtimeEntityType.AddProperty(
                "VIi",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VIi", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VIi>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vIi.AddAnnotation("Relational:ColumnName", "vII");
            vIi.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vIi.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vIpi = runtimeEntityType.AddProperty(
                "VIpi",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VIpi", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VIpi>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vIpi.AddAnnotation("Relational:ColumnName", "vIPI");
            vIpi.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vIpi.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vIpidevol = runtimeEntityType.AddProperty(
                "VIpidevol",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VIpidevol", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VIpidevol>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vIpidevol.AddAnnotation("Relational:ColumnName", "vIPIDevol");
            vIpidevol.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vIpidevol.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vNf = runtimeEntityType.AddProperty(
                "VNf",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VNf", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VNf>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vNf.AddAnnotation("Relational:ColumnName", "vNF");
            vNf.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vNf.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vOutro = runtimeEntityType.AddProperty(
                "VOutro",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VOutro", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VOutro>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vOutro.AddAnnotation("Relational:ColumnName", "vOutro");
            vOutro.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vOutro.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vPis = runtimeEntityType.AddProperty(
                "VPis",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VPis", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VPis>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vPis.AddAnnotation("Relational:ColumnName", "vPIS");
            vPis.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vPis.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vProd = runtimeEntityType.AddProperty(
                "VProd",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VProd", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VProd>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vProd.AddAnnotation("Relational:ColumnName", "vProd");
            vProd.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vProd.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vSeg = runtimeEntityType.AddProperty(
                "VSeg",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VSeg", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VSeg>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vSeg.AddAnnotation("Relational:ColumnName", "vSeg");
            vSeg.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vSeg.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vSt = runtimeEntityType.AddProperty(
                "VSt",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VSt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VSt>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vSt.AddAnnotation("Relational:ColumnName", "vST");
            vSt.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vSt.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vTotTrib = runtimeEntityType.AddProperty(
                "VTotTrib",
                typeof(decimal),
                propertyInfo: typeof(TotalNotum).GetProperty("VTotTrib", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<VTotTrib>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
            vTotTrib.AddAnnotation("Relational:ColumnName", "vTotTrib");
            vTotTrib.AddAnnotation("Relational:ColumnType", "decimal(10, 2)");
            vTotTrib.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var xChave = runtimeEntityType.AddProperty(
                "XChave",
                typeof(string),
                propertyInfo: typeof(TotalNotum).GetProperty("XChave", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<XChave>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 45,
                unicode: false);
            xChave.AddAnnotation("Relational:ColumnName", "xChave");
            xChave.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var xHash = runtimeEntityType.AddProperty(
                "XHash",
                typeof(string),
                propertyInfo: typeof(TotalNotum).GetProperty("XHash", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<XHash>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 35,
                unicode: false);
            xHash.AddAnnotation("Relational:ColumnName", "xHash");
            xHash.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { idTotal });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__total_no__8348CCEF9725D6C5");

            var index = runtimeEntityType.AddIndex(
                new[] { idNota, xChave, xHash });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("IdNota")!, declaringEntityType.FindProperty("XChave")!, declaringEntityType.FindProperty("XHash")! },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("IdNota")!, principalEntityType.FindProperty("XChave")!, principalEntityType.FindProperty("XHash")! })!,
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            var importacaoNotaXml = declaringEntityType.AddNavigation("ImportacaoNotaXml",
                runtimeForeignKey,
                onDependent: true,
                typeof(ImportacaoNotaXml),
                propertyInfo: typeof(TotalNotum).GetProperty("ImportacaoNotaXml", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TotalNotum).GetField("<ImportacaoNotaXml>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var totalNota = principalEntityType.AddNavigation("TotalNota",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<TotalNotum>),
                propertyInfo: typeof(ImportacaoNotaXml).GetProperty("TotalNota", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ImportacaoNotaXml).GetField("<TotalNota>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__total_nota__6383C8BA");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "NOTA_FISCAL");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "total_nota");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
