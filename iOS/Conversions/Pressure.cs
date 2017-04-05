using System.Collections.Generic;

namespace ConvertNow.iOS
{
	public class Pressure : AbstractCalculator
	{
		private string inputString = "";
		private double inputValue;
		public List<double> resultList { get; set; }
		public List<Units> finalresultList { get; set; }
		internal double atmospheresResult, barsResult, centimeterswaterResult, feet_of_waterResult, inches_of_waterResult, kilogram_forcesResult, kilonewtonsResult, kilopascalsResult, meganewtonsResult,
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
						atmospheresResult = inputValue;
						barsResult = inputValue * 1.01325;
						centimeterswaterResult = inputValue * 1033.227453;
						feet_of_waterResult = inputValue * 33.898538;
						inches_of_waterResult = inputValue * 406.782462;
						kilogram_forcesResult = inputValue * 10332.274528;
						kilonewtonsResult = inputValue * 101.325;
						kilopascalsResult = inputValue * 101.325;
						meganewtonsResult = inputValue * 0.101325;
						newtons_sq_meterResult = inputValue * 101325;
						pascalsResult = inputValue * 101325;
						poundalsResult = inputValue * 69968.097448;
						tonsResult = inputValue * 0.007348;
						tonnesResult = inputValue * 10.332275;
						torrResult = inputValue * 760.0021;
						break;

