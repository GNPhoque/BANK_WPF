//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BANK_WPF.Model.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMPTE
    {
        public int NUMERO_COMPTE { get; set; }
        public double SOLDE { get; set; }
        public int ID_TYPE_COMPTE { get; set; }
        public int ID_OPERATION { get; set; }
    
        public virtual TYPECOMPTE TYPECOMPTE { get; set; }
        public virtual OPERATIONS OPERATIONS { get; set; }
        public virtual CLIENTS CLIENTS { get; set; }
    }
}
