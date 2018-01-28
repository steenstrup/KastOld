using System;

namespace Kast.Models.DnD5E
{
    public enum EnumStats { Str, Dex, Con, Int, Wis, Cha};

    public class Stat
    {

        public Stat(EnumStats enustats, int value)
        {
            enumStat = enustats;
            Value = value;
            Modifire = (int)Math.Floor((value - 10) / 2.0);
        }

        public int Value;

        public int Modifire { get; private set; }

        public EnumStats enumStat { get; private set; }

    }
}