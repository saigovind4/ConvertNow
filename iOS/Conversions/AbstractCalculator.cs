using UIKit;
using Foundation;
using System;
namespace ConvertNow.iOS
{
	public interface AbstractCalculator
	{
		Units[] performCalculations(Object obj,Units[] unitsList);
	}
}
