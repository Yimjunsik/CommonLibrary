using System;
namespace CommonLibrary.Extensions
{
    /// <summary>
    /// String 클래스를 기반으로해서 추가로 확장할 메서드를 라이브러리에 구축한다.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// 숫자인지 아닌지 체크하는 String 확장 메서드.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNumeric(this string s)
        {
            long result;
            return long.TryParse(s, out result);
        }

        /// <summary>
        /// DateTime 타입인지 아닌지 체크하는 String 확장 메서드.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsDateTime(this string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }
            else
            {
                DateTime result;
                return DateTime.TryParse(s, out result);
            }
        }
 
    }
}
