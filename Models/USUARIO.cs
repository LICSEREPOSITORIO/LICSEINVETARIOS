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
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.ENTRADA = new HashSet<ENTRADA>();
            this.SOLICITUD = new HashSet<SOLICITUD>();
        }
    
        public int rol { get; set; }
        public int id_usuario { get; set; }
        public string usu_nombre { get; set; }
        public string usu_apellido { get; set; }
        public string usu_telefono { get; set; }
        public string usu_correo { get; set; }
        public string contraseña { get; set; }
        public int estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTRADA> ENTRADA { get; set; }
        public virtual ESTADO_USUARIO ESTADO_USUARIO { get; set; }
        public virtual ROL ROL1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITUD> SOLICITUD { get; set; }
    }
}
