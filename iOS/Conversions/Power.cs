using System.Collections.Generic;

namespace ConvertNow.iOS
{
	public class Power : AbstractCalculator
	{
		private string inputString = "";
		private double inputValue;
		public List<double> resultList { get; set; }
		public List<Units> finalresultList { get; set; }
		private double btuperhour,btuperminute,btupersecond,caloriesperhour,caloriesperminute,caloriespersecond,gigawatts,horsepowerselectric,horsepowersinternational
		,horsepowerswater,horsepowersmetric,watts,joulesperhour,joulesperminute,joulespersecond,kilocaloriesperhour,kilocaloriesperminute;

		public Power(string name)
		{
			inputString = name;
		}

		private int testMethod(string selectedUnit)
		{
			var returnValue = new int();
			switch (selectedUnit)
			{
				case "Btu per hour":
					returnValue = PowerEnum.Btuperhour.GetHashCode(); break;


				case "Btu per minute":
							returnValue = PowerEnum.Btuperminute.GetHashCode(); break;


				case "Btupersecond":
							returnValue = PowerEnum.Btupersecond.GetHashCode(); break;



				case "Calories per hour":
							returnValue = PowerEnum.Caloriesperhour.GetHashCode(); break;



				case "Calories per minute":
							returnValue = PowerEnum.Caloriesperminute.GetHashCode(); break;



				case "Calories per second":
							returnValue = PowerEnum.Caloriespersecond.GetHashCode(); break;


				case "Giga watts":
							returnValue = PowerEnum.Gigawatts.GetHashCode(); break;



				case "Horsepowers (electric)":
							returnValue = PowerEnum.Horsepowerselectric.GetHashCode(); break;



				case "Horsepowers (international)":
							returnValue = PowerEnum.Horsepowersinternational.GetHashCode(); break;



				case "Horsepowers (water)":
							returnValue = PowerEnum.Horsepowerswater.GetHashCode(); break;


				case "Horsepowers (metric)":
							returnValue = PowerEnum.Horsepowersmetric.GetHashCode(); break;


				case "Watts":
							returnValue = PowerEnum.Watts.GetHashCode(); break;



				case "Joules per hour":
							returnValue = PowerEnum.Joulesperhour.GetHashCode(); break;


				case "Joules per minute":
							returnValue = PowerEnum.Joulesperminute.GetHashCode(); break;


				case "Joules per second":
							returnValue = PowerEnum.Joulespersecond.GetHashCode(); break;


				case "Kilocalories per hour":
							returnValue = PowerEnum.Kilocaloriesperhour.GetHashCode(); break;


				case "Kilocalories per minute":
							returnValue = PowerEnum.Kilocaloriesperminute.GetHashCode(); break;


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
						btuperhour = inputValue;
						btuperminute = 0.016667 * inputValue;
						btupersecond = 0.000278 * inputValue;
						caloriesperhour = 252.164426 * inputValue;
						caloriesperminute = 4.20274 * inputValue;
						caloriespersecond = 0.070046 * inputValue;
						gigawatts = 0.0000000003 * inputValue;
						horsepowerselectric = 0.000393 * inputValue;
						horsepowersinternational = 0.000393 * inputValue;
						horsepowerswater = 0.000393 * inputValue;
						horsepowersmetric = 0.000398 * inputValue;
						watts = 0.293071 * inputValue;
						joulesperhour = 1055.05596 * inputValue;
						joulesperminute = 17.584266 * inputValue;
						joulespersecond = 0.293071 * inputValue;
						kilocaloriesperhour = 0.252164 * inputValue;
						kilocaloriesperminute = 0.004203 * inputValue;
						break;
					case 1:
						btuperhour = 60.000003 * inputValue;
						btuperminute = inputValue;
						btupersecond = 0.016667 * inputValue;
						caloriesperhour = 15129.866444 * inputValue;
						caloriesperminute = 252.164441 * inputValue;
						caloriespersecond = 4.202741 * inputValue;
						gigawatts = 0.00000002 * inputValue;
						horsepowerselectric = 0.023571 * inputValue;
						horsepowersinternational = 0.023581 * inputValue;
						horsepowerswater = 0.02357 * inputValue;
						horsepowersmetric = 0.023908 * inputValue;
						watts = 17.584267 * inputValue;
						joulesperhour = 63303.3612 * inputValue;
						joulesperminute = 1055.05602 * inputValue;
						joulespersecond = 17.584267 * inputValue;
						kilocaloriesperhour = 15.129866 * inputValue;
						kilocaloriesperminute = 0.252164 * inputValue;
						break;
					case 2:
						btuperhour = 3600.000136 * inputValue;
						btuperminute = 59.999999 * inputValue;
						btupersecond = inputValue;
						caloriesperhour = 907791.969407 * inputValue;
						caloriesperminute = 15129.866157 * inputValue;
						caloriespersecond = 252.164436 * inputValue;
						gigawatts = 0.000001 * inputValue;
						horsepowerselectric = 1.414284 * inputValue;
						horsepowersinternational = 1.414853 * inputValue;
						horsepowerswater = 1.414203 * inputValue;
						horsepowersmetric = 1.434477 * inputValue;
						watts = 1055.056 * inputValue;
						joulesperhour = 3798201.6 * inputValue;
						joulesperminute = 63303.36 * inputValue;
						joulespersecond = 1055.056 * inputValue;
						kilocaloriesperhour = 907.791969 * inputValue;
						kilocaloriesperminute = 15.129866 * inputValue;
						break;
					case 3:
						btuperhour = 0.003966 * inputValue;
						btuperminute = 0.000066 * inputValue;
						btupersecond = 0.000001 * inputValue;
						caloriesperhour = inputValue;
						caloriesperminute = 0.016667 * inputValue;
						caloriespersecond = 0.000278 * inputValue;
						gigawatts = 0.000000000001 * inputValue;
						horsepowerselectric = 0.000002 * inputValue;
						horsepowersinternational = 0.000002 * inputValue;
						horsepowerswater = 0.000002 * inputValue;
						horsepowersmetric = 0.000002 * inputValue;
						watts = 0.001162 * inputValue;
						joulesperhour = 4.184 * inputValue;
						joulesperminute = 0.069733 * inputValue;
						joulespersecond = 0.001162 * inputValue;
						kilocaloriesperhour = 0.001 * inputValue;
						kilocaloriesperminute = 0.000017 * inputValue;
						break;
					case 4:
						btuperhour = 0.23794 * inputValue;
						btuperminute = 0.003966 * inputValue;
						btupersecond = 0.000066 * inputValue;
						caloriesperhour = 60 * inputValue;
						caloriesperminute = inputValue;
						caloriespersecond = 0.016667 * inputValue;
						gigawatts = 0.0000000001 * inputValue;
						horsepowerselectric = 0.000093 * inputValue;
						horsepowersinternational = 0.000094 * inputValue;
						horsepowerswater = 0.000093 * inputValue;
						horsepowersmetric = 0.000095 * inputValue;
						watts = 0.069733 * inputValue;
						joulesperhour = 251.04 * inputValue;
						joulesperminute = 4.184 * inputValue;
						joulespersecond = 0.069733 * inputValue;
						kilocaloriesperhour = 0.06 * inputValue;
						kilocaloriesperminute = 0.001 * inputValue;
						break;
					case 5:
						btuperhour = 14.276399 * inputValue;
						btuperminute = 0.23794 * inputValue;
						btupersecond = 0.003966 * inputValue;
						caloriesperhour = 3600 * inputValue;
						caloriesperminute = 60 * inputValue;
						caloriespersecond = inputValue;
						gigawatts = 0.000000004 * inputValue;
						horsepowerselectric = 0.005609 * inputValue;
						horsepowersinternational = 0.005611 * inputValue;
						horsepowerswater = 0.005608 * inputValue;
						horsepowersmetric = 0.005689 * inputValue;
						watts = 4.184 * inputValue;
						joulesperhour = 15062.4 * inputValue;
						joulesperminute = 251.04 * inputValue;
						joulespersecond = 4.184 * inputValue;
						kilocaloriesperhour = 3.6 * inputValue;
						kilocaloriesperminute = 0.06 * inputValue;
						break;
					case 6:
						btuperhour = 3412141285.851795 * inputValue;
						btuperminute = 56869018.196778 * inputValue;
						btupersecond = 947816.987913 * inputValue;
						caloriesperhour = 860420650095.6024 * inputValue;
						caloriesperminute = 14340344168.26004 * inputValue;
						caloriespersecond = 239005736.137667 * inputValue;
						gigawatts = inputValue;
						horsepowerselectric = 1340482.573727 * inputValue;
						horsepowersinternational = 1341022.089595 * inputValue;
						horsepowerswater = 1340405.311758 * inputValue;
						horsepowersmetric = 1359621.524875 * inputValue;
						watts = 1000000000 * inputValue;
						joulesperhour = 360000000e+4 * inputValue;
						joulesperminute = 600000000e+2 * inputValue;
						joulespersecond = 1000000000 * inputValue;
						kilocaloriesperhour = 860420650.095602 * inputValue;
						kilocaloriesperminute = 14340344.16826 * inputValue;
						break;
					case 7:
						btuperhour = 2545.457399 * inputValue;
						btuperminute = 42.424288 * inputValue;
						btupersecond = 0.707071 * inputValue;
						caloriesperhour = 641873.804971 * inputValue;
						caloriesperminute = 10697.89675 * inputValue;
						caloriespersecond = 178.298279 * inputValue;
						gigawatts = 0.000001 * inputValue;
						horsepowerselectric = inputValue;
						horsepowersinternational = 1.000402 * inputValue;
						horsepowerswater = 0.999942 * inputValue;
						horsepowersmetric = 1.014278 * inputValue;
						watts = 746 * inputValue;
						joulesperhour = 2685600 * inputValue;
						joulesperminute = 44760 * inputValue;
						joulespersecond = 746 * inputValue;
						kilocaloriesperhour = 641.873805 * inputValue;
						kilocaloriesperminute = 10.697897 * inputValue;
						break;
					case 8:
						btuperhour = 2544.433319 * inputValue;
						btuperminute = 42.40722 * inputValue;
						btupersecond = 0.706787 * inputValue;
						caloriesperhour = 641615.568283 * inputValue;
						caloriesperminute = 10693.592805 * inputValue;
						caloriespersecond = 178.226547 * inputValue;
						gigawatts = 0.000001 * inputValue;
						horsepowerselectric = 0.999598 * inputValue;
						horsepowersinternational = inputValue;
						horsepowerswater = 0.99954 * inputValue;
						horsepowersmetric = 1.01387 * inputValue;
						watts = 745.699872 * inputValue;
						joulesperhour = 2684519.537696 * inputValue;
						joulesperminute = 44741.992295 * inputValue;
						joulespersecond = 745.699872 * inputValue;
						kilocaloriesperhour = 641.615568 * inputValue;
						kilocaloriesperminute = 10.693593 * inputValue;
						break;
					case 9:
						btuperhour = 2545.604121 * inputValue;
						btuperminute = 42.426733 * inputValue;
						btupersecond = 0.707112 * inputValue;
						caloriesperhour = 641910.803059 * inputValue;
						caloriesperminute = 10698.513384 * inputValue;
						caloriespersecond = 178.308556 * inputValue;
						gigawatts = 0.000001 * inputValue;
						horsepowerselectric = 1.000058 * inputValue;
						horsepowersinternational = 1.00046 * inputValue;
						horsepowerswater = inputValue;
						horsepowersmetric = 1.014336 * inputValue;
						watts = 746.043 * inputValue;
						joulesperhour = 2685754.8 * inputValue;
						joulesperminute = 44762.58 * inputValue;
						joulespersecond = 746.043 * inputValue;
						kilocaloriesperhour = 641.910803 * inputValue;
						kilocaloriesperminute = 10.698513 * inputValue;
						break;
					case 10:
						btuperhour = 2545.604121 * inputValue;
						btuperminute = 42.426733 * inputValue;
						btupersecond = 0.707112 * inputValue;
						caloriesperhour = 641910.803059 * inputValue;
						caloriesperminute = 10698.513384 * inputValue;
						caloriespersecond = 178.308556 * inputValue;
						gigawatts = 0.000001 * inputValue;
						horsepowerselectric = 1.000058 * inputValue;
						horsepowersinternational = 1.00046 * inputValue;
						horsepowerswater = inputValue;
						horsepowersmetric = 1.014336 * inputValue;
						watts = 746.043 * inputValue;
						joulesperhour = 2685754.8 * inputValue;
						joulesperminute = 44762.58 * inputValue;
						joulespersecond = 746.043 * inputValue;
						kilocaloriesperhour = 641.910803 * inputValue;
						kilocaloriesperminute = 10.698513 * inputValue;
						break;
					case 11:
						btuperhour = 3.412141 * inputValue;
						btuperminute = 0.056869 * inputValue;
						btupersecond = 0.000948 * inputValue;
						caloriesperhour = 860.42065 * inputValue;
						caloriesperminute = 14.340344 * inputValue;
						caloriespersecond = 0.239006 * inputValue;
						gigawatts = 0.000000001 * inputValue;
						horsepowerselectric = 0.00134 * inputValue;
						horsepowersinternational = 0.001341 * inputValue;
						horsepowerswater = 0.00134 * inputValue;
						horsepowersmetric = 0.00136 * inputValue;
						watts = inputValue;
						joulesperhour = 3600 * inputValue;
						joulesperminute = 60 * inputValue;
						joulespersecond = 1 * inputValue;
						kilocaloriesperhour = 0.860421 * inputValue;
						kilocaloriesperminute = 0.01434 * inputValue;
						break;
					case 12:
						btuperhour = 0.000948 * inputValue;
						btuperminute = 0.000016 * inputValue;
						btupersecond = 0.0000003 * inputValue;
						caloriesperhour = 0.239006 * inputValue;
						caloriesperminute = 0.003983 * inputValue;
						caloriespersecond = 0.000066 * inputValue;
						gigawatts = 0.0000000000003 * inputValue;
						horsepowerselectric = 0.0000004 * inputValue;
						horsepowersinternational = 0.0000004 * inputValue;
						horsepowerswater = 0.0000004 * inputValue;
						horsepowersmetric = 0.0000004 * inputValue;
						watts = 0.000278 * inputValue;
						joulesperhour = inputValue;
						joulesperminute = 0.016667 * inputValue;
						joulespersecond = 0.000278 * inputValue;
						kilocaloriesperhour = 0.000239 * inputValue;
						kilocaloriesperminute = 0.000004 * inputValue;
						break;
					case 13:
						btuperhour = 0.056869 * inputValue;
						btuperminute = 0.000948 * inputValue;
						btupersecond = 0.000016 * inputValue;
						caloriesperhour = 14.340344 * inputValue;
						caloriesperminute = 0.239006 * inputValue;
						caloriespersecond = 0.003983 * inputValue;
						gigawatts = 0.00000000002 * inputValue;
						horsepowerselectric = 0.000022 * inputValue;
						horsepowersinternational = 0.000022 * inputValue;
						horsepowerswater = 0.000022 * inputValue;
						horsepowersmetric = 0.000023 * inputValue;
						watts = 0.016667 * inputValue;
						joulesperhour = 60 * inputValue;
						joulesperminute = inputValue;
						joulespersecond = 0.016667 * inputValue;
						kilocaloriesperhour = 0.01434 * inputValue;
						kilocaloriesperminute = 0.000239 * inputValue;
						break;
					case 14:
						btuperhour = 3.412141 * inputValue;
						btuperminute = 0.056869 * inputValue;
						btupersecond = 0.000948 * inputValue;
						caloriesperhour = 860.42065 * inputValue;
						caloriesperminute = 14.340344 * inputValue;
						caloriespersecond = 0.239006 * inputValue;
						gigawatts = 0.000000001 * inputValue;
						horsepowerselectric = 0.00134 * inputValue;
						horsepowersinternational = 0.001341 * inputValue;
						horsepowerswater = 0.00134 * inputValue;
						horsepowersmetric = 0.00136 * inputValue;
						watts = 1 * inputValue;
						joulesperhour = 3600 * inputValue;
						joulesperminute = 60 * inputValue;
						joulespersecond = inputValue;
						kilocaloriesperhour = 0.860421 * inputValue;
						kilocaloriesperminute = 0.01434 * inputValue;
						break;
					case 15:
						btuperhour = 3.965666 * inputValue;
						btuperminute = 0.066094 * inputValue;
						btupersecond = 0.001102 * inputValue;
						caloriesperhour = 1000 * inputValue;
						caloriesperminute = 16.666667 * inputValue;
						caloriespersecond = 0.277778 * inputValue;
						gigawatts = 0.000000001 * inputValue;
						horsepowerselectric = 0.001558 * inputValue;
						horsepowersinternational = 0.001559 * inputValue;
						horsepowerswater = 0.001558 * inputValue;
						horsepowersmetric = 0.00158 * inputValue;
						watts = 1.162222 * inputValue;
						joulesperhour = 4184 * inputValue;
						joulesperminute = 69.733333 * inputValue;
						joulespersecond = 1.162222 * inputValue;
						kilocaloriesperhour = inputValue;
						kilocaloriesperminute = 0.016667 * inputValue;
						break;
					case 16:
						btuperhour = 237.939986 * inputValue;
						btuperminute = 3.965666 * inputValue;
						btupersecond = 0.066094 * inputValue;
						caloriesperhour = 60000 * inputValue;
						caloriesperminute = 1000 * inputValue;
						caloriespersecond = 16.666667 * inputValue;
						gigawatts = 0.0000001 * inputValue;
						horsepowerselectric = 0.093476 * inputValue;
						horsepowersinternational = 0.093514 * inputValue;
						horsepowerswater = 0.093471 * inputValue;
						horsepowersmetric = 0.094811 * inputValue;
						watts = 69.733333 * inputValue;
						joulesperhour = 251040 * inputValue;
						joulesperminute = 4184 * inputValue;
						joulespersecond = 69.733333 * inputValue;
						kilocaloriesperhour = 60 * inputValue;
						kilocaloriesperminute = inputValue;
						break;
					default: ;
						break;
				}
			}
			resultList.Add(btuperhour);
			resultList.Add(btuperminute);
			resultList.Add(btupersecond);
			resultList.Add(caloriesperhour);
			resultList.Add(caloriesperminute);
			resultList.Add(caloriespersecond);
			resultList.Add(gigawatts);
			resultList.Add(horsepowerselectric);
			resultList.Add(horsepowersinternational);
			resultList.Add(horsepowerswater);
			resultList.Add(horsepowersmetric);
			resultList.Add(watts);
			resultList.Add(joulesperhour);
			resultList.Add(joulesperminute);
			resultList.Add(joulespersecond);
			resultList.Add(kilocaloriesperhour);
			resultList.Add(kilocaloriesperminute);

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



		public enum PowerEnum
		{
			Btuperhour,
			Btuperminute,
			Btupersecond,
			Caloriesperhour,
			Caloriesperminute,
			Caloriespersecond,
			Gigawatts,
			Horsepowerselectric,
			Horsepowersinternational,
			Horsepowerswater,
			Horsepowersmetric,
			Watts,
			Joulesperhour,
			Joulesperminute,
			Joulespersecond,
			Kilocaloriesperhour,
			Kilocaloriesperminute
		};
	}
}
