using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ekisher
{
	class ScoreCoverter
	{
		public static int MaxValue = 1000;
		/// <summary>
		/// スコアポイントを難易度に応じてスコア列挙型に変換します。
		/// </summary>
		/// <param name="scorePoint">スコアポイント</param>
		/// <param name="difficulty">難易度</param>
		/// <returns></returns>
		public static Score ConvertToScore(int scorePoint, IDifficulty difficulty)
		{
			if (scorePoint == 1000) { return Score.Perfect; }
			else if (scorePoint == 0) { return Score.Hell; }
			if (scorePoint >= MaxValue - difficulty.VeryGoodThreshold) { return Score.VeryGood; }
			else if (scorePoint >= MaxValue - difficulty.GoodThreshold) { return Score.Good; }
			else if (scorePoint >= MaxValue - difficulty.SoCloseThreshold) { return Score.SoClose; }
			else if (scorePoint >= MaxValue - difficulty.BadThreshold) { return Score.Bad; }
			else { return Score.VeryBad; }

		}

	}
}
