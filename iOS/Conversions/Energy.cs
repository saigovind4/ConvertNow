using System;
using System.Collections.Generic;

namespace ConvertNow.iOS
{
	public class Energy : AbstractCalculator
	{
		public List<double> resultList { get; set; }
		public List<Units> finalresultList { get; set; }

		private string inputString = "";
		private double inputValue;
		private double calories, centigrade_heat_units, electron_volts, ergs, foot_pound_force, foot_poundals, gigajoules, horsepower_hours, joules, kilocalories, kilogram_force_meters, kilojoules, megajoules,
			newton_meters, therms, watt_hours;


		public Energy(string name)
		{
			inputString = name;
		}
		private int testMethod(string selectedUnit)
		{
			var returnValue = new int();
			switch (selectedUnit)
			{
				case "Calories (food)":
							returnValue = EnergyEnum.Caloriesfood.GetHashCode();   break;

				case "Centigrade heat units":
							returnValue = EnergyEnum.Centigradeheatunits.GetHashCode();   break;
					                                
				case "Electron volts":
							returnValue = EnergyEnum.Electronvolts.GetHashCode();   break;
							                        
				case "Ergs":
							returnValue = EnergyEnum.Ergs.GetHashCode();   break;
							                        
				case "Foot_pound force":
							returnValue = EnergyEnum.Foot_poundforce.GetHashCode();   break;
							                        
				case "Foot poundals":
							returnValue = EnergyEnum.Footpoundals.GetHashCode();   break;
							                        
				case "Giga joules":
							returnValue = EnergyEnum.Gigajoules.GetHashCode();   break;

				case "Horse power hours":
							returnValue = EnergyEnum.Horsepowerhours.GetHashCode();   break;
							                        
				case "Joules":
							returnValue = EnergyEnum.Joules.GetHashCode();   break;
							                        
				case "Kilo calories":
							returnValue = EnergyEnum.Kilocalories.GetHashCode();   break;

				case "Kilogram_force meters":
							returnValue = EnergyEnum.Kilogram_forcemeters.GetHashCode();   break;
							                        
				case "Kilo joules":
							returnValue = EnergyEnum.Kilojoules.GetHashCode();   break;
							                        
				case "Mega joules":
							returnValue = EnergyEnum.Megajoules.GetHashCode();   break;
							                        
				case "Newton meters":
							returnValue = EnergyEnum.Newtonmeters.GetHashCode();   break;
							                        
				case "Therms":
							returnValue = EnergyEnum.Therms.GetHashCode();   break;
							                        
				case "Watt hours":
							returnValue = EnergyEnum.Watthours.GetHashCode();   break;

				default:
							returnValue = -1; break;
			}
			return returnValue;
		}


		List<Units> AbstractCalculator.performCalculations(object obj, List<Units> unitsList)
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
						calories = inputValue;
						centigrade_heat_units = inputValue * 2.202694;
						electron_volts = inputValue * 2.612673902595822e+22;
						ergs = inputValue * 418600000e+2;
						foot_pound_force = inputValue * 3087.435157;
						foot_poundals = inputValue * 99335.548173;
						gigajoules = inputValue * 0.0000041;
						horsepower_hours = inputValue * 0.001559;
						joules = inputValue * 4186;
						kilocalories = inputValue * 0.999809;
						kilogram_force_meters = inputValue * 426.853207;
						kilojoules = inputValue * 4.186;
						megajoules = inputValue * 0.004186;
						newton_meters = inputValue * 4186;
						therms = inputValue * 0.000039;
						watt_hours = inputValue * 1.162778;
						break;

					case 1:
						centigrade_heat_units = inputValue;
						calories = inputValue * 0.453989;
						electron_volts = 1.1861264893676781e+22;
						ergs = inputValue * 190040000e+2;
						foot_pound_force = inputValue * 1401.663108;
						foot_poundals = inputValue * 45097.294732;
						gigajoules = inputValue * 0.0000019;
						horsepower_hours = inputValue * 0.000708;
						joules = inputValue * 1900.4;
						kilocalories = inputValue * 0.453903;
						kilogram_force_meters = inputValue * 193.786869;
						kilojoules = inputValue * 1.9004;
						megajoules = inputValue * 0.0019;
						newton_meters = inputValue * 1900.4;
						therms = inputValue * 0.000018;
						watt_hours = inputValue * 0.527889;
						break;

