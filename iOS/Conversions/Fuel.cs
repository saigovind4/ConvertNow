using System;
using System.Collections.Generic;

namespace ConvertNow.iOS
{
	public class Fuel : AbstractCalculator
	{
		private string inputString = "";
		private double inputValue;
		public List<double> resultList { get; set; }
		public List<Units> finalresultList { get; set; }
		private double gallonUsResult, gallonUkResult, kplResult, lp100k, lpMeterResult, mpgUKResult, mpgUSResult;

		public Fuel(string name)
		{
			inputString = name;
		}

		private int testMethod(string selectedUnit)
		{
			var returnValue = new int();
			switch (selectedUnit)
			{
				case "Gallons (UK) per 100miles":
					returnValue = FuelEnum.GallonsUKper100miles.GetHashCode(); break;


				case "Gallons (US) per100miles":
							returnValue = FuelEnum.GallonsUSper100miles.GetHashCode(); break;


				case "Kilometer per liter":
							returnValue = FuelEnum.Kilometerperliter.GetHashCode(); break;


				case "Liters per 100 Kilometers":
							returnValue = FuelEnum.Litersper100Kilometers.GetHashCode(); break;


				case "Liters per meter":
							returnValue = FuelEnum.Literspermeter.GetHashCode(); break;


				case "Miles per gallon(UK)":
							returnValue = FuelEnum.MilespergallonUK.GetHashCode(); break;


				case "Miles per gallon(US)":
							returnValue = FuelEnum.MilespergallonUS.GetHashCode(); break;

				default:
							returnValue = -1; break;
			}
			return returnValue;
		}

		public List<Units> performCalculations(object obj, List<Units> unitsList)
		{
			var value = (int)obj;
			if (inputString == "")
			{

			}
			else
			{
				inputValue = double.Parse(inputString);
				switch (value)
				{
					case 0:
						gallonUkResult = inputValue;
						gallonUsResult = 1.20095 * inputValue;
						kplResult = 35.400619 * inputValue;
						lp100k = 2.824809 * inputValue;
						lpMeterResult = 0.000028 * inputValue;
						mpgUKResult = 100 * inputValue;
						mpgUSResult = 83.267418 * inputValue;
						break;
					case 1:
						gallonUkResult = 0.832674 * inputValue;
						gallonUsResult = inputValue;
						kplResult = 42.514371 * inputValue;
						lp100k = 2.352146 * inputValue;
						lpMeterResult = 0.000024 * inputValue;
						mpgUKResult = 120.094993 * inputValue;
						mpgUSResult = 100 * inputValue;
						break;
					case 2:
						gallonUkResult = 35.400619 * inputValue;
						gallonUsResult = 42.514371 * inputValue;
						kplResult = inputValue;
						lp100k = 100 * inputValue;
						lpMeterResult = 0.001 * inputValue;
						mpgUKResult = 2.824809 * inputValue;
						mpgUSResult = 2.352146 * inputValue;
						break;
					case 3:
						gallonUkResult = 0.354006 * inputValue;
						gallonUsResult = 0.425144 * inputValue;
						kplResult = 100 * inputValue;
						lp100k = inputValue;
						lpMeterResult = 0.00001 * inputValue;
						mpgUKResult = 282.480936 * inputValue;
						mpgUSResult = 235.214583 * inputValue;
						break;
					case 4:
						gallonUkResult = 35400.618993 * inputValue;
						gallonUsResult = 42514.370743 * inputValue;
						kplResult = 0.001 * inputValue;
						lp100k = 100000 * inputValue;
						lpMeterResult = inputValue;
						mpgUKResult = 0.002825 * inputValue;
						mpgUSResult = 0.002352 * inputValue;
						break;
					case 5:
						gallonUkResult = 100 * inputValue;
						gallonUsResult = 120.094993 * inputValue;
						kplResult = 0.354006 * inputValue;
						lp100k = 282.480936 * inputValue;
						lpMeterResult = 0.002825 * inputValue;
						mpgUKResult = inputValue;
						mpgUSResult = 0.832674 * inputValue;
						break;
					case 6:
						gallonUkResult = 83.267418 * inputValue;
						gallonUsResult = 100 * inputValue;
						kplResult = 0.425144 * inputValue;
						lp100k = 235.214583 * inputValue;
						lpMeterResult = 0.002352 * inputValue;
						mpgUKResult = 1.20095 * inputValue;
						mpgUSResult = inputValue;
						break;
					default: ;
						break;
				}
			}
			resultList.Add(gallonUkResult);
			resultList.Add(gallonUsResult);
			resultList.Add(kplResult);
			resultList.Add(lp100k);
			resultList.Add(lpMeterResult);
			resultList.Add(mpgUKResult);
			resultList.Add(mpgUSResult);

			var size = unitsList.Count;

			for (var i = 0; i < size; i++)
			{
				var unitsObj = new Units();
				if (unitsList[i].unit_status == 1)
				{
					unitsObj.unit_name = unitsList[i].unit_name;
					unitsObj.result = resultList[i];
					finalresultList.Add(unitsObj);
				}
			}
			return finalresultList;
		}

		public enum FuelEnum
		{

			GallonsUKper100miles,
			GallonsUSper100miles,
			Kilometerperliter,
			Litersper100Kilometers,
			Literspermeter,
			MilespergallonUK,
			MilespergallonUS
		};
	}
}
