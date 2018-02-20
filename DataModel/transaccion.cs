//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class transaccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public transaccion()
        {
            this.transaccion_detalle = new HashSet<transaccion_detalle>();
        }
    
        public int id_transaccion { get; set; }
        public string cod_transaccion { get; set; }
        public Nullable<decimal> id_tipo_transaccion { get; set; }
        public Nullable<int> id_compania_nomina { get; set; }
        public string cod_banco_pago { get; set; }
        public string usu_creacion { get; set; }
        public System.DateTime fec_creacion { get; set; }
        public string usu_modificacion { get; set; }
        public Nullable<System.DateTime> fec_modificacion { get; set; }
        public short estado { get; set; }
        public Nullable<short> estado_transaccion { get; set; }
        public Nullable<decimal> monto_generado { get; set; }
        public Nullable<int> cant_detalles_generados { get; set; }
        public Nullable<int> cant_rechazos_automaticos { get; set; }
        public string num_cuenta_pago { get; set; }
        public string ruta_archivo { get; set; }
    
        public virtual compania compania { get; set; }
        public virtual tipo_transaccion tipo_transaccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transaccion_detalle> transaccion_detalle { get; set; }
    }
}