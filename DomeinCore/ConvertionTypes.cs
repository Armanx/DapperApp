using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomeinCore
{
    public class ConvertionTypes : IDomainObject
    {

        public int Id { get; set; }
        public int MyInt { get; set; }

        public int? myIntNullable { get; set; }
        public uint myUint { get; set; }
        public string MyString { get; set; }
        public Byte[] MyByteArray { get; set; }
        public Byte MyByte { get; set; }
        public DateTime myDateTime { get; set; }
        public DateTime? myDateTimeNullable { get; set; }
        public Decimal myDecimal { get; set; }
        public float myFloat { get; set; }
        public char myChar { get; set; }
        public double myDouble { get; set; }

        //public List<int> MyListOfStrings { get; set; }
        //public object myObject { get; set; }

        public long myLong { get; set; }
        public ulong myUlong { get; set; }
        public short myShort { get; set; }
        public ushort myUshort { get; set; }

        public colors MyColor { get; set; }

    }

    public enum colors
    {
        Red = 0,
        Blue = 1,
        Green = 2,
        Yellow = 3
    }
}
