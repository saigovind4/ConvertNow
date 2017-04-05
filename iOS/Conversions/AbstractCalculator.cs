using System.Collections.Generic;

namespace ConvertNow.iOS
{
	public interface AbstractCalculator
	{
		List<Units> performCalculations(object obj,List<Units> unitsList);
	}
}
