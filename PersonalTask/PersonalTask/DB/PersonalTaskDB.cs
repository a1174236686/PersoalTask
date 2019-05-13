using PersonalTask.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTask.DB
{
    class PersonalTaskDB : DbContext
    {
        public PersonalTaskDB()
            : base(new SQLiteConnection(@"Data Source=" + Application.StartupPath + @"\db\Database.sqlite;Version=3;"), false)
        {
            if (!File.Exists(Application.StartupPath + @"\db\Database.sqlite"))
            {
                File.Copy(Application.StartupPath + @"\db\DbBack\Database.sqlite", Application.StartupPath + @"\db\Database.sqlite");
            }            
        }


        /// <summary> 个人任务表
        /// 
        /// </summary>
        public DbSet<tTask> tTask { get; set; }
    }
}
