//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE3
{
    using System;
    using System.Collections.Generic;
    
    public partial class saison
    {
        public saison()
        {
            this.episode = new HashSet<episode>();
        }
    
        public int idSerie { get; set; }
        public int numSaison { get; set; }
        public int anneeSaison { get; set; }
        public int nbrEpisodesPrevus { get; set; }
    
        public virtual ICollection<episode> episode { get; set; }
        public virtual serie serie { get; set; }
    }
}
