//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LICSE_Inventarios.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class M_Salida
    {
        public int Solicitud { get; set; }
        public string Referencia { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<System.DateTime> Fecha_salida { get; set; }
        public string Solicitante { get; set; }
        public string Sede { get; set; }
    }
}
