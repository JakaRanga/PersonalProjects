//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jPwdGen.EntityF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PwdUser
    {
        public int ID { get; set; }
        public int ID_USER { get; set; }
        public string LB_SOFT { get; set; }
        public string LB_PWD { get; set; }
        public int IS_ACTIVE { get; set; }
    
        public virtual Users Users { get; set; }
    }
}