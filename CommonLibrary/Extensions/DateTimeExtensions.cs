using System;
namespace CommonLibrary.Extensions
{
    /// <summary>
    /// DateTime 클래스를 기반으로 라이브러리에 새로운 메서드를 구축한다.
    /// </summary>
    public static class DateTimeExtensions
    {
        public static DateTime FirstDateOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        public static DateTime LastDateOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }
    }
}
