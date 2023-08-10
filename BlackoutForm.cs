using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsUpdate
{
	// Token: 0x02000004 RID: 4
	public partial class BlackoutForm : Form
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000022E0 File Offset: 0x000004E0
		public BlackoutForm(bool windows10)
		{
			this.isWindows10 = windows10;
			this.InitializeComponent();
			Cursor.Hide();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022FC File Offset: 0x000004FC
		[AsyncStateMachine(typeof(BlackoutForm.<BlackoutTimer_Tick>d__3))]
		private void BlackoutTimer_Tick(object sender, EventArgs e)
		{
			BlackoutForm.<BlackoutTimer_Tick>d__3 <BlackoutTimer_Tick>d__;
			<BlackoutTimer_Tick>d__.<>4__this = this;
			<BlackoutTimer_Tick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<BlackoutTimer_Tick>d__.<>1__state = -1;
			AsyncVoidMethodBuilder <>t__builder = <BlackoutTimer_Tick>d__.<>t__builder;
			<>t__builder.Start<BlackoutForm.<BlackoutTimer_Tick>d__3>(ref <BlackoutTimer_Tick>d__);
		}

		// Token: 0x04000008 RID: 8
		private bool shown;

		// Token: 0x04000009 RID: 9
		private bool isWindows10;
	}
}
