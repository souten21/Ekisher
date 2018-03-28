using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ekisher
{
	public partial class Form1 : Form
	{
		EkishaBreaker breaker;

		#region コンストラクタ
		public Form1()
		{
			this.DoubleBuffered = true;
			this.KeyPreview = true;
			InitializeComponent();
			InitControls();
		}

		#endregion

		#region イベントハンドラ
		//キー押下時
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Space)
			{
				SpaceKeyPressed();
			}
			else if (e.KeyData == Keys.R)
			{
				Reset();
			}
			else if (e.KeyData == Keys.Escape) { this.Close(); };
			
		}

		//描画時
		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			breaker?.Draw(e.Graphics);
		}
		#endregion

		#region メソッド
		//初期化
		void InitControls()
		{
			breaker = new EkishaBreaker();
			this.Paint += Form1_Paint;
			this.KeyDown += Form1_KeyDown;
		}

		//スペースキー押下時
		void SpaceKeyPressed()
		{
			throw new NotImplementedException();
		}

		//リセット
		private void Reset()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
