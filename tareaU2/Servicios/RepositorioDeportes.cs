using System.Collections.Generic;
using tareaU2.Models;

namespace tareaU2.Servicios
{
    public class RepositorioDeportes : IRepositorioDeportes
    {
        public List<Deportes> ObtenerDeportes()
        {
            return new List<Deportes> {
                new Deportes
                {
                    Titulo = "México confirma su 11 titular para enfrentar a Jamaica en la Copa Oro 2023",
                    Descripcion = "México y Jamaica se enfrentarán en el espectacular Allegiant Stadium de Las Vegas. Buscan el boleto a la gran final de la Copa Oro",
                    ImagenUrl = "/img/eje_dep1.jpg",
                    Link = "",
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
    }
}
