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
    
    public partial class seg_usuarios
    {
        public int id_seg_usuarios { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string cedula { get; set; }
        public string usuario { get; set; }
        public short estado { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public Nullable<int> id_seg_rol { get; set; }
        public string usu_creacion { get; set; }
        public System.DateTime fec_creacion { get; set; }
        public string usu_modificacion { get; set; }
        public Nullable<System.DateTime> fec_modificacion { get; set; }
    
        public virtual seg_rol seg_rol { get; set; }
    }
}
