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
    
    public partial class movimiento_concepto
    {
        public int id { get; set; }
        public Nullable<int> id_concepto_contable { get; set; }
        public Nullable<int> id_compania_movimiento { get; set; }
        public Nullable<int> codigo_contable { get; set; }
        public Nullable<short> naturaleza_movimiento { get; set; }
        public string usu_creacion { get; set; }
        public Nullable<System.DateTime> fec_creacion { get; set; }
        public string usu_modificacion { get; set; }
        public Nullable<System.DateTime> fec_modificacion { get; set; }
        public Nullable<decimal> estado { get; set; }
    
        public virtual codigo_contable codigo_contable1 { get; set; }
        public virtual compania compania { get; set; }
        public virtual concepto_contable concepto_contable { get; set; }
    }
}
