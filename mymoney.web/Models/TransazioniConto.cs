//------------------------------------------------------------------------------
// <auto-generated>
//    Codice generato da un modello.
//
//    Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//    Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mymoney.web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransazioniConto
    {
        public int TransazioneID { get; set; }
        public int ContoID { get; set; }
        public Nullable<int> TipoTransazioneID { get; set; }
        public Nullable<decimal> Importo { get; set; }
        public Nullable<System.DateTime> DataTransazione { get; set; }
        public string Descrizione { get; set; }
    
        public virtual Conti Conti { get; set; }
        public virtual TipoTransazioni TipoTransazioni { get; set; }
    }
}
