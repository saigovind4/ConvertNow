using System.Collections.Generic;

namespace ConvertNow.iOS
{
	public class Length : AbstractCalculator
	{
		private string inputString = "";
		private double inputValue;
		public List<double> resultList { get; set; }
		public List<Units> finalresultList { get; set; }
		internal double ångströmsResult,astronomicalunitsResult,centimetersResult,chainsResult,decimetersResult,fathomsResult,furlongsResult, inchesResult,kilometersResult,lightyearsResult, metersResult,
		   micrometersResult,millimetersResult,nanometersResult,parsecsResult,yardsResult,milesResult,feetResult;

		public Length(string name)
		{
			inputString = name;
		}

		private int testMethod(string selectedUnit)
		{
			var returnValue = new int();
			switch (selectedUnit)
			{
				case "Angströms":
					returnValue = LengthEnum.Angströms.GetHashCode(); break;

				case "Astronomical units":
							returnValue = LengthEnum.Astronomicalunits.GetHashCode(); break;

				case "Centimeters":
							returnValue = LengthEnum.Centimeters.GetHashCode(); break;

				case "Chains (surveyors)":
							returnValue = LengthEnum.Chainssurveyors.GetHashCode(); break;

				case "Decimeters":
							returnValue = LengthEnum.Decimeters.GetHashCode(); break;

				case "Fathoms":
							returnValue = LengthEnum.Fathoms.GetHashCode(); break;

				case "Furlongs":
							returnValue = LengthEnum.Furlongs.GetHashCode(); break;

				case "Inches ":
							returnValue = LengthEnum.Inches.GetHashCode(); break;

				case "Kilometers":
							returnValue = LengthEnum.Kilometers.GetHashCode(); break;

				case "Light years":
							returnValue = LengthEnum.Lightyears.GetHashCode(); break;

				case "Meters":
							returnValue = LengthEnum.Meters.GetHashCode(); break;

				case "Millimeters ":
							returnValue = LengthEnum.Millimeters.GetHashCode(); break;

				case "Micrometers":
							returnValue = LengthEnum.Micrometers.GetHashCode(); break;

				case "Nanometers ":
							returnValue = LengthEnum.Nanometers.GetHashCode(); break;

				case "Parsecs":
							returnValue = LengthEnum.Parsecs.GetHashCode(); break;

				case "Yards":
							returnValue = LengthEnum.Yards.GetHashCode(); break;

				case "Miles":
							returnValue = LengthEnum.Miles.GetHashCode(); break;

				case "Feet":
							returnValue = LengthEnum.Feet.GetHashCode(); break;

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
						ångströmsResult = inputValue;
						astronomicalunitsResult = inputValue * 6.684587122671E-22;
						centimetersResult = inputValue * 1E-8;
						chainsResult = 4.970969537899E-12 * inputValue;
						decimetersResult = 1E-9 * inputValue;
						fathomsResult = 5.468066491689E-11 * inputValue;
						furlongsResult = 4.970969537899E-13 * inputValue;
						inchesResult = 3.937007874016E-9 * inputValue;
						kilometersResult = 1E-13 * inputValue;
						lightyearsResult = 1.057000834025E-26 * inputValue;
						metersResult = 1E-10 * inputValue;
						micrometersResult = 0.0001 * inputValue;
						millimetersResult = 1E-7 * inputValue;
						nanometersResult = 0.1 * inputValue;
						parsecsResult = 3.240779289639E-27 * inputValue;
						yardsResult = 1.093613298338E-10 * inputValue;
						milesResult = 6.213712E-14 * inputValue;
						feetResult = 3.28084E-10 * inputValue;
						break;
					case 1:
						ångströmsResult = inputValue * 1.49597870691E+21;
						astronomicalunitsResult = inputValue;
						centimetersResult = inputValue * 1495978706E+4;
						chainsResult = 7436464581.395 * inputValue;
						decimetersResult = 1495978706E+3 * inputValue;
						fathomsResult = 81801110395.34 * inputValue;
						furlongsResult = 743646458.1395 * inputValue;
						inchesResult = 588967994E+4 * inputValue;
						kilometersResult = 149597870.691 * inputValue;
						lightyearsResult = 0.00001581250740887 * inputValue;
						metersResult = 1495978706E+2 * inputValue;
						micrometersResult = 1495978706E+8 * inputValue;
						millimetersResult = 1495978706E+5 * inputValue;
						nanometersResult = 1495978706E+11 * inputValue;
						parsecsResult = 0.000004848136811095 * inputValue;
						yardsResult = 163602220790.7 * inputValue;
						milesResult = 92956229.370476 * inputValue;
						feetResult = 490808891076.116 * inputValue;
						break;
					case 2:
						ångströmsResult = 100000000 * inputValue;
						astronomicalunitsResult = 6.684587122671E-14 * inputValue;
						centimetersResult = inputValue;
						chainsResult = 0.0004970969537899 * inputValue;
						decimetersResult = 0.1 * inputValue;
						fathomsResult = 0.005468066491689 * inputValue;
						furlongsResult = 0.00004970969537899 * inputValue;
						inchesResult = 0.3937007874016 * inputValue;
						kilometersResult = 0.00001 * inputValue;
						lightyearsResult = 1.057000834025E-18 * inputValue;
						metersResult = 0.01 * inputValue;
						millimetersResult = 10 * inputValue;
						micrometersResult = 10000 * inputValue;
						nanometersResult = 10000000 * inputValue;
						parsecsResult = 3.240779289639E-19 * inputValue;
						yardsResult = 0.01093613298338 * inputValue;
						milesResult = 0.0125 * inputValue;
						feetResult = 66.000132 * inputValue;

						break;
					case 3:
						ångströmsResult = 2011680000E+2 * inputValue;
						astronomicalunitsResult = 1.344725022293E-10 * inputValue;
						centimetersResult = 2011.68 * inputValue;
						chainsResult = inputValue;
						decimetersResult = 201.168 * inputValue;
						fathomsResult = 11 * inputValue;
						furlongsResult = 0.1 * inputValue;
						inchesResult = 792 * inputValue;
						kilometersResult = 0.0201168 * inputValue;
						lightyearsResult = 2.126347437791E-15 * inputValue;
						metersResult = 20.1168 * inputValue;
						millimetersResult = 20116.8 * inputValue;
						micrometersResult = 20116800 * inputValue;
						nanometersResult = 201168E+5 * inputValue;
						parsecsResult = 6.519410881382E-16 * inputValue;
						yardsResult = 22 * inputValue;
						milesResult = 0.0125 * inputValue;
						feetResult = 66.000132 * inputValue;
						break;
					case 4:
						ångströmsResult = 1000000000 * inputValue;
						astronomicalunitsResult = 6.684587122671E-13 * inputValue;
						centimetersResult = 10 * inputValue;
						chainsResult = 0.004970969537899 * inputValue;
						decimetersResult = inputValue;
						fathomsResult = 0.05468066491689 * inputValue;
						furlongsResult = 0.0004970969537899 * inputValue;
						inchesResult = 3.937007874016 * inputValue;
						kilometersResult = 0.0001 * inputValue;
						lightyearsResult = 1.057000834025E-17 * inputValue;
						metersResult = 0.1 * inputValue;
						millimetersResult = 100 * inputValue;
						micrometersResult = 100000 * inputValue;
						nanometersResult = 100000000 * inputValue;
						parsecsResult = 3.240779289639E-18 * inputValue;
						yardsResult = 0.1093613298338 * inputValue;
						milesResult = 0.000062 * inputValue;
						feetResult = 0.328084 * inputValue;
						break;
					case 5:
						ångströmsResult = 18288000E+3 * inputValue;
						astronomicalunitsResult = 1.222477292994E-11 * inputValue;
						centimetersResult = 182.88 * inputValue;
						chainsResult = 0.09090909090909 * inputValue;
						decimetersResult = 18.288 * inputValue;
						fathomsResult = inputValue;
						furlongsResult = 0.009090909090909 * inputValue;
						inchesResult = 72 * inputValue;
						kilometersResult = 0.0018288 * inputValue;
						lightyearsResult = 1.933043125264E-16 * inputValue;
						metersResult = 1.8288 * inputValue;
						millimetersResult = 1828.8 * inputValue;
						micrometersResult = 1828800 * inputValue;
						nanometersResult = 1828800000 * inputValue;
						parsecsResult = 5.926737164892E-17 * inputValue;
						yardsResult = 2 * inputValue;
						milesResult = 0.001136 * inputValue;
						feetResult = 6 * inputValue;

						break;
					case 6:
						ångströmsResult = 2011680000E+3 * inputValue;
						astronomicalunitsResult = 1.344725022293E-9 * inputValue;
						centimetersResult = 20116.8 * inputValue;
						chainsResult = 10 * inputValue;
						decimetersResult = 2011.68 * inputValue;
						fathomsResult = 110 * inputValue;
						furlongsResult = inputValue;
						inchesResult = 7920 * inputValue;
						kilometersResult = 0.201168 * inputValue;
						lightyearsResult = 2.126347437791E-14 * inputValue;
						metersResult = 201.168 * inputValue;
						millimetersResult = 201168 * inputValue;
						micrometersResult = 201168000 * inputValue;
						nanometersResult = 201168000E+3 * inputValue;
						parsecsResult = 6.519410881382E-15 * inputValue;
						yardsResult = 220 * inputValue;
						milesResult = 0.125 * inputValue;
						feetResult = 660 * inputValue;

						break;
					case 7:
						ångströmsResult = 254000000 * inputValue;
						astronomicalunitsResult = 1.697885129158E-13 * inputValue;
						centimetersResult = 2.54 * inputValue;
						chainsResult = 0.001262626262626 * inputValue;
						decimetersResult = 0.254 * inputValue;
						fathomsResult = 0.01388888888889 * inputValue;
						furlongsResult = 0.0001262626262626 * inputValue;
						inchesResult = inputValue;
						kilometersResult = 0.0000254 * inputValue;
						lightyearsResult = 2.684782118423E-18 * inputValue;
						metersResult = 0.0254 * inputValue;
						millimetersResult = 25.4 * inputValue;
						micrometersResult = 25400 * inputValue;
						nanometersResult = 25400000 * inputValue;
						parsecsResult = 8.231579395684E-19 * inputValue;
						yardsResult = 0.02777777777778 * inputValue;
						milesResult = 0.000016 * inputValue;
						feetResult = 0.083333 * inputValue;

						break;
					case 8:
						ångströmsResult = 1000000000E+4 * inputValue;
						astronomicalunitsResult = 6.684587122671E-9 * inputValue;
						centimetersResult = 100000 * inputValue;
						chainsResult = 49.70969537899 * inputValue;
						decimetersResult = 10000 * inputValue;
						fathomsResult = 546.8066491688 * inputValue;
						furlongsResult = 4.970969537899 * inputValue;
						inchesResult = 39370.07874016 * inputValue;
						kilometersResult = inputValue;
						lightyearsResult = 1.057000834025E-13 * inputValue;
						metersResult = 1000 * inputValue;
						millimetersResult = 1000000 * inputValue;
						micrometersResult = 1000000000 * inputValue;
						nanometersResult = 10000000E+5 * inputValue;
						parsecsResult = 3.240779289639E-14 * inputValue;
						yardsResult = 1093.613298338 * inputValue;
						milesResult = 0.621371 * inputValue;
						feetResult = 3280.839895 * inputValue;
						break;
					case 9:
						ångströmsResult = 9.460730472581E+25 * inputValue;
						astronomicalunitsResult = 63241.07708807 * inputValue;
						centimetersResult = 946073047E+9 * inputValue;
						chainsResult = 470290029E+6 * inputValue;
						decimetersResult = 946073047E+8 * inputValue;
						fathomsResult = 517319032E+7 * inputValue;
						furlongsResult = 470290029E+5 * inputValue;
						inchesResult = 372469703E+9 * inputValue;
						kilometersResult = 946073047E+4 * inputValue;
						lightyearsResult = inputValue;
						metersResult = 946073047E+7 * inputValue;
						millimetersResult = 946073047E+10 * inputValue;
						micrometersResult = 9.460730472581E+21 * inputValue;
						nanometersResult = 9.460730472581E+24 * inputValue;
						parsecsResult = 0.306601393804 * inputValue;
						yardsResult = 1034638065E+7 * inputValue;
						break;
					case 10:
						ångströmsResult = 10000000E+3 * inputValue;
						astronomicalunitsResult = 6.684587122671E-12 * inputValue;
						centimetersResult = 100 * inputValue;
						chainsResult = 0.04970969537899 * inputValue;
						decimetersResult = 10 * inputValue;
						fathomsResult = 0.5468066491689 * inputValue;
						furlongsResult = 0.004970969537899 * inputValue;
						inchesResult = 39.37007874016 * inputValue;
						kilometersResult = 0.001 * inputValue;
						lightyearsResult = 1.057000834025E-16 * inputValue;
						metersResult = inputValue;
						millimetersResult = 1000 * inputValue;
						micrometersResult = 1000000 * inputValue;
						nanometersResult = 1000000000 * inputValue;
						parsecsResult = 3.240779289639E-17 * inputValue;
						yardsResult = 1.093613298338 * inputValue;
						milesResult = 5878499814210.01 * inputValue;
						feetResult = 31038479019028900 * inputValue;
						break;
					case 11:
						ångströmsResult = 10000000 * inputValue;
						astronomicalunitsResult = 6.684587122671E-15 * inputValue;
						centimetersResult = 0.1 * inputValue;
						chainsResult = 0.00004970969537899 * inputValue;
						decimetersResult = 0.01 * inputValue;
						fathomsResult = 0.0005468066491689 * inputValue;
						furlongsResult = 0.000004970969537899 * inputValue;
						inchesResult = 0.03937007874016 * inputValue;
						kilometersResult = 0.000001 * inputValue;
						lightyearsResult = 1.057000834025E-19 * inputValue;
						metersResult = 0.001 * inputValue;
						millimetersResult = inputValue;
						micrometersResult = 1000 * inputValue;
						nanometersResult = 1000000 * inputValue;
						parsecsResult = 3.240779289639E-20 * inputValue;
						yardsResult = 0.001093613298338 * inputValue;
						milesResult = 0.006214E-4 * inputValue;
						feetResult = 0.003281 * inputValue;


						break;
					case 12:
						ångströmsResult = 10000 * inputValue;
						astronomicalunitsResult = 6.684587122671E-18 * inputValue;
						centimetersResult = 0.0001 * inputValue;
						chainsResult = 4.970969537899E-8 * inputValue;
						decimetersResult = 0.00001 * inputValue;
						fathomsResult = 5.468066491689E-7 * inputValue;
						furlongsResult = 4.970969537899E-9 * inputValue;
						inchesResult = 0.00003937007874016 * inputValue;
						kilometersResult = 1E-9 * inputValue;
						lightyearsResult = 1.057000834025E-22 * inputValue;
						metersResult = 0.000001 * inputValue;
						millimetersResult = 0.001 * inputValue;
						micrometersResult = inputValue;
						nanometersResult = 1000 * inputValue;
						parsecsResult = 3.240779289639E-23 * inputValue;
						yardsResult = 0.000001093613298338 * inputValue;
						milesResult = 0.006214E-7 * inputValue;
						feetResult = 0.000328E-2 * inputValue;
						break;
					case 13:
						ångströmsResult = 10 * inputValue;
						astronomicalunitsResult = 6.684587122671E-21 * inputValue;
						centimetersResult = 1E-7 * inputValue;
						chainsResult = 4.970969537899E-11 * inputValue;
						decimetersResult = 1E-8 * inputValue;
						fathomsResult = 5.468066491689E-10 * inputValue;
						furlongsResult = 5.468066491689E-10 * inputValue;
						inchesResult = 3.937007874016E-8 * inputValue;
						kilometersResult = 1E-12 * inputValue;
						lightyearsResult = 1.057000834025E-25 * inputValue;
						metersResult = 1E-9 * inputValue;
						millimetersResult = 0.000001 * inputValue;
						micrometersResult = 0.001 * inputValue;
						nanometersResult = inputValue;
						parsecsResult = 3.240779289639E-26 * inputValue;
						yardsResult = 1.093613298338E-9 * inputValue;
						milesResult = 0.006214E-10 * inputValue;
						feetResult = 0.003281E-6 * inputValue;
						break;
					case 14:
						ångströmsResult = 3.085677581306E+26 * inputValue;
						astronomicalunitsResult = 206264.8062471 * inputValue;
						centimetersResult = 308567758E+10 * inputValue;
						chainsResult = 1533880926E+6 * inputValue;
						decimetersResult = 308567758E+9 * inputValue;
						fathomsResult = 1687269018E+7 * inputValue;
						furlongsResult = 1533880926E+5 * inputValue;
						inchesResult = 1214833693E+9 * inputValue;
						kilometersResult = 308567758E+5 * inputValue;
						lightyearsResult = 3.261563776971 * inputValue;
						metersResult = 308567758E+8 * inputValue;
						millimetersResult = 308567758E+11 * inputValue;
						micrometersResult = 3.085677581306E+22 * inputValue;
						nanometersResult = 3.085677581306E+25 * inputValue;
						parsecsResult = inputValue;
						yardsResult = 337453803E+8 * inputValue;
						milesResult = 19173511691720 * inputValue;
						feetResult = 1012361417E+8 * inputValue;
						break;
					case 15:
						ångströmsResult = 91440E+5 * inputValue;
						astronomicalunitsResult = 0.061124E-10 * inputValue;
						centimetersResult = 91.44 * inputValue;
						chainsResult = 0.045454 * inputValue;
						decimetersResult = 9.144 * inputValue;
						fathomsResult = 0.5 * inputValue;
						furlongsResult = 0.004545 * inputValue;
						inchesResult = 36 * inputValue;
						kilometersResult = 0.000914 * inputValue;
						lightyearsResult = 0.966542E-16 * inputValue;
						metersResult = 308567758E+8 * inputValue;
						millimetersResult = 0.9144 * inputValue;
						micrometersResult = 914400 * inputValue;
						nanometersResult = 914400000 * inputValue;
						parsecsResult = 0.296337E-16 * inputValue;
						yardsResult = inputValue;
						milesResult = 0.000568 * inputValue;
						feetResult = 3 * inputValue;
						break;

					case 16:
						ångströmsResult = 1609344E+7 * inputValue;
						astronomicalunitsResult = 0.010758E-6 * inputValue;
						centimetersResult = 160934.4 * inputValue;
						chainsResult = 79.99984 * inputValue;
						decimetersResult = 16093.44 * inputValue;
						fathomsResult = 880 * inputValue;
						furlongsResult = 8 * inputValue;
						inchesResult = 63360 * inputValue;
						kilometersResult = 1.609344 * inputValue;
						lightyearsResult = 0.017011E-11 * inputValue;
						metersResult = 1609.344 * inputValue;
						millimetersResult = 1609344 * inputValue;
						micrometersResult = 1609344000 * inputValue;
						nanometersResult = 1609344E+6 * inputValue;
						parsecsResult = 0.005216E-11 * inputValue;
						yardsResult = 1760 * inputValue;
						milesResult = inputValue;
						feetResult = 5280 * inputValue;
						break;

					case 17:
						ångströmsResult = 3048000000 * inputValue;
						astronomicalunitsResult = 0.002037E-9 * inputValue;
						centimetersResult = 30.48 * inputValue;
						chainsResult = 0.015151 * inputValue;
						decimetersResult = 3.048 * inputValue;
						fathomsResult = 0.166667 * inputValue;
						furlongsResult = 0.001515 * inputValue;
						inchesResult = 12 * inputValue;
						kilometersResult = 0.000305 * inputValue;
						lightyearsResult = 0.032218E-15 * inputValue;
						metersResult = 0.3048 * inputValue;
						millimetersResult = 304.8 * inputValue;
						micrometersResult = 304800 * inputValue;
						nanometersResult = 304800000 * inputValue;
						parsecsResult = 0.098779E-16 * inputValue;
						yardsResult = 0.333333 * inputValue;
						milesResult = 0.000189 * inputValue;
						feetResult = inputValue;
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

		public enum LengthEnum
		{
			Angströms,
			Astronomicalunits,
			Centimeters,
			Chainssurveyors,
			Decimeters,
			Fathoms,
			Furlongs,
			Inches,
			Kilometers,
			Lightyears,
			Meters,
			Millimeters,
			Micrometers,
			Nanometers,
			Parsecs,
			Yards,
			Miles,
			Feet
		};
	}
}
