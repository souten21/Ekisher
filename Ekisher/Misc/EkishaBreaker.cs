using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Ekisher
{
	class EkishaBreaker
	{
		#region 定数
		static readonly int GageMaxValue = 1000;
		#endregion


		#region メンバ
		Form TargetForm;
		Random random = new Random();
		Timer timerProc = new Timer() { Interval = 10 };
		Font font = new Font("Meiryo", 20);
		Font font2 = new Font("Meiryo", 40);

		SolidBrush BarBrush = new SolidBrush(Color.FromArgb(180, 50, 60));
		Size BorderSize = SystemInformation.Border3DSize;
		int vValue = 0;
		int cnt = 0;
		ImageProvider imgProvider;

		int[] Powers = new int[3];

		#endregion


		#region プロパティ
		/// <summary>
		/// 選択した難易度
		/// </summary>
		public IDifficulty Difficulty { get; set; }

		/// <summary>
		/// 開始日時
		/// </summary>
		public DateTime StartTime { get; set; }

		/// <summary>
		/// 今の状態
		/// </summary>
		public SequenceType Sequence { get; set; } = SequenceType.Title;

		/// <summary>
		/// 数字が上昇しているか？
		/// </summary>
		public bool IsUpV { get; set; } = true;

		/// <summary>
		/// 値
		/// </summary>
		public int VValue
		{
			get { return vValue; }
			set
			{
				if (value < 0) { vValue = 0; return; }
				if (GageMaxValue < value) { vValue = GageMaxValue; return; }
				vValue = value;
			}
		}
		#endregion

		#region コンストラクタ
		public EkishaBreaker(Form target)
		{
			TargetForm = target;
			Init();
		}
		#endregion

		#region イベントハンドラ
		//タイマーチック
		private void TimerProc_Tick(object sender, EventArgs e)
		{
			TargetForm?.Invalidate();
		}

		#endregion

		#region メソッド
		//初期化
		private void Init()
		{
			StartTime = DateTime.Now;
			timerProc.Tick += TimerProc_Tick;
			timerProc.Start();
		}

		//描画
		public void Draw(Graphics g)
		{
			g.Clear(Color.Black);
			switch (Sequence)
			{
				case SequenceType.Title:
					DrawBeforeStart(g);
					break;
				case SequenceType.SelectDifficulty:
					break;
				case SequenceType.Started:
					DrawStarted(g);
					break;
				case SequenceType.Animation:
					DrawAnimation(g);
					break;
				case SequenceType.Result:
					DrawResult(g);
					break;
				default:
					break;
			}
		}

		//値を変動
		private void AddValue()
		{
			var amount = random.Next(1, 20);
			if (IsUpV)
			{
				if (GageMaxValue == VValue) { IsUpV = !IsUpV; }
			}
			else
			{
				if (VValue == 0) { IsUpV = !IsUpV; }
			}
			VValue += amount * (IsUpV ? 1 : -1);
		}


		void DrawBeforeStart(Graphics g)
		{
			var caption = "スペースキーを押したらスタートします。";
			g.DrawString(caption, font, Brushes.White, GetTextCenterPoint(g, caption, font));
		}

		//開始後の描画
		void DrawStarted(Graphics g)
		{
			DateTime now = DateTime.Now;
			//g.FillRectangle(BarBrush, new RectangleF(0f, 0f, this.Width * (VValue / (float)GageMaxValue), 20));
			//if (VValue == 1000) { g.FillRectangle(Brushes.White, new RectangleF(0f, 0f, this.Width, 20)); }
			//g.DrawLine(Pens.White, new Point(0, 20), new Point(this.Width, 20));
		}

		//確定後の描画
		void DrawAnimation(Graphics g)
		{
			cnt++;
			g.DrawString(cnt.ToString(), font, Brushes.White, new Point(20, 20));
			if (cnt >= 100) { Sequence = SequenceType.Result; }
		}


		string GetResultString()
		{
			return (VValue == 1000 ? "完璧"
				: VValue >= 995 ? "よし"
				: VValue >= 970 ? "OK"
				: "残念") + $"[{VValue.ToString()}]";
		}

	

		void Reset()
		{
			vValue = 0;
			cnt = 0;
			StartTime = DateTime.Now;
			Sequence = SequenceType.Started;
		}

		#endregion
	}
}
