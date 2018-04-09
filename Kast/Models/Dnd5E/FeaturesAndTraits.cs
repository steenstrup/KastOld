using System.Collections.Generic;

namespace Kast.Models.Dnd5E
{
    public class FeatureAndTrait
    {
        public int FeatureAndTraitId { get; set; }
        public string Name { get; set; }
        public string LongDescription { get; set; }
        public string ShortDescription { get; set; }

        public FeatureAndTrait(){ }

        public FeatureAndTrait(string name)
        {
            Name = name;
            LongDescription = "";
            ShortDescription = "";
        }
    }

    public class FeatureAndTraitBuilder
    {
        private readonly List<FeatureAndTrait> _featureAndTraits;

        public static FeatureAndTraitBuilder DefualdFeatureAndTraitBuilder()
        {
            return new FeatureAndTraitBuilder();
        }

        public FeatureAndTraitBuilder()
        {
            _featureAndTraits = new List<FeatureAndTrait>();
        }

        public FeatureAndTraitBuilder loadFeatures()
        {
            _featureAndTraits.Add(new FeatureAndTrait("SpellCasting Arcane"));
            _featureAndTraits.Add(new FeatureAndTrait("Arcane Recovery"));
            _featureAndTraits.Add(new FeatureAndTrait("War magic"));
            _featureAndTraits.Add(new FeatureAndTrait("Arcane deflection"));
            _featureAndTraits.Add(new FeatureAndTrait("Tactical wit"));
            _featureAndTraits.Add(new FeatureAndTrait("War Caster"));
            _featureAndTraits.Add(new FeatureAndTrait("Ritual Caster (w)"));
            
            _featureAndTraits.Add(new FeatureAndTrait("SpellCasting Divine"));
            _featureAndTraits.Add(new FeatureAndTrait("Knowledge Domain"));
            _featureAndTraits.Add(new FeatureAndTrait("Blessing of Knowledge"));
            _featureAndTraits.Add(new FeatureAndTrait("Ritual Caster (c)"));

            _featureAndTraits.Add(new FeatureAndTrait("Darkvision"));
            _featureAndTraits.Add(new FeatureAndTrait("Keen Senses"));
            _featureAndTraits.Add(new FeatureAndTrait("Fay Acestry"));
            _featureAndTraits.Add(new FeatureAndTrait("Trance"));
            _featureAndTraits.Add(new FeatureAndTrait("Cantrip"));

            return this;
        }

        public FeatureAndTraitBuilder loadTraits()
        {
            return this;
        }

        public IEnumerable<FeatureAndTrait> Build()
        {
            return _featureAndTraits;
        }

    }
}
