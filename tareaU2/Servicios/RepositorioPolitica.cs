using tareaU2.Models;

namespace tareaU2.Servicios
{
    public class RepositorioPolitica : IRepositorioPolitica
    {
        public List<Politica> ObtenerPolitica()
        {
            return new List<Politica>() { 
                new Politica() {
                    Titulo="La reducción de la violencia no se acabará con cárceles",
                    Descripcion="El Partido Liberal anunció que presentará un plan contra la inseguridad y violencia",
                    ImagenUrl="/img/eje_pol1.jpg",
                    DescripcionURL="",
                },
                new Politica() {
                    Titulo="Bancada del PN no apoyará a ningún candidato para FG, activista de Libre",
                    Descripcion="La bancada del Partido Nacional, no apoyará ningún candidato para fiscal general, que sea activista o que pregone la ideología del Partido Libertad y Refundación (Libre), anunció el diputado nacionalista, Antonio Rivera Callejas.",
                    ImagenUrl="/img/eje_pol2.jpg",
                    DescripcionURL="",
                },
                new Politica() {
                    Titulo="Congreso retrasa dar información sobre actas vía transparencia, pero Redondo mostró los datos en sesión",
                    Descripcion="El presidente del Poder Legislativo mostró en sesión una base de datos sobre las actas ratificadas",
                    ImagenUrl="/img/eje_pol3.jpg",
                    DescripcionURL="",
                },
            };
        }
    }
}
