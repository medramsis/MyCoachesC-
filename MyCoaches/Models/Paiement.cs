//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyCoaches.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paiement
    {
        public int id { get; set; }
        public Nullable<decimal> Montant { get; set; }
        public Nullable<System.DateTime> Datep { get; set; }
        public Nullable<int> C_idEntraineur { get; set; }
    
        public virtual Entraineur Entraineur { get; set; }
    }
}