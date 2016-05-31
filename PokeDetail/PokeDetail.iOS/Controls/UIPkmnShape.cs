using System;
using UIKit;
using Foundation;
using CoreGraphics;

namespace PokeDetail.iOS.Controls
{

    public enum PokemonShape
    {
        Ball,
        Squiggle,
        Fish, 
        Arms,
        Blob,
        Upright,
        Legs,
        Quadruped,
        Wings,
        Tentacles,
        Heads,
        Humanoid,
        BugWings,
        Armor
    }

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

        private PokemonShape _shape;
        public PokemonShape Shape
        {
            get { return _shape; }
            set { _shape = value; SetNeedsDisplay(); }
        }

		public override void Draw (CGRect rect)
        {
            if (_shape == PokemonShape.Ball)
                DrawBodyOnly(rect);
            else if (_shape == PokemonShape.Fish)
                DrawFish(rect);
            else if (_shape == PokemonShape.Quadruped)
                DrawQuadruped(rect);
            else if (_shape == PokemonShape.Squiggle)
                DrawSerpentine(rect);
            else if (_shape == PokemonShape.Legs)
                DrawBodyAndLegs(rect);
            else if (_shape == PokemonShape.Heads)
                DrawMultipleBodies(rect);
            else if (_shape == PokemonShape.Tentacles)
                DrawTenctacle(rect);
            else if (_shape == PokemonShape.Armor)
                DrawInsectoid(rect);
            else if (_shape == PokemonShape.BugWings)
                DrawFourWinged(rect);
            else
                DrawNotImplemented(rect);

		}

