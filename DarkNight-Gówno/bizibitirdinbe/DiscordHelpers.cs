using System;
using System.Globalization;

namespace bizibitirdinbe
{
	// Token: 0x0200003B RID: 59
	public static class DiscordHelpers
	{
		// Token: 0x060000DF RID: 223 RVA: 0x000029E4 File Offset: 0x00000BE4
		public static string DateTimeToISO(DateTime dateTime)
		{
			return DiscordHelpers.DateTimeToISO(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00010630 File Offset: 0x0000E830
		public static string DateTimeToISO(int year, int month, int day, int hour, int minute, int second)
		{
			return new DateTime(year, month, day, hour, minute, second, 0, DateTimeKind.Local).ToString("yyyy-MM-dd'T'HH:mm:ss.fffK", CultureInfo.InvariantCulture);
		}
	}
}
