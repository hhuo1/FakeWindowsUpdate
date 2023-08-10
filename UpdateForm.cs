using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WindowsUpdate.Properties;

namespace WindowsUpdate
{
	// Token: 0x02000008 RID: 8
	public partial class UpdateForm : Form
	{
		// Token: 0x06000021 RID: 33 RVA: 0x0000276B File Offset: 0x0000096B
		public UpdateForm()
		{
			base.SuspendLayout();
			base.Opacity = 0.0;
			this.InitializeComponent();
			Cursor.Hide();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000027A0 File Offset: 0x000009A0
		public void UpdateForm_Load(object sender, EventArgs e)
		{
			this.DoubleBuffered = true;
			this.UpdateForm_Resize(sender, e);
			this.LoadingBox.Delay = 50;
			this.LoadingBox.AnimationWidth = 32;
			this.LoadingBox.Image = Resources.aero_busy;
			this.Refresh();
			base.ResumeLayout(true);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000027F4 File Offset: 0x000009F4
		public void UpdateForm_Resize(object sender, EventArgs e)
		{
			this.UpdateLabel.Location = new Point(base.Width / 2 - this.UpdateLabel.Width / 2, base.Height / 2 - this.UpdateLabel.Height / 2);
			this.LoadingBox.Location = new Point(this.UpdateLabel.Location.X - this.LoadingBox.Width, this.UpdateLabel.Location.Y + (this.UpdateLabel.Height / 2 - this.LoadingBox.Height / 2));
			this.LogonText.Location = new Point(base.Width / 2 - this.LogonText.Width / 2, base.Height - 75);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000028CA File Offset: 0x00000ACA
		private void UpdateLabel_Paint(object sender, PaintEventArgs e)
		{
			this.UpdateLabel.Text = "Configuring Windows updates\n0% complete\nDo not turn off your computer.";
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000028DC File Offset: 0x00000ADC
		public void TextTimer_Tick(object sender, EventArgs e)
		{
			this.TextTimer.Interval = this.RNG.Next(10000, 30001);
			this.UpdateLabel.ModifyText(string.Format("Configuring Windows updates\n{0}% complete\nDo not turn off your computer.", this.percentage += ((this.RNG.Next(0, 6) == 0) ? this.RNG.Next(1, 6) : this.RNG.Next(1, 3))));
			if (this.percentage >= 102)
			{
				Process.GetCurrentProcess().Kill();
				this.TextTimer.Stop();
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000297D File Offset: 0x00000B7D
		private void OpacityTimer_Tick(object sender, EventArgs e)
		{
			base.Opacity += 0.025;
			if (base.Opacity == 1.0)
			{
				this.OpacityTimer.Stop();
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000029B1 File Offset: 0x00000BB1
		private void TopMostTimer_Tick(object sender, EventArgs e)
		{
			base.TopMost = true;
			base.BringToFront();
			base.Focus();
		}

		// Token: 0x0400000F RID: 15
		public Random RNG = new Random();

		// Token: 0x04000010 RID: 16
		public int percentage;
	}
}
