using System;

namespace TestDB_CodeFerst.DB
{
    public class Record
    {
        public int RecordId { get; set; }
        public string Content { get; set; } 
        public  string Status { get; set; }
        public DateTime DateRecord { get; set; }

        public bool IsDeleted { get; set; }
    }
}


