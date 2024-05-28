
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.Models;

namespace MauiApp1.DataTransactions
{
    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection conn;

        public DBTrans(string dbPath)
        {
            this.dbPath = dbPath;
            Init();
        }
        public void Init()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<Assignment>();
            conn.CreateTable<Child>();
            conn.CreateTable<Parent>();
        }

        public List<Assignment> GetAssignments()
        {
            return conn.Table<Assignment>().ToList();
        }
        public List<Child> GetChilds()
        {
            return conn.Table<Child>().ToList();
        }

        public List<Parent> GetParents()
        {

            return conn.Table<Parent>().ToList();
        }

        public void AddAssignment(Assignment assi)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(assi);
        }
        public void AddChild(Child chi)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(chi);
        }
        public void AddParent(Parent par)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(par);
        }
        public void DeleteAssignment(int assi_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Assignment { A_ID = assi_ID });
        }
        public void DeleteChild(int chi_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Child { C_ID = chi_ID });
        }
        public void DeleteParent(int Parent_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Parent { P_ID = Parent_ID });
        }
    }
}
