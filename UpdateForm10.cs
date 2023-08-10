using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WindowsUpdate.Properties;

namespace WindowsUpdate
{
	// Token: 0x02000009 RID: 9
	public partial class UpdateForm10 : UpdateForm
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002DB0 File Offset: 0x00000FB0
		public UpdateForm10()
		{
			base.Resize -= new EventHandler(base.UpdateForm_Resize);
			this.TextTimer.Tick -= new EventHandler(base.TextTimer_Tick);
			this.TextTimer.Tick += new EventHandler(this._TextTimer_Tick);
			base.Load -= new EventHandler(base.UpdateForm_Load);
			this.UpdateLabel.Dispose();
			this.LogonText.Dispose();
			this.InitializeComponent();
			Cursor.Hide();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002E38 File Offset: 0x00001038
		private void UpdateForm10_Load(object sender, EventArgs e)
		{
			this.DoubleBuffered = true;
			this.UpdateForm10_Resize(sender, e);
			this.LoadingBox.Delay = 35;
			this.LoadingBox.AnimationWidth = 64;
			this.LoadingBox.Image = Resources.win10_load;
			this.LoadingBox.BringToFront();
			this.Refresh();
			base.ResumeLayout(true);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002E98 File Offset: 0x00001098
		public void _TextTimer_Tick(object sender, EventArgs e)
		{
			this.TextTimer.Interval = this.RNG.Next(10000, 30001);
			this._UpdateLabel.Text = string.Format("Working on updates  {0}% complete.\nDon't turn off your PC. This will take a while.", this.percentage += ((this.RNG.Next(0, 6) == 0) ? this.RNG.Next(1, 6) : this.RNG.Next(1, 3)));
			if (this.percentage >= 102)
			{
				Process.GetCurrentProcess().Kill();
				this.TextTimer.Stop();
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002F3C File Offset: 0x0000113C
		private void UpdateForm10_Resize(object sender, EventArgs e)
		{
			this._UpdateLabel.Location = new Point(base.Width / 2 - this._UpdateLabel.Width / 2, base.Height / 2 - this._UpdateLabel.Height / 2);
			this.ReminderLabel.Location = new Point(base.Width / 2 - this.ReminderLabel.Width / 2, base.Height - 75);
			this.LoadingBox.Location = new Point(this._UpdateLabel.Location.X + this._UpdateLabel.Width / 2 - this.LoadingBox.Width / 2, this._UpdateLabel.Location.Y - this.LoadingBox.Height);
		}
	}
}
