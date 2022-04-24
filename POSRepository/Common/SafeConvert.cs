using System;
using System.Collections.Generic;
using System.Text;

namespace POSRepository.Common
{
    public static class SafeConvert
    {

        public static string ToString(object value)
        {
            try
            {
                return value == DBNull.Value || value == null ? null : value.ToString();
            }
            catch
            {
                return null;
            }
        }
        public static string NullToString(object value)
        {
            try
            {
                return value == DBNull.Value || value == null ? string.Empty : value.ToString();
            }
            catch
            {
                return null;
            }
        }

        public static int ToInt32(object value)
        {
            try
            {
                if (value == null || value.ToString().Equals(string.Empty))
                    return default;

                return Convert.ToInt32(value);
            } // Remove general catch
            catch (ArgumentException)
            {
                return default;
            }
            catch (OverflowException)
            {
                return default;
            }
            catch (FormatException)
            {
                return default;
            }
        }

        public static long ToInt64(object value)
        {
            try
            {
                if (value == null || value.ToString().Equals(string.Empty))
                    return default;

                return Convert.ToInt64(value);
            }
            catch (ArgumentException)
            {
                return default;
            }
            catch (OverflowException)
            {
                return default;
            }
            catch (FormatException)
            {
                return default;
            }
        }

        public static bool ToBoolean(object value)
        {
            try
            {
                if (value == null || value.ToString().Equals(string.Empty))
                    return default;

                return Convert.ToBoolean(value);
            }
            catch (InvalidCastException)
            {
                return default;
            }
        }


        public static bool ToBoolean(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                    return default;

                return Convert.ToBoolean(value);
            }
            catch
            {
                return value == "1";
            }
        }

        public static byte[] ToByteArray(object value)
        {
            try
            {
                if (value == DBNull.Value || value == null || value.ToString().Equals(string.Empty))
                    return null;

                return (byte[])value;
            }
            catch (InvalidCastException)
            {
                return new byte[0];
            }
        }

        public static decimal ToDecimal(object value)
        {
            try
            {
                if (value == null || value.ToString().Equals(string.Empty))
                    return default;

                return Convert.ToDecimal(value);
            }
            catch
            {
                return default;
            }
        }

        public static DateTime ToDateTime(object value, DateTime defValue)
        {
            try
            {
                if (value == null || value.ToString() == null || value.ToString().Equals(string.Empty))
                    return defValue;

                return Convert.ToDateTime(value);
            }
            catch (InvalidCastException)
            {
                return defValue;
            }
        }

        public static T? ToNullable<T>(object value) where T : struct
        {
            if (value is T)
                return new T?((T)value);

            if (value == null || value is DBNull)
                return new T?();

            try
            {
                if (value is decimal)
                {
                    int strValue = Convert.ToInt32(value);
                    object TempValue = strValue;
                    return new T?((T)TempValue);
                }
                else if (value is string)
                {
                    string strTemp = ToString(value);
                    if (strTemp != null)
                    {
                        int strValue = Convert.ToInt32(value);
                        object TempValue = strValue;
                        return new T?((T)TempValue);
                    }
                }
                else if (value is int)
                {
                    int strValue = Convert.ToInt32(value);
                    object TempValue = strValue;
                    return new T?((T)TempValue);
                }
                else if (value is long)
                {
                    int strValue = Convert.ToInt32(value);
                    object TempValue = strValue;
                    return new T?((T)TempValue);
                }
                return new T?((T)value);
            }
            catch (Exception ex)
            {

                return new T?();
            }
        }

        public static DateTime ToDateTime(object value)
        {
            return ToDateTime(value, default);
        }

        public static string ConvertDateTimeToString(object value)
        {
            try
            {
                if (value == null || value.ToString() == null || value.ToString().Equals(string.Empty))
                {
                    return string.Empty;
                }
                else
                {
                    return Convert.ToDateTime(value).ToShortDateString();
                }
            }
            catch (InvalidCastException)
            {
                return ToDateTime(value, default).ToShortDateString();
            }

        }

        public static T ToEnum<T>(object value, T defVal)
            where T : struct
        {
            try { return ToEnum<T>(value); }
            catch { }

            return defVal;
        }

        public static T ToEnum<T>(object value)
            where T : struct
        {
            string strValue = value + "";
            return (T)Enum.Parse(typeof(T), strValue, true);
        }

        //public static object DbValue<T>(T? value) where T : struct
        //{
        //    return value.HasValue ? value.Value : DBNull.Value;
        //}

        /// <summary>
        /// Return DBNull if value is null
        /// </summary>
        /// <param name="value"></param>
        /// <returns>value or of DBNull</returns>
        /// <remarks>This function will also work with Nullable&ltT&gt</remarks>
        public static object DbValue(object value)
        {
            return value == null ? DBNull.Value : value;
        }
    }
}
