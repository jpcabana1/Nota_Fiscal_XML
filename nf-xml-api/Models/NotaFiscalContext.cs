using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace nf_xml_api.Models
{
    public partial class NotaFiscalContext : DbContext
    {
        public NotaFiscalContext()
        {
        }

        public NotaFiscalContext(DbContextOptions<NotaFiscalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ImportacaoNotaXml> ImportacaoNotaXmls { get; set; } = null!;
        public virtual DbSet<ProdutoNotum> ProdutoNota { get; set; } = null!;
        public virtual DbSet<TotalNotum> TotalNota { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=NOTA_FISCAL");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImportacaoNotaXml>(entity =>
            {
                entity.HasKey(e => new { e.IdNota, e.XChave, e.XHash })
                    .HasName("PK__importac__2F4CB906A35B9690");

                entity.ToTable("importacao_nota_xml", "NOTA_FISCAL");

                entity.Property(e => e.IdNota)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idNota");

                entity.Property(e => e.XChave)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("xChave");

                entity.Property(e => e.XHash)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("xHash");

                entity.Property(e => e.DtImportacao)
                    .HasColumnType("datetime")
                    .HasColumnName("dtImportacao")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.XStatusImportacao)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("xStatusImportacao");

                entity.Property(e => e.XmlNota)
                    .HasColumnType("xml")
                    .HasColumnName("xmlNota");
            });

            modelBuilder.Entity<ProdutoNotum>(entity =>
            {
                entity.HasKey(e => e.IdProduto)
                    .HasName("PK__produto___5EEDF7C33D9AF9D9");

                entity.ToTable("produto_nota", "NOTA_FISCAL");

                entity.Property(e => e.IdProduto).HasColumnName("idProduto");

                entity.Property(e => e.CEan).HasColumnName("cEAN");

                entity.Property(e => e.CEantrib)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cEANTrib");

                entity.Property(e => e.CProd).HasColumnName("cProd");

                entity.Property(e => e.Cest).HasColumnName("CEST");

                entity.Property(e => e.Cfop).HasColumnName("CFOP");

                entity.Property(e => e.IdNota).HasColumnName("idNota");

                entity.Property(e => e.IndTot).HasColumnName("indTot");

                entity.Property(e => e.Ncm).HasColumnName("NCM");

                entity.Property(e => e.QCom)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("qCom");

                entity.Property(e => e.QTrib)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("qTrib");

                entity.Property(e => e.UCom)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("uCom");

                entity.Property(e => e.UTrib)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("uTrib");

                entity.Property(e => e.VProd)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("vProd");

                entity.Property(e => e.VUnCom)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("vUnCom");

                entity.Property(e => e.VUnTrib)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("vUnTrib");

                entity.Property(e => e.XChave)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("xChave");

                entity.Property(e => e.XHash)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("xHash");

                entity.Property(e => e.XProd)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("xProd");

                entity.HasOne(d => d.ImportacaoNotaXml)
                    .WithMany(p => p.ProdutoNota)
                    .HasForeignKey(d => new { d.IdNota, d.XChave, d.XHash })
                    .HasConstraintName("FK__produto_nota__3A81B327");
            });

            modelBuilder.Entity<TotalNotum>(entity =>
            {
                entity.HasKey(e => e.IdTotal)
                    .HasName("PK__total_no__8348CCEF7899BF06");

                entity.ToTable("total_nota", "NOTA_FISCAL");

                entity.Property(e => e.IdTotal).HasColumnName("idTotal");

                entity.Property(e => e.IdNota).HasColumnName("idNota");

                entity.Property(e => e.VBc)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vBC");

                entity.Property(e => e.VBcst)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vBCST");

                entity.Property(e => e.VCofins)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vCOFINS");

                entity.Property(e => e.VDesc)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vDesc");

                entity.Property(e => e.VFcp)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vFCP");

                entity.Property(e => e.VFcpst)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vFCPST");

                entity.Property(e => e.VFcpstret)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vFCPSTRet");

                entity.Property(e => e.VFrete)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vFrete");

                entity.Property(e => e.VIcms)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vICMS");

                entity.Property(e => e.VIcmsdeson)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vICMSDeson");

                entity.Property(e => e.VIi)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vII");

                entity.Property(e => e.VIpi)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vIPI");

                entity.Property(e => e.VIpidevol)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vIPIDevol");

                entity.Property(e => e.VNf)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vNF");

                entity.Property(e => e.VOutro)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vOutro");

                entity.Property(e => e.VPis)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vPIS");

                entity.Property(e => e.VProd)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vProd");

                entity.Property(e => e.VSeg)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vSeg");

                entity.Property(e => e.VSt)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vST");

                entity.Property(e => e.VTotTrib)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("vTotTrib");

                entity.Property(e => e.XChave)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("xChave");

                entity.Property(e => e.XHash)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("xHash");

                entity.HasOne(d => d.ImportacaoNotaXml)
                    .WithMany(p => p.TotalNota)
                    .HasForeignKey(d => new { d.IdNota, d.XChave, d.XHash })
                    .HasConstraintName("FK__total_nota__3D5E1FD2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
