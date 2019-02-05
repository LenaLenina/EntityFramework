namespace TPH
{
    using System.Data.Entity;

    public class TPHModel : DbContext
    {
        // Контекст настроен для использования строки подключения "TPHModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "TPH.TPHModel" в экземпляре LocalDb. 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "TPHModel" 
        // в файле конфигурации приложения.
        public TPHModel()
            : base("name=TPHModel")
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

    public class Smartphone : Phone
    {
        public string OS { get; set; }
    }
}