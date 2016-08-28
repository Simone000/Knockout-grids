using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockoutGrids.Controllers
{
    public class DipendentiController : ApiController
    {
        private List<DipendenteModel> GetDipendentiModels()
        {
            var dipendenti = new List<DipendenteModel>()
            {
                new DipendenteModel()
                {
                    ID = 1,
                    Nome= "Dipendente 1",
                    Reparto = new RepartoModel()
                    {
                        ID= 1, Nome= "Reparto 1",
                        Azienda = new AziendaModel(){ ID = 1, Nome = "Azienda 1" }
                    }
                },
                new DipendenteModel()
                {
                    ID = 2,
                    Nome= "Dipendente 2",
                    Reparto = new RepartoModel()
                    {
                        ID= 3, Nome= "Reparto 3",
                        Azienda = new AziendaModel(){ ID = 2, Nome = "Azienda 2" }
                    }
                },
                new DipendenteModel()
                {
                    ID = 3,
                    Nome= "Dipendente 3",
                    Reparto = new RepartoModel()
                    {
                        ID= 4, Nome= "Reparto 4",
                        Azienda = new AziendaModel(){ ID = 1, Nome = "Azienda 1" }
                    }
                },
                new DipendenteModel()
                {
                    ID = 4,
                    Nome= "Dipendente 4",
                    Reparto = new RepartoModel()
                    {
                        ID= 5, Nome= "Reparto 5",
                        Azienda = new AziendaModel(){ ID = 3, Nome = "Azienda 3" }
                    }
                },
                new DipendenteModel()
                {
                    ID = 5,
                    Nome= "Dipendente 5",
                    Reparto = new RepartoModel()
                    {
                        ID= 1, Nome= "Reparto 1",
                        Azienda = new AziendaModel(){ ID = 1, Nome = "Azienda 1" }
                    }
                },
                new DipendenteModel()
                {
                    ID = 6,
                    Nome= "Dipendente 6",
                    Reparto = new RepartoModel()
                    {
                        ID= 1, Nome= "Reparto 1",
                        Azienda = new AziendaModel(){ ID = 1, Nome = "Azienda 1" }
                    }
                },
            };

            return dipendenti;
        }

        [HttpGet]
        public IHttpActionResult GetDipendentiPaged(int PageSize, int CurrPage, string SortBy, bool IsDesc, string SearchBy, string Search)
        {
            var dipendenti = GetDipendentiModels().OrderBy(p => p.ID);

            //paginazione
            var dipPaged = dipendenti.Skip(Math.Abs(CurrPage) * PageSize)
                                               .Take(PageSize);

            return Ok(dipPaged.ToList());
        }
    }
}
