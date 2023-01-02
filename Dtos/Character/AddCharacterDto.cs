using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_dotnet.Dtos.Character
{
    public class AddCharacterDto
    {
        public string Name { get; set; } = "Frodo";
        public int Hitpoint { get; set; } = 100;
        public int Strength { get; set; }= 10;
        public int Defense { get; set; }= 10;
        public int Intelligence { get; set; }= 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}