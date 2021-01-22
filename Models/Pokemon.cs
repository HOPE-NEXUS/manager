using System;
using poketwo_manager.Enums;

namespace poketwo_manager.Models
{
    public class UserPokemon
    {
        public int Level { get; set; }
        public string Nickname { get; set; }
        public Guid PokemonId { get; set; }
        public int Experience { get; set; }
        public int NextExp { get; set; }
        public Nature Nature { get; set; }
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int SpAtk { get; set; }
        public int SpDef { get; set; }
        public int Spd { get; set; }
        public int TotalIV { get; set; }
    }
}
