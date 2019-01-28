using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace formulageneral
{
    //ironicamnete cree esta clase para no repetir tanto codigo, pero no me di cuenta que tenia que guardar los cambios en dbrowser para que se guardara mis tablas y ya no quise usar esto o guardarlo
    //pero si funciona esta clase
    class DB
    {
        public SQLiteConnection myconnect;
       public DB()
        {
            myconnect = new SQLiteConnection("Data Source= registros.sqlite3");

        }
        public void create()
        {
            if (!File.Exists("./registros.sqlite3"))
            {
                SQLiteConnection.CreateFile("registros.sqlite3");

            }
        }
        public void open()
        {
            if(myconnect.State != System.Data.ConnectionState.Open)
            {
                myconnect.Open();
            }
        }
        public void close()
        {
            if(myconnect.State != System.Data.ConnectionState.Closed)
            {
                myconnect.Clone();
            }
        }
     

    }
}
