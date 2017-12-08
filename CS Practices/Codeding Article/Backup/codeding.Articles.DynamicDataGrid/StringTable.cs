//StringTable.cs

using System;
using System.Collections.Generic;

namespace codeding.Articles.DynamicDataGrid
{
    public class StringTable : Dictionary<int, StringRow>
    {
        public List<string> ColumnNames { get; set; }

        public StringTable()
        {
            ColumnNames = new List<string>();
        }
    }
}
