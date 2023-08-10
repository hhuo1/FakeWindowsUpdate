namespace WindowsUpdate
{
	// Token: 0x02000004 RID: 4
	public partial class BlackoutForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002335 File Offset: 0x00000535
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002354 File Offset: 0x00000554
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.BlackoutTimer = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.BlackoutTimer.Enabled = true;
			this.BlackoutTimer.Interval = 10;
			this.BlackoutTimer.Tick += new global::System.EventHandler(this.BlackoutTimer_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.ControlBox = false;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "BlackoutForm";
			base.Opacity = 0.0;
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.TopMost = true;
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.ResumeLayout(false);
		}

		// Token: 0x0400000A RID: 10
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Timer BlackoutTimer;
	}
}
