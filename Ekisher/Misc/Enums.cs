using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ekisher
{
	/// <summary>
	/// 今の状態
	/// </summary>
	enum SequenceType
	{
		/// <summary>
		/// 起動直後
		/// </summary>
		Title,

		/// <summary>
		/// 難易度選択
		/// </summary>
		SelectDifficulty,

		/// <summary>
		/// 開始した
		/// </summary>
		Started,

		/// <summary>
		/// 確定状態
		/// </summary>
		Animation,

		/// <summary>
		/// 結果表示
		/// </summary>
		Result
	}

	/// <summary>
	/// スコア
	/// </summary>
	enum Score
	{
		/// <summary>
		/// 完璧
		/// </summary>
		Perfect,

		/// <summary>
		/// とても良い
		/// </summary>
		VeryGood,

		/// <summary>
		/// 良い
		/// </summary>
		Good,

		/// <summary>
		/// 惜しい
		/// </summary>
		SoClose,

		/// <summary>
		/// 悪い
		/// </summary>
		Bad,

		/// <summary>
		/// 超悪い
		/// </summary>
		VeryBad,

		/// <summary>
		/// 最低
		/// </summary>
		Hell
	}

	public enum GageType
	{
		MinMax,
		Centering,
		Balance
	}
}
