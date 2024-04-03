using Microsoft.EntityFrameworkCore;
using API_Data_CRM.Models.Entity;

namespace API_Data_CRM.Models.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; } //vista

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeo de la vista SQL
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToView("VI_GP_INFO_CLIENTE_VENTAS_COBRANZA");
                entity.HasKey(e => e.Ruc);

                entity.Property(e => e.Ruc)
                .ValueGeneratedNever()
                .HasColumnName("Ruc");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(65)
                    .IsUnicode(false)
                    .HasColumnName("Nombre");

                entity.Property(e => e.Clase)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Clase");

                entity.Property(e => e.Nivel)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Nivel");

                entity.Property(e => e.Cod_Dir_Principal)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Cod_Dir_Principal");

                entity.Property(e => e.Correo)
                    .HasMaxLength(201)
                    .IsUnicode(false)
                    .HasColumnName("Correo");

                entity.Property(e => e.Metodo_Envio)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Metodo_Envio");

                entity.Property(e => e.Direccion1)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("Direccion1");

                entity.Property(e => e.Provincia)
                    .HasMaxLength(29)
                    .IsUnicode(false)
                    .HasColumnName("Provincia");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("Ciudad");

                entity.Property(e => e.Telefono1)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("Telefono1");

                entity.Property(e => e.Descuento)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Descuento");

                entity.Property(e => e.Condicion_Pago)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("Condicion_Pago");

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Estado");

                entity.Property(e => e.Ventas_3_Anio)
                    .IsUnicode(false)
                    .HasColumnName("Ventas_3_Anio");

                entity.Property(e => e.Tipologia)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tipologia");

                entity.Property(e => e.Tipo_Garantia)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_Garantia");

                entity.Property(e => e.Cumpleanios)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Cumpleanios");

                entity.Property(e => e.Cheques_Postfechados)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Cheques_Postfechados");

                entity.Property(e => e.Cheques_Protestados)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Cheques_Protestados");

                entity.Property(e => e.Cupo_Permitido)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Cupo_Permitido");

                entity.Property(e => e.Documentos_Por_Vencer)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Documentos_Por_Vencer");

                entity.Property(e => e.Documentos_Vencidos)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Documentos_Vencidos");

                entity.Property(e => e.Notas_De_Credito)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Notas_De_Credito");
            });

        }
    }
}
