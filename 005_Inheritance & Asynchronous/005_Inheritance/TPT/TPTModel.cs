using System.ComponentModel.DataAnnotations.Schema;

namespace TPT
{
    using System.Data.Entity;

    public class TPTModel : DbContext
    {
        // Контекст настроен для использования строки подключения "TPTModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "TPT.TPTModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "TPTModel" 
        // в файле конфигурации приложения.
        public TPTModel()
            : base("name=TPTModel")
        {
        }


        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Smartphone> Smartphones { get; set; }
    }

    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
    }

    //Добавление атрибута
    [Table("Smartphones")]
    public class Smartphone : Phone
    {
        public string OS { get; set; }
    }
}