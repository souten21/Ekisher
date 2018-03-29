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
		//EkishaBreaker breaker;
		ImageProvider imgProvider;
		Timer timerDraw = new Timer() { Interval = 10 };
		int cnt = 0;

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
			var g = e.Graphics;
			g.Clear(Color.Black);
			g.DrawImage(imgProvider.GetFrameImage(Score.Perfect, cnt), new PointF());
			using (var f = new Font("Meiryo", 10))
			{
				g.DrawString(cnt.ToString(), f, Brushes.White, new Point(100, 20));
			}
			//breaker?.Draw(e.Graphics);
		}
		#endregion

		#region メソッド
		//初期化
		void InitControls()
		{
			//breaker = new EkishaBreaker();
			this.Paint += Form1_Paint;
			this.KeyDown += Form1_KeyDown;

			imgProvider = new ImageProvider();
			timerDraw.Tick += (s, e) => { if (cnt < 600) { cnt++; } else { cnt = 0; } this.Invalidate(); };
			timerDraw.Start();
		}

		//スペースキー押下時
		void SpaceKeyPressed()
		{
			return;
			throw new NotImplementedException();
		}

		//リセット
		private void Reset()
		{
			return;
			throw new NotImplementedException();
		}

		#endregion
	}
}
