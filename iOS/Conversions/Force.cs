using System.Collections.Generic;

namespace ConvertNow.iOS
{
	public class Force : AbstractCalculator
	{
		private string inputString = "";
		private double inputValue;
		public List<double> resultList { get; set; }
		public List<Units> finalresultList { get; set; }
		private double dynes,kilogramsforce,kilonewtons,kips,meganewtons,newtons,poundsforce,poundals,sthène,tonnesforce,tonsforceUK,tonsforceUS;

		public Force(string name)
		{
			inputString = name;
		}

		private int testMethod(string selectedUnit)
		{
			var returnValue = new int();
			switch (selectedUnit)
			{
				case "Dynes":
					returnValue = ForceEnum.Dynes.GetHashCode(); break;

				case "Kilograms force":
							returnValue = ForceEnum.Kilogramsforce.GetHashCode(); break;

				case "Kilo newtons":
							returnValue = ForceEnum.Kilonewtons.GetHashCode(); break;

				case "Kips":
							returnValue = ForceEnum.Kips.GetHashCode(); break;

				case "Mega newtons":
							returnValue = ForceEnum.Meganewtons.GetHashCode(); break;

				case "Newtons":
							returnValue = ForceEnum.Newtons.GetHashCode(); break;

				case "Pounds force":
							returnValue = ForceEnum.Poundsforce.GetHashCode(); break;

				case "Poundals":
							returnValue = ForceEnum.Poundals.GetHashCode(); break;

				case "Sthène":
							returnValue = ForceEnum.Sthène.GetHashCode(); break;

				case "Tonnes force":
							returnValue = ForceEnum.Tonnesforce.GetHashCode(); break;

				case "Tons force(UK)":
							returnValue = ForceEnum.TonsforceUK.GetHashCode(); break;

				case "Tons force(US)":
							returnValue = ForceEnum.TonsforceUS.GetHashCode(); break;
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
						dynes = inputValue;
						kilogramsforce = 0.000001 * inputValue;
						kilonewtons = 0.00000001 * inputValue;
						kips = 0.000000002 * inputValue;
						meganewtons = 0.00000000001 * inputValue;
						newtons = 0.00001 * inputValue;
						poundsforce = 0.000002 * inputValue;
						poundals = 0.000072 * inputValue;
						sthène = 0.00000001 * inputValue;
						tonnesforce = 0.000000001 * inputValue;
						tonsforceUK = 0.000000001 * inputValue;
						tonsforceUS = 0.000000001 * inputValue;
						break;
					case 1:
						dynes = 980665 * inputValue;
						kilogramsforce = inputValue;
						kilonewtons = 0.009807 * inputValue;
						kips = 0.002205 * inputValue;
						meganewtons = 0.00001 * inputValue;
						newtons = 9.80665 * inputValue;
						poundsforce = 2.204623 * inputValue;
						poundals = 70.931612 * inputValue;
						sthène = 0.009807 * inputValue;
						tonnesforce = 0.001 * inputValue;
						tonsforceUK = 0.000984 * inputValue;
						tonsforceUS = 0.001102 * inputValue;
						break;
					case 2:
						dynes = 100000000 * inputValue;
						kilogramsforce = 101.971621 * inputValue;
						kilonewtons = inputValue;
						kips = 0.224809 * inputValue;
						meganewtons = 0.001 * inputValue;
						newtons = 1000 * inputValue;
						poundsforce = 224.808943 * inputValue;
						poundals = 7233.011464 * inputValue;
						sthène = 1 * inputValue;
						tonnesforce = 0.101972 * inputValue;
						tonsforceUK = 0.100361 * inputValue;
						tonsforceUS = 0.112404 * inputValue;
						break;
					case 3:
						dynes = 444822200 * inputValue;
						kilogramsforce = 453.592409 * inputValue;
						kilonewtons = 4.448222 * inputValue;
						kips = inputValue;
						meganewtons = 0.004448 * inputValue;
						newtons = 4448.222 * inputValue;
						poundsforce = 1000.000086 * inputValue;
						poundals = 32174.040722 * inputValue;
						sthène = 4.448222 * inputValue;
						tonnesforce = 0.453592 * inputValue;
						tonsforceUK = 0.446429 * inputValue;
						tonsforceUS = 0.5 * inputValue;
						break;
					case 4:
						dynes = 99999999999.99998 * inputValue;
						kilogramsforce = 101971.621298 * inputValue;
						kilonewtons = 1000 * inputValue;
						kips = 224.808924 * inputValue;
						meganewtons = inputValue;
						newtons = 1000000 * inputValue;
						poundsforce = 224808.9431 * inputValue;
						poundals = 7233011.464323 * inputValue;
						sthène = 1000 * inputValue;
						tonnesforce = 101.971621 * inputValue;
						tonsforceUK = 100.361135 * inputValue;
						tonsforceUS = 112.404472 * inputValue;
						break;
					case 5:
						dynes = 100000 * inputValue;
						kilogramsforce = 0.101972 * inputValue;
						kilonewtons = 0.001 * inputValue;
						kips = 0.000225 * inputValue;
						meganewtons = 0.000001 * inputValue;
						newtons = inputValue;
						poundsforce = 0.224809 * inputValue;
						poundals = 7.233011 * inputValue;
						sthène = 0.001 * inputValue;
						tonnesforce = 0.000102 * inputValue;
						tonsforceUK = 0.0001 * inputValue;
						tonsforceUS = 0.000112 * inputValue;
						break;
					case 6:
						dynes = 444822.161526 * inputValue;
						kilogramsforce = 0.453592 * inputValue;
						kilonewtons = 0.004448 * inputValue;
						kips = 0.001 * inputValue;
						meganewtons = 0.000004 * inputValue;
						newtons = 4.448222 * inputValue;
						poundsforce = inputValue;
						poundals = 32.174038 * inputValue;
						sthène = 0.004448 * inputValue;
						tonnesforce = 0.000454 * inputValue;
						tonsforceUK = 0.000446 * inputValue;
						tonsforceUS = 0.0005 * inputValue;
						break;
					case 7:
						dynes = 13825.5 * inputValue;
						kilogramsforce = 0.014098 * inputValue;
						kilonewtons = 0.000138 * inputValue;
						kips = 0.000031 * inputValue;
						meganewtons = 0.0000001 * inputValue;
						newtons = 0.138255 * inputValue;
						poundsforce = 0.031081 * inputValue;
						poundals = inputValue;
						sthène = 0.000138 * inputValue;
						tonnesforce = 0.000014 * inputValue;
						tonsforceUK = 0.000014 * inputValue;
						tonsforceUS = 0.000016 * inputValue;
						break;
					case 8:
						dynes = 100000000 * inputValue;
						kilogramsforce = 101.971621 * inputValue;
						kilonewtons = 1 * inputValue;
						kips = 0.224809 * inputValue;
						meganewtons = 0.001 * inputValue;
						newtons = 1000 * inputValue;
						poundsforce = 224.808943 * inputValue;
						poundals = 7233.011464 * inputValue;
						sthène = inputValue;
						tonnesforce = 0.101972 * inputValue;
						tonsforceUK = 0.100361 * inputValue;
						tonsforceUS = 0.112404 * inputValue;
						break;
					case 9:
						dynes = 980665000 * inputValue;
						kilogramsforce = 1000 * inputValue;
						kilonewtons = 9.80665 * inputValue;
						kips = 2.204622 * inputValue;
						meganewtons = 0.009807 * inputValue;
						newtons = 9806.65 * inputValue;
						poundsforce = 2204.622622 * inputValue;
						poundals = 70931.611877 * inputValue;
						sthène = 9.80665 * inputValue;
						tonnesforce = inputValue;
						tonsforceUK = 0.984207 * inputValue;
						tonsforceUS = 1.102311 * inputValue;
						break;
					case 10:
						dynes = 996401641.818352 * inputValue;
						kilogramsforce = 1016.046909 * inputValue;
						kilonewtons = 9.964016 * inputValue;
						kips = 2.24 * inputValue;
						meganewtons = 0.009964 * inputValue;
						newtons = 9964.016418 * inputValue;
						poundsforce = 2240 * inputValue;
						poundals = 72069.844983 * inputValue;
						sthène = 9.964016 * inputValue;
						tonnesforce = 1.016047 * inputValue;
						tonsforceUK = inputValue;
						tonsforceUS = 1.12 * inputValue;
						break;
					case 11:
						dynes = 889644323.0521 * inputValue;
						kilogramsforce = 907.18474 * inputValue;
						kilonewtons = 8.896443 * inputValue;
						kips = 2 * inputValue;
						meganewtons = 0.008896 * inputValue;
						newtons = 8896.443231 * inputValue;
						poundsforce = 2000 * inputValue;
						poundals = 64348.075878 * inputValue;
						sthène = 8.896443 * inputValue;
						tonnesforce = 0.907185 * inputValue;
						tonsforceUK = 0.892857 * inputValue;
						tonsforceUS = inputValue;
						break;
					default: ;
						break;

					}
				}

					resultList.Add(dynes);
					resultList.Add(kilogramsforce);
					resultList.Add(kilonewtons);
					resultList.Add(kips);
					resultList.Add(meganewtons);
					resultList.Add(newtons);
					resultList.Add(poundsforce);
					resultList.Add(poundals);
					resultList.Add(sthène);
					resultList.Add(tonnesforce);
					resultList.Add(tonsforceUK);
					resultList.Add(tonsforceUS);
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


		public enum ForceEnum
		{
			Dynes,
			Kilogramsforce,
			Kilonewtons,
			Kips,
			Meganewtons,
			Newtons,
			Poundsforce,
			Poundals,
			Sthène,
			Tonnesforce,
			TonsforceUK,
			TonsforceUS
		};
	}
}
