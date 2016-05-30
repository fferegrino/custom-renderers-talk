using System;
using UIKit;
using Foundation;
using CoreGraphics;

namespace PokeDetail.iOS.Controls
{
	public class UIPkmnShape : UIControl
	{
		public UIPkmnShape (NSCoder coder) : base(coder)
		{
			SetDefaultProperties ();
		}

		public UIPkmnShape (CGRect frame) : base(frame)
		{
			SetDefaultProperties ();
		}

		private void SetDefaultProperties()
		{
//			MaxRating = 5;
//			_rating = 0;
//			_displayMode = StarRatingDisplayMode.Full;
//			HalfStarThreshold = EdDefaultHalfstarThreshold;
//			HorizontalMargin = 10;
			BackgroundColor = UIColor.Clear;
		}

		public override void Draw (CGRect rect)
		{
			var bounds = Bounds;

			DrawMultipleBodies (rect);

		}

		const float margin = 10;

		void DrawBodyOnly(CGRect rect)
		{
			var ovalPath = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.10000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.20000f + 0.5f), NMath.Floor(rect.Width * 0.90000f + 0.5f) - NMath.Floor(rect.Width * 0.10000f + 0.5f), NMath.Floor(rect.Height * 0.80000f + 0.5f) - NMath.Floor(rect.Height * 0.20000f + 0.5f)));
			UIColor.Gray.SetFill();
			ovalPath.Fill();

		}



		void DrawBodyAndLegs(CGRect rect)
		{
			//// Oval Drawing
			var ovalPath = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.10000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.11000f + 0.5f), NMath.Floor(rect.Width * 0.90000f + 0.5f) - NMath.Floor(rect.Width * 0.10000f + 0.5f), NMath.Floor(rect.Height * 0.71000f + 0.5f) - NMath.Floor(rect.Height * 0.11000f + 0.5f)));
			UIColor.Gray.SetFill();
			ovalPath.Fill();


			//// Rectangle Drawing
			var rectanglePath = UIBezierPath.FromRect(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.20000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.43000f + 0.5f), NMath.Floor(rect.Width * 0.44000f + 0.5f) - NMath.Floor(rect.Width * 0.20000f + 0.5f), NMath.Floor(rect.Height * 0.88000f + 0.5f) - NMath.Floor(rect.Height * 0.43000f + 0.5f)));
			UIColor.Gray.SetFill();
			rectanglePath.Fill();


			//// Rectangle 2 Drawing
			var rectangle2Path = UIBezierPath.FromRect(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.56000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.43000f + 0.5f), NMath.Floor(rect.Width * 0.80000f + 0.5f) - NMath.Floor(rect.Width * 0.56000f + 0.5f), NMath.Floor(rect.Height * 0.88000f + 0.5f) - NMath.Floor(rect.Height * 0.43000f + 0.5f)));
			UIColor.Gray.SetFill();
			rectangle2Path.Fill();

		}

		void DrawFish(CGRect rect){
			//// Oval Drawing
			var ovalPath = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.07000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.30000f + 0.5f), NMath.Floor(rect.Width * 0.75000f + 0.5f) - NMath.Floor(rect.Width * 0.07000f + 0.5f), NMath.Floor(rect.Height * 0.69000f + 0.5f) - NMath.Floor(rect.Height * 0.30000f + 0.5f)));
			UIColor.Gray.SetFill();
			ovalPath.Fill();


			//// Bezier Drawing
			UIBezierPath bezierPath = new UIBezierPath();
			bezierPath.MoveTo(new CGPoint(rect.GetMinX() + 0.49020f * rect.Width, rect.GetMinY() + 0.50000f * rect.Height));
			bezierPath.AddLineTo(new CGPoint(rect.GetMinX() + 0.88235f * rect.Width, rect.GetMinY() + 0.32000f * rect.Height));
			bezierPath.AddLineTo(new CGPoint(rect.GetMinX() + 0.88235f * rect.Width, rect.GetMinY() + 0.69000f * rect.Height));
			bezierPath.AddLineTo(new CGPoint(rect.GetMinX() + 0.49020f * rect.Width, rect.GetMinY() + 0.50000f * rect.Height));
			UIColor.Gray.SetFill();
			bezierPath.Fill();
		}

		void DrawMultipleBodies(CGRect rect){
			//// Oval Drawing
			var ovalPath = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.26000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.30000f + 0.5f), NMath.Floor(rect.Width * 0.74000f + 0.5f) - NMath.Floor(rect.Width * 0.26000f + 0.5f), NMath.Floor(rect.Height * 0.69000f + 0.5f) - NMath.Floor(rect.Height * 0.30000f + 0.5f)));
			UIColor.Gray.SetFill();
			ovalPath.Fill();


			//// Oval 2 Drawing
			var oval2Path = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.26000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.72000f + 0.5f), NMath.Floor(rect.Width * 0.50000f + 0.5f) - NMath.Floor(rect.Width * 0.26000f + 0.5f), NMath.Floor(rect.Height * 0.85000f + 0.5f) - NMath.Floor(rect.Height * 0.72000f + 0.5f)));
			UIColor.Gray.SetFill();
			oval2Path.Fill();


			//// Oval 3 Drawing
			var oval3Path = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.17000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.57000f + 0.5f), NMath.Floor(rect.Width * 0.26000f + 0.5f) - NMath.Floor(rect.Width * 0.17000f + 0.5f), NMath.Floor(rect.Height * 0.65000f + 0.5f) - NMath.Floor(rect.Height * 0.57000f + 0.5f)));
			UIColor.Gray.SetFill();
			oval3Path.Fill();


			//// Oval 4 Drawing
			var oval4Path = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.50000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.20000f + 0.5f), NMath.Floor(rect.Width * 0.74000f + 0.5f) - NMath.Floor(rect.Width * 0.50000f + 0.5f), NMath.Floor(rect.Height * 0.30000f + 0.5f) - NMath.Floor(rect.Height * 0.20000f + 0.5f)));
			UIColor.Gray.SetFill();
			oval4Path.Fill();


			//// Oval 5 Drawing
			var oval5Path = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.62000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.65000f + 0.5f), NMath.Floor(rect.Width * 0.81000f + 0.5f) - NMath.Floor(rect.Width * 0.62000f + 0.5f), NMath.Floor(rect.Height * 0.77000f + 0.5f) - NMath.Floor(rect.Height * 0.65000f + 0.5f)));
			UIColor.Gray.SetFill();
			oval5Path.Fill();
		}
	}
}

