using System;
using System.Collections.Generic;

namespace ElectricInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio aRadio = new Radio();
            Radio anotherRAdio = new Radio();
            AllInONe anAllInOne = new AllInONe();
            AllInONe anotherAllInOne = new AllInONe();

            List<IRadio> iradioList = new List<IRadio>() {
                aRadio, anotherAllInOne,
                anotherRAdio, anAllInOne
            };

            TestRadios(iradioList);
        }

        static void TestRadios(List<IRadio> radios) {
            foreach(IRadio radio in radios) {
                radio.TurnRadioOn();
                radio.TurnRadioOff();
            }
        }
    }
}
