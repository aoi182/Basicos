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
    
    public partial class p_colaborador_bloqueado
    {
        public int id { get; set; }
        public Nullable<decimal> identificacion { get; set; }
        public string nom_colaborador { get; set; }
        public string usu_creacion { get; set; }
        public System.DateTime fec_creacion { get; set; }
        public string usu_modificacion { get; set; }
        public Nullable<System.DateTime> fec_modificacion { get; set; }
        public short estado { get; set; }
    }
}