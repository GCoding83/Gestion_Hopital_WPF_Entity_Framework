//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NLH
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medecin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medecin()
        {
            this.Dossier_Admission = new HashSet<Dossier_Admission>();
        }
    
        public int idMedecin { get; set; }
        public string nomMedecin { get; set; }
        public string prenomMedecin { get; set; }
        public string specialiteMedecin { get; set; }
        public Nullable<int> departementMedecin { get; set; }
    
        public virtual Departement Departement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dossier_Admission> Dossier_Admission { get; set; }
    }
}