					case 2:
						electron_volts = inputValue;
						calories = inputValue * 0.38275E-22;
						centigrade_heat_units = inputValue * 0.84308E-22;
						ergs = inputValue * 0.160219E-11;
						foot_pound_force = inputValue * 13558179.483314;
						foot_poundals = inputValue * 32.174133;
						gigajoules = inputValue * 0.0000001;
						horsepower_hours = inputValue * 0.0000005;
						joules = inputValue * 1.355818;
						kilocalories = inputValue * 0.382677E-22;
						kilogram_force_meters = inputValue * 0.138255;
						kilojoules = inputValue * 0.001356;
						megajoules = inputValue * 0.0000014;
						newton_meters = inputValue * 1.355818;
						therms = inputValue * 0.00000001;
						watt_hours = inputValue * 0.000377;
						break;

					case 3:
						ergs = inputValue;
						calories = inputValue * 0.238892E-10;
						centigrade_heat_units = inputValue * 0.526205E-10;
						electron_volts = inputValue * 624145700572.342;
						foot_pound_force = inputValue * 0.0000007;
						foot_poundals = inputValue * 0.000002;
						gigajoules = inputValue * 1E-16;
						horsepower_hours = inputValue * 0.372506E-13;
						joules = inputValue * 0.0000001;
						kilocalories = inputValue * 0.239006e-10;
						kilogram_force_meters = inputValue * 0.00000001;
						kilojoules = inputValue * 0.0000000001;
						megajoules = inputValue * 0.1e-12;
						newton_meters = inputValue * 0.0000001;
						therms = inputValue * 0.947817e-15;
						watt_hours = inputValue * 0.277778e-10;
						break;

					case 4:
						foot_pound_force = inputValue;
						calories = inputValue * 0.000324;
						centigrade_heat_units = inputValue * 0.000713;
						electron_volts = inputValue * 846227943e+10;
						ergs = inputValue * 13558179.483314;
						foot_poundals = inputValue * 32.174133;
						gigajoules = inputValue * 0.00000001;
						horsepower_hours = inputValue * 0.0000015;
						joules = inputValue * 1.355818;
						kilocalories = inputValue * 0.000324;
						kilogram_force_meters = inputValue * 0.138255;
						kilojoules = inputValue * 0.001356;
						megajoules = inputValue * 0.0000014;
						newton_meters = inputValue * 1.355818;
						therms = inputValue * 0.00000001;
						watt_hours = inputValue * 0.000377;
						break;

					case 5:
						foot_poundals = inputValue;
						calories = inputValue * 0.00001;
						centigrade_heat_units = inputValue * 0.000022;
						electron_volts = inputValue * 263014998e+9;
						ergs = inputValue * 421400;
						foot_pound_force = inputValue * 0.031081;
						gigajoules = inputValue * 0.4214e-10;
						horsepower_hours = inputValue * 0.000000016;
						joules = inputValue * 0.04214;
						kilocalories = inputValue * 0.00001;
						kilogram_force_meters = inputValue * 0.004297;
						kilojoules = inputValue * 0.000042;
						megajoules = inputValue * 0.00000004;
						newton_meters = inputValue * 0.04214;
						therms = inputValue * 0.39941e-9;
						watt_hours = inputValue * 0.000012;
						break;

					case 6:
						gigajoules = inputValue;
						calories = inputValue * 238891.543239;
						centigrade_heat_units = inputValue * 526205.009472;
						electron_volts = inputValue * 624145700e+19;
						ergs = inputValue * 1000000000e+7;
						foot_pound_force = inputValue * 737562149.277265;
						foot_poundals = inputValue * 23730422401.5188;
						horsepower_hours = inputValue * 372.506072;
						joules = inputValue * 1000000000;
						kilocalories = inputValue * 238845.896627;
						kilogram_force_meters = inputValue * 101971621.297793;
						kilojoules = inputValue * 1000000;
						megajoules = inputValue * 1000;
						newton_meters = inputValue * 1000000000;
						therms = inputValue * 9.478171;
						watt_hours = inputValue * 277777.777778;
						break;

