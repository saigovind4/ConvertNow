using System.Collections.Generic;

namespace ConvertNow.iOS
{
	public class Area : AbstractCalculator
	{
		private string inputString = "";
		private double inputValue;
		public List<double> resultList { get; set; }
		public List<Units> finalresultList { get; set; }

		private double acreResult, aresResult, hectaresResult, roodsResult, scmResult, sftResult, sinchResult, skmResult, smResult, smilesResult, smmResults, srodsResult, sydResult, townshipResult;

		public Area(string name)
		{
			inputString = name;
		}

		private int testMethod(string selectedUnit)
		{
			var returnValue = new int();
			switch (selectedUnit)
			{
				case "Acres":
					returnValue = AreaEnum.Acres.GetHashCode();
					break;

				case "Ares":
					returnValue = AreaEnum.Ares.GetHashCode();
					break;

				case "Hectares":
							returnValue = AreaEnum.Hectares.GetHashCode();
							break;
				case "Roods":
							returnValue = AreaEnum.Roods.GetHashCode();
					break;
				case "Square centimeters":
							returnValue = AreaEnum.Squarecentimeters.GetHashCode();
					break;
				case "Square kilometers":
							returnValue = AreaEnum.Squarekilometers.GetHashCode();
					break;
				case "Square miles":
							returnValue = AreaEnum.Squaremiles.GetHashCode();
					break;
				case "Square yards":
							returnValue = AreaEnum.Squareyards.GetHashCode();
					break;
				case "Square millimeters":
							returnValue = AreaEnum.Squaremillimeters.GetHashCode();;
					break;
				case "Square rods (or poles)":
							returnValue = AreaEnum.Squarerodsorpoles.GetHashCode();;
					break;
				case "Square feet":
							returnValue = AreaEnum.Squarefeet.GetHashCode();;
					break;
				case "Square inches":
							returnValue = AreaEnum.Squareinches.GetHashCode();;
					break;
				case "Square meters":
							returnValue = AreaEnum.Squaremeters.GetHashCode();
					break;
				case "Townships":
							returnValue = AreaEnum.Townships.GetHashCode();;
					break;		                      
				default:
							returnValue = -1;
							break;

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
						acreResult = inputValue;
						aresResult = 40.468564224 * inputValue;
						hectaresResult = 0.40468564224 * inputValue;
						roodsResult = 4 * inputValue;
						scmResult = 40468564.224 * inputValue;
						sftResult = 43560 * inputValue;
						sinchResult = 6272640 * inputValue;
						skmResult = 0.0040468564224 * inputValue;
						smResult = 4046.8564224 * inputValue;
						smilesResult = 0.0015625 * inputValue;
						smmResults = 4046856422.4 * inputValue;
						srodsResult = 160 * inputValue;
						sydResult = 4840 * inputValue;
						townshipResult = 0.00004340277777778 * inputValue;
						break;
					case 1:
						acreResult = 0.02471053814672 * inputValue;
						aresResult = inputValue;
						hectaresResult = 0.01 * inputValue;
						roodsResult = 0.09884215258687 * inputValue;
						scmResult = 1000000 * inputValue;
						sftResult = 1076.391041671 * inputValue;
						sinchResult = 155000.3100006 * inputValue;
						skmResult = 0.0001 * inputValue;
						smResult = 100 * inputValue;
						smilesResult = 0.00003861021585424 * inputValue;
						smmResults = 100000000 * inputValue;
						srodsResult = 3.953686103475 * inputValue;
						sydResult = 119.5990046301 * inputValue;
						townshipResult = 0.000001072505995951 * inputValue;
						break;
					case 2:
						acreResult = 2.471053814672 * inputValue;
						aresResult = 100 * inputValue;
						hectaresResult = inputValue;
						roodsResult = 9.884215258687 * inputValue;
						scmResult = 100000000 * inputValue;
						sftResult = 107639.1041671 * inputValue;
						sinchResult = 15500031.00006 * inputValue;
						skmResult = 0.01 * inputValue;
						smResult = 10000 * inputValue;
						smilesResult = 0.003861021585424 * inputValue;
						smmResults = 10000000E+3 * inputValue;
						srodsResult = 395.3686103475 * inputValue;
						sydResult = 11959.90046301 * inputValue;
						townshipResult = 0.0001072505995951 * inputValue;
						break;

					case 3:
						acreResult = 0.25 * inputValue;
						aresResult = 0.25 * inputValue;
						hectaresResult = 0.10117141056 * inputValue;
						roodsResult = inputValue;
						scmResult = 10117141.056 * inputValue;
						sftResult = 10890 * inputValue;
						sinchResult = 1568160 * inputValue;
						skmResult = 0.0010117141056 * inputValue;
						smResult = 1011.7141056 * inputValue;
						smilesResult = 0.000390625 * inputValue;
						smmResults = 1011714105.6 * inputValue;
						srodsResult = 40 * inputValue;
						sydResult = 1210 * inputValue;
						townshipResult = 0.00001085069444444 * inputValue;
						break;
					case 4:
						acreResult = 2.471053814672E-8 * inputValue;
						aresResult = 0.000001 * inputValue;
						hectaresResult = 1E-8 * inputValue;
						roodsResult = 9.884215258687E-8 * inputValue;
						scmResult = inputValue;
						sftResult = 0.001076391041671 * inputValue;
						sinchResult = 0.1550003100006 * inputValue;
						skmResult = 1E-10 * inputValue;
						smResult = 0.0001 * inputValue;
						smilesResult = 3.861021585424E-11 * inputValue;
						smmResults = 100 * inputValue;
						srodsResult = 0.000003953686103475 * inputValue;
						sydResult = 0.0001195990046301 * inputValue;
						townshipResult = 1.072505995951E-12 * inputValue;
						break;

					case 5:
						acreResult = 0.00002295684113866 * inputValue;
						aresResult = 0.0009290304 * inputValue;
						hectaresResult = 0.000009290304 * inputValue;
						roodsResult = 0.00009182736455463 * inputValue;
						scmResult = 929.0304 * inputValue;
						sftResult = inputValue;
						sinchResult = 144 * inputValue;
						skmResult = 9.290304E-8 * inputValue;
						smResult = 0.09290304 * inputValue;
						smilesResult = 3.587006427915E-8 * inputValue;
						smmResults = 92903.04 * inputValue;
						srodsResult = 0.003673094582185 * inputValue;
						sydResult = 0.1111111111111 * inputValue;
						townshipResult = 9.963906744209E-10 * inputValue;
						break;
					case 6:
						acreResult = 1.594225079074E-7 * inputValue;
						aresResult = 0.0000064516 * inputValue;
						hectaresResult = 6.4516E-8 * inputValue;
						roodsResult = 6.376900316294E-7 * inputValue;
						scmResult = 6.4516 * inputValue;
						sftResult = 0.006944444444445 * inputValue;
						sinchResult = inputValue;
						skmResult = 6.4516E-10 * inputValue;
						smResult = 0.00064516 * inputValue;
						smilesResult = 2.490976686052E-10 * inputValue;
						smmResults = 645.16 * inputValue;
						srodsResult = 0.00002550760126518 * inputValue;
						sydResult = 0.0007716049382716 * inputValue;
						townshipResult = 6.919379683479E-12 * inputValue;
						break;
					case 7:
						acreResult = 247.1053814672 * inputValue;
						aresResult = 10000 * inputValue;
						hectaresResult = 100 * inputValue;
						roodsResult = 988.4215258687 * inputValue;
						scmResult = 10000000E+3 * inputValue;
						sftResult = 10763910.41671 * inputValue;
						sinchResult = 1550003100.006 * inputValue;
						skmResult = inputValue;
						smResult = 1000000 * inputValue;
						smilesResult = 0.3861021585425 * inputValue;
						smmResults = 1000000000E+4 * inputValue;
						srodsResult = 39536.86103475 * inputValue;
						sydResult = 1195990.046301 * inputValue;
						townshipResult = 0.01072505995951 * inputValue;
						break;
					case 8:
						acreResult = 0.0002471053814672 * inputValue;
						aresResult = 0.01 * inputValue;
						hectaresResult = 0.0001 * inputValue;
						roodsResult = 0.0009884215258687 * inputValue;
						scmResult = 10000 * inputValue;
						sftResult = 10.76391041671 * inputValue;
						sinchResult = 1550.003100006 * inputValue;
						skmResult = 0.000001 * inputValue;
						smResult = inputValue;
						smilesResult = 3.861021585425E-7 * inputValue;
						smmResults = 1000000 * inputValue;
						srodsResult = 0.03953686103475 * inputValue;
						sydResult = 1.195990046301 * inputValue;
						townshipResult = 1.072505995951E-8 * inputValue;
						break;
					case 9:
						acreResult = 640 * inputValue;
						aresResult = 25899.88110336 * inputValue;
						hectaresResult = 258.9988110336 * inputValue;
						roodsResult = 2560 * inputValue;
						scmResult = 25899881103.36 * inputValue;
						sftResult = 27878400 * inputValue;
						sinchResult = 40144896E+2 * inputValue;
						skmResult = 2.589988110336 * inputValue;
						smResult = 2589988.110336 * inputValue;
						smilesResult = inputValue;
						smmResults = 258998811E+4 * inputValue;
						srodsResult = 102400 * inputValue;
						sydResult = 3097600 * inputValue;
						townshipResult = 0.02777777777778 * inputValue;
						break;
					case 10:
						acreResult = 2.471053814672E-10 * inputValue;
						aresResult = 1E-8 * inputValue;
						hectaresResult = 1E-10 * inputValue;
						roodsResult = 9.884215258687E-10 * inputValue;
						scmResult = 0.01 * inputValue;
						sftResult = 0.00001076391041671 * inputValue;
						sinchResult = 0.001550003100006 * inputValue;
						skmResult = 1E-12 * inputValue;
						smResult = 0.000001 * inputValue;
						smilesResult = 3.861021585425E-13 * inputValue;
						smmResults = inputValue;
						srodsResult = 3.953686103475E-8 * inputValue;
						sydResult = 0.000001195990046301 * inputValue;
						townshipResult = 1.072505995951E-14 * inputValue;
						break;
					case 11:
						acreResult = 0.00625 * inputValue;
						aresResult = 0.2529285264 * inputValue;
						hectaresResult = 0.002529285264 * inputValue;
						roodsResult = 0.025 * inputValue;
						scmResult = 252928.5264 * inputValue;
						sftResult = 272.25 * inputValue;
						sinchResult = 39204 * inputValue;
						skmResult = 0.00002529285264 * inputValue;
						smResult = 25.29285264 * inputValue;
						smilesResult = 3.861021585425E-13 * inputValue;
						smmResults = 0.000009765625 * inputValue;
						srodsResult = inputValue;
						sydResult = 30.25 * inputValue;
						townshipResult = 2.712673611111E-7 * inputValue;
						break;
					case 12:
						acreResult = 0.0002066115702479 * inputValue;
						aresResult = 0.0083612736 * inputValue;
						hectaresResult = 0.000083612736 * inputValue;
						roodsResult = 0.0008264462809917 * inputValue;
						scmResult = 8361.2736 * inputValue;
						sftResult = 9 * inputValue;
						sinchResult = 1296 * inputValue;
						skmResult = 8.3612736E-7 * inputValue;
						smResult = 0.83612736 * inputValue;
						smilesResult = 3.228305785124E-7 * inputValue;
						smmResults = 836127.36 * inputValue;
						srodsResult = 0.03305785123967 * inputValue;
						sydResult = inputValue;
						townshipResult = 8.967516069788E-9 * inputValue;
						break;
					case 13:
						acreResult = 23040 * inputValue;
						aresResult = 932395.719721 * inputValue;
						hectaresResult = 9323.95719721 * inputValue;
						roodsResult = 92160 * inputValue;
						scmResult = 932395719E+3 * inputValue;
						sftResult = 1003622400 * inputValue;
						sinchResult = 1445216256E+2 * inputValue;
						skmResult = 93.2395719721 * inputValue;
						smResult = 93239571.9721 * inputValue;
						smilesResult = 36 * inputValue;
						smmResults = 932395719E+5 * inputValue;
						srodsResult = 3686400 * inputValue;
						sydResult = 111513600 * inputValue;
						townshipResult = inputValue;
						break;
					default: ;
						break;
				}
			}
			resultList.Add(acreResult);
			resultList.Add(aresResult);
			resultList.Add(hectaresResult);
			resultList.Add(roodsResult);
			resultList.Add(scmResult);
			resultList.Add(sftResult);
			resultList.Add(sinchResult);
			resultList.Add(skmResult);
			resultList.Add(smResult);
			resultList.Add(smilesResult);
			resultList.Add(smmResults);
			resultList.Add(srodsResult);
			resultList.Add(sydResult);
			resultList.Add(townshipResult);
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


		enum AreaEnum
		{
			Acres,
			Ares,
			Hectares,
			Roods,
			Squarecentimeters,
			Squarefeet,
			Squareinches,
			Squarekilometers,
			Squaremeters,
			Squaremiles,
			Squaremillimeters,
			Squarerodsorpoles,
			Squareyards,
			Townships
		};
	}
}
