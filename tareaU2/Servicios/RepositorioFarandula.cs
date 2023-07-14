using tareaU2.Models;

namespace tareaU2.Servicios
{
    public class RepositorioFarandula : IRepositorioFarandula
    {
        public List<Farandula> ObtenerFarandula()
        { 
            return new List<Farandula> {
                new Farandula
                {
                    Titulo ="Miguel Bosé regresa a la música con una colaboración con el puertorriqueño Rauw Alejandro",
                    Descripcion = "El cantante español Miguel Bosé confirmó que participa en el disco del puertorriqueño Rauw Alejandro “Playa Saturno” con una colaboración en la canción “Si te pegas”.",
                    ImagenUrl ="/img/eje_far1.jpg",
                    Link = "",
                },
                new Farandula
                {
                    Titulo ="Tom Cruise contra la inteligencia artificial en “Misión Imposible 7”",
                    Descripcion = "Tom Cruise lucha contra la inteligencia artificial sin olvidar las acrobacias en “Misión Imposible: Sentencia Mortal” ",
                    ImagenUrl ="/img/eje_far2.jpg",
                    Link = "",
                },
                new Farandula
                {
                    Titulo ="Hondureña Jamie Espinoza se corona segunda finalista en Reinado Internacional del Cacao",
                    Descripcion = "Con una elegancia única al modelar en la pasarela, un hermoso rostro y una figura esbelta, la hondureña Jamie Espinoza logró entrar al top de las mujeres más bellas en el Reinado Internacional del Cacao",
                    ImagenUrl ="/img/eje_far3.jpg",
                    Link = "",
                },
            }; 
        }
    }
}
