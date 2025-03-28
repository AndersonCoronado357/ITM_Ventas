//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITM_Ventas.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculo()
        {
            this.Ventas = new HashSet<Venta>();
        }
    
        public int IdVehiculo { get; set; }
        public int IdMarca { get; set; }
        public int IdAgencia { get; set; }
        public string Motor { get; set; }
        public int NumeroPuertas { get; set; }
        public string TipoCombustible { get; set; }
        public string Accesorios { get; set; }


        [JsonIgnore]
        public virtual Agencia Agencia { get; set; }

        [JsonIgnore]
        public virtual Marca Marca { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
