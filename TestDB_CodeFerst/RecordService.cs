using System;
using System.Collections.Generic;
using System.Linq;

namespace TestDB_CodeFerst
{
    internal class RecordService
    {
        internal static void AddRecord(string content, string status)
        {
            try
            {
                using  DB.MsSqlContext db = new DB.MsSqlContext();
                db.Records.Add( new DB.Record { Content =content,
                Status = status, DateRecord = DateTime.Now,
                });
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal static List<string> GetRecord()
        {
            try
            {
                using DB.MsSqlContext db = new DB.MsSqlContext();
                List<string> rez = new List<string>();
                db.Records.ToList().ForEach(r => rez.Add($"{r.Content},  {r.Status}, {r.DateRecord}"));
                return rez;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}