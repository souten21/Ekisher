using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ekisher
{
	/// <summary>
	/// 難易度インターフェース
	/// </summary>
	interface IDifficulty
	{
		/// <summary>
		/// 難易度名
		/// </summary>
		string Name { get; }
		
		/// <summary>
		/// 難易度の概要
		/// </summary>
		string Description { get; }

		/// <summary>
		/// 「VeryGood」になる最大値からの差
		/// </summary>
		int VeryGoodThreshold { get; }

		/// <summary>
		/// 「Good」になる最大値からの差
		/// </summary>
		int GoodThreshold { get; }

		/// <summary>
		/// 「SoClose」になる最大値からの差
		/// </summary>
		int SoCloseThreshold { get; }

		/// <summary>
		/// 「Bad」になる最大値からの差
		/// </summary>
		int BadThreshold { get; }

		/// <summary>
		/// ゲージ増加乱数値の上限（下限は1）
		/// </summary>
		int GageRandomAmountDeflection { get; }
	}
}
