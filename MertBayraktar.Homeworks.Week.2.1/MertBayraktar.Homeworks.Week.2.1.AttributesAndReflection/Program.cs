using System.Reflection;
using MertBayraktar.Homeworks.Week._2._1.AttributesAndReflection;

Product p = new Product();
p.Id = 1;

TableAttribute(p);
ColumnAttribute(p);


static void TableAttribute(object product)
{
    Type type = product.GetType();
    var attr = type.GetCustomAttributes().ToList();

    if (attr.Count > 0)
    {
        foreach (var obj in attr)
        {
            if (obj is TableAttribute)
            {
                var Table = obj as TableAttribute;

                string TableName = Table.Name;
                string[] Letters = new[] { "ı", "İ", "ç", "Ç", "ü", "Ü", "ö", "Ö", "ş", "Ş", "ğ", "Ğ" };

                bool ContainsSpecChar = TableName.Any(x => !char.IsLetterOrDigit(x));
                bool ContainsTrChar = Letters.Any(TableName.Contains);

                if (ContainsSpecChar || ContainsTrChar)
                    Console.WriteLine("Tablo ismi özel veya Türkçe karakter içeremez!");
                else
                    Console.WriteLine("Tablo Adı : " + Table.Name);

            }
        }
    }



}
static void ColumnAttribute(object product)
{
    Type type = product.GetType();

    foreach (PropertyInfo info in type.GetProperties())
    {
        foreach (object item in info.GetCustomAttributes())
        {
            if (item is ColumnAttribute)
            {
                var Column = item as ColumnAttribute;
                Console.WriteLine($"Kolonları : {Column.Name}   Kolon Tipi : {Column.Type}   Zorunluluk : {Column.Required}");

            }
        }

    }
}
