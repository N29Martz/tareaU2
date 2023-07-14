using tareaU2.Models;

namespace tareaU2.Servicios
{
    public class RepositorioMundo : IRepositorioMundo
    {
        public List<Mundo> ObtenerMudo()
        {
            return new List<Mundo>
            {
                new Mundo {
                    Titulo = "Hombre en EEUU acusado de ser agente del FBI demanda a Fox por difamación",
                    Descripcion = "Los acusa de inventar una “historia fantástica” en la que Epps era “un agente encubierto del FBI responsable por la muchedumbre que irrumpió violentamente en el Capitolio",
                    ImagenUrl = "/img/eje_mundo1.png",
                    DireccionURL="",

                },
                new Mundo {
                    Titulo = "Seis muertos y 12 heridos en el violento atentado con explosivos en México",
                    Descripcion = "El ataque estuvo dirigido a “personal de la fiscalía del Estado y de la policía municipal de Tlajomulco” y se cometió con “siete” artefactos “explosivos improvisados”, detalló el gobernador Enrique Alfaro",
                    ImagenUrl = "/img/eje_mundo2.jpg",
                    DireccionURL="",
                },
                new Mundo {
                    Titulo = "Al menos 15 muertos dejan como resultado la temporada de lluvias en Guatemala",
                    Descripcion = "Según el informe, hasta el momento se han reportado 15 fallecidos, 723.414 afectados y 87 personas permanecen en albergues",
                    ImagenUrl = "/img/eje_mundo3.png",
                    DireccionURL="",
                },
            };
        }
    }
}
