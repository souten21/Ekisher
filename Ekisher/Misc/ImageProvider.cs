using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Ekisher
{
	class ImageProvider
	{ 

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
			throw new NotImplementedException();
		}

		//とても良いとき
		Image GetVeryGoodImage(int frameCnt)
		{
			throw new NotImplementedException();
		}

		//良い時
		Image GetGoodImage(int frameCnt)
		{
			throw new NotImplementedException();
		}
	
		//惜しい時
		Image GetSoCloseImage(int frameCnt)
		{
			throw new NotImplementedException();
		}

		//悪い時
		Image GetBadImage(int frameCnt)
		{
			throw new NotImplementedException();
		}

		//とても悪いとき
		Image GetVeryBadImage(int frameCnt)
		{
			throw new NotImplementedException();
		}

		//最低の時
		Image GetHellImage(int frameCnt)
		{
			throw new NotImplementedException();
		}

	}
}
