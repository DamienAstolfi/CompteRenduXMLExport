//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompteRenduXMLExport
{
    using System;
    using System.Collections.Generic;
    
    public partial class Compte_rendu
    {
        public int cr_id { get; set; }
        public Nullable<decimal> cr_ph_id { get; set; }
        public Nullable<System.DateTime> cr_datedeb { get; set; }
        public Nullable<System.DateTime> cr_datefin { get; set; }
        public string cr_client { get; set; }
        public string cr_presta { get; set; }
        public string cr_infolocalisation { get; set; }
        public string cr_adresse { get; set; }
        public string cr_cp { get; set; }
        public string cr_ville { get; set; }
        public string cr_description { get; set; }
        public string cr_gpsX { get; set; }
        public string cr_gpsY { get; set; }
        public Nullable<short> cr_etat { get; set; }
        public Nullable<System.DateTime> cr_GTI { get; set; }
        public Nullable<System.DateTime> cr_gtr { get; set; }
        public string cr_rapport { get; set; }
        public string cr_rapport_type { get; set; }
        public string cr_user { get; set; }
        public Nullable<System.DateTime> cr_date_synchro { get; set; }
        public Nullable<System.DateTime> cr_date_PEC { get; set; }
        public Nullable<System.DateTime> cr_date_Arrivée { get; set; }
        public Nullable<System.DateTime> cr_date_gel { get; set; }
        public Nullable<System.DateTime> cr_date_terminé { get; set; }
        public string cr_codeSite { get; set; }
        public string cr_listeIDGEDECO { get; set; }
        public Nullable<System.DateTime> cr_DateModif { get; set; }
        public Nullable<bool> cr_withRDV { get; set; }
        public string cr_owner { get; set; }
        public string cr_site { get; set; }
        public string cr_oldValue { get; set; }
        public string cr_accompagnant { get; set; }
        public string cr_alerte { get; set; }
        public Nullable<decimal> cr_tempsMethode { get; set; }
    }
}