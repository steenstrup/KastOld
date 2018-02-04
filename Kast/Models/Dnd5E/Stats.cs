using System;

namespace Kast.Models.DnD5E
{
    public enum EnumStats { Str, Dex, Con, Int, Wis, Cha};

    public class Stat
    {

        public Stat(EnumStats enustats, int value, string decription)
        {
            EnumStat = enustats;
            Value = value;
            Decription = decription;
            Modifire = (int)Math.Floor((value - 10) / 2.0);
        }

        public int Value;

        public int Modifire { get;}

        public EnumStats EnumStat { get; }

        public string Decription { get; }

    }
}