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
        [NonAction]
        private List<AziendaModel> GetAziendeModels()
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
                            },
                            new DipendenteModel()
                            {
                                ID = 2,
                                Nome = "Dipendente 2"
                            },
                            new DipendenteModel()
                            {
                                ID = 3,
                                Nome = "Dipendente 3"
                            }
                        }
                    },
                    new RepartoModel()
                    {
                        ID = 2,
                        Nome = "Reparto 2",
                        Dipendenti = new List<DipendenteModel>()
                        {
                            new DipendenteModel()
                            {
                                ID = 4,
                                Nome = "Dipendente 4"
                            },
                            new DipendenteModel()
                            {
                                ID = 5,
                                Nome = "Dipendente 5"
                            },
                            new DipendenteModel()
                            {
                                ID = 6,
                                Nome = "Dipendente 6"
                            }
                        }
                    }
                }
            });
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
                            },
                            new DipendenteModel()
                            {
                                ID = 2,
                                Nome = "Dipendente 2"
                            },
                            new DipendenteModel()
                            {
                                ID = 3,
                                Nome = "Dipendente 3"
                            }
                        }
                    }
                }
            });
            return aziende;
        }

        [HttpGet]
        public IHttpActionResult GetAziende()
        {
            return Ok(GetAziendeModels());
        }

        [HttpGet]
        public IHttpActionResult GetAziendePaged(int PageSize, int CurrPage, string SortBy, bool IsDesc, string SearchBy, string Search)
        {
            var aziende = GetAziendeModels();

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
