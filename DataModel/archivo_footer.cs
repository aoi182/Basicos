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
    
    public partial class archivo_footer
    {
        public decimal id_archivo_footer { get; set; }
        public decimal id_archivo { get; set; }
        public string nombre { get; set; }
        public decimal orden { get; set; }
        public decimal tamano { get; set; }
        public string tipo_dato { get; set; }
        public string formato { get; set; }
        public Nullable<short> decimales { get; set; }
        public string caracter_relleno { get; set; }
        public string justificacion { get; set; }
        public string val_defecto { get; set; }
        public string funcionbd { get; set; }
        public string nom_campobd { get; set; }
        public string requerido { get; set; }
        public string usu_creacion { get; set; }
        public System.DateTime fec_creacion { get; set; }
        public string usu_modificacion { get; set; }
        public Nullable<System.DateTime> fec_modificacion { get; set; }
        public short estado { get; set; }
        public string descripcion { get; set; }
        public string observaciones { get; set; }
    
        public virtual archivo archivo { get; set; }
    }
}
