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
    
    public partial class rechazo_detalle
    {
        public int id { get; set; }
        public int id_rechazo { get; set; }
        public Nullable<int> id_motivo_rechazo { get; set; }
        public string cod_motivo_rechazo { get; set; }
        public string descripcion { get; set; }
        public string usu_creacion { get; set; }
        public System.DateTime fec_creacion { get; set; }
        public string usu_modificacion { get; set; }
        public Nullable<System.DateTime> fec_modificacion { get; set; }
        public short estado { get; set; }
    
        public virtual p_motivo_rechazo p_motivo_rechazo { get; set; }
        public virtual rechazo rechazo { get; set; }
    }
}
