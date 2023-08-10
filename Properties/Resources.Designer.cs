using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsUpdate.Properties
{
	// Token: 0x0200000A RID: 10
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"), DebuggerNonUserCode, CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00003379 File Offset: 0x00001579
		internal Resources()
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00003381 File Offset: 0x00001581
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("WindowsUpdate.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000033AD File Offset: 0x000015AD
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000033B4 File Offset: 0x000015B4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000033BC File Offset: 0x000015BC
		internal static Bitmap aero_busy
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("aero_busy", Resources.resourceCulture);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000033D7 File Offset: 0x000015D7
		internal static Bitmap background
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("background", Resources.resourceCulture);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000033F2 File Offset: 0x000015F2
		internal static Bitmap logon
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("logon", Resources.resourceCulture);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000340D File Offset: 0x0000160D
		internal static Bitmap win10_load
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("win10_load", Resources.resourceCulture);
			}
		}

		// Token: 0x0400001B RID: 27
		private static ResourceManager resourceMan;

		// Token: 0x0400001C RID: 28
		private static CultureInfo resourceCulture;
	}
}
