using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockoutGrids.Controllers
{
    public class AziendeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetAziende()
        {
            var aziende = new List<AziendaModel>();
            aziende.Add(new AziendaModel()
            {
                ID = 1,
                Nome = "Azienda 1",
                Reparti = new List<RepartoModel>()
                {
                    new RepartoModel()
                    {
                        ID = 1,
                        Nome = "Reparto 1",
                        Dipendenti = new List<DipendenteModel>()
                        {
                            new DipendenteModel()
                            {
                                ID = 1,
                                Nome = "Dipendente 1"
                            }
                        }
                    }
                }
            });

            return Ok(aziende);
        }

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
        }

        public class DipendenteModel
        {
            public int ID { get; set; }
            public string Nome { get; set; }
        }
    }
}