					case 7:
						horsepower_hours = inputValue;
						calories = inputValue * 641.309126;
						centigrade_heat_units = inputValue * 1412.607872;
						electron_volts = inputValue * 1675531616e+16;
						ergs = inputValue * 268452000e+5;
						foot_pound_force = inputValue * 1980000.340978;
						foot_poundals = inputValue * 63704793.545325;
						gigajoules = inputValue * 0.002685;
						joules = inputValue * 2684520;
						kilocalories = inputValue * 641.186586;
						kilogram_force_meters = inputValue * 273744.856806;
						kilojoules = inputValue * 2684.52;
						megajoules = inputValue * 2.68452;
						newton_meters = inputValue * 2684520;
						therms = inputValue * 0.025444;
						watt_hours = inputValue * 745.7;
						break;
					case 8:
						joules = inputValue;
						calories = inputValue * 0.000239;
						centigrade_heat_units = inputValue * 0.000526;
						electron_volts = inputValue * 624145700e+10;
						ergs = inputValue * 10000000;
						foot_pound_force = inputValue * 0.737562;
						foot_poundals = inputValue * 23.730422;
						gigajoules = inputValue * 0.000000001;
						horsepower_hours = inputValue * 0.0000037;
						kilocalories = inputValue * 0.000239;
						kilogram_force_meters = inputValue * 0.101972;
						kilojoules = inputValue * 0.001;
						megajoules = inputValue * 0.000001;
						newton_meters = inputValue * 1;
						therms = inputValue * 0.00000001;
						watt_hours = inputValue * 0.000278;
						break;

					case 9:
						kilocalories = inputValue;
						calories = inputValue * 1.000191;
						centigrade_heat_units = inputValue * 2.203115;
						electron_volts = inputValue * 261317321e+14;
						ergs = inputValue * 41868000e+3;
						foot_pound_force = inputValue * 3088.025207;
						foot_poundals = inputValue * 99354.532511;
						gigajoules = inputValue * 0.000004;
						horsepower_hours = inputValue * 0.00156;
						joules = inputValue * 4186.8;
						kilogram_force_meters = inputValue * 426.934784;
						kilojoules = inputValue * 4.1868;
						megajoules = inputValue * 0.004187;
						newton_meters = inputValue * 4186.8;
						therms = inputValue * 0.000039;
						watt_hours = inputValue * 1.163;
						break;

					case 10:
						kilogram_force_meters = inputValue;
						calories = inputValue * 0.002343;
						centigrade_heat_units = inputValue * 0.00516;
						electron_volts = inputValue * 612077843e+11;
						ergs = inputValue * 98066500;
						foot_pound_force = inputValue * 7.233014;
						foot_poundals = inputValue * 232.715947;
						gigajoules = inputValue * 0.00000001;
						horsepower_hours = inputValue * 0.00000365;
						joules = inputValue * 9.80665;
						kilocalories = inputValue * 0.002342;
						kilojoules = inputValue * 0.009807;
						megajoules = inputValue * 0.000098;
						newton_meters = inputValue * 9.80665;
						therms = inputValue * 0.00000090;
						watt_hours = inputValue * 0.002724;
						break;

					case 11:
						kilojoules = inputValue;
						calories = inputValue * 0.238892;
						centigrade_heat_units = inputValue * 0.526205;
						electron_volts = inputValue * 624145700e+13;
						ergs = inputValue * 100000000e+2;
						foot_pound_force = inputValue * 737.562149;
						foot_poundals = inputValue * 23730.422402;
						gigajoules = inputValue * 0.000001;
						horsepower_hours = inputValue * 0.000373;
						joules = inputValue * 1000;
						kilocalories = inputValue * 0.238846;
						kilogram_force_meters = inputValue * 101.971621;
						megajoules = inputValue * 0.001;
						newton_meters = inputValue * 1000;
						therms = inputValue * 0.0000094;
						watt_hours = inputValue * 0.277778;
						break;