		void DrawBodyOnly(CGRect rect)
		{
			var ovalPath = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.10000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.20000f + 0.5f), NMath.Floor(rect.Width * 0.90000f + 0.5f) - NMath.Floor(rect.Width * 0.10000f + 0.5f), NMath.Floor(rect.Height * 0.80000f + 0.5f) - NMath.Floor(rect.Height * 0.20000f + 0.5f)));
			UIColor.Gray.SetFill();
			ovalPath.Fill();
		}

		void DrawBodyAndLegs(CGRect rect)
		{
			// Oval Drawing
			var ovalPath = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.10000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.11000f + 0.5f), NMath.Floor(rect.Width * 0.90000f + 0.5f) - NMath.Floor(rect.Width * 0.10000f + 0.5f), NMath.Floor(rect.Height * 0.71000f + 0.5f) - NMath.Floor(rect.Height * 0.11000f + 0.5f)));
			UIColor.Gray.SetFill();
			ovalPath.Fill();

			// Rectangle Drawing
			var rectanglePath = UIBezierPath.FromRect(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.20000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.43000f + 0.5f), NMath.Floor(rect.Width * 0.44000f + 0.5f) - NMath.Floor(rect.Width * 0.20000f + 0.5f), NMath.Floor(rect.Height * 0.88000f + 0.5f) - NMath.Floor(rect.Height * 0.43000f + 0.5f)));
			UIColor.Gray.SetFill();
			rectanglePath.Fill();

			// Rectangle 2 Drawing
			var rectangle2Path = UIBezierPath.FromRect(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.56000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.43000f + 0.5f), NMath.Floor(rect.Width * 0.80000f + 0.5f) - NMath.Floor(rect.Width * 0.56000f + 0.5f), NMath.Floor(rect.Height * 0.88000f + 0.5f) - NMath.Floor(rect.Height * 0.43000f + 0.5f)));
			UIColor.Gray.SetFill();
			rectangle2Path.Fill();
		}

		void DrawFish(CGRect rect){
			// Oval Drawing
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

        //// PaintCode Trial Version
        //// www.paintcodeapp.com

        private void DrawSerpentine(CGRect rect)
        {
            //// Bezier Drawing
            UIBezierPath bezierPath = new UIBezierPath();
            bezierPath.MoveTo(new CGPoint(rect.GetMinX() + 0.30500f * rect.Width, rect.GetMinY() + 0.43500f * rect.Height));
            bezierPath.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.17500f * rect.Width, rect.GetMinY() + 0.40500f * rect.Height), new CGPoint(rect.GetMinX() + 0.30500f * rect.Width, rect.GetMinY() + 0.43500f * rect.Height), new CGPoint(rect.GetMinX() + 0.26500f * rect.Width, rect.GetMinY() + 0.43500f * rect.Height));
            bezierPath.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.13500f * rect.Width, rect.GetMinY() + 0.22500f * rect.Height), new CGPoint(rect.GetMinX() + 0.08500f * rect.Width, rect.GetMinY() + 0.37500f * rect.Height), new CGPoint(rect.GetMinX() + 0.09500f * rect.Width, rect.GetMinY() + 0.26500f * rect.Height));
            bezierPath.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.41500f * rect.Width, rect.GetMinY() + 0.18500f * rect.Height), new CGPoint(rect.GetMinX() + 0.17500f * rect.Width, rect.GetMinY() + 0.18500f * rect.Height), new CGPoint(rect.GetMinX() + 0.35500f * rect.Width, rect.GetMinY() + 0.14500f * rect.Height));
            bezierPath.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.55500f * rect.Width, rect.GetMinY() + 0.40500f * rect.Height), new CGPoint(rect.GetMinX() + 0.47500f * rect.Width, rect.GetMinY() + 0.22500f * rect.Height), new CGPoint(rect.GetMinX() + 0.58500f * rect.Width, rect.GetMinY() + 0.24500f * rect.Height));
            bezierPath.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.71500f * rect.Width, rect.GetMinY() + 0.62500f * rect.Height), new CGPoint(rect.GetMinX() + 0.52500f * rect.Width, rect.GetMinY() + 0.56500f * rect.Height), new CGPoint(rect.GetMinX() + 0.63500f * rect.Width, rect.GetMinY() + 0.70500f * rect.Height));
            bezierPath.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.89500f * rect.Width, rect.GetMinY() + 0.62500f * rect.Height), new CGPoint(rect.GetMinX() + 0.79500f * rect.Width, rect.GetMinY() + 0.54500f * rect.Height), new CGPoint(rect.GetMinX() + 0.92500f * rect.Width, rect.GetMinY() + 0.54500f * rect.Height));
            bezierPath.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.51500f * rect.Width, rect.GetMinY() + 0.81500f * rect.Height), new CGPoint(rect.GetMinX() + 0.86500f * rect.Width, rect.GetMinY() + 0.70500f * rect.Height), new CGPoint(rect.GetMinX() + 0.70500f * rect.Width, rect.GetMinY() + 0.90500f * rect.Height));
            bezierPath.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.30500f * rect.Width, rect.GetMinY() + 0.56500f * rect.Height), new CGPoint(rect.GetMinX() + 0.32500f * rect.Width, rect.GetMinY() + 0.72500f * rect.Height), new CGPoint(rect.GetMinX() + 0.30500f * rect.Width, rect.GetMinY() + 0.69500f * rect.Height));
            bezierPath.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.30500f * rect.Width, rect.GetMinY() + 0.43500f * rect.Height), new CGPoint(rect.GetMinX() + 0.30500f * rect.Width, rect.GetMinY() + 0.43500f * rect.Height), new CGPoint(rect.GetMinX() + 0.30500f * rect.Width, rect.GetMinY() + 0.43500f * rect.Height));
            bezierPath.ClosePath();
            UIColor.Gray.SetFill();
            bezierPath.Fill();
        }

        private void DrawInsectoid(CGRect rect)
        {
            //// Bezier Drawing
            UIBezierPath bezierPath = new UIBezierPath();
            bezierPath.MoveTo(new CGPoint(rect.GetMinX() + 0.15500f * rect.Width, rect.GetMinY() + 0.47746f * rect.Height));
            bezierPath.AddLineTo(new CGPoint(rect.GetMinX() + 0.19384f * rect.Width, rect.GetMinY() + 0.54225f * rect.Height));
            bezierPath.AddLineTo(new CGPoint(rect.GetMinX() + 0.84116f * rect.Width, rect.GetMinY() + 0.62000f * rect.Height));
            bezierPath.AddLineTo(new CGPoint(rect.GetMinX() + 0.88000f * rect.Width, rect.GetMinY() + 0.54225f * rect.Height));
            bezierPath.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.54339f * rect.Width, rect.GetMinY() + 0.29605f * rect.Height), new CGPoint(rect.GetMinX() + 0.88000f * rect.Width, rect.GetMinY() + 0.54225f * rect.Height), new CGPoint(rect.GetMinX() + 0.77643f * rect.Width, rect.GetMinY() + 0.33492f * rect.Height));
            bezierPath.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.15500f * rect.Width, rect.GetMinY() + 0.47746f * rect.Height), new CGPoint(rect.GetMinX() + 0.31036f * rect.Width, rect.GetMinY() + 0.25718f * rect.Height), new CGPoint(rect.GetMinX() + 0.15500f * rect.Width, rect.GetMinY() + 0.47746f * rect.Height));
            bezierPath.ClosePath();
            UIColor.Gray.SetFill();
            bezierPath.Fill();


            //// Oval Drawing
            var ovalPath = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.13000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.32000f + 0.5f), NMath.Floor(rect.Width * 0.36000f + 0.5f) - NMath.Floor(rect.Width * 0.13000f + 0.5f), NMath.Floor(rect.Height * 0.56000f + 0.5f) - NMath.Floor(rect.Height * 0.32000f + 0.5f)));
            UIColor.Gray.SetFill();
            ovalPath.Fill();


            //// Bezier 2 Drawing
            UIBezierPath bezier2Path = new UIBezierPath();
            bezier2Path.MoveTo(new CGPoint(rect.GetMinX() + 0.66000f * rect.Width, rect.GetMinY() + 0.53000f * rect.Height));
            bezier2Path.AddLineTo(new CGPoint(rect.GetMinX() + 0.77000f * rect.Width, rect.GetMinY() + 0.53000f * rect.Height));
            bezier2Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.73000f * rect.Width, rect.GetMinY() + 0.71000f * rect.Height), new CGPoint(rect.GetMinX() + 0.77000f * rect.Width, rect.GetMinY() + 0.53000f * rect.Height), new CGPoint(rect.GetMinX() + 0.83000f * rect.Width, rect.GetMinY() + 0.71000f * rect.Height));
            bezier2Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.66000f * rect.Width, rect.GetMinY() + 0.53000f * rect.Height), new CGPoint(rect.GetMinX() + 0.71500f * rect.Width, rect.GetMinY() + 0.60000f * rect.Height), new CGPoint(rect.GetMinX() + 0.66000f * rect.Width, rect.GetMinY() + 0.53000f * rect.Height));
            bezier2Path.ClosePath();
            UIColor.Gray.SetFill();
            bezier2Path.Fill();


            //// Bezier 3 Drawing
            UIBezierPath bezier3Path = new UIBezierPath();
            bezier3Path.MoveTo(new CGPoint(rect.GetMinX() + 0.54338f * rect.Width, rect.GetMinY() + 0.48500f * rect.Height));
            bezier3Path.AddLineTo(new CGPoint(rect.GetMinX() + 0.66500f * rect.Width, rect.GetMinY() + 0.52500f * rect.Height));
            bezier3Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.54338f * rect.Width, rect.GetMinY() + 0.70500f * rect.Height), new CGPoint(rect.GetMinX() + 0.66500f * rect.Width, rect.GetMinY() + 0.52500f * rect.Height), new CGPoint(rect.GetMinX() + 0.63459f * rect.Width, rect.GetMinY() + 0.70500f * rect.Height));
            bezier3Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.54338f * rect.Width, rect.GetMinY() + 0.48500f * rect.Height), new CGPoint(rect.GetMinX() + 0.53578f * rect.Width, rect.GetMinY() + 0.66000f * rect.Height), new CGPoint(rect.GetMinX() + 0.54338f * rect.Width, rect.GetMinY() + 0.48500f * rect.Height));
            bezier3Path.ClosePath();
            UIColor.Gray.SetFill();
            bezier3Path.Fill();


            //// Bezier 4 Drawing
            UIBezierPath bezier4Path = new UIBezierPath();
            bezier4Path.MoveTo(new CGPoint(rect.GetMinX() + 0.44500f * rect.Width, rect.GetMinY() + 0.49500f * rect.Height));
            bezier4Path.AddLineTo(new CGPoint(rect.GetMinX() + 0.32805f * rect.Width, rect.GetMinY() + 0.52500f * rect.Height));
            bezier4Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.40115f * rect.Width, rect.GetMinY() + 0.69500f * rect.Height), new CGPoint(rect.GetMinX() + 0.32805f * rect.Width, rect.GetMinY() + 0.52500f * rect.Height), new CGPoint(rect.GetMinX() + 0.28420f * rect.Width, rect.GetMinY() + 0.69500f * rect.Height));
            bezier4Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.44500f * rect.Width, rect.GetMinY() + 0.49500f * rect.Height), new CGPoint(rect.GetMinX() + 0.40845f * rect.Width, rect.GetMinY() + 0.59000f * rect.Height), new CGPoint(rect.GetMinX() + 0.44500f * rect.Width, rect.GetMinY() + 0.49500f * rect.Height));
            bezier4Path.ClosePath();
            UIColor.Gray.SetFill();
            bezier4Path.Fill();
        }

        private void DrawQuadruped(CGRect rect)
        {
            //// Oval Drawing
            var ovalPath = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.14000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.11000f + 0.5f), NMath.Floor(rect.Width * 0.45000f + 0.5f) - NMath.Floor(rect.Width * 0.14000f + 0.5f), NMath.Floor(rect.Height * 0.35000f + 0.5f) - NMath.Floor(rect.Height * 0.11000f + 0.5f)));
            UIColor.Gray.SetFill();
            ovalPath.Fill();


            //// Rectangle Drawing
            var rectanglePath = UIBezierPath.FromRoundedRect(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.30000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.42000f + 0.5f), NMath.Floor(rect.Width * 0.87000f + 0.5f) - NMath.Floor(rect.Width * 0.30000f + 0.5f), NMath.Floor(rect.Height * 0.68000f + 0.5f) - NMath.Floor(rect.Height * 0.42000f + 0.5f)), 9.0f);
            UIColor.Gray.SetFill();
            rectanglePath.Fill();


            //// Rectangle 2 Drawing
            var rectangle2Path = UIBezierPath.FromRoundedRect(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.30000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.17000f + 0.5f), NMath.Floor(rect.Width * 0.45000f + 0.5f) - NMath.Floor(rect.Width * 0.30000f + 0.5f), NMath.Floor(rect.Height * 0.59000f + 0.5f) - NMath.Floor(rect.Height * 0.17000f + 0.5f)), 7.5f);
            UIColor.Gray.SetFill();
            rectangle2Path.Fill();


            //// Rectangle 3 Drawing
            var rectangle3Path = UIBezierPath.FromRoundedRect(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.42000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.62000f + 0.5f), NMath.Floor(rect.Width * 0.52000f + 0.5f) - NMath.Floor(rect.Width * 0.42000f + 0.5f), NMath.Floor(rect.Height * 0.87000f + 0.5f) - NMath.Floor(rect.Height * 0.62000f + 0.5f)), 5.0f);
            UIColor.Gray.SetFill();
            rectangle3Path.Fill();


            //// Rectangle 5 Drawing
            var rectangle5Path = UIBezierPath.FromRoundedRect(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.66000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.62000f + 0.5f), NMath.Floor(rect.Width * 0.76000f + 0.5f) - NMath.Floor(rect.Width * 0.66000f + 0.5f), NMath.Floor(rect.Height * 0.87000f + 0.5f) - NMath.Floor(rect.Height * 0.62000f + 0.5f)), 5.0f);
            UIColor.Gray.SetFill();
            rectangle5Path.Fill();
        }

        private void DrawFourWinged(CGRect rect)
        {


            //// Rectangle 2 Drawing
            UIBezierPath rectangle2Path = new UIBezierPath();
            rectangle2Path.MoveTo(new CGPoint(rect.GetMinX() + 36.0f, rect.GetMinY() + 35.0f));
            rectangle2Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 51.0f, rect.GetMinY() + 22.0f), new CGPoint(rect.GetMinX() + 35.55f, rect.GetMinY() + 30.32f), new CGPoint(rect.GetMinX() + 38.68f, rect.GetMinY() + 22.0f));
            rectangle2Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 65.0f, rect.GetMinY() + 33.0f), new CGPoint(rect.GetMinX() + 62.87f, rect.GetMinY() + 22.0f), new CGPoint(rect.GetMinX() + 64.9f, rect.GetMinY() + 28.88f));
            rectangle2Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.60000f * rect.Width, rect.GetMinY() + 0.44000f * rect.Height), new CGPoint(rect.GetMinX() + 65.14f, rect.GetMinY() + 38.95f), new CGPoint(rect.GetMinX() + 0.59613f * rect.Width, rect.GetMinY() + 0.42938f * rect.Height));
            rectangle2Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.60000f * rect.Width, rect.GetMinY() + 0.48344f * rect.Height), new CGPoint(rect.GetMinX() + 0.60712f * rect.Width, rect.GetMinY() + 0.46251f * rect.Height), new CGPoint(rect.GetMinX() + 0.60000f * rect.Width, rect.GetMinY() + 0.44163f * rect.Height));
            rectangle2Path.AddLineTo(new CGPoint(rect.GetMinX() + 0.60000f * rect.Width, rect.GetMinY() + 0.69242f * rect.Height));
            rectangle2Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.59378f * rect.Width, rect.GetMinY() + 0.76814f * rect.Height), new CGPoint(rect.GetMinX() + 0.60000f * rect.Width, rect.GetMinY() + 0.72837f * rect.Height), new CGPoint(rect.GetMinX() + 0.60000f * rect.Width, rect.GetMinY() + 0.74928f * rect.Height));
            rectangle2Path.AddLineTo(new CGPoint(rect.GetMinX() + 0.59288f * rect.Width, rect.GetMinY() + 0.77179f * rect.Height));
            rectangle2Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.50975f * rect.Width, rect.GetMinY() + 0.83000f * rect.Height), new CGPoint(rect.GetMinX() + 0.58016f * rect.Width, rect.GetMinY() + 0.80674f * rect.Height), new CGPoint(rect.GetMinX() + 0.54694f * rect.Width, rect.GetMinY() + 0.83000f * rect.Height));
            rectangle2Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.50500f * rect.Width, rect.GetMinY() + 0.83000f * rect.Height), new CGPoint(rect.GetMinX() + 0.50500f * rect.Width, rect.GetMinY() + 0.83000f * rect.Height), new CGPoint(rect.GetMinX() + 0.50500f * rect.Width, rect.GetMinY() + 0.83000f * rect.Height));
            rectangle2Path.AddLineTo(new CGPoint(rect.GetMinX() + 0.50500f * rect.Width, rect.GetMinY() + 0.83000f * rect.Height));
            rectangle2Path.AddLineTo(new CGPoint(rect.GetMinX() + 0.50500f * rect.Width, rect.GetMinY() + 0.83000f * rect.Height));
            rectangle2Path.AddLineTo(new CGPoint(rect.GetMinX() + 0.50025f * rect.Width, rect.GetMinY() + 0.83000f * rect.Height));
            rectangle2Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.41712f * rect.Width, rect.GetMinY() + 0.77179f * rect.Height), new CGPoint(rect.GetMinX() + 0.46306f * rect.Width, rect.GetMinY() + 0.83000f * rect.Height), new CGPoint(rect.GetMinX() + 0.42984f * rect.Width, rect.GetMinY() + 0.80674f * rect.Height));
            rectangle2Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.41000f * rect.Width, rect.GetMinY() + 0.68656f * rect.Height), new CGPoint(rect.GetMinX() + 0.41000f * rect.Width, rect.GetMinY() + 0.74928f * rect.Height), new CGPoint(rect.GetMinX() + 0.41000f * rect.Width, rect.GetMinY() + 0.72837f * rect.Height));
            rectangle2Path.AddLineTo(new CGPoint(rect.GetMinX() + 0.41000f * rect.Width, rect.GetMinY() + 0.69242f * rect.Height));
            rectangle2Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 0.42000f * rect.Width, rect.GetMinY() + 0.44000f * rect.Height), new CGPoint(rect.GetMinX() + 0.41000f * rect.Width, rect.GetMinY() + 0.44163f * rect.Height), new CGPoint(rect.GetMinX() + 0.42000f * rect.Width, rect.GetMinY() + 0.44000f * rect.Height));
            rectangle2Path.AddCurveToPoint(new CGPoint(rect.GetMinX() + 36.0f, rect.GetMinY() + 35.0f), new CGPoint(rect.GetMinX() + 0.42340f * rect.Width, rect.GetMinY() + 0.43067f * rect.Height), new CGPoint(rect.GetMinX() + 36.55f, rect.GetMinY() + 40.72f));
            rectangle2Path.ClosePath();
            UIColor.Gray.SetFill();
            rectangle2Path.Fill();


            //// Oval 2 Drawing
            var oval2Path = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.12000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.40000f + 0.5f), NMath.Floor(rect.Width * 0.45000f + 0.5f) - NMath.Floor(rect.Width * 0.12000f + 0.5f), NMath.Floor(rect.Height * 0.61000f + 0.5f) - NMath.Floor(rect.Height * 0.40000f + 0.5f)));
            UIColor.Gray.SetFill();
            oval2Path.Fill();


            //// Oval 3 Drawing
            var oval3Path = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.21000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.55000f + 0.5f), NMath.Floor(rect.Width * 0.45000f + 0.5f) - NMath.Floor(rect.Width * 0.21000f + 0.5f), NMath.Floor(rect.Height * 0.73000f + 0.5f) - NMath.Floor(rect.Height * 0.55000f + 0.5f)));
            UIColor.Gray.SetFill();
            oval3Path.Fill();


            //// Oval 4 Drawing
            var oval4Path = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.55000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.40000f + 0.5f), NMath.Floor(rect.Width * 0.88000f + 0.5f) - NMath.Floor(rect.Width * 0.55000f + 0.5f), NMath.Floor(rect.Height * 0.61000f + 0.5f) - NMath.Floor(rect.Height * 0.40000f + 0.5f)));
            UIColor.Gray.SetFill();
            oval4Path.Fill();


            //// Oval 5 Drawing
            var oval5Path = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + NMath.Floor(rect.Width * 0.55000f + 0.5f), rect.GetMinY() + NMath.Floor(rect.Height * 0.55000f + 0.5f), NMath.Floor(rect.Width * 0.79000f + 0.5f) - NMath.Floor(rect.Width * 0.55000f + 0.5f), NMath.Floor(rect.Height * 0.73000f + 0.5f) - NMath.Floor(rect.Height * 0.55000f + 0.5f)));
            UIColor.Gray.SetFill();
            oval5Path.Fill();
        }


        private void DrawTenctacle(CGRect rect)
        {

            //// Oval Drawing
            var ovalPath = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + 16.0f, rect.GetMinY() + 19.0f, 68.0f, 43.0f));
            UIColor.Gray.SetFill();
            ovalPath.Fill();


            //// Oval 2 Drawing
            var oval2Path = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + 16.0f, rect.GetMinY() + 42.0f, 11.0f, 32.0f));
            UIColor.Gray.SetFill();
            oval2Path.Fill();


            //// Oval 3 Drawing
            var oval3Path = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + 33.0f, rect.GetMinY() + 49.0f, 11.0f, 32.0f));
            UIColor.Gray.SetFill();
            oval3Path.Fill();


            //// Oval 4 Drawing
            var oval4Path = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + 58.0f, rect.GetMinY() + 49.0f, 11.0f, 32.0f));
            UIColor.Gray.SetFill();
            oval4Path.Fill();


            //// Oval 5 Drawing
            var oval5Path = UIBezierPath.FromOval(new CGRect(rect.GetMinX() + 73.0f, rect.GetMinY() + 42.0f, 11.0f, 32.0f));
            UIColor.Gray.SetFill();
            oval5Path.Fill();
        }

        private void DrawNotImplemented(CGRect frame){
            UIBezierPath textPath = new UIBezierPath();
            textPath.MoveTo(new CGPoint(frame.GetMinX() + 0.40164f * frame.Width, frame.GetMinY() + 0.39663f * frame.Height));
            textPath.AddLineTo(new CGPoint(frame.GetMinX() + 0.40164f * frame.Width, frame.GetMinY() + 0.31069f * frame.Height));
            textPath.AddLineTo(new CGPoint(frame.GetMinX() + 0.31411f * frame.Width, frame.GetMinY() + 0.31069f * frame.Height));
            textPath.AddLineTo(new CGPoint(frame.GetMinX() + 0.31411f * frame.Width, frame.GetMinY() + 0.39663f * frame.Height));
            textPath.AddLineTo(new CGPoint(frame.GetMinX() + 0.40164f * frame.Width, frame.GetMinY() + 0.39663f * frame.Height));
            textPath.ClosePath();
            textPath.MoveTo(new CGPoint(frame.GetMinX() + 0.31411f * frame.Width, frame.GetMinY() + 0.62503f * frame.Height));
            textPath.AddLineTo(new CGPoint(frame.GetMinX() + 0.31411f * frame.Width, frame.GetMinY() + 0.71097f * frame.Height));
            textPath.AddLineTo(new CGPoint(frame.GetMinX() + 0.40164f * frame.Width, frame.GetMinY() + 0.71097f * frame.Height));
            textPath.AddLineTo(new CGPoint(frame.GetMinX() + 0.40164f * frame.Width, frame.GetMinY() + 0.62503f * frame.Height));
            textPath.AddLineTo(new CGPoint(frame.GetMinX() + 0.31411f * frame.Width, frame.GetMinY() + 0.62503f * frame.Height));
            textPath.ClosePath();
            textPath.MoveTo(new CGPoint(frame.GetMinX() + 0.62874f * frame.Width, frame.GetMinY() + 0.86349f * frame.Height));
            textPath.AddLineTo(new CGPoint(frame.GetMinX() + 0.68000f * frame.Width, frame.GetMinY() + 0.86349f * frame.Height));
            textPath.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.59996f * frame.Width, frame.GetMinY() + 0.68696f * frame.Height), new CGPoint(frame.GetMinX() + 0.64267f * frame.Width, frame.GetMinY() + 0.80413f * frame.Height), new CGPoint(frame.GetMinX() + 0.61600f * frame.Width, frame.GetMinY() + 0.74529f * frame.Height));
            textPath.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.57591f * frame.Width, frame.GetMinY() + 0.50192f * frame.Height), new CGPoint(frame.GetMinX() + 0.58393f * frame.Width, frame.GetMinY() + 0.62864f * frame.Height), new CGPoint(frame.GetMinX() + 0.57591f * frame.Width, frame.GetMinY() + 0.56696f * frame.Height));
            textPath.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.59957f * frame.Width, frame.GetMinY() + 0.31998f * frame.Height), new CGPoint(frame.GetMinX() + 0.57591f * frame.Width, frame.GetMinY() + 0.43843f * frame.Height), new CGPoint(frame.GetMinX() + 0.58380f * frame.Width, frame.GetMinY() + 0.37779f * frame.Height));
            textPath.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.68000f * frame.Width, frame.GetMinY() + 0.14500f * frame.Height), new CGPoint(frame.GetMinX() + 0.61534f * frame.Width, frame.GetMinY() + 0.26217f * frame.Height), new CGPoint(frame.GetMinX() + 0.64215f * frame.Width, frame.GetMinY() + 0.20384f * frame.Height));
            textPath.AddLineTo(new CGPoint(frame.GetMinX() + 0.62874f * frame.Width, frame.GetMinY() + 0.14500f * frame.Height));
            textPath.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.53609f * frame.Width, frame.GetMinY() + 0.31765f * frame.Height), new CGPoint(frame.GetMinX() + 0.58774f * frame.Width, frame.GetMinY() + 0.19816f * frame.Height), new CGPoint(frame.GetMinX() + 0.55685f * frame.Width, frame.GetMinY() + 0.25572f * frame.Height));
            textPath.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.50494f * frame.Width, frame.GetMinY() + 0.50192f * frame.Height), new CGPoint(frame.GetMinX() + 0.51532f * frame.Width, frame.GetMinY() + 0.37959f * frame.Height), new CGPoint(frame.GetMinX() + 0.50494f * frame.Width, frame.GetMinY() + 0.44102f * frame.Height));
            textPath.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.51361f * frame.Width, frame.GetMinY() + 0.59948f * frame.Height), new CGPoint(frame.GetMinX() + 0.50494f * frame.Width, frame.GetMinY() + 0.53599f * frame.Height), new CGPoint(frame.GetMinX() + 0.50783f * frame.Width, frame.GetMinY() + 0.56851f * frame.Height));
            textPath.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.53845f * frame.Width, frame.GetMinY() + 0.69006f * frame.Height), new CGPoint(frame.GetMinX() + 0.51940f * frame.Width, frame.GetMinY() + 0.63045f * frame.Height), new CGPoint(frame.GetMinX() + 0.52768f * frame.Width, frame.GetMinY() + 0.66064f * frame.Height));
            textPath.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.57749f * frame.Width, frame.GetMinY() + 0.77716f * frame.Height), new CGPoint(frame.GetMinX() + 0.54923f * frame.Width, frame.GetMinY() + 0.71948f * frame.Height), new CGPoint(frame.GetMinX() + 0.56224f * frame.Width, frame.GetMinY() + 0.74852f * frame.Height));
            textPath.AddCurveToPoint(new CGPoint(frame.GetMinX() + 0.62874f * frame.Width, frame.GetMinY() + 0.86349f * frame.Height), new CGPoint(frame.GetMinX() + 0.59273f * frame.Width, frame.GetMinY() + 0.80581f * frame.Height), new CGPoint(frame.GetMinX() + 0.60982f * frame.Width, frame.GetMinY() + 0.83459f * frame.Height));
            textPath.ClosePath();
            UIColor.Black.SetFill();
            textPath.Fill();
        }
	}
}

