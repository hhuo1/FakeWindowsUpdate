namespace WindowsUpdate
{
	// Token: 0x02000009 RID: 9
	public partial class UpdateForm10 : global::WindowsUpdate.UpdateForm
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00003012 File Offset: 0x00001212
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003034 File Offset: 0x00001234
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsUpdate.UpdateForm10));
			this._UpdateLabel = new global::System.Windows.Forms.Label();
			this.ReminderLabel = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.LogonText).BeginInit();
			base.SuspendLayout();
			this.TextTimer.Interval = 1956;
			this.LoadingBox.AnimationIndex = 5;
			this.LoadingBox.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("LoadingBox.BackgroundImage");
			this.LoadingBox.Delay = 50;
			this.LoadingBox.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("LoadingBox.Image");
			this.LoadingBox.Location = new global::System.Drawing.Point(193, 209);
			this.LoadingBox.Size = new global::System.Drawing.Size(64, 64);
			this.LogonText.Location = new global::System.Drawing.Point(225, 375);
			this._UpdateLabel.AutoSize = true;
			this._UpdateLabel.BackColor = global::System.Drawing.Color.Transparent;
			this._UpdateLabel.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this._UpdateLabel.ForeColor = global::System.Drawing.Color.White;
			this._UpdateLabel.Location = new global::System.Drawing.Point(12, 9);
			this._UpdateLabel.Name = "_UpdateLabel";
			this._UpdateLabel.Size = new global::System.Drawing.Size(488, 64);
			this._UpdateLabel.TabIndex = 4;
			this._UpdateLabel.Text = "Working on updates  0% complete.\r\nDon't turn off your PC. This will take a while.";
			this._UpdateLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ReminderLabel.AutoSize = true;
			this.ReminderLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.ReminderLabel.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ReminderLabel.ForeColor = global::System.Drawing.Color.White;
			this.ReminderLabel.Location = new global::System.Drawing.Point(12, 84);
			this.ReminderLabel.Name = "ReminderLabel";
			this.ReminderLabel.Size = new global::System.Drawing.Size(366, 32);
			this.ReminderLabel.TabIndex = 5;
			this.ReminderLabel.Text = "Your PC will restart several times.";
			this.ReminderLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(0, 120, 215);
			this.BackgroundImage = null;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.ReminderLabel);
			base.Controls.Add(this._UpdateLabel);
			this.DoubleBuffered = true;
			base.Name = "UpdateForm10";
			base.Opacity = 1.0;
			this.Text = "UpdateForm10";
			base.Load += new global::System.EventHandler(this.UpdateForm10_Load);
			base.Resize += new global::System.EventHandler(this.UpdateForm10_Resize);
			base.Controls.SetChildIndex(this.LoadingBox, 0);
			base.Controls.SetChildIndex(this._UpdateLabel, 0);
			base.Controls.SetChildIndex(this.ReminderLabel, 0);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000018 RID: 24
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Label _UpdateLabel;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Label ReminderLabel;
	}
}
