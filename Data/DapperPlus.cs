using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DapperPlus
    {
        public string ConnectionString { get; private set; }
        public string InitialCatalog { get; set; }

        public DapperPlus(string connectionString)
        {
            ConnectionString = connectionString;
        }


        public string SetInitialCatalog(string CatalogName)
        {
            //Maybe TODO maybe i should find and replace exisiting init catalog in connection string ? 
            InitialCatalog = $"Initial Catalog = {CatalogName};";
            ConnectionString = $"{ConnectionString} Initial Catalog = {CatalogName};";
            return $"Initial Catalog has been set to : { CatalogName} ";
        }

        public void CreateDB(string DbName, string ConnectionString)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Execute($"CREATE DATABASE {DbName};");
            }
        }

        /// <summary>
        /// This will use existing connection string which was provided during creation of DapperPlus Instance
        /// </summary>
        /// <param name="DbName"></param>
        public void CreateDB(string DbName)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Execute($"CREATE DATABASE {DbName};");
            }
        }

        public void CreateTable(Type type, string ConnectionString)
        {

            string tbName = type.Name;

            using (var con = new SqlConnection(ConnectionString))
            {

                var props = type.GetProperties();
                var x = props[17].PropertyType.IsEnum;
                var fields = type.GetProperties().Select(f => new { Name = f.Name, type = f.PropertyType.Name }).ToArray();
                var fieldsType = fields.Select(f => f.type).ToList<String>();
                var listOfDbTipes = DbTypeConverter(fieldsType);

                string sFieldNamesAndTypes = "";

                for (int i = 0; i < listOfDbTipes.Count; i++)
                {
                    var fieldDbType = listOfDbTipes.ElementAt(i);
                    var fieldName = fields.ElementAt(i).Name;
                    //(	[Id] [uniqueidentifier] NOT NULL, [FirstName] [nchar](25) NULL, [LastName] [nchar](50) NULL);

                    if (i == 0)
                    {
                        sFieldNamesAndTypes += $"([{ fieldName}] [{ fieldDbType}] NOT NULL, ";
                    }
                    else if (i == listOfDbTipes.Count - 1)
                    {
                        sFieldNamesAndTypes += $"{ fieldName} { fieldDbType}  NULL);";
                    }
                    else
                    {
                        sFieldNamesAndTypes += $"{ fieldName} { fieldDbType}  NULL, ";
                    }

                }
                var query = $"CREATE TABLE {tbName} {sFieldNamesAndTypes}";
                con.Execute(query);


                //CREATE TABLE Persons([Id][uniqueidentifier] NOT NULL,);

            }
        }


        private List<string> DbTypeConverter(List<string> DotNetTypes)
        {

            //TODO ENUMS and NullableTypes
            var returnList = new List<string>();
            foreach (var item in DotNetTypes)
            {
                if (item == "Int16") { returnList.Add("smallint"); }
                if (item == "Int32") { returnList.Add("int"); }
                if (item == "Int64" || item == "UInt32") { returnList.Add("bigint"); }
                if (item == "Guid") { returnList.Add("uniqueidentifier"); }
                if (item == "String") { returnList.Add("nchar (100)"); }
                if (item == "Boolean") { returnList.Add("bit"); }
                if (item == "DateTime") { returnList.Add("datetime2"); }
                if (item == "Decimal") { returnList.Add("decimal(18,2)"); }
                if (item == "Single") { returnList.Add("real"); }
                if (item == "Char") { returnList.Add("nvarchar(1)"); }
                if (item == "Double") { returnList.Add("float"); }
                if (item == "Byte[]") { returnList.Add("varbinary(max)"); }
                if (item == "UInt64") { returnList.Add("decimal(20,0)"); }
                if (item == "Byte") { returnList.Add("tinyint"); }
                //TODO BYTE Array  MyByteArray = table.Column<byte[]>(type: "varbinary(max)", nullable: true),



            }
            return returnList;
        }

    }
}
