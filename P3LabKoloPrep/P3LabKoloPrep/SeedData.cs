using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BasketStats.Models
{
    public static class SeedData
    {
        public static List<Player> Initialize()
        {
            var lista = new List<Player>();
            

            lista.AddRange(new List<Player> {
                new Player
                {
                    Name = "Michał",
                    Surname = "Salamon",
                    NickName = "Magic"
                },
                new Player
                {
                    Name = "Artur",
                    Surname = "Tyc",
                    NickName = "Tycu"
                },
                new Player
                {
                    Name = "Krystian",
                    Surname = "Kuczmarz",
                    NickName = "Alf"
                },
                new Player
                {
                    Name = "Grzegorz",
                    Surname = "Kobiela",
                    NickName = null
                },
                new Player
                {
                    Name = "Norbert",
                    Surname = "Przemyk",
                    NickName = null
                },
                new Player
                {
                    Name = "Bartłomiej",
                    Surname = "Strządała",
                    NickName = null
                },
                new Player
                {
                    Name = "Mateusz",
                    Surname = "Wieczorek",
                    NickName = null
                },
                new Player
                {
                    Name = "Piotr",
                    Surname = "Pio",
                    NickName = null
                },
                new Player
                {
                    Name = "Paweł",
                    Surname = "Mazur",
                    NickName = null
                },
                new Player
                {
                    Name = "Krystian",
                    Surname = "Karcz",
                    NickName = null
                },
                new Player
                {
                    Name = "Paweł",
                    Surname = "Olejnik",
                    NickName = "Olo"
                },
                new Player
                {
                    Name = "Tomasz",
                    Surname = "Stachura",
                    NickName = null
                },
                new Player
                {
                    Name = "Marek",
                    Surname = "Moś",
                    NickName = null
                },
                new Player
                {
                    Name = "Leszek",
                    Surname = "Hendzel",
                    NickName = null
                },
                new Player
                {
                    Name = "Mateusz",
                    Surname = "Strządała",
                    NickName = null
                },
                new Player
                {
                    Name = "Robert",
                    Surname = "Jóźwiak",
                    NickName = "Joseph"
                },
                new Player
                {
                    Name = "Kuba",
                    Surname = "Machalica",
                    NickName = null
                },
                new Player
                {
                    Name = "Michał",
                    Surname = "Moś",
                    NickName = null
                },
                new Player
                {
                    Name = "Szymon",
                    Surname = "Polok",
                    NickName = "Biszkopt"
                },
                new Player
                {
                    Name = "Rafał",
                    Surname = "Król",
                    NickName = "LBJ"
                }

                });
            return lista;            
        }
    }
}
