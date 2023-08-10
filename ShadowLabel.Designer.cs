using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsUpdate
{
	// Token: 0x02000007 RID: 7
	public class ShadowLabel : UserControl
	{
		// Token: 0x0600001A RID: 26 RVA: 0x000024FC File Offset: 0x000006FC
		public ShadowLabel()
		{
			this.InitializeComponent();
			this.DoubleBuffered = true;
			base.ResizeRedraw = true;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			this.sf.LineAlignment = StringAlignment.Center;
			this.sf.Alignment = StringAlignment.Center;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002552 File Offset: 0x00000752
		public void ModifyText(string text)
		{
			this.Text = text;
			this.Refresh();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002564 File Offset: 0x00000764
		private void ShadowLabel_Paint(object sender, PaintEventArgs e)
		{
			this.Shadow(e.Graphics);
			e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), base.ClientRectangle, this.sf);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000025B0 File Offset: 0x000007B0
		private void Shadow(Graphics g)
		{
			for (byte b = 0; b < 5; b += 1)
			{
				g.DrawString(this.Text, this.Font, new SolidBrush(this.GenerateShadowColor(this.ForeColor, b)), new RectangleF((float)((double)b / 1.5), (float)((double)b / 1.5), (float)((double)base.Width + (double)b / 1.5), (float)((double)base.Height + (double)b / 1.5)), this.sf);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002640 File Offset: 0x00000840
		private Color GenerateShadowColor(Color color, byte i)
		{
			short num = (short)this.ForeColor.A;
			short num2 = (short)this.ForeColor.R;
			short num3 = (short)this.ForeColor.G;
			short num4 = (short)this.ForeColor.B;
			num2 = ((num2 - (short)(i * 160) < 0) ? 0 : (num2 - (short)(i * 160)));
			num3 = ((num3 - (short)(i * 160) < 0) ? 0 : (num3 - (short)(i * 160)));
			num4 = ((num4 - (short)(i * 160) < 0) ? 0 : (num4 - (short)(i * 160)));
			num = ((num - (short)(i * 80) < 0) ? 0 : (num - (short)(i * 80)));
			return Color.FromArgb((int)num, (int)num2, (int)num3, (int)num4);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000026F8 File Offset: 0x000008F8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002718 File Offset: 0x00000918
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Name = "ShadowLabel";
			base.Paint += new PaintEventHandler(this.ShadowLabel_Paint);
			base.ResumeLayout(false);
		}

		// Token: 0x0400000D RID: 13
		private StringFormat sf = new StringFormat();

		// Token: 0x0400000E RID: 14
		private IContainer components;
	}
}
