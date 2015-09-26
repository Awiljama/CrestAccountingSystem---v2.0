﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace CrestAccountingSystem
{
    public class CrestAccountingModel : DataContext
    {
        private const string CONNECTION_STRING = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CrestAccountingDatabase.mdf;Integrated Security=True";
        public CrestAccountingModel(string connection) : base(connection)
        {
            Connection.ConnectionString = CONNECTION_STRING;
        }
    }
}
