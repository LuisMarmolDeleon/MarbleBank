//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class administrador
    {
        public int Id_admin { get; set; }
        public string Nombres { get; set; }
        public string Apellido { get; set; }
        public string cedula { get; set; }
        public Nullable<System.DateTime> Fecha_Nacimiento { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string Codigo_confirmacion { get; set; }
        public Nullable<byte> Confirmado { get; set; }
    }
}
