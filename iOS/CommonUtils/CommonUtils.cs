using System;
namespace ConvertNow.iOS
{
	public struct CommonUtils
	{
		public string displayText(int tagValue)
		{
			string result = "";
			switch (tagValue)
			{
				case 0:
					result = "TEMPERATURE";
					break;
				case 1:
					result = "SPEED";
					break;
				case 2:
					result = "LENGTH";
					break;
				case 3:
					result = "AREA";
					break;
				case 4:
					result = "WEIGHT";
					break;
				case 5:
					result = "VOLUME";
					break;
				case 6:
					result = "PRESSURE";
					break;
				case 7:
					result = "FUEL";
					break;
				case 8:
					result = "ANGLE";
					break;
				case 9:
					result = "BYTES";
					break;
				case 10:
					result = "ELECTRIC CURRENT";
					break;
				case 11:
					result = "ENERGY";
					break;
				case 12:
					result = "FORCE";
					break;
				case 13:
					result = "POWER";
					break;
				case 14:
					result = "TIME";
					break;
				case 15:
					result = "Compass";
					break;
				default:
					break;
			}
			return result;
		}

	}

}
