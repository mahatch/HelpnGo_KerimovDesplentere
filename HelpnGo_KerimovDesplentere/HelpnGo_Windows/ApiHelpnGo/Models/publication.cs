//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiHelpnGo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class publication
    {
        public decimal Publication_id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Phone_number { get; set; }
        public string Email { get; set; }
        public decimal Author_id { get; set; }
        public string Category_label { get; set; }
        public string Province_label { get; set; }
        public bool Is_offer { get; set; }
    
        public virtual category category { get; set; }
        public virtual province province { get; set; }
        public virtual user user { get; set; }
    }
}
