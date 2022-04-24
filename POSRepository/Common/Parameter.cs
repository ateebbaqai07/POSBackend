using System.Data;

namespace POSRepository.Common
{
    public class Parameter
    {
        public Parameter()
        {
            DbType = ParameterDbType.String;
            ParameterDirection = ParameterDirection.Input;
        }

        public string ParameterName { get; set; }
        public object Value { get; set; }
        public ParameterDbType DbType { get; set; }
        public ParameterDirection ParameterDirection { get; set; }
    }

    public enum ParameterDbType
    {

        //DbType
        AnsiString = 0,
        Binary = 1,
        Byte = 2,
        Boolean = 3,
        Currency = 4,
        Date = 5,
        DateTime = 6,
        Decimal = 7,
        Double = 8,
        Guid = 9,
        Int16 = 10,
        Int32 = 11,
        Int64 = 12,
        Object = 13,
        SByte = 14,
        Single = 15,
        String = 16,
        Time = 17,
        UInt16 = 18,
        UInt32 = 19,
        UInt64 = 20,
        VarNumeric = 21,
        AnsiStringFixedLength = 22,
        StringFixedLength = 23,
        Xml = 25,
        DateTime2 = 26,
        DateTimeOffset = 27,

        //Oracle DbType
        BFile = 101,
        Blob = 102,
        //Byte = 103,
        Char = 104,
        Clob = 105,
        //Date = 106,
        //Decimal = 107,
        //Double = 108,
        Long = 109,
        LongRaw = 110,
        //Int16 = 111,
        //Int32 = 112,
        //Int64 = 113,
        IntervalDS = 114,
        IntervalYM = 115,
        NClob = 116,
        NChar = 117,
        NVarchar2 = 119,
        Raw = 120,
        RefCursor = 121,
        //Single = 122,
        TimeStamp = 123,
        TimeStampLTZ = 124,
        TimeStampTZ = 125,
        Varchar2 = 126,
        XmlType = 127,
        BinaryDouble = 132,
        BinaryFloat = 133,
        //Boolean = 134,
    }
}
