using System.Collections.Generic;

namespace ConvertNow.iOS
{
	public class Bytes : AbstractCalculator
	{
		private string inputString = "";
		private double inputValue;
		public List<double> resultList { get; set; }
		public List<Units> finalresultList { get; set; }
		private double bitsResult, bytesResult,kilobitsResult,kilobytesResult,megabitsResult,megabytesResult,gigabitsResult,gigabytesResult,terabitsResult,terabytesResult,petabitsResult,petabytesResult,exabitsResult,exabytesResult;
	
		public Bytes(string name)
		{
			inputString = name;
		}

		private int testMethod(string selectedUnit)
		{
			var returnValue = new int();
			switch (selectedUnit)
			{
				case "Bits":
					returnValue = BytesEnum.Bits.GetHashCode();   break;

				case "Bytes":
							returnValue = BytesEnum.Bytes.GetHashCode();   break;

				case "Kilobits":
							returnValue = BytesEnum.Kilobits.GetHashCode();   break;

				case "Kilobytes":
							returnValue = BytesEnum.Kilobytes.GetHashCode();   break;

				case "Megabits":
							returnValue = BytesEnum.Megabits.GetHashCode();   break;

				case "Megabytes":
							returnValue = BytesEnum.Megabytes.GetHashCode();   break;

				case "Gigabits":
							returnValue = BytesEnum.Gigabits.GetHashCode();   break;

				case "Gigabytes":
							returnValue = BytesEnum.Gigabytes.GetHashCode();   break;

				case "Terabits":
							returnValue = BytesEnum.Terabits.GetHashCode();   break;

				case "Terabytes":
							returnValue = BytesEnum.Terabytes.GetHashCode();   break;

				case "Petabits":
							returnValue = BytesEnum.Petabits.GetHashCode();   break;

				case "Petabytes":
							returnValue = BytesEnum.Petabytes.GetHashCode();   break;

				case "Exabits":
							returnValue = BytesEnum.Exabits.GetHashCode();   break;

				case "Exabytes":
							returnValue = BytesEnum.Exabytes.GetHashCode();   break;
		default: returnValue = -1;
					break;
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
						bitsResult = inputValue;
						bytesResult = 0.125 * inputValue;
						kilobitsResult = 0.000977 * inputValue;
						kilobytesResult = 0.000122 * inputValue;
						megabitsResult = 0.000001 * inputValue;
						megabytesResult = 1.25e-7 * inputValue;
						gigabitsResult = 1.0e-9 * inputValue;
						gigabytesResult = 1.25e-10 * inputValue;
						terabitsResult = 1.0e-12 * inputValue;
						terabytesResult = 1.25e-13 * inputValue;
						petabitsResult = 1.0e-15 * inputValue;
						petabytesResult = 1.25e-16 * inputValue;
						exabitsResult = 1.0e-18 * inputValue;
						exabytesResult = 1.25e-19 * inputValue;
						break;
					case 1:
						bitsResult = 8 * inputValue;
						bytesResult = inputValue;
						kilobitsResult = 0.007813 * inputValue;
						kilobytesResult = 0.000977 * inputValue;
						megabitsResult = 8.0e-6 * inputValue;
						megabytesResult = 1.0e-6 * inputValue;
						gigabitsResult = 8.0e-9 * inputValue;
						gigabytesResult = 1.0e-9 * inputValue;
						terabitsResult = 8.0e-12 * inputValue;
						terabytesResult = 1.0e-12 * inputValue;
						petabitsResult = 8.0e-15 * inputValue;
						petabytesResult = 1.0e-15 * inputValue;
						exabitsResult = 8.0e-18 * inputValue;
						exabytesResult = 1.0e-18 * inputValue;
						break;
					case 2:
						bitsResult = 1024 * inputValue;
						bytesResult = 128 * inputValue;
						kilobitsResult = inputValue;
						kilobytesResult = 0.125 * inputValue;
						megabitsResult = 0.000977 * inputValue;
						megabytesResult = 0.000122 * inputValue;
						gigabitsResult = 1.0e-6 * inputValue;
						gigabytesResult = 1.25e-7 * inputValue;
						terabitsResult = 1.0e-9 * inputValue;
						terabytesResult = 1.25e-10 * inputValue;
						petabitsResult = 1.0e-12 * inputValue;
						petabytesResult = 1.25e-13 * inputValue;
						exabitsResult = 1.0e-15 * inputValue;
						exabytesResult = 1.25e-16 * inputValue;
						break;
					case 3:
						bitsResult = 8192 * inputValue;
						bytesResult = 1024 * inputValue;
						kilobitsResult = 8 * inputValue;
						kilobytesResult = inputValue;
						megabitsResult = 0.007813 * inputValue;
						megabytesResult = 0.000977 * inputValue;
						gigabitsResult = 8.0e-6 * inputValue;
						gigabytesResult = 1.0e-6 * inputValue;
						terabitsResult = 8.0e-9 * inputValue;
						terabytesResult = 1.0e-9 * inputValue;
						petabitsResult = 8.0e-12 * inputValue;
						petabytesResult = 1.0e-12 * inputValue;
						exabitsResult = 8.0e-15 * inputValue;
						exabytesResult = 1.0e-15 * inputValue;
						break;
					case 4:
						bitsResult = 1048576 * inputValue;
						bytesResult = 131072 * inputValue;
						kilobitsResult = 1024 * inputValue;
						kilobytesResult = 128 * inputValue;
						megabitsResult = inputValue;
						megabytesResult = 0.125 * inputValue;
						gigabitsResult = 0.000977 * inputValue;
						gigabytesResult = 0.000122 * inputValue;
						terabitsResult = 0.000001 * inputValue;
						terabytesResult = 1.25e-7 * inputValue;
						petabitsResult = 1.0e-9 * inputValue;
						petabytesResult = 1.25e-10 * inputValue;
						exabitsResult = 1.0e-12 * inputValue;
						exabytesResult = 1.25e-13 * inputValue;
						break;
					case 5:
						bitsResult = 8388608 * inputValue;
						bytesResult = 1048576 * inputValue;
						kilobitsResult = 8192 * inputValue;
						kilobytesResult = 1024 * inputValue;
						megabitsResult = 8 * inputValue;
						megabytesResult = inputValue;
						gigabitsResult = 0.007813 * inputValue;
						gigabytesResult = 0.000977 * inputValue;
						terabitsResult = 8.0e-6 * inputValue;
						terabytesResult = 1.0e-6 * inputValue;
						petabitsResult = 8.0e-9 * inputValue;
						petabytesResult = 1.0e-9 * inputValue;
						exabitsResult = 8.0e-12 * inputValue;
						exabytesResult = 1.0e-12 * inputValue;
						break;
					case 6:
						bitsResult = 1073741824 * inputValue;
						bytesResult = 134217728 * inputValue;
						kilobitsResult = 1048576 * inputValue;
						kilobytesResult = 131072 * inputValue;
						megabitsResult = 1024 * inputValue;
						megabytesResult = 128 * inputValue;
						gigabitsResult = inputValue;
						gigabytesResult = 0.125 * inputValue;
						terabitsResult = 0.000977 * inputValue;
						terabytesResult = 0.000125 * inputValue;
						petabitsResult = 1.0e-6 * inputValue;
						petabytesResult = 1.25e-7 * inputValue;
						exabitsResult = 1.0e-9 * inputValue;
						exabytesResult = 1.25e-10 * inputValue;
						break;
					case 7:
						bitsResult = 858993459e+1 * inputValue;
						bytesResult = 1073741824 * inputValue;
						kilobitsResult = 8388608 * inputValue;
						kilobytesResult = 1048576 * inputValue;
						megabitsResult = 8192 * inputValue;
						megabytesResult = 1024 * inputValue;
						gigabitsResult = 8 * inputValue;
						gigabytesResult = inputValue;
						terabitsResult = 0.007813 * inputValue;
						terabytesResult = 0.000977 * inputValue;
						petabitsResult = 8.0e-6 * inputValue;
						petabytesResult = 1.0e-6 * inputValue;
						exabitsResult = 8.0e-9 * inputValue;
						exabytesResult = 1.0e-9 * inputValue;
						break;
					case 8:
						bitsResult = 1099511627e+3 * inputValue;
						bytesResult = 1374389534e+2 * inputValue;
						kilobitsResult = 1073741824 * inputValue;
						kilobytesResult = 134217728 * inputValue;
						megabitsResult = 1048576 * inputValue;
						megabytesResult = 131072 * inputValue;
						gigabitsResult = 1024 * inputValue;
						gigabytesResult = 128 * inputValue;
						terabitsResult = inputValue;
						terabytesResult = 0.125 * inputValue;
						petabitsResult = 0.000977 * inputValue;
						petabytesResult = 0.000122 * inputValue;
						exabitsResult = 1.0e-6 * inputValue;
						exabytesResult = 1.25e-7 * inputValue;
						break;
					case 9:
						bitsResult = 879609302e+4 * inputValue;
						bytesResult = 1099511627e+3 * inputValue;
						kilobitsResult = 858993459e+1 * inputValue;
						kilobytesResult = 1073741824 * inputValue;
						megabitsResult = 8388608 * inputValue;
						megabytesResult = 1048576 * inputValue;
						gigabitsResult = 8192 * inputValue;
						gigabytesResult = 1024 * inputValue;
						terabitsResult = 8 * inputValue;
						terabytesResult = inputValue;
						petabitsResult = 0.007813 * inputValue;
						petabytesResult = 0.000977 * inputValue;
						exabitsResult = 8.0e-6 * inputValue;
						exabytesResult = 1.0e-6 * inputValue;
						break;
					case 10:
						bitsResult = 1125899906e+6 * inputValue;
						bytesResult = 1407374883e+5 * inputValue;
						kilobitsResult = 1099511627e+3 * inputValue;
						kilobytesResult = 1374389534e+2 * inputValue;
						megabitsResult = 1073741824 * inputValue;
						megabytesResult = 134217728 * inputValue;
						gigabitsResult = 1048576 * inputValue;
						gigabytesResult = 131072 * inputValue;
						terabitsResult = 1024 * inputValue;
						terabytesResult = 128 * inputValue;
						petabitsResult = inputValue;
						petabytesResult = 0.125 * inputValue;
						exabitsResult = 0.000977 * inputValue;
						exabytesResult = 0.000122 * inputValue;
						break;
					case 11:
						bitsResult = 8.0e15 * inputValue;
						bytesResult = 1.0e15 * inputValue;
						kilobitsResult = 8.0e12 * inputValue;
						kilobytesResult = 1000000000e+3 * inputValue;
						megabitsResult = 8000000e+3 * inputValue;
						megabytesResult = 1000000000 * inputValue;
						gigabitsResult = 8000000 * inputValue;
						gigabytesResult = 1000000 * inputValue;
						terabitsResult = 8000 * inputValue;
						terabytesResult = 1000 * inputValue;
						petabitsResult = 8 * inputValue;
						petabytesResult = inputValue;
						exabitsResult = 0.008 * inputValue;
						exabytesResult = 0.001 * inputValue;
						break;
					case 12:
						bitsResult = 1152921504e+9 * inputValue;
						bytesResult = 1441151880e+8 * inputValue;
						kilobitsResult = 1125899906e+6 * inputValue;
						kilobytesResult = 1407374883e+5 * inputValue;
						megabitsResult = 1099511627e+3 * inputValue;
						megabytesResult = 1374389534e+2 * inputValue;
						gigabitsResult = 1073741824 * inputValue;
						gigabytesResult = 134217728 * inputValue;
						terabitsResult = 1048576 * inputValue;
						terabytesResult = 131072 * inputValue;
						petabitsResult = 1024 * inputValue;
						petabytesResult = 128 * inputValue;
						exabitsResult = inputValue;
						exabytesResult = 0.125 * inputValue;
						break;
					case 13:
						bitsResult = 922337203e+10 * inputValue;
						bytesResult = 1152921504e+9 * inputValue;
						kilobitsResult = 900719925e+7 * inputValue;
						kilobytesResult = 1125899906e+6 * inputValue;
						megabitsResult = 879609302e+4 * inputValue;
						megabytesResult = 1099511627e+3 * inputValue;
						gigabitsResult = 858993459e+1 * inputValue;
						gigabytesResult = 1073741824 * inputValue;
						terabitsResult = 8388608 * inputValue;
						terabytesResult = 1048576 * inputValue;
						petabitsResult = 8192 * inputValue;
						petabytesResult = 1024 * inputValue;
						exabitsResult = 8 * inputValue;
						exabytesResult = inputValue;
						break;
					default: ;
						break;
				}
			}
			resultList.Add(bitsResult);
			resultList.Add(bytesResult);
			resultList.Add(kilobitsResult);
			resultList.Add(kilobytesResult);
			resultList.Add(megabitsResult);
			resultList.Add(megabytesResult);
			resultList.Add(gigabitsResult);
			resultList.Add(gigabytesResult);
			resultList.Add(terabitsResult);
			resultList.Add(terabytesResult);
			resultList.Add(petabitsResult);
			resultList.Add(petabytesResult);
			resultList.Add(exabitsResult);
			resultList.Add(exabytesResult);
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

		public enum BytesEnum
		{
			Bits,
			Bytes,
			Kilobits,
			Kilobytes,
			Megabits,
			Megabytes,
			Gigabits,
			Gigabytes,
			Terabits,
			Terabytes,
			Petabits,
			Petabytes,
			Exabits,
			Exabytes
		};

	}
}
