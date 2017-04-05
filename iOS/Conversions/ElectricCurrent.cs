	using System;
	using System.Collections.Generic;

	namespace ConvertNow.iOS
	{
		public class ElectricCurrent : AbstractCalculator
		{
			private string inputString = "";
			private double inputValue;
			public List<double> resultList { get; set; }
			public List<Units> finalresultList { get; set; }
			private double abampere, ampere, biot, centiampere, coulomb_second, EMU_of_current, teraampere, watt_volt, gaussian_electric_current, gilbert, kiloampere, weber_henry, megaampere, milliampere, picoampere, volt_ohm;

			public ElectricCurrent(string name)
			{
				inputString = name;
			}
			private int testMethod(string selectedUnit)
			{
				var returnValue = new int();
				switch (selectedUnit)
				{
					case "Abampere":
						returnValue = ElectricCurrentEnum.Abampere.GetHashCode();   break;

					 case "Ampere":
								returnValue = ElectricCurrentEnum.Ampere.GetHashCode();   break;


					 case "Biot":
								returnValue = ElectricCurrentEnum.Biot.GetHashCode();   break;


					 case "Centiampere":
								returnValue = ElectricCurrentEnum.Centiampere.GetHashCode();   break;


					 case "Coulomb per second":
								returnValue = ElectricCurrentEnum.Coulombpersecond.GetHashCode();   break;


					 case "EMU of current":
								returnValue = ElectricCurrentEnum.EMUofcurrent.GetHashCode();   break;


					 case "Tera ampere":
								returnValue = ElectricCurrentEnum.Teraampere.GetHashCode();   break;


					 case "Watt per volt":
								returnValue = ElectricCurrentEnum.Wattpervolt.GetHashCode();   break;


					 case "Gaussian electric current":
								returnValue = ElectricCurrentEnum.Gaussianelectriccurrent.GetHashCode();   break;

					 case "Gilbert":
								returnValue = ElectricCurrentEnum.Gilbert.GetHashCode();   break;


					 case "Kilo ampere":
								returnValue = ElectricCurrentEnum.Kiloampere.GetHashCode();   break;


					 case "Mega ampere":
								returnValue = ElectricCurrentEnum.Megaampere.GetHashCode();   break;


					 case "Milli ampere":
								returnValue = ElectricCurrentEnum.Milliampere.GetHashCode();   break;

					 case "Pico ampere":
								returnValue = ElectricCurrentEnum.Picoampere.GetHashCode();   break;


					 case "Volt per ohm":
								returnValue = ElectricCurrentEnum.Voltperohm.GetHashCode();   break;


					 case "Weber per henry":
								returnValue = ElectricCurrentEnum.Weberperhenry.GetHashCode();   break;
								                                 
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
							abampere = inputValue;
							ampere = inputValue * 10;
							biot = inputValue * 1;
							centiampere = inputValue * 1000;
							coulomb_second = inputValue * 10;
							EMU_of_current = inputValue * 1;
							teraampere = inputValue * 0;
							watt_volt = inputValue * 10;
							gaussian_electric_current = inputValue * 29979245368.4314;
							gilbert = inputValue * 12.566371;
							kiloampere = inputValue * 0.01;
							weber_henry = inputValue * 10;
							megaampere = inputValue * 0.00001;
							milliampere = inputValue * 10000;
							picoampere = inputValue * 1000000000e+4;
							volt_ohm = inputValue * 10;
							break;
						case 1:
							ampere = inputValue;
							abampere = inputValue * 0.1;
							biot = inputValue * 0.1;
							centiampere = inputValue * 100;
							coulomb_second = inputValue * 1;
							EMU_of_current = inputValue * 0.1;
							teraampere = inputValue * 0;
							watt_volt = inputValue * 1;
							gaussian_electric_current = inputValue * 2997924536.84314;
							gilbert = inputValue * 1.256637;
							kiloampere = inputValue * 0.001;
							weber_henry = inputValue * 1;
							megaampere = inputValue * 0.000001;
							milliampere = inputValue * 1000;
							picoampere = inputValue * 100000000e+4;
							volt_ohm = inputValue * 1;
							break;
						case 2:
							biot = inputValue;
							abampere = inputValue * 1;
							ampere = inputValue * 10;
							centiampere = inputValue * 1000;
							coulomb_second = inputValue * 10;
							EMU_of_current = inputValue * 1;
							teraampere = inputValue * 0;
							watt_volt = inputValue * 10;
							gaussian_electric_current = inputValue * 29979245368.4314;
							gilbert = inputValue * 12.566371;
							kiloampere = inputValue * 0.01;
							weber_henry = inputValue * 10;
							megaampere = inputValue * 0.00001;
							milliampere = inputValue * 10000;
							picoampere = inputValue * 1000000000e+4;
							volt_ohm = inputValue * 10;
							break;

						case 3:
							centiampere = inputValue;
							abampere = inputValue * 0.001;
							ampere = inputValue * 0.01;
							biot = inputValue * 0.001;
							coulomb_second = inputValue * 0.01;
							EMU_of_current = inputValue * 0.001;
							teraampere = inputValue * 0;
							watt_volt = inputValue * 0.01;
							gaussian_electric_current = inputValue * 29979245.368431;
							gilbert = inputValue * 0.012566;
							kiloampere = inputValue * 0.00001;
							weber_henry = inputValue * 0.01;
							megaampere = inputValue * 0.00000001;
							milliampere = inputValue * 10;
							picoampere = inputValue * 100000000e+2;
							volt_ohm = inputValue * 0.01;
							break;

						case 4:
							coulomb_second = inputValue;
							abampere = inputValue * 0.1;
							ampere = inputValue * 1;
							biot = inputValue * 0.1;
							centiampere = inputValue * 100;
							EMU_of_current = inputValue * 0.1;
							teraampere = inputValue * 0;
							watt_volt = inputValue * 1;
							gaussian_electric_current = inputValue * 2997924536.84314;
							gilbert = inputValue * 1.256637;
							kiloampere = inputValue * 0.001;
							weber_henry = inputValue * 1;
							megaampere = inputValue * 0.000001;
							milliampere = inputValue * 1000;
							picoampere = inputValue * 1000000000e+3;
							volt_ohm = inputValue * 1;
							break;

						case 5:
							EMU_of_current = inputValue;
							abampere = inputValue * 1;
							ampere = inputValue * 10;
							biot = inputValue * 1;
							centiampere = inputValue * 1000;
							coulomb_second = inputValue * 10;
							teraampere = inputValue * 0;
							watt_volt = inputValue * 10;
							gaussian_electric_current = inputValue * 29979245368.4314;
							gilbert = inputValue * 12.566371;
							kiloampere = inputValue * 0.01;
							weber_henry = inputValue * 10;
							megaampere = inputValue * 0.00001;
							milliampere = inputValue * 10000;
							picoampere = inputValue * 1000000000e+4;
							volt_ohm = inputValue * 10;
							break;

						case 6:
							teraampere = inputValue;
							abampere = inputValue * 1000000000e+2;
							ampere = inputValue * 1000000000e+3;
							biot = inputValue * 1000000000e+2;
							centiampere = inputValue * 1000000000e+5;
							coulomb_second = inputValue * 1000000000e+3;
							EMU_of_current = inputValue * 1000000000e+2;
							watt_volt = inputValue * 1000000000e+3;
							gaussian_electric_current = inputValue * 299792453e+13;
							gilbert = inputValue * 1256637054265.81;
							kiloampere = inputValue * 1000000000;
							weber_henry = inputValue * 1000000000e+3;
							megaampere = inputValue * 1000000;
							milliampere = inputValue * 1000000000e+6;
							picoampere = inputValue * 1000000000e+15;
							volt_ohm = inputValue * 1000000000e+3;
							break;
						case 7:
							watt_volt = inputValue;
							abampere = inputValue * 0.1;
							ampere = inputValue * 1;
							biot = inputValue * 0.1;
							centiampere = inputValue * 100;
							coulomb_second = inputValue * 1;
							EMU_of_current = inputValue * 0.1;
							teraampere = inputValue * 0;
							gaussian_electric_current = inputValue * 2997924536.84314;
							gilbert = inputValue * 1.256637;
							kiloampere = inputValue * 0.001;
							weber_henry = inputValue * 1;
							megaampere = inputValue * 0.000001;
							milliampere = inputValue * 1000;
							picoampere = inputValue * 1000000000e+3;
							volt_ohm = inputValue * 1;
							break;
						case 8:
							gaussian_electric_current = inputValue;
							abampere = inputValue * 0.00000000003;
							ampere = inputValue * 0.0000000003;
							biot = inputValue * 0.00000000003;
							centiampere = inputValue * 0.000000033;
							coulomb_second = inputValue * 0.0000000003;
							EMU_of_current = inputValue * 0.00000000003;
							teraampere = inputValue * 0;
							watt_volt = inputValue * 0.0000000003;
							gilbert = inputValue * 0.0000000004;
							kiloampere = inputValue * 0;
							weber_henry = inputValue * 0.0000000003;
							megaampere = inputValue * 0;
							milliampere = inputValue * 0.0000003;
							picoampere = inputValue * 333.5641;
							volt_ohm = inputValue * 0.0000000003;
							break;
						case 9:
							gilbert = inputValue;
							abampere = inputValue * 0.079577;
							ampere = inputValue * 0.795775;
							biot = inputValue * 0.079577;
							centiampere = inputValue * 79.577472;
							coulomb_second = inputValue * 0.795775;
							EMU_of_current = inputValue * 0.079577;
							teraampere = inputValue * 0;
							watt_volt = inputValue * 0.795775;
							gaussian_electric_current = inputValue * 2385672558.88748;
							kiloampere = inputValue * 0.000796;
							weber_henry = inputValue * 0.795775;
							megaampere = inputValue * 0.000001;
							milliampere = inputValue * 795.77472;
							picoampere = inputValue * 795774720e+3;
							volt_ohm = inputValue * 0.795775;
							break;
						case 10:
							kiloampere = inputValue;
							abampere = inputValue * 100;
							ampere = inputValue * 1000;
							biot = inputValue * 100;
							centiampere = inputValue * 100000;
							coulomb_second = inputValue * 1000;
							EMU_of_current = inputValue * 100;
							teraampere = inputValue * 0.000000001;
							watt_volt = inputValue * 1000;
							gaussian_electric_current = inputValue * 2997924536843.14;
							gilbert = inputValue * 1256.637054;
							weber_henry = inputValue * 1000;
							megaampere = inputValue * 0.001;
							milliampere = inputValue * 1000000;
							picoampere = inputValue * 1000000000e+6;
							volt_ohm = inputValue * 1000;
							break;
						case 11:
							weber_henry = inputValue;
							abampere = inputValue * 0.1;
							ampere = inputValue * 1;
							biot = inputValue * 0.1;
							centiampere = inputValue * 100;
							coulomb_second = inputValue * 1;
							EMU_of_current = inputValue * 0.1;
							teraampere = inputValue * 0;
							watt_volt = inputValue * 1;
							gaussian_electric_current = inputValue * 2997924536.84314;
							gilbert = inputValue * 1.256637;
							kiloampere = inputValue * 0.001;
							megaampere = inputValue * 0.000001;
							milliampere = inputValue * 1000;
							picoampere = inputValue * 1000000000e+3;
							volt_ohm = inputValue * 1;
							break;
						case 12:
							megaampere = inputValue;
							abampere = inputValue * 100000;
							ampere = inputValue * 1000000;
							biot = inputValue * 100000;
							centiampere = inputValue * 100000000;
							coulomb_second = inputValue * 1000000;
							EMU_of_current = inputValue * 100000;
							teraampere = inputValue * 0.000001;
							watt_volt = inputValue * 1000000;
							gaussian_electric_current = inputValue * 299792453e+7;
							gilbert = inputValue * 1256637.054266;
							kiloampere = inputValue * 1000;
							weber_henry = inputValue * 1000000;
							milliampere = inputValue * 1000000000;
							picoampere = inputValue * 1000000000e+9;
							volt_ohm = inputValue * 1000000;
							break;
						case 13:
							milliampere = inputValue;
							abampere = inputValue * 0.0001;
							ampere = inputValue * 0.001;
							biot = inputValue * 0.0001;
							centiampere = inputValue * 0.1;
							coulomb_second = inputValue * 0.001;
							EMU_of_current = inputValue * 0.0001;
							teraampere = inputValue * 0;
							watt_volt = inputValue * 0.001;
							gaussian_electric_current = inputValue * 2997924.536843;
							gilbert = inputValue * 0.001257;
							kiloampere = inputValue * 0.000001;
							weber_henry = inputValue * 0.001;
							megaampere = inputValue * 0.000000001;
							picoampere = inputValue * 1000000000;
							volt_ohm = inputValue * 0.001;
							break;
						case 14:
							picoampere = inputValue;
							abampere = inputValue * 0;
							ampere = inputValue * 0;
							biot = inputValue * 0;
							centiampere = inputValue * 0.0000000001;
							coulomb_second = inputValue * 0;
							EMU_of_current = inputValue * 0;
							teraampere = inputValue * 0;
							watt_volt = inputValue * 0;
							gaussian_electric_current = inputValue * 0.002998;
							gilbert = inputValue * 0;
							kiloampere = inputValue * 0;
							weber_henry = inputValue * 0;
							megaampere = inputValue * 0;
							milliampere = inputValue * 0.000000001;
							volt_ohm = inputValue * 0;
							break;
						case 15:
							volt_ohm = inputValue;
							abampere = inputValue * 0.1;
							ampere = inputValue * 1;
							biot = inputValue * 0.1;
							centiampere = inputValue * 100;
							coulomb_second = inputValue * 1;
							EMU_of_current = inputValue * 0.1;
							teraampere = inputValue * 0;
							watt_volt = inputValue * 1;
							gaussian_electric_current = inputValue * 2997924536.84314;
							gilbert = inputValue * 1.256637;
							kiloampere = inputValue * 0.001;
							weber_henry = inputValue * 1;
							megaampere = inputValue * 0.000001;
							milliampere = inputValue * 1000;
							picoampere = inputValue * 1000000000e+3;
							break;
						default: ;
							break;
					}
				}
				resultList.Add(abampere);
				resultList.Add(ampere);
				resultList.Add(biot);
				resultList.Add(centiampere);
				resultList.Add(coulomb_second);
				resultList.Add(EMU_of_current);
				resultList.Add(teraampere);
				resultList.Add(watt_volt);
				resultList.Add(gaussian_electric_current);
				resultList.Add(gilbert);
				resultList.Add(kiloampere);
				resultList.Add(megaampere);
				resultList.Add(milliampere);
				resultList.Add(picoampere);
				resultList.Add(volt_ohm);
				resultList.Add(weber_henry);

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

			public enum ElectricCurrentEnum
			{
				Abampere,
				Ampere,
				Biot,
				Centiampere,
				Coulombpersecond,
				EMUofcurrent,
				Teraampere,
				Wattpervolt,
				Gaussianelectriccurrent,
				Gilbert,
				Kiloampere,
				Megaampere,
				Milliampere,
				Picoampere,
				Voltperohm,
				Weberperhenry
			};
		}
	}