					case 12:
						megajoules = inputValue;
						calories = inputValue * 238.891543;
						centigrade_heat_units = inputValue * 526.205009;
						electron_volts = inputValue * 624145700e+16;
						ergs = inputValue * 1000000000e+4;
						foot_pound_force = inputValue * 737562.149277;
						foot_poundals = inputValue * 23730422.401519;
						gigajoules = inputValue * 0.001;
						horsepower_hours = inputValue * 0.372506;
						joules = inputValue * 1000000;
						kilocalories = inputValue * 238.845897;
						kilogram_force_meters = inputValue * 101971.621298;
						kilojoules = inputValue * 1000;
						newton_meters = inputValue * 1000000;
						therms = inputValue * 0.009478;
						watt_hours = inputValue * 277.777778;
						break;

					case 13:
						newton_meters = inputValue;
						calories = inputValue * 0.000239;
						centigrade_heat_units = inputValue * 0.000526;
						electron_volts = inputValue * 624145700e+10;
						ergs = inputValue * 10000000;
						foot_pound_force = inputValue * 0.737562;
						foot_poundals = inputValue * 23.730422;
						gigajoules = inputValue * 0.000000001;
						horsepower_hours = inputValue * 0.000000373;
						joules = inputValue * 1;
						kilocalories = inputValue * 0.000239;
						kilogram_force_meters = inputValue * 0.101972;
						kilojoules = inputValue * 0.001;
						megajoules = inputValue * 0.000001;
						therms = inputValue * 0.00000001;
						watt_hours = inputValue * 0.000278;
						break;

					case 14:
						therms = inputValue;
						calories = inputValue * 25204.392083;
						centigrade_heat_units = inputValue * 55517.56749;
						electron_volts = inputValue * 658508574e+18;
						ergs = inputValue * 1055055852e+6;
						foot_pound_force = inputValue * 77816926.223165;
						foot_poundals = inputValue * 2503692103.87632;
						gigajoules = inputValue * 0.105506;
						horsepower_hours = inputValue * 39.301471;
						joules = inputValue * 105505585.257348;
						kilocalories = inputValue * 25199.57611;
						kilogram_force_meters = inputValue * 10758575.584664;
						kilojoules = inputValue * 105505.585257;
						megajoules = inputValue * 105.505585;
						newton_meters = inputValue * 105505585.257348;
						watt_hours = inputValue * 29307.107016;
						break;

					case 15:
						watt_hours = inputValue;
						calories = inputValue * 0.86001;
						centigrade_heat_units = inputValue * 1.894338;
						electron_volts = inputValue * 224692452e+14;
						ergs = inputValue * 36000000e+3;
						foot_pound_force = inputValue * 2655.223737;
						foot_poundals = inputValue * 85429.520645;
						gigajoules = inputValue * 0.0000036;
						horsepower_hours = inputValue * 0.001341;
						joules = inputValue * 3600;
						kilocalories = inputValue * 0.859845;
						kilogram_force_meters = inputValue * 367.097837;
						kilojoules = inputValue * 3.6;
						megajoules = inputValue * 0.0036;
						newton_meters = inputValue * 3600;
						therms = inputValue * 0.000034;
						break;

					default:
						break;
				}
			}
			resultList.Add(calories);
			resultList.Add(centigrade_heat_units);
			resultList.Add(electron_volts);
			resultList.Add(ergs);
			resultList.Add(foot_pound_force);
			resultList.Add(foot_poundals);
			resultList.Add(gigajoules);
			resultList.Add(horsepower_hours);
			resultList.Add(joules);
			resultList.Add(kilocalories);
			resultList.Add(kilogram_force_meters);
			resultList.Add(kilojoules);
			resultList.Add(megajoules);
			resultList.Add(newton_meters);
			resultList.Add(therms);
			resultList.Add(watt_hours);

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

		public enum EnergyEnum
		{
			Caloriesfood,
			Centigradeheatunits,
			Electronvolts,
			Ergs,
			Foot_poundforce,
			Footpoundals,
			Gigajoules,
			Horsepowerhours,
			Joules,
			Kilocalories,
			Kilogram_forcemeters,
			Kilojoules,
			Megajoules,
			Newtonmeters,
			Therms,
			Watthours
		};
	}
}
