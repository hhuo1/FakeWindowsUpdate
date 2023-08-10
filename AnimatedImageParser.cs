using System;
using System.Drawing;

namespace WindowsUpdate
{
	// Token: 0x02000003 RID: 3
	internal class AnimatedImageParser
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002290 File Offset: 0x00000490
		public static Bitmap CropImage(Image image, int x, int y, int width, int height)
		{
			Bitmap bitmap = new Bitmap(width, height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.DrawImageUnscaled(image, x, y, width, height);
			}
			return bitmap;
		}
	}
}
