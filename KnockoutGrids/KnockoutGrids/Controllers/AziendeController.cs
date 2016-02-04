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


        /*
        [HttpGet]
        [ResponseType(typeof(List<AziendaServiziModel>))] //azienda con stato servizi
        public async Task<IHttpActionResult> GetAziendeServiziPaged(int PageSize, int CurrPage, string SortBy, bool IsDesc, string SearchBy, string Search)
        {
            var aziende = db.AziendeR.GetAziende(Enum_Servizi.Tutti);
            switch (SortBy)
            {
                case "nome":
                    aziende = IsDesc ? aziende.OrderByDescending(p => p.NomeOrganizzazione) : aziende.OrderBy(p => p.NomeOrganizzazione);
                    break;
                case "email":
                    aziende = IsDesc ? aziende.OrderByDescending(p => p.Email) : aziende.OrderBy(p => p.Email);
                    break;
                case "telefono":
                    aziende = IsDesc ? aziende.OrderByDescending(p => p.NumeroTelefono) : aziende.OrderBy(p => p.NumeroTelefono);
                    break;
                case "stato.descrizione":
                    aziende = IsDesc ? aziende.OrderByDescending(p => p.esm_StatiAziende.ID) : aziende.OrderBy(p => p.esm_StatiAziende.ID);
                    break;
                default:
                    aziende = IsDesc ? aziende.OrderByDescending(p => p.DataUltimaModifica) : aziende.OrderBy(p => p.DataUltimaModifica);
                    break;
            }
            aziende = aziende.AsQueryable();

            //search
            if (!string.IsNullOrWhiteSpace(Search))
                aziende = aziende.Where(p => p.NomeOrganizzazione.Contains(Search));

            var aziendeServizi_q = TOMODELS.ToAziendeServiziModels().Invoke(aziende.AsExpandable());

            switch (SortBy)
            {
                
                case "stato_SorvSani":
                    aziendeServizi_q = IsDesc ? aziendeServizi_q.OrderByDescending(p => p.Stato_SorvSani) : aziendeServizi_q.OrderBy(p => p.Stato_SorvSani);
                    break;
                case "stato_Formazione":
                    aziendeServizi_q = IsDesc ? aziendeServizi_q.OrderByDescending(p => p.Stato_Formazione) : aziendeServizi_q.OrderBy(p => p.Stato_Formazione);
                    break;
                case "stato_Sicurezza":
                    aziendeServizi_q = IsDesc ? aziendeServizi_q.OrderByDescending(p => p.Stato_Sicurezza) : aziendeServizi_q.OrderBy(p => p.Stato_Sicurezza);
                    break;
                case "stato_Haccp":
                    aziendeServizi_q = IsDesc ? aziendeServizi_q.OrderByDescending(p => p.Stato_Haccp) : aziendeServizi_q.OrderBy(p => p.Stato_Haccp);
                    break;
            }


            //paginazione
            aziendeServizi_q = aziendeServizi_q.Skip(Math.Abs(CurrPage) * PageSize)
                                               .Take(PageSize);

            var aziendeServizi = await aziendeServizi_q.ToListAsync();

            return Ok(aziendeServizi);
        }
        */


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
