using System;
using System.Data.SqlClient;

namespace _002_StoredFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataModel db = new DataModel())
            {
                //функция будет находить все строки, у которых столбец Price содержит меньшее значение, чем в параметре @price.
                SqlParameter parameter = new SqlParameter("@price", 18000);
                var phone = db.Database.SqlQuery<Phone>("SELECT * FROM GetPhonesByPrice (@price)", parameter);
                foreach (var item in phone)
                {
                    Console.WriteLine("{0}.{1} - {2}", item.Id, item.Name, item.Price);
                }
            }
        }
    }
}
//Скрипт для создания табличной функц.
//CREATE FUNCTION [dbo].[GetPhonesByPrice]
//(
//    @price int
//)
//RETURNS @returntable TABLE
//(
//    Id int,
//    Name nvarchar(50),
//    Price int,
//    CompanyId int
//)
//AS
//BEGIN
//    INSERT @returntable
//    SELECT * FROM Phones WHERE Price < @price
//    RETURN
//END

