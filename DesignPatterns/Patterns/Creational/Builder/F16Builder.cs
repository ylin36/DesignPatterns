using System;
namespace DesignPatterns.Patterns.Creational.Builder
{
	public class F16Builder : AircraftBuilder
	{
        private F16 _f16;

        public F16Builder()
        {
            _f16 = new F16();
        }

        public override void BuildCockpit()
        {
            _f16.Cockpit = "1 man cockpit";
        }

        public override void BuildEngine()
        {
            _f16.Engine = "General Electric F110";
        }

        public override void BuildWings()
        {
            _f16.Wings = "Fighter wings";
        }

        public override IAirCraft GetResult()
        {
            return _f16;
        }
    }
}

