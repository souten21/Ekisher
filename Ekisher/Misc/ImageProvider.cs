using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Ekisher
{
	class ImageProvider
	{
		Image img1;
		Image img2;
		Image img3;

		public ImageProvider()
		{
			img1 = GenerateTestImage(1);
			img2 = GenerateTestImage(2);
			img3 = GenerateTestImage(3);
		}

		public Image GetOpeningImage(int frameCnt)
		{
			return img1;//TODO: 
		}

		public Image GetFrameImage(Score score, int frameCnt)
		{
			switch (score)
			{
				case Score.Perfect:
					return GetPerfectImage(frameCnt);
				case Score.VeryGood:
					return GetVeryGoodImage(frameCnt);
				case Score.Good:
					return GetGoodImage(frameCnt);
				case Score.SoClose:
					return GetSoCloseImage(frameCnt);
				case Score.Bad:
					return GetBadImage(frameCnt);
				case Score.VeryBad:
					return GetVeryBadImage(frameCnt);
				case Score.Hell:
					return GetHellImage(frameCnt);
				default:
					return null;
			}
		}

		//最大値のときの画像
		Image GetPerfectImage(int frameCnt)
		{
			return frameCnt < 200 ? img1
				: frameCnt < 400 ? img2
				: img3;
		}

		//とても良いとき
		Image GetVeryGoodImage(int frameCnt)
		{
			return GetPerfectImage(frameCnt);
			throw new NotImplementedException();
		}

		//良い時
		Image GetGoodImage(int frameCnt)
		{
			return GetPerfectImage(frameCnt);
			throw new NotImplementedException();
		}
	
		//惜しい時
		Image GetSoCloseImage(int frameCnt)
		{
			return GetPerfectImage(frameCnt);
			throw new NotImplementedException();
		}

		//悪い時
		Image GetBadImage(int frameCnt)
		{
			return GetPerfectImage(frameCnt);
			throw new NotImplementedException();
		}

		//とても悪いとき
		Image GetVeryBadImage(int frameCnt)
		{
			return GetPerfectImage(frameCnt);
			throw new NotImplementedException();
		}

		//最低の時
		Image GetHellImage(int frameCnt)
		{
			return GetPerfectImage(frameCnt);
			throw new NotImplementedException();
		}


		Image GenerateTestImage(int i)
		{
			var img = new Bitmap(200, 200);
			using (var g = Graphics.FromImage(img))
			using (var f = new Font("Meiryo", 20))
			{
				g.FillRectangle(Brushes.Blue, new Rectangle(0, 0, 200, 200));
				g.DrawString($"{i.ToString()}", f, Brushes.White, 0, 0);
				return img;
			}
		}
	}
}
