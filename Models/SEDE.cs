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
    
    public partial class SEDE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SEDE()
        {
            this.SOLICITUD = new HashSet<SOLICITUD>();
        }
    
        public int id_sede { get; set; }
        public string sede_nombre { get; set; }
        public string sede_direccion { get; set; }
        public Nullable<int> tipo { get; set; }
        public string sede_encargado { get; set; }
    
        public virtual TIPO_SEDE TIPO_SEDE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITUD> SOLICITUD { get; set; }
    }
}
