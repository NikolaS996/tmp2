﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MessageUtil.DataAccess
{
    public static class DBFunctions
    {
        //Staticka klasa koja sadrzi sve zajednicke funkcije mikroservisa

        public static readonly string ConnectionString = "Data Source=147.91.175.176;" +
                                                "Initial Catalog=URIS2018_G4_M6;" +
                                                "Persist Security Info=True;" +
                                                "User ID=URIS2018_G4_M6;" +
                                                "Password=masazeri2015;" +
                                                "MultipleActiveResultSets=True;";
        //public static string ConnectionString = "Data Source=147.91.175.176;" +
        //                                        "Initial Catalog=it49g2015;" +
        //                                        "Persist Security Info=True;" +
        //                                        "User ID=it49g2015;" +
        //                                        "Password=ftnftn2015;" +
        //                                        "MultipleActiveResultSets=True;";
    }
}
