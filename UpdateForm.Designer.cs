namespace WindowsUpdate
{
	// Token: 0x02000008 RID: 8
	public partial class UpdateForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000028 RID: 40 RVA: 0x000029C7 File Offset: 0x00000BC7
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000029E8 File Offset: 0x00000BE8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsUpdate.UpdateForm));
			this.TextTimer = new global::System.Windows.Forms.Timer(this.components);
			this.OpacityTimer = new global::System.Windows.Forms.Timer(this.components);
			this.LogonText = new global::System.Windows.Forms.PictureBox();
			this.TopMostTimer = new global::System.Windows.Forms.Timer(this.components);
			this.UpdateLabel = new global::WindowsUpdate.ShadowLabel();
			this.LoadingBox = new global::WindowsUpdate.AnimatedImageBox();
			((global::System.ComponentModel.ISupportInitialize)this.LogonText).BeginInit();
			base.SuspendLayout();
			this.TextTimer.Enabled = true;
			this.TextTimer.Tick += new global::System.EventHandler(this.TextTimer_Tick);
			this.OpacityTimer.Enabled = true;
			this.OpacityTimer.Interval = 10;
			this.OpacityTimer.Tick += new global::System.EventHandler(this.OpacityTimer_Tick);
			this.LogonText.BackColor = global::System.Drawing.Color.Transparent;
			this.LogonText.BackgroundImage = global::WindowsUpdate.Properties.Resources.logon;
			this.LogonText.Location = new global::System.Drawing.Point(12, 388);
			this.LogonText.Name = "LogonText";
			this.LogonText.Size = new global::System.Drawing.Size(350, 50);
			this.LogonText.TabIndex = 3;
			this.LogonText.TabStop = false;
			this.TopMostTimer.Enabled = true;
			this.TopMostTimer.Interval = 1;
			this.TopMostTimer.Tick += new global::System.EventHandler(this.TopMostTimer_Tick);
			this.UpdateLabel.AutoSize = true;
			this.UpdateLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.UpdateLabel.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.UpdateLabel.ForeColor = global::System.Drawing.Color.White;
			this.UpdateLabel.Location = new global::System.Drawing.Point(12, 6);
			this.UpdateLabel.Margin = new global::System.Windows.Forms.Padding(6, 7, 6, 7);
			this.UpdateLabel.Name = "UpdateLabel";
			this.UpdateLabel.Size = new global::System.Drawing.Size(350, 100);
			this.UpdateLabel.TabIndex = 2;
			this.UpdateLabel.Paint += new global::System.Windows.Forms.PaintEventHandler(this.UpdateLabel_Paint);
			this.LoadingBox.AnimationIndex = 0;
			this.LoadingBox.BackColor = global::System.Drawing.Color.Transparent;
			this.LoadingBox.Delay = 100;
			this.LoadingBox.Image = null;
			this.LoadingBox.Location = new global::System.Drawing.Point(12, 116);
			this.LoadingBox.Name = "LoadingBox";
			this.LoadingBox.Size = new global::System.Drawing.Size(32, 32);
			this.LoadingBox.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.ControlBox = false;
			base.Controls.Add(this.LogonText);
			base.Controls.Add(this.UpdateLabel);
			base.Controls.Add(this.LoadingBox);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "UpdateForm";
			base.Opacity = 0.0;
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.TopMost = true;
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.UpdateForm_Load);
			base.Resize += new global::System.EventHandler(this.UpdateForm_Resize);
			((global::System.ComponentModel.ISupportInitialize)this.LogonText).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000011 RID: 17
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Timer OpacityTimer;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Timer TopMostTimer;

		// Token: 0x04000014 RID: 20
		public global::WindowsUpdate.ShadowLabel UpdateLabel;

		// Token: 0x04000015 RID: 21
		public global::System.Windows.Forms.Timer TextTimer;

		// Token: 0x04000016 RID: 22
		public global::WindowsUpdate.AnimatedImageBox LoadingBox;

		// Token: 0x04000017 RID: 23
		public global::System.Windows.Forms.PictureBox LogonText;
	}
}