					case 1:
						barsResult = inputValue;
						atmospheresResult = inputValue * 0.986923;
						centimeterswaterResult = inputValue * 1019.716213;
						feet_of_waterResult = inputValue * 33.455256;
						inches_of_waterResult = inputValue * 401.463076;
						kilogram_forcesResult = inputValue * 10197.16213;
						kilonewtonsResult = inputValue * 100;
						kilopascalsResult = inputValue * 100;
						meganewtonsResult = inputValue * 0.1;
						newtons_sq_meterResult = inputValue * 100000;
						pascalsResult = inputValue * 100000;
						poundalsResult = inputValue * 69053.143299;
						tonsResult = inputValue * 0.007252;
						tonnesResult = inputValue * 10.197162;
						torrResult = inputValue * 750.063755;
						break;
					case 2:
						centimeterswaterResult = inputValue;
						atmospheresResult = inputValue * 0.000968;
						barsResult = inputValue * 0.000981;
						feet_of_waterResult = inputValue * 0.032808;
						inches_of_waterResult = inputValue * 0.393701;
						kilogram_forcesResult = inputValue * 10;
						kilonewtonsResult = inputValue * 0.098067;
						kilopascalsResult = inputValue * 0.098067;
						meganewtonsResult = inputValue * 0.000098;
						newtons_sq_meterResult = inputValue * 98.0665;
						pascalsResult = inputValue * 98.0665;
						poundalsResult = inputValue * 67.718001;
						tonsResult = inputValue * 0.000007;
						tonnesResult = inputValue * 0.01;
						torrResult = inputValue * 0.735561;
						break;
					case 3:
						feet_of_waterResult = inputValue;
						atmospheresResult = inputValue * 0.0295;
						barsResult = inputValue * 0.029891;
						centimeterswaterResult = inputValue * 30.48;
						inches_of_waterResult = inputValue * 12;
						kilogram_forcesResult = inputValue * 304.8;
						kilonewtonsResult = inputValue * 2.989067;
						kilopascalsResult = inputValue * 2.989067;
						meganewtonsResult = inputValue * 0.002989;
						newtons_sq_meterResult = inputValue * 2989.06692;
						pascalsResult = inputValue * 2989.06692;
						poundalsResult = inputValue * 2064.044664;
						tonsResult = inputValue * 0.000217;
						tonnesResult = inputValue * 0.3048;
						torrResult = inputValue * 22.419908;
						break;
					case 4:
						inches_of_waterResult = inputValue;
						atmospheresResult = inputValue * 0.002458;
						barsResult = inputValue * 0.002491;
						centimeterswaterResult = inputValue * 2.54;
						feet_of_waterResult = inputValue * 0.083333;
						kilogram_forcesResult = inputValue * 25.4;
						kilonewtonsResult = inputValue * 0.249089;
						kilopascalsResult = inputValue * 0.249089;
						meganewtonsResult = inputValue * 0.000249;
						newtons_sq_meterResult = inputValue * 249.08891;
						pascalsResult = inputValue * 249.08891;
						poundalsResult = inputValue * 172.003722;
						tonsResult = inputValue * 0.000018;
						tonnesResult = inputValue * 0.0254;
						torrResult = inputValue * 1.868326;
						break;
					case 5:
						kilogram_forcesResult = inputValue;
						atmospheresResult = inputValue * 0.000097;
						barsResult = inputValue * 0.000098;
						centimeterswaterResult = inputValue * 0.1;
						feet_of_waterResult = inputValue * 0.003281;
						inches_of_waterResult = inputValue * 0.03937;
						kilonewtonsResult = inputValue * 0.009807;
						kilopascalsResult = inputValue * 0.009807;
						meganewtonsResult = inputValue * 0.000098;
						newtons_sq_meterResult = inputValue * 9.80665;
						pascalsResult = inputValue * 9.80665;
						poundalsResult = inputValue * 6.7718;
						tonsResult = inputValue * 0.000007;
						tonnesResult = inputValue * 0.001;
						torrResult = inputValue * 0.073556;
						break;
					case 6:
						kilonewtonsResult = inputValue;
						atmospheresResult = inputValue * 0.009869;
						barsResult = inputValue * 0.01;
						centimeterswaterResult = inputValue * 10.197162;
						feet_of_waterResult = inputValue * 0.334553;
						inches_of_waterResult = inputValue * 4.014631;
						kilogram_forcesResult = inputValue * 101.971621;
						kilopascalsResult = inputValue * 1;
						meganewtonsResult = inputValue * 0.001;
						newtons_sq_meterResult = inputValue * 1000;
						pascalsResult = inputValue * 1000;
						poundalsResult = inputValue * 690.531433;
						tonsResult = inputValue * 0.000073;
						tonnesResult = inputValue * 0.101972;
						torrResult = inputValue * 7.500638;
						break;
					case 7:
						kilopascalsResult = inputValue;
						atmospheresResult = inputValue * 0.009869;
						barsResult = inputValue * 0.01;
						centimeterswaterResult = inputValue * 10.197162;
						feet_of_waterResult = inputValue * 0.334553;
						inches_of_waterResult = inputValue * 4.014631;
						kilogram_forcesResult = inputValue * 101.971621;
						kilonewtonsResult = inputValue * 1;
						meganewtonsResult = inputValue * 0.001;
						newtons_sq_meterResult = inputValue * 1000;
						pascalsResult = inputValue * 1000;
						poundalsResult = inputValue * 690.531433;
						tonsResult = inputValue * 0.000073;
						tonnesResult = inputValue * 0.101972;
						torrResult = inputValue * 7.500638;
						break;
					case 8:
						meganewtonsResult = inputValue;
						atmospheresResult = inputValue * 9.869233;
						barsResult = inputValue * 10;
						centimeterswaterResult = inputValue * 10197.16213;
						feet_of_waterResult = inputValue * 334.552563;
						inches_of_waterResult = inputValue * 4014.63076;
						kilogram_forcesResult = inputValue * 101971.621298;
						kilonewtonsResult = inputValue * 1000;
						kilopascalsResult = inputValue * 1000;
						newtons_sq_meterResult = inputValue * 1000000;
						pascalsResult = inputValue * 1000000;
						poundalsResult = inputValue * 690531.432991;
						tonsResult = inputValue * 0.072519;
						tonnesResult = inputValue * 101.971621;
						torrResult = inputValue * 7500.637554;
						break;
					case 9:
						newtons_sq_meterResult = inputValue;
						atmospheresResult = inputValue * 0.000099;
						barsResult = inputValue * 0.00001;
						centimeterswaterResult = inputValue * 0.010197;
						feet_of_waterResult = inputValue * 0.000335;
						inches_of_waterResult = inputValue * 0.004015;
						kilogram_forcesResult = inputValue * 0.101972;
						kilonewtonsResult = inputValue * 0.001;
						kilopascalsResult = inputValue * 0.001;
						meganewtonsResult = inputValue * 0.000001;
						pascalsResult = inputValue * 1;
						poundalsResult = inputValue * 0.690531;
						tonsResult = inputValue * 0.000001;
						tonnesResult = inputValue * 0.000102;
						torrResult = inputValue * 0.007501;
						break;
					case 10:
						pascalsResult = inputValue;
						atmospheresResult = inputValue * 0.000099;
						barsResult = inputValue * 0.00001;
						centimeterswaterResult = inputValue * 0.010197;
						feet_of_waterResult = inputValue * 0.000335;
						inches_of_waterResult = inputValue * 0.004015;
						kilogram_forcesResult = inputValue * 0.101972;
						kilonewtonsResult = inputValue * 0.001;
						kilopascalsResult = inputValue * 0.001;
						meganewtonsResult = inputValue * 0.000001;
						newtons_sq_meterResult = inputValue * 1;
						poundalsResult = inputValue * 0.690531;
						tonsResult = inputValue * 0.000001;
						tonnesResult = inputValue * 0.000102;
						torrResult = inputValue * 0.007501;
						break;
					case 11:
						poundalsResult = inputValue;
						atmospheresResult = inputValue * 0.000014;
						barsResult = inputValue * 0.000014;
						centimeterswaterResult = inputValue * 0.014767;
						feet_of_waterResult = inputValue * 0.000484;
						inches_of_waterResult = inputValue * 0.005814;
						kilogram_forcesResult = inputValue * 0.147671;
						kilonewtonsResult = inputValue * 0.001448;
						kilopascalsResult = inputValue * 0.001448;
						meganewtonsResult = inputValue * 0.0000014;
						newtons_sq_meterResult = inputValue * 1.44816;
						pascalsResult = inputValue * 1.44816;
						tonsResult = inputValue * 0.0000001;
						tonnesResult = inputValue * 0.000148;
						torrResult = inputValue * 0.010862;
						break;
					case 12:
						tonsResult = inputValue;
						atmospheresResult = inputValue * 136.091784;
						barsResult = inputValue * 137.895;
						centimeterswaterResult = inputValue * 140613.767189;
						feet_of_waterResult = inputValue * 4613.312572;
						inches_of_waterResult = inputValue * 55359.750862;
						kilogram_forcesResult = inputValue * 1406137.671886;
						kilonewtonsResult = inputValue * 13789.5;
						kilopascalsResult = inputValue * 13789.5;
						meganewtonsResult = inputValue * 13.7895;
						newtons_sq_meterResult = inputValue * 13789500;
						pascalsResult = inputValue * 13789500;
						poundalsResult = inputValue * 9522083.195227;
						tonnesResult = inputValue * 1406.137672;
						torrResult = inputValue * 103430.041554;
						break;
					case 13:
						tonnesResult = inputValue;
						atmospheresResult = inputValue * 0.096784;
						barsResult = inputValue * 0.098067;
						centimeterswaterResult = inputValue * 100;
						feet_of_waterResult = inputValue * 3.28084;
						inches_of_waterResult = inputValue * 39.370079;
						kilogram_forcesResult = inputValue * 1000;
						kilonewtonsResult = inputValue * 9.80665;
						kilopascalsResult = inputValue * 9.80665;
						meganewtonsResult = inputValue * 0.009807;
						newtons_sq_meterResult = inputValue * 9806.65;
						pascalsResult = inputValue * 9806.65;
						poundalsResult = inputValue * 6771.800077;
						tonsResult = inputValue * 1;
						torrResult = inputValue * 73.556127;
						break;
					case 14:
						torrResult = inputValue;
						atmospheresResult = inputValue * 0.001316;
						barsResult = inputValue * 0.001333;
						centimeterswaterResult = inputValue * 1.359506;
						feet_of_waterResult = inputValue * 0.044603;
						inches_of_waterResult = inputValue * 0.535239;
						kilogram_forcesResult = inputValue * 13.59506;
						kilonewtonsResult = inputValue * 0.133322;
						kilopascalsResult = inputValue * 0.133322;
						meganewtonsResult = inputValue * 0.000133;
						newtons_sq_meterResult = inputValue * 133.322;
						pascalsResult = inputValue * 133.322;
						poundalsResult = inputValue * 92.063032;
						tonsResult = inputValue * 0.000096;
						tonnesResult = inputValue * 0.013595;
						break;
					default: ; 
					    break;
				}
			}
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
