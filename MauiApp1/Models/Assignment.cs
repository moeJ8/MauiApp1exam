using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class Assignment
    {
        [PrimaryKey,AutoIncrement]
        public int A_ID { get; set; }
        public int C_ID { get; set; }
        public int  P_ID { get; set; }
    }
}
