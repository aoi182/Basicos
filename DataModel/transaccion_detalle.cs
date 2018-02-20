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
    
    public partial class transaccion_detalle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public transaccion_detalle()
        {
            this.rechazo = new HashSet<rechazo>();
        }
    
        public int id { get; set; }
        public int id_transaccion { get; set; }
        public string llave_nomina { get; set; }
        public Nullable<decimal> nit_compania { get; set; }
        public Nullable<short> tipo_nomina_colab { get; set; }
        public string num_nomina_colab { get; set; }
        public string num_contrato_colab { get; set; }
        public Nullable<System.DateTime> fec_nomina_colab { get; set; }
        public string nom_compania { get; set; }
        public Nullable<decimal> nit_cliente { get; set; }
        public string nom_cliente { get; set; }
        public string tipo_docum_colab { get; set; }
        public Nullable<decimal> num_docum_colab { get; set; }
        public string cod_banco_colab { get; set; }
        public string nom_banco_colab { get; set; }
        public string num_cuenta_colab { get; set; }
        public string tipo_cuenta_colab { get; set; }
        public string des_tipo_cuenta_colab { get; set; }
        public string nom_tipo_nomina_colab { get; set; }
        public Nullable<decimal> monto_pago_colab { get; set; }
        public string nom_colaborador { get; set; }
        public Nullable<short> tipo_nomina_liquidacion { get; set; }
        public Nullable<short> estado_mora { get; set; }
        public Nullable<System.DateTime> fec_programacion_pago { get; set; }
        public Nullable<short> estado_pago { get; set; }
        public string usu_creacion { get; set; }
        public System.DateTime fec_creacion { get; set; }
        public string usu_modificacion { get; set; }
        public Nullable<System.DateTime> fec_modificacion { get; set; }
        public short estado { get; set; }
        public string ciudad_colab { get; set; }
        public string cod_ciudad_colab { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rechazo> rechazo { get; set; }
        public virtual transaccion transaccion { get; set; }
        public virtual transaccion_detalle transaccion_detalle1 { get; set; }
        public virtual transaccion_detalle transaccion_detalle2 { get; set; }
    }
}
