﻿using System;
using System.ComponentModel.Design;
using ADO.NET.Settings.Connect_and_Submit_Sql_To_Db;

namespace ADO.NET
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ADO.NET Wizard");
            Console.WriteLine("================================");
            Console.WriteLine("Choose one of the following options");
            Console.WriteLine("1.get database infrom from connection string");
            Console.WriteLine("2.connect db with errors");
            Console.WriteLine("3.get a rows affected in select query using executescaler");
            Console.WriteLine("4.rows affected for insert country");
            Console.WriteLine("5.rows affected for Get country using parameters");
            Console.WriteLine("6.rows affected for insert country using parameters");
            Console.WriteLine("7.rows affected for insert country using parameters and get output parameter");
            Console.WriteLine("8.rows affected for insert country,state using parameters with rollbackable transaction");
            Console.WriteLine("==============================Read Tables using SQL DATA READER================================");
            Console.WriteLine("9.Get Countries As DataReader"); 
            Console.WriteLine("10.Get Countries As Generic List"); 
                Console.WriteLine("11.Get Countries As GenericList Using GetFieldValue which wont work for nullable types");
            Console.WriteLine("12.Get Countries As GenericList Using custom GetFieldValue which work for nullable types");
            Console.WriteLine("13.Get Multiple Result Sets");
            Console.WriteLine("============================Exceptions=========================");
                Console.WriteLine("14:Simple exception");
            Console.WriteLine("15.catch useful exception details"); 
                Console.WriteLine("16.Gather All Exception Information");
            Console.WriteLine("============================DataTable=========================");
            Console.WriteLine("17.Get Countries As DataTable");
            Console.WriteLine("18.Get Countries As Generic List");//can be used to return a the whole table as a list without object mapping
            Console.WriteLine("19.Get Multiple Result Sets Using DataSet"); 
            string optionSelected = Console.ReadLine();

            switch (Convert.ToInt32(optionSelected))
            {
                case 1:
                    Console.Write("enter connection string:");
                    string connectionString = Console.ReadLine();
                    //string result=Connection.Connect(connectionString);
                    string result1 = Connection.ConnectUsingBlock(connectionString);
                    Console.WriteLine(result1);
                    break;

                case 2:
                    Console.Write("using invalid connection string");
                    string result2 = Connection.ConnectWithErrors();
                    Console.WriteLine(result2);
                    break;
                case 3:
                    Console.WriteLine("SQL: SELECT COUNT(*) FROM Country");
                    int result3 = Command.GetCountryTableCountScalar();
                    Console.WriteLine("Rows Affected: "+result3.ToString());
                    break;
                case 4:
                    Command.InsertCountry();
                    break;
                case 5:
                    Command.GetCountryCountScalarUsingParameters();
                    break;
                case 6:
                    Command.InsertCountryUsingParameters();
                    break;
                case 7:
                    Command.InsertCountryOutputParameter(); 
                    break;
                case 8:
                    Command.TransactionProcessing(); 
                    break;
                case 9:
                    DataReader.GetCountriesAsDataReader();
                    break;
                case 10:
                    DataReader.GetCountriesAsGenericList();
                    break;
                case 11:
                    DataReader.GetCountriesAsGenericListUsingGetFieldValue();
                    break;
                case 12:
                    DataReader.GetCountriesAsGenericListUsingCustomGetFieldValue();
                    break;
                case 13:
                    DataReader.GetMultipleResultSets();
                    break;
                case 14:
                    Exceptions.SimpleExceptionHandling();
                    break;
                case 15:
                    Exceptions.CatchException(); 
                    break;
                case 16:
                    Exceptions.GatherExceptionInformation(); 
                    break;
                case 17:
                    DataTables d = new DataTables();
                    d.GetCountriesAsDataTable();
                    break;
                case 18:
                    DataTables d1 = new DataTables();
                    d1.GetCountriesAsGenericList();
                    break;
                case 19:
                    DataTables d2 = new DataTables();
                    d2.GetMultipleResultSetsUsingDataSet();
                    break;
                    
            }
            Console.ReadKey();

        }
    }
}
