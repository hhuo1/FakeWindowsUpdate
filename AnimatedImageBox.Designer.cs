using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsUpdate
{
	// Token: 0x02000002 RID: 2
	public class AnimatedImageBox : UserControl
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		[Description("The image containing the animation."), Category("Appearance"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
		public Image Image
		{
			get
			{
				return this.image;
			}
			set
			{
				this.image = value;
				if (this.image != null)
				{
					this.AnimationTimer.Start();
					return;
				}
				this.AnimationTimer.Stop();
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002080 File Offset: 0x00000280
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002088 File Offset: 0x00000288
		[Description("The animation delay."), Category("Appearance"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
		public int Delay
		{
			get
			{
				return this.delay;
			}
			set
			{
				this.delay = value;
				this.AnimationTimer.Interval = this.delay;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020A2 File Offset: 0x000002A2
		// (set) Token: 0x06000006 RID: 6 RVA: 0x000020AA File Offset: 0x000002AA
		[Description("The current image index in the animation."), Category("Appearance"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
		public int AnimationIndex
		{
			get
			{
				return this.animationIndex;
			}
			set
			{
				this.OnAnimationIndexChanged();
				this.animationIndex = value;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000007 RID: 7 RVA: 0x000020BC File Offset: 0x000002BC
		// (remove) Token: 0x06000008 RID: 8 RVA: 0x000020F4 File Offset: 0x000002F4
		[Description("The event that gets called when the current image index is changed."), Category("Behavior"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
		[method: CompilerGenerated]
		[CompilerGenerated]
		public event EventHandler AnimationIndexChanged;

		// Token: 0x06000009 RID: 9 RVA: 0x00002129 File Offset: 0x00000329
		private void OnAnimationIndexChanged()
		{
			EventHandler expr_06 = this.AnimationIndexChanged;
			if (expr_06 == null)
			{
				return;
			}
			expr_06(this, new EventArgs());
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002141 File Offset: 0x00000341
		public AnimatedImageBox()
		{
			this.InitializeComponent();
			this.DoubleBuffered = true;
			base.ResizeRedraw = true;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002180 File Offset: 0x00000380
		private void AnimationTimer_Tick(object sender, EventArgs e)
		{
			if (this.AnimationIndex == this.image.Width / this.AnimationWidth - 1)
			{
				this.animationIndex = -1;
			}
			int num = this.AnimationIndex;
			this.AnimationIndex = num + 1;
			this.BackgroundImage = AnimatedImageParser.CropImage(this.image, -(this.AnimationWidth * this.AnimationIndex), 0, this.AnimationWidth, this.image.Height);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000021F1 File Offset: 0x000003F1
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002210 File Offset: 0x00000410
		private void InitializeComponent()
		{
			this.components = new Container();
			this.AnimationTimer = new Timer(this.components);
			base.SuspendLayout();
			this.AnimationTimer.Tick += new EventHandler(this.AnimationTimer_Tick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Name = "AnimatedImageBox";
			base.ResumeLayout(false);
		}

		// Token: 0x04000001 RID: 1
		private Image image;

		// Token: 0x04000002 RID: 2
		private int delay = 100;

		// Token: 0x04000003 RID: 3
		[Description("The width of each image in the animation."), Category("Appearance"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
		public int AnimationWidth = 32;

		// Token: 0x04000004 RID: 4
		private int animationIndex = -1;

		// Token: 0x04000006 RID: 6
		private IContainer components;

		// Token: 0x04000007 RID: 7
		private Timer AnimationTimer;
	}
}
