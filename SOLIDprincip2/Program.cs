using SOLIDprincip;
using SOLIDprincip2;
using System.Text;

var enc65001 = Encoding.GetEncoding(65001);
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = enc65001;

CookNotRight bob = new CookNotRight("Bob");
bob.MakeDinner();
Console.WriteLine();
Console.WriteLine("Новый вариант");
CookRight bobi = new CookRight("Bob");
bobi.MakeDinner(new PotatoMeal());
Console.WriteLine();
bobi.MakeDinner(new SaladMeal());
//Теперь класс Cook закрыт от изменений, зато мы можем легко расширить его функциональность,
//определив дополнительные реализации интерфейса IMeal