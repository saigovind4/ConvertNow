using System.Collections.Generic;

namespace ConvertNow.iOS
{
	public class Angle : AbstractCalculator
	{
		public List<double> resultList { get; set; }
		public List<Units>  finalresultList { get; set; }

		private string inputString = "";
		private double inputValue;
		internal double Arcminute, Arcsecond, Circle, Degree, Gon, Grad, MilNato, milSovietUnion, milSweden, octant, quadrant, radian, revolution, sextant, sign, turn;

		public Angle(string name)
		{
			inputString = name;
		}

		private int testMethod(string selectedUnit)
		{
			var returnValue = new int();
			switch (selectedUnit)
			{
				case "Arcminute":
					returnValue = AngleEnum.Arcminute.GetHashCode();
					break;

				case "Arcsecond":
					returnValue = AngleEnum.Arcsecond.GetHashCode();
					break;

				case "Circle":
					returnValue = AngleEnum.Circle.GetHashCode();
					break;

				case "Degree":
					returnValue = AngleEnum.Degree.GetHashCode();
					break;

				case "Gon":
					returnValue = AngleEnum.Gon.GetHashCode();
					break;

				case "Grad":
					returnValue = AngleEnum.Grad.GetHashCode();
					break;

				case "Mil (Nato)":
					returnValue = AngleEnum.MilNato.GetHashCode();
					break;

				case "Mil (Soviet Union)":
					returnValue = AngleEnum.MilSovietUnion.GetHashCode();
					break;

				case "Mil (Sweden)":
					returnValue = AngleEnum.MilSweden.GetHashCode();
					break;

				case "Octant":
					returnValue = AngleEnum.Octant.GetHashCode();
					break;

				case "Quadrant":
					returnValue = AngleEnum.Quadrant.GetHashCode();
					break;

				case "Radian":
					returnValue = AngleEnum.Radian.GetHashCode();
					break;

				case "Revolution":
					returnValue = AngleEnum.Revolution.GetHashCode();
					break;

				case "Sextant":
					returnValue = AngleEnum.Sextant.GetHashCode();
					break;

				case "Sign":
					returnValue = AngleEnum.Sign.GetHashCode();
					break;

				case "Turn":
					returnValue = AngleEnum.Turn.GetHashCode();
					break;

				default: ;
					break;
			}
			return returnValue;
		}


		 public List<Units> performCalculations(object obj,List<Units> unitsList)
		{
			var value = (int)obj;
			if (inputString != "")
			{
				inputValue = double.Parse(inputString);
				switch (value)
				{
					case 0:
						Arcminute = inputValue;
						Arcsecond = 60 * inputValue;
						Circle = 0.000046 * inputValue;
						Degree = 0.016667 * inputValue;
						Gon = 0.018519 * inputValue;
						Grad = 0.018519 * inputValue;
						MilNato = 0.296296 * inputValue;
						milSovietUnion = 0.277778 * inputValue;
						milSweden = 0.291667 * inputValue;
						octant = 0.00037 * inputValue;
						quadrant = 0.000185 * inputValue;
						radian = 0.000291 * inputValue;
						revolution = 0.000046 * inputValue;
						sextant = 0.000278 * inputValue;
						sign = 0.000556 * inputValue;
						turn = 0.000046 * inputValue;
						break;

					case 1:
						Arcminute = 0.016667 * inputValue;
						Arcsecond = inputValue;
						Circle = 0.000001 * inputValue;
						Degree = 0.000278 * inputValue;
						Gon = 0.000309 * inputValue;
						Grad = 0.000309 * inputValue;
						MilNato = 0.004938 * inputValue;
						milSovietUnion = 0.00463 * inputValue;
						milSweden = 0.004861 * inputValue;
						octant = 0.000006 * inputValue;
						quadrant = 0.000003 * inputValue;
						radian = 0.000005 * inputValue;
						revolution = 0.000001 * inputValue;
						sextant = 0.000005 * inputValue;
						sign = 0.000009 * inputValue;
						turn = 0.000001 * inputValue;
						break;

					case 2:
						Arcminute = 21600 * inputValue;
						Arcsecond = 1296000 * inputValue;
						Circle = inputValue;
						Degree = 360 * inputValue;
						Gon = 400 * inputValue;
						Grad = 400 * inputValue;
						MilNato = 6400 * inputValue;
						milSovietUnion = 6000 * inputValue;
						milSweden = 6300 * inputValue;
						octant = 8 * inputValue;
						quadrant = 4 * inputValue;
						radian = 6.283185 * inputValue;
						revolution = 1 * inputValue;
						sextant = 6 * inputValue;
						sign = 12 * inputValue;
						turn = 1 * inputValue;
						break;
					case 3:
						Arcminute = 60 * inputValue;
						Arcsecond = 3600 * inputValue;
						Circle = 0.002778 * inputValue;
						Degree = inputValue;
						Gon = 1.111111 * inputValue;
						Grad = 1.111111 * inputValue;
						MilNato = 17.777778 * inputValue;
						milSovietUnion = 16.666667 * inputValue;
						milSweden = 17.5 * inputValue;
						octant = 0.022222 * inputValue;
						quadrant = 0.011111 * inputValue;
						radian = 0.017453 * inputValue;
						revolution = 0.002778 * inputValue;
						sextant = 0.016667 * inputValue;
						sign = 0.033333 * inputValue;
						turn = 0.002778 * inputValue;
						break;

					case 4:
						Arcminute = 54 * inputValue;
						Arcsecond = 3240 * inputValue;
						Circle = 0.0025 * inputValue;
						Degree = 0.9 * inputValue;
						Gon = inputValue;
						Grad = 1 * inputValue;
						MilNato = 16 * inputValue;
						milSovietUnion = 15 * inputValue;
						milSweden = 15.75 * inputValue;
						octant = 0.02 * inputValue;
						quadrant = 0.01 * inputValue;
						radian = 0.015708 * inputValue;
						revolution = 0.0025 * inputValue;
						sextant = 0.015 * inputValue;
						sign = 0.03 * inputValue;
						turn = 0.0025 * inputValue;
						break;
					case 5:

						Arcminute = 54 * inputValue;
						Arcsecond = 3240 * inputValue;
						Circle = 0.0025 * inputValue;
						Degree = 0.9 * inputValue;
						Gon = inputValue;
						Grad = 1 * inputValue;
						MilNato = 16 * inputValue;
						milSovietUnion = 15 * inputValue;
						milSweden = 15.75 * inputValue;
						octant = 0.02 * inputValue;
						quadrant = 0.01 * inputValue;
						radian = 0.015708 * inputValue;
						revolution = 0.0025 * inputValue;
						sextant = 0.015 * inputValue;
						sign = 0.03 * inputValue;
						turn = 0.0025 * inputValue;
						break;
					case 6:
						Arcminute = 3.375 * inputValue;
						Arcsecond = 202.5 * inputValue;
						Circle = 0.000156 * inputValue;
						Degree = 0.05625 * inputValue;
						Gon = 0.0625 * inputValue;
						Grad = 0.0625 * inputValue;
						MilNato = inputValue;
						milSovietUnion = 0.9375 * inputValue;
						milSweden = 0.984375 * inputValue;
						octant = 0.00125 * inputValue;
						quadrant = 0.000625 * inputValue;
						radian = 0.000982 * inputValue;
						revolution = 0.000156 * inputValue;
						sextant = 0.000937 * inputValue;
						sign = 0.001875 * inputValue;
						turn = 0.000156 * inputValue;
						break;
					case 7:
						Arcminute = 3.6 * inputValue;
						Arcsecond = 216 * inputValue;
						Circle = 0.000167 * inputValue;
						Degree = 0.06 * inputValue;
						Gon = 0.066667 * inputValue;
						Grad = 0.066667 * inputValue;
						MilNato = 1.066667 * inputValue;
						milSovietUnion = inputValue;
						milSweden = 1.05 * inputValue;
						octant = 0.001333 * inputValue;
						quadrant = 0.000667 * inputValue;
						radian = 0.001047 * inputValue;
						revolution = 0.000167 * inputValue;
						sextant = 0.001 * inputValue;
						sign = 0.002 * inputValue;
						turn = 0.000167 * inputValue;
						break;
					case 8:
						Arcminute = 3.428571 * inputValue;
						Arcsecond = 205.714286 * inputValue;
						Circle = 0.000159 * inputValue;
						Degree = 0.057143 * inputValue;
						Gon = 0.063492 * inputValue;
						Grad = 0.063492 * inputValue;
						MilNato = 1.015873 * inputValue;
						milSovietUnion = 0.952381 * inputValue;
						milSweden = inputValue;
						octant = 0.00127 * inputValue;
						quadrant = 0.000635 * inputValue;
						radian = 0.000997 * inputValue;
						revolution = 0.000159 * inputValue;
						sextant = 0.000952 * inputValue;
						sign = 0.001905 * inputValue;
						turn = 0.000159 * inputValue;
						break;
					case 9:
						Arcminute = 2700 * inputValue;
						Arcsecond = 162000 * inputValue;
						Circle = 0.125 * inputValue;
						Degree = 45 * inputValue;
						Gon = 50 * inputValue;
						Grad = 50 * inputValue;
						MilNato = 800 * inputValue;
						milSovietUnion = 750 * inputValue;
						milSweden = 787.5 * inputValue;
						octant = inputValue;
						quadrant = 0.5 * inputValue;
						radian = 0.785398 * inputValue;
						revolution = 0.125 * inputValue;
						sextant = 0.75 * inputValue;
						sign = 1.5 * inputValue;
						turn = 0.125 * inputValue;
						break;
					case 10:
						Arcminute = 5400 * inputValue;
						Arcsecond = 324000 * inputValue;
						Circle = 0.25 * inputValue;
						Degree = 90 * inputValue;
						Gon = 100 * inputValue;
						Grad = 100 * inputValue;
						MilNato = 1600 * inputValue;
						milSovietUnion = 1500 * inputValue;
						milSweden = 1575 * inputValue;
						octant = 2 * inputValue;
						quadrant = inputValue;
						radian = 1.570796 * inputValue;
						revolution = 0.25 * inputValue;
						sextant = 1.5 * inputValue;
						sign = 3 * inputValue;
						turn = 0.25 * inputValue;
						break;
					case 11:
						Arcminute = 3437.746771 * inputValue;
						Arcsecond = 206264.80624 * inputValue;
						Circle = 0.159155 * inputValue;
						Degree = 57.29578 * inputValue;
						Gon = 63.661977 * inputValue;
						Grad = 63.661977 * inputValue;
						MilNato = 1018.591636 * inputValue;
						milSovietUnion = 954.929659 * inputValue;
						milSweden = 1002.676141 * inputValue;
						octant = 1.27324 * inputValue;
						quadrant = 0.63662 * inputValue;
						radian = inputValue;
						revolution = 0.159155 * inputValue;
						sextant = 0.95493 * inputValue;
						sign = 1.909859 * inputValue;
						turn = 0.159155 * inputValue;
						break;
					case 12:
						Arcminute = 21600 * inputValue;
						Arcsecond = 1296000 * inputValue;
						Circle = 1 * inputValue;
						Degree = 360 * inputValue;
						Gon = 400 * inputValue;
						Grad = 400 * inputValue;
						MilNato = 6400 * inputValue;
						milSovietUnion = 6000 * inputValue;
						milSweden = 6300 * inputValue;
						octant = 8 * inputValue;
						quadrant = 4 * inputValue;
						radian = 6.283185 * inputValue;
						revolution = inputValue;
						sextant = 6 * inputValue;
						sign = 12 * inputValue;
						turn = 1 * inputValue;
						break;
					case 13:
						Arcminute = 3600 * inputValue;
						Arcsecond = 216000 * inputValue;
						Circle = 0.166667 * inputValue;
						Degree = 60 * inputValue;
						Gon = 66.666667 * inputValue;
						Grad = 66.666667 * inputValue;
						MilNato = 1066.666667 * inputValue;
						milSovietUnion = 1000 * inputValue;
						milSweden = 1050 * inputValue;
						octant = 1.333333 * inputValue;
						quadrant = 0.666667 * inputValue;
						radian = 1.047198 * inputValue;
						revolution = 0.166667 * inputValue;
						sextant = inputValue;
						sign = 2 * inputValue;
						turn = 0.166667 * inputValue;
						break;
					case 14:
						Arcminute = 1800 * inputValue;
						Arcsecond = 108000 * inputValue;
						Circle = 0.083333 * inputValue;
						Degree = 30 * inputValue;
						Gon = 33.333333 * inputValue;
						Grad = 33.333333 * inputValue;
						MilNato = 533.333333 * inputValue;
						milSovietUnion = 500 * inputValue;
						milSweden = 525 * inputValue;
						octant = 0.666667 * inputValue;
						quadrant = 0.333333 * inputValue;
						radian = 0.523599 * inputValue;
						revolution = 0.083333 * inputValue;
						sextant = 0.5 * inputValue;
						sign = inputValue;
						turn = 0.083333 * inputValue;
						break;
					case 15:
						Arcminute = 21600 * inputValue;
						Arcsecond = 1296000 * inputValue;
						Circle = 1 * inputValue;
						Degree = 360 * inputValue;
						Gon = 400 * inputValue;
						Grad = 400 * inputValue;
						MilNato = 6400 * inputValue;
						milSovietUnion = 6000 * inputValue;
						milSweden = 6300 * inputValue;
						octant = 8 * inputValue;
						quadrant = 4 * inputValue;
						radian = 6.283185 * inputValue;
						revolution = 1 * inputValue;
						sextant = 6 * inputValue;
						sign = 12 * inputValue;
						turn = inputValue;
						break;

					default: ; break;
				}
			}
			resultList.Add(Arcminute);
			resultList.Add(Arcsecond);
		    resultList.Add(Circle);
		  	resultList.Add(Degree);
		    resultList.Add(Gon);
		    resultList.Add(Grad);
		    resultList.Add(MilNato);
			resultList.Add(milSovietUnion);
			resultList.Add(milSweden);

			var size = unitsList.Count;
			for (var i = 0; i < size; i++)
			{
				var unitsObj  = new Units();
				if (unitsList[i].unit_status == 1)
				{
					unitsObj.unit_name = unitsList[i].unit_name;
					unitsObj.result = resultList[i];
					finalresultList.Add(unitsObj);
				}
			}

			return finalresultList;
		}

		enum AngleEnum 
		{
			Arcminute,
			Arcsecond,
			Circle,
			Degree,
			Gon,
			Grad,
			MilNato,
			MilSovietUnion,
			MilSweden,
			Octant,
			Quadrant,
			Radian,
			Revolution,
			Sextant,
			Sign,
			Turn
		};

	}
}
