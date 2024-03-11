using Generics;

IntList datas = new IntList();

datas.Add(1);
datas.Add(2);
datas.Add(3);
datas.Add(4);
datas.Add(5);

//var result=datas.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

StringList text = new StringList();

text.Add("salam");
text.Add("sagol");

//var result1 = text.GetAll();

//foreach (var item in result1)
//{
//    Console.WriteLine(item);
//}

DataList<int> data = new DataList<int>();
data.Add(1);
data.Add(5);
data.Add(10);

//var final = data.GetAll();
//foreach (var item in final)
//{
//    Console.WriteLine(item);
//}

DataList<string> names = new DataList<string>();

names.Add("salam");
names.Add("salam");
names.Add("salam");
names.Add("sagol");
names.Delete("salam");
var final = names.GetAll();

foreach (var item in final)
{
    Console.WriteLine(item);
}

DataList<Book> books = new DataList<Book>();

books.Add(new Book { Id = 1, Name = "test1" });
books.Add(new Book { Id = 2, Name = "test2" });
books.Add(new Book { Id = 3, Name = "test3" });
books.GetAll();

//var result = books.GetAll();
//foreach (var item in result)
//{
//    Console.WriteLine(item.Name);
//}