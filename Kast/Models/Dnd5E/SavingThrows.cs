namespace Kast.Models.DnD5E
{
    public class SavingThrow
    {
        public EnumStats EnumStat { get; set; }
        public int Value { get; set; }

        public SavingThrow(EnumStats stat, int value)
        {
            EnumStat = stat;
            Value = value;
        }
    }
}