using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockoutGrids
{
    public class AziendaModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public List<RepartoModel> Reparti { get; set; }
    }

    public class RepartoModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public List<DipendenteModel> Dipendenti { get; set; }
        public AziendaModel Azienda { get; set; }
    }

    public class DipendenteModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public RepartoModel Reparto { get; set; }
    }
}