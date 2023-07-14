using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tareaU2.Models;
using tareaU2.Servicios;

namespace tareaU2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioDeportes repositorioDeportes;
        private readonly IRepositorioFarandula repositorioFarandula;
        private readonly IRepositorioMundo repositorioMundo;
        private readonly IRepositorioPolitica repositoriPolitica;

        public HomeController(ILogger<HomeController> logger, IRepositorioDeportes repositorioDeportes,
            IRepositorioFarandula repositorioFarandula, IRepositorioMundo repositorioMundo, IRepositorioPolitica repositoriPolitica)
        {
            _logger = logger;
            this.repositorioDeportes = repositorioDeportes;
            this.repositorioFarandula = repositorioFarandula;
            this.repositorioMundo = repositorioMundo;
            this.repositoriPolitica = repositoriPolitica;
        }

        public IActionResult Index()
        {
            var deportes = repositorioDeportes.ObtenerDeportes().Take(3).ToList();
            var farandula = repositorioFarandula.ObtenerFarandula().Take(3).ToList();
            var mundo = repositorioMundo.ObtenerMudo().Take(3).ToList();
            var politica = repositoriPolitica.ObtenerPolitica().Take(3).ToList();
            var modelo = new HomeIndexViewModel
            {
                Deportes = deportes,
                Farandulas = farandula,
                Mundo = mundo,
                Politicas = politica,
            };
            return View(modelo);
        }

        public IActionResult Deportes()
        {
            var deportes = repositorioDeportes.ObtenerDeportes(); 
            return View(deportes);
        }

        public IActionResult Farandula()
        {
            var farandula = repositorioFarandula.ObtenerFarandula();
            return View(farandula);
        }

        public IActionResult Mundo()
        {
            var mundo = repositorioMundo.ObtenerMudo();
            return View(mundo);
        }

        public IActionResult Politica() {
            var politica = repositoriPolitica.ObtenerPolitica();
            return View(politica);
        }

        public IActionResult AgregarNoticias()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<Deportes> ObtenerDeportes()
        {
            return new List<Deportes> {
                new Deportes
                {
                    Titulo = "México confirma su 11 titular para enfrentar a Jamaica en la Copa Oro 2023",
                    Descripcion = "México y Jamaica se enfrentarán en el espectacular Allegiant Stadium de Las Vegas. Buscan el boleto a la gran final de la Copa Oro",
                    ImagenUrl = "/img/eje_dep1.jpg",
                    Link = ""
                },
                new Deportes
                {
                    Titulo = "Las figuras que enfrentará Messi por el dominio de la MLS",
                    Descripcion = "Lionel Messi se convertirá en la superestrella indiscutible de la liga de fútbol norteamericana (MLS), donde estas otras figuras le esperan para la pelea por los títulos.",
                    ImagenUrl = "/img/eje_dep2.jpg",
                    Link = ""
                },
                new Deportes
                {
                    Titulo = "Limeño de El Salvador se refuerza con hondureños",
                    Descripcion = "Los futbolistas hondureños Ever Alvarado y Hesller Morales, han sido anunciados como refuerzos del equipo Municipal Limeño de la primera división de El Salvador.",
                    ImagenUrl = "/img/eje_dep3.jpg",
                    Link = ""
                },

            };

        }

        //private List<Farandula> ObteneFarandula() {
        //    return new List<Farandula>
        //    {
        //        new Farandula
        //        {
        //            Titulo ="Miguel Bosé regresa a la música con una colaboración con el puertorriqueño Rauw Alejandro",
        //            Descripcion = "El cantante español Miguel Bosé confirmó que participa en el disco del puertorriqueño Rauw Alejandro “Playa Saturno” con una colaboración en la canción “Si te pegas”.",
        //            ImagenUrl ="/img/eje_far1.jpg",
        //            Link = "",
        //        },
        //        new Farandula
        //        {
        //            Titulo ="Tom Cruise contra la inteligencia artificial en “Misión Imposible 7”",
        //            Descripcion = "Tom Cruise lucha contra la inteligencia artificial sin olvidar las acrobacias en “Misión Imposible: Sentencia Mortal” ",
        //            ImagenUrl ="/img/eje_far2.jpg",
        //            Link = "",
        //        },
        //        new Farandula
        //        {
        //            Titulo ="Hondureña Jamie Espinoza se corona segunda finalista en Reinado Internacional del Cacao",
        //            Descripcion = "Con una elegancia única al modelar en la pasarela, un hermoso rostro y una figura esbelta, la hondureña Jamie Espinoza logró entrar al top de las mujeres más bellas en el Reinado Internacional del Cacao",
        //            ImagenUrl ="/img/eje_far3.jpg",
        //            Link = "",
        //        },
        //    };

        //}

        //private List<Mundo> ObtenerMudo()
        //{
        //    return new List<Mundo>
        //    {
        //        new Mundo {
        //            Titulo = "Hombre en EEUU acusado de ser agente del FBI demanda a Fox por difamación",
        //            Descripcion = "Los acusa de inventar una “historia fantástica” en la que Epps era “un agente encubierto del FBI responsable por la muchedumbre que irrumpió violentamente en el Capitolio",
        //            ImagenUrl = "/img/eje_mundo1.png",
        //            DireccionURL="",

        //        },
        //        new Mundo {
        //            Titulo = "Seis muertos y 12 heridos en el violento atentado con explosivos en México",
        //            Descripcion = "El ataque estuvo dirigido a “personal de la fiscalía del Estado y de la policía municipal de Tlajomulco” y se cometió con “siete” artefactos “explosivos improvisados”, detalló el gobernador Enrique Alfaro",
        //            ImagenUrl = "/img/eje_mundo2.jpg",
        //            DireccionURL="",
        //        },
        //        new Mundo {
        //            Titulo = "Al menos 15 muertos dejan como resultado la temporada de lluvias en Guatemala",
        //            Descripcion = "Según el informe, hasta el momento se han reportado 15 fallecidos, 723.414 afectados y 87 personas permanecen en albergues",
        //            ImagenUrl = "/img/eje_mundo3.png",
        //            DireccionURL="",
        //        },
        //    };
        //}
    }
}