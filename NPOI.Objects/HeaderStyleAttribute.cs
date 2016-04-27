﻿namespace NPOI.Objects
{
    public class HeaderStyleAttribute : StyleAttribute
    {
        public ushort ColumnWidth { get; set; }

        public HeaderStyleAttribute()
        {
            ColumnWidth = 6;
        }
    }
}
