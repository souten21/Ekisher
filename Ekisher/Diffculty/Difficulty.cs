using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ekisher
{
	class Lunatic : IDifficulty
	{
		public string Name => "超強い易者";
		public string Description => "マゾ向け";
		public int VeryGoodThreshold => 5;
		public int GoodThreshold => 10;
		public int SoCloseThreshold => 15;
		public int BadThreshold => 20;
		public int GageRandomAmountDeflection => 100;
	}

	class Hard : IDifficulty
	{
		public string Name => "強い易者";
		public string Description => "易者の強さを味わいたい方に";
		public int VeryGoodThreshold => 10;
		public int GoodThreshold => 20;
		public int SoCloseThreshold => 30;
		public int BadThreshold => 50;
		public int GageRandomAmountDeflection => 30;
	}

	class Normal : IDifficulty
	{
		public string Name => "普通の易者";
		public string Description => "とりあえずやってみる方に";
		public int VeryGoodThreshold => 20;
		public int GoodThreshold => 40;
		public int SoCloseThreshold => 80;
		public int BadThreshold => 200;
		public int GageRandomAmountDeflection => 15;
	}

	class Easy : IDifficulty
	{
		public string Name => "弱い易者";
		public string Description => "手っ取り早くマルチエンドを見たい方に";
		public int VeryGoodThreshold => 50;
		public int GoodThreshold => 100;
		public int SoCloseThreshold => 200;
		public int BadThreshold => 500;
		public int GageRandomAmountDeflection => 5;
	}

}
