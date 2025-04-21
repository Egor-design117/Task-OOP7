using Microsoft.EntityFrameworkCore;

public class ProductDbContext : DbContext
{
    #region Конструктор
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    #endregion

    #region Public свойство
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(GetProducts());
        base.OnModelCreating(modelBuilder);
    }

    #endregion

    #region методы
    private Product[] GetProducts() => new Product[] {
        new Product{
    ProductID = 1,
    ProductName = "Комплект дисков BBS SR 17x7.5 ET35",
    ProductDescription = "Легкосплавные диски в серебристом цвете с технологией FlowForming для повышенной прочности.",
    ProductPrice = 42990,
    ProductUnit = 5
},

new Product{
    ProductID = 2,
    ProductName = "Комбо-набор Liqui Moly: масло 5W-40 + фильтр",
    ProductDescription = "Синтетическое моторное масло Longtime High Tech и фильтр в подарочной упаковке.",
    ProductPrice = 5990,
    ProductUnit = 18
},

new Product{
    ProductID = 3,
    ProductName = "Коврики в салон WeatherTech DigitalFit",
    ProductDescription = "Точные коврики по контуру салона с высокими бортами для защиты от влаги и грязи.",
    ProductPrice = 12990,
    ProductUnit = 7
},

new Product{
    ProductID = 4,
    ProductName = "Комплект Brembo P06083 (передние тормоза)",
    ProductDescription = "Включает диски и колодки для премиального тормозного комплекта.",
    ProductPrice = 45990,
    ProductUnit = 3
},

new Product{
    ProductID = 5,
    ProductName = "Автохолодильник Dometic CFX3 35",
    ProductDescription = "Портативный холодильник/морозильник на 32 литра с Bluetooth управлением.",
    ProductPrice = 89990,
    ProductUnit = 2
},

new Product{
    ProductID = 6,
    ProductName = "Комплект LED-ламп Philips Ultinon Pro9000",
    ProductDescription = "Мощные LED-лампы головного света с гарантией 5 лет (комплект 2 шт).",
    ProductPrice = 24990,
    ProductUnit = 9
},

new Product{
    ProductID = 7,
    ProductName = "Штатная магнитола Pioneer DMH-Z5350BT",
    ProductDescription = "2DIN мультимедиа с Apple CarPlay, Android Auto и 6.8-дюймовым экраном.",
    ProductPrice = 32990,
    ProductUnit = 4
}



    };
    #endregion
}