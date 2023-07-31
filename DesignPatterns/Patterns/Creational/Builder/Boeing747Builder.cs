using System;
namespace DesignPatterns.Patterns.Creational.Builder
{
    public class Boeing747Builder : AircraftBuilder
    {
        private Boeing747 _boeing747;

        public Boeing747Builder()
        {
            _boeing747 = new Boeing747();
        }

        public override void BuildCockpit()
        {
            _boeing747.Cockpit = "Commercial boeing cockpit"; 
        }

        public override void BuildBathroom()
        {
            _boeing747.Bathroom = "4 bathrooms";
        }

        public override void BuildEngine()
        {
            _boeing747.Engine = "Commercial boeing engine";
        }

        public override void BuildWings()
        {
            _boeing747.Wings = "Commercial wings";
        }

        public override IAirCraft GetResult()
        {
            return _boeing747;
        }
    }
}