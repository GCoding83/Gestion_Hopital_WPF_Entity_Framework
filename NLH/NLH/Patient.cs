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
    
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.Dossier_Admission = new HashSet<Dossier_Admission>();
            this.Parents = new HashSet<Parent>();
        }
    
        public int idPatient { get; set; }
        public System.DateTime dateNaissancePatient { get; set; }
        public string nomPatient { get; set; }
        public string prenomPatient { get; set; }
        public string adressePatient { get; set; }
        public string villePatient { get; set; }
        public string provincePatient { get; set; }
        public string cpPatient { get; set; }
        public string noTelPatient { get; set; }
        public Nullable<int> idCompagnie { get; set; }
        public Nullable<int> typeLitPrefere { get; set; }
    
        public virtual Compagnie_Assurance Compagnie_Assurance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dossier_Admission> Dossier_Admission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parent> Parents { get; set; }
        public virtual Type_Lit Type_Lit { get; set; }
    }
}
