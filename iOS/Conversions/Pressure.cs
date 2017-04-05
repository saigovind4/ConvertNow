using System;
using System.Collections.Generic;

namespace ConvertNow.iOS
{
	public class Pressure : AbstractCalculator
	{
		private string inputString = "";
		private double inputValue;
		public List<double> resultList { get; set; }
		public List<Units> finalresultList { get; set; }
		private double atmospheresResult, barsResult, centimeterswaterResult, feet_of_waterResult, inches_of_waterResult, kilogram_forcesResult, kilonewtonsResult, kilopascalsResult, meganewtonsResult,
			newtons_sq_meterResult, pascalsResult, poundalsResult, tonsResult, tonnesResult, torrResult;

		public Pressure(string name)
		{
			inputString = name;
		}

		private int testMethod(string selectedUnit)
		{
			var returnValue = new int();
			switch (selectedUnit)
			{
				case "Atmospheres":
					returnValue = PressureEnum.Atmospheres.GetHashCode(); break;

				case "Bars":
							returnValue = PressureEnum.Bars.GetHashCode(); break;

				case "Centimeters water":
							returnValue = PressureEnum.Centimeterswater.GetHashCode(); break;

				case "Feet of water":
							returnValue = PressureEnum.Feetofwater.GetHashCode(); break;

				case "Inches of water":
							returnValue = PressureEnum.Inchesofwater.GetHashCode(); break;

				case "Kilogram forces/sq meter":
							returnValue = PressureEnum.Kilogramforcessqmeter.GetHashCode(); break;

				case "Kilonewtons/sq meter":
							returnValue = PressureEnum.Kilonewtonssqmeter.GetHashCode(); break;

				case "Kilo pascals":
							returnValue = PressureEnum.Kilopascals.GetHashCode(); break;

				case "Mega newtons/sq meter":
							returnValue = PressureEnum.Meganewtonssqmeter.GetHashCode(); break;

				case "Newtons/sq meter":
							returnValue = PressureEnum.Newtonssqmeter.GetHashCode(); break;

				case "Pascals":
							returnValue = PressureEnum.Pascals.GetHashCode(); break;

				case "Poundals/sq foot":
							returnValue = PressureEnum.Poundalssqfoot.GetHashCode(); break;

				case "Tons(US)-force/sq inch":
							returnValue = PressureEnum.TonsUSforcesqinch.GetHashCode(); break;

				case "Tonnes-force/sq meter":
							returnValue = PressureEnum.Tonnesforcesqmeter.GetHashCode(); break;

				case "Torr (mm Hg 0°C)":
							returnValue = PressureEnum.TorrmmHg0C.GetHashCode(); break;
							                          
				default:  returnValue = -1; break;
			}
		}

		public enum PressureEnum
		{
			Atmospheres,
			Bars,
			Centimeterswater,
			Feetofwater,
			Inchesofwater,
			Kilogramforcessqmeter,
			Kilonewtonssqmeter,
			Kilopascals,
			Meganewtonssqmeter,
			Newtonssqmeter,
			Pascals,
			Poundalssqfoot,
			TonsUSforcesqinch,
			Tonnesforcesqmeter,
			TorrmmHg0C,
		};

	}
}
