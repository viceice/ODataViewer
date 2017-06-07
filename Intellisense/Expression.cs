using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace DataServicesViewer
{
    public static class Expression
    {
        static Dictionary<string, List<IntellisenseItem>> funcs = new Dictionary<string, List<IntellisenseItem>>();
        static Dictionary<string, List<string>> funcsToolTip = new Dictionary<string, List<string>>();


        public static IntellisenseItem[] LogicalOperators =
            new IntellisenseItem[] 
            { 
                new IntellisenseItem("eq", DSType.Operation, "Equal\n Example: /Customers?filter=City eq 'London'" ), 
                new IntellisenseItem("ne", DSType.Operation, "Not Equal\n Example: /Customers?filter=City ne 'London'"), 
                new IntellisenseItem("gt", DSType.Operation, "Greater than\n Example: /Product?$filter=UnitPrice gt 20"), 
                new IntellisenseItem("gteq", DSType.Operation, "Greater than or equal\n Example: /Orders?$filter=Freight gteq 800"), 
                new IntellisenseItem("lt", DSType.Operation, "Less than\n Example: /Orders?$filter=Freight lt 1"), 
                new IntellisenseItem("lteq", DSType.Operation, "Less than or equal\n Example: /Product?$filter=UnitPrice lteq 20") 
            };

        public static IntellisenseItem[] LogicalGroupOperators = 
            new IntellisenseItem[] 
            { 
                new IntellisenseItem("and",DSType.Operation, "Logical and\n Example: /Product?filter=UnitPrice lteq 20 and UnitPrice gt 10"), 
                new IntellisenseItem("or", DSType.Operation, "Logical or\n Example: /Product?filter=UnitPrice lteq 20 or UnitPrice gt 10"), 
                new IntellisenseItem("not",DSType.Operation, "Logical negation\n Example: /Orders?$ ?$filter=not endswith(ShipPostalCode,'100')") 
            };

        public static IntellisenseItem[] BoolFunc = 
            new IntellisenseItem[] 
            { 
                new IntellisenseItem("contains", DSType.Function , "bool contains(string p0, string p1)"), 
                new IntellisenseItem("endswith", DSType.Function, "bool endswith(string p0, string p1)"), 
                new IntellisenseItem("startswith", DSType.Function, "bool startswith(string p0, string p1)"), 
                new IntellisenseItem("IsOf", DSType.Function, "bool IsOf(type p0)") 
            };





        static Expression()
        {
            InitBoolFuncs();
            InitIntFuncs();
            InitStringFuncs();
        }

        private static void InitBoolFuncs()
        {
            List<IntellisenseItem> boolFunc = new List<IntellisenseItem>();

            boolFunc.Add(new IntellisenseItem("contains( 'string' , 'string' )", DSType.Function));
            boolFunc.Add(new IntellisenseItem("endswith( 'string' , 'string' )", DSType.Function));
            boolFunc.Add(new IntellisenseItem("startswith( 'string' , 'string' )", DSType.Function));
            boolFunc.Add(new IntellisenseItem("isof( 'type' )", DSType.Function));
            boolFunc.Add(new IntellisenseItem("isof( 'expression' , 'type' )", DSType.Function));


            funcs.Add("bool", boolFunc);
        }
        private static void InitIntFuncs()
        {
            List<IntellisenseItem> intFunc = new List<IntellisenseItem>();

            intFunc.Add(new IntellisenseItem("day", DSType.Function   , "int day( DateTime p0 )" ));
            intFunc.Add(new IntellisenseItem("hour", DSType.Function,   "int hour( DateTime p0 )"));
            intFunc.Add(new IntellisenseItem("minute", DSType.Function, "int minute( DateTime p0 )"));
            intFunc.Add(new IntellisenseItem("month", DSType.Function,  "int month( DateTime p0 )"));
            intFunc.Add(new IntellisenseItem("second", DSType.Function, "int second( DateTime p0 )"));
            intFunc.Add(new IntellisenseItem("year", DSType.Function,   "int year( DateTime p0 )"));

            intFunc.Add(new IntellisenseItem("length" , DSType.Function, "int length(string p0)"));
            intFunc.Add(new IntellisenseItem("indexof", DSType.Function, "int indexof(string arg)"));


            funcs.Add("Int32", intFunc);
        }
        private static void InitStringFuncs()
        {
            List<IntellisenseItem> stringFunc = new List<IntellisenseItem>();

            stringFunc.Add(new IntellisenseItem("insert", DSType.Function, "string insert(string p0, int pos, string p1)"));
            stringFunc.Add(new IntellisenseItem("remove", DSType.Function, "string remove(string p0, int pos)"));
            stringFunc.Add(new IntellisenseItem("replace", DSType.Function, "string replace(string p0, string find, string replace)"));
            stringFunc.Add(new IntellisenseItem("substring", DSType.Function, "string substring(string p0, int pos)"));
            stringFunc.Add(new IntellisenseItem("tolower", DSType.Function, "string tolower(string p0)"));
            stringFunc.Add(new IntellisenseItem("toupper", DSType.Function, "string toupper(string p0)"));

            stringFunc.Add(new IntellisenseItem("trim", DSType.Function, "string trim(string p0)"));
            stringFunc.Add(new IntellisenseItem("concat", DSType.Function, "string concat(string p0, string p1)"));


            funcs.Add("String", stringFunc);
        }

        public static List<IntellisenseItem> Funcs(string type)
        {
            if (funcs.ContainsKey(type))
                return funcs[type];

            return new List<IntellisenseItem>();
        }
        public static List<string> FuncsToolTip(string f)
        {
            if (funcsToolTip.ContainsKey(f))
                return funcsToolTip[f];

            return new List<string>();
        }

        public static BitmapSource ToBitmapSource(this System.Drawing.Bitmap bitmap)
        {
            using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
            {
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                stream.Position = 0;

                var result = BitmapFrame.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                result.Freeze();
                return result;
            }
        }
    }
}
