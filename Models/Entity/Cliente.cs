namespace API_Data_CRM.Models.Entity
{
    public class Cliente
    {
        public string? Ruc { get; set; }
        public string? Ventas_6_Meses { get; set; }
        public string? Nombre { get; set; }
        public string? Clase { get; set; }
        public string? Nivel { get; set; }
        public string? Cod_Dir_Principal { get; set; }
        public string? Correo { get; set; }
        public string? Metodo_Envio { get; set; }
        public string? Direccion1 { get; set; }
        public string? Provincia { get; set; }
        public string? Ciudad { get; set; }
        public string? Telefono1 { get; set; }
        public string? Descuento { get; set; }
        public string? Condicion_Pago { get; set; }
        public string? Estado { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public DateTime Fecha_Modificacion { get; set; }
        public string? Ventas_3_Anio { get; set; }
        public string? Tipologia { get; set; }
        public string? Tipo_Garantia { get; set; }
        public string? Cumpleanios { get; set; }
        public decimal Cheques_Postfechados { get; set; }
        public decimal Cheques_Protestados { get; set; }
        public decimal Cupo_Permitido { get; set; }
        public decimal Cupo { get; set; }
        public decimal Documentos_Por_Vencer { get; set; }
        public decimal Documentos_Vencidos { get; set; }
        public decimal Notas_De_Credito { get; set; }
    }

}
