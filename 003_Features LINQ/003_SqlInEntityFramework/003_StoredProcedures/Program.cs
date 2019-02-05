using System;
using System.Data.SqlClient;

namespace _003_StoredProcedures
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataModel db = new DataModel())
            {
                //Данная процедура ищет все строки, где значение столбца название компании равно строке, переданной через параметр @param.
                SqlParameter parameter = new SqlParameter("@param","Samsung");
                var phones = db.Database.SqlQuery<Phone>("GetPhonesByCompany @param", parameter);
                foreach (var item in phones)
                {
                    Console.WriteLine("{0}.{1} - {2}", item.Id, item.Name, item.Price);
                }
            }
        }
    }
}
//Процедура SQL
//CREATE PROCEDURE [dbo].[GetPhonesByCompany]
//    @name nvarchar(50) 
//AS
//    SELECT * FROM Phones 
//    WHERE CompanyId=(SELECT Id FROM Companies WHERE Name=@name)
//GO

