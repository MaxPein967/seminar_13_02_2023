// ## Условные операторы
// ### Оператор if
Console.WriteLine("## Условные операторы");
Console.WriteLine("### Оператор if");

int n1 = 9;
int n2 = 12;
if (n1 < n2)
{
    Console.WriteLine($"Число {n1} меньше числа {n2}");
}

int n3 = 15;
int n4 = 12;
if (n3 < n4)
{
    Console.WriteLine($"Число {n3} меньше числа {n4}");
}
else
{
    Console.WriteLine($"Число {n3} больше числа {n4}");
}

int n5 = 13;
int n6 = 12;
if (n5 < n6)
{
    Console.WriteLine($"Число {n5} меньше числа {n6}");
}
else if (n5 > n6)
{
    Console.WriteLine($"Число {n5} больше числа {n6}");
}
else
{
    Console.WriteLine($"Число {n5} равно числу {n6}");
}

// ### Оператор switch            
Console.WriteLine("### Оператор switch");
int n7 = 1;
switch (n7)
{
    case 1: Console.WriteLine("Case 1"); break;
    case 2: Console.WriteLine("Case 2"); break;
    default: Console.WriteLine("Default case"); break;
}

// #### Шаблон константы          
Console.WriteLine("#### Шаблон константы");
string s1 = "Three";
switch (s1.ToLower())
{
    case "one": Console.WriteLine("Case one"); break;
    case "two": Console.WriteLine("Case two"); break;
    case "three": Console.WriteLine("Case three"); break;
    case "four": Console.WriteLine("Case four"); break;
    case "five": Console.WriteLine("Case five"); break;
    default: Console.WriteLine("Default case"); break;
}

// #### Шаблон типа          
Console.WriteLine("#### Шаблон типа");
object trans = new Moto() { Name = "Suzuki" };
switch (trans)
{
    case Bicycle bicycle: Console.WriteLine($"Bicycle: {bicycle.Name}"); break;
    case Moto moto: Console.WriteLine($"Moto: {moto.Name}"); break;
    case Car car: Console.WriteLine($"Car {car.Name}"); break;
    case Transport transport: Console.WriteLine($"Transport {transport.Name}"); break;
    case null: Console.WriteLine("Transport is null!"); break;
}

// #### Выражение с ключевым словом when        
Console.WriteLine("#### Выражение с ключевым словом when");
object bc = new Bicycle() { Name = "Trec", WheelsCount = 1 };
switch (bc)
{
    case Bicycle bicycle when bicycle.WheelsCount == 1: Console.WriteLine($"Bicycle: {bicycle.Name}, type - monocycle"); break;
    case Bicycle bicycle when bicycle.WheelsCount == 2: Console.WriteLine($"Bicycle: {bicycle.Name}, type - classic"); break;
    case Bicycle bicycle when bicycle.WheelsCount == 3: Console.WriteLine($"Bicycle: {bicycle.Name}, type - tricycle"); break;
    case Moto moto: Console.WriteLine($"Moto: {moto.Name}"); break;
    case Car car: Console.WriteLine($"Car {car.Name}"); break;
    case Transport transport: Console.WriteLine($"Transport {transport.Name}"); break;
    case null: Console.WriteLine("Transport is null!"); break;
}

// ### Тернарный оператор     
Console.WriteLine("### Тернарный оператор");
int n8 = 5;
int n9 = 8;
int largerNumber = n8 > n9 ? n8 : n9;

// ## Циклы
// ### Цикл for
Console.WriteLine("## Циклы");
Console.WriteLine("### Цикл for");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Квадрат числа {i} = {i * i}");
}

// ### Циклы while и do/while
Console.WriteLine("### Циклы while и do/while");
Console.WriteLine("-> Цикл while");
int index1 = 0;
int n10 = 3;
while (index1 <= n10)
{
    Console.WriteLine($"Итерация цикла номер {index1}");
    index1++;
}

Console.WriteLine("-> Цикл do while");
int index2 = 0;
int n11 = 3;
do
{
    Console.WriteLine($"Итерация цикла номер {index2}");
    index2++;
} while (index2 > n11);

// ### Цикл foreach
Console.WriteLine("### Цикл foreach");
int[] nums = { 6, 3, 6, 8, 9, 12, 4, 5, 88, 54, 3, 66, 78, 10, 12, 5, 7, 9, 3, 5 };
int result = 0;
foreach (int n in nums)
{
    if (n > 10)
    {
        result++;
    }
}
Console.WriteLine($"Количество чисел в массиве больше 10: {result}");

result = 0;
foreach (var n in nums)
{
    if (n < 10)
    {
        result++;
    }
}
Console.WriteLine($"Количество чисел в массиве меньше 10: {result}");

// ### Операторы перехода
Console.WriteLine("### Операторы перехода");
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > 10)
    {
        Console.WriteLine($"{nums[i]} > 10");
        continue;
    }
    if (i > 7)
    {
        Console.WriteLine("Break cycle");
        break;
    }
}

// ### LINQ как инструмент обхода коллекций
Console.WriteLine("### LINQ как инструмент обхода коллекций");

var evenSq = new List<int>();
foreach (var n in nums)
{
    if (n % 2 == 0)
    {
        evenSq.Add(n * n);
    }
}
foreach (var n in evenSq)
{
    Console.Write($"{n} ");
}
Console.WriteLine();

evenSq = nums
            .Where(v => v % 2 == 0)
            .Select(v => v * v)
            .ToList();

foreach (var n in evenSq)
{
    Console.Write($"{n} ");
}
Console.WriteLine();

var arr1 = nums.Where(v => v > 10).ToList(); // Take elements thats higher then 10
var arr2 = nums.Select(v => v - 7).ToList(); // Sub 7 from every elements
var arr3 = nums.Select(v => v % 2 == 0).ToList();

// Football example
var teams = CreateList();
var selectedTeams = from team in teams          // определяем каждый элемент из teams как team
                    where team.PlaceGroup == 1  // фильтрация по критерию PlaceGroup == 1
                    orderby team.Name           // упорядочиваем по имени
                    select team;                // выбираем объект

foreach (var team in selectedTeams)
{
    Console.WriteLine(team.Name + " " + team.NumberpointsScored);
}


private static List<FootballTeam> CreateList()
{
    return new List<FootballTeam>
            {
                { new FootballTeam() { Name="Zenit", Country="Russia", Group= 1, PlaceGroup= 3, NumberpointsScored = 3}},
                { new FootballTeam() { Name="Ajax", Country="Holand", Group= 1, PlaceGroup= 2, NumberpointsScored = 4}},
                { new FootballTeam() { Name="Manchester United", Country="England", Group= 1, PlaceGroup= 1, NumberpointsScored = 6}},
                { new FootballTeam() { Name="Bavaria", Country="Germany", Group= 2, PlaceGroup= 1, NumberpointsScored = 8}},
                { new FootballTeam() { Name="Spartak", Country="Russia", Group= 2, PlaceGroup= 2, NumberpointsScored= 6}},
                { new FootballTeam() { Name="Real", Country="Italy", Group= 2, PlaceGroup= 3, NumberpointsScored = 3}},
                { new FootballTeam() { Name="Arsenal", Country="England", Group= 3, PlaceGroup= 2, NumberpointsScored = 9}},
                { new FootballTeam() { Name="Shakter", Country="Ukrane", Group=3, PlaceGroup= 3, NumberpointsScored = 6}},
                { new FootballTeam() { Name="Barselona", Country="Espane", Group= 3, PlaceGroup= 1, NumberpointsScored = 12}}
            };
}


public class FootballTeam
{
    public string Name { get; set; }
    public string Country { get; set; }
    public int Group { get; set; }
    public int PlaceGroup { get; set; }
    public int NumberpointsScored { get; set; }
}


class Transport
{
    public string Name { get; set; }
    public int WheelsCount { get; set; }
}
class Bicycle : Transport { }
class Moto : Transport { }
class Car : Transport { }


// ## Работа с переменными типа перечисления
Console.WriteLine("## Работа с переменными типа перечисления");

WeekDay wd;
int dayNum;
wd = WeekDay.Friday;
Console.WriteLine($"Пример дня недели: {wd}");

dayNum = (int)wd;
Console.WriteLine($"{wd} идет в перечислении под номером {dayNum}");

wd -= 3;
dayNum = (int)wd;
Console.WriteLine($"{wd} идет в перечислении под номером {dayNum}");

WorkAtDay(WeekDay.Monday);
WorkAtDay(WeekDay.Friday);
WorkAtDay((WeekDay)3);
WorkAtDay(WeekDay.Sunday);

Console.WriteLine();

// ## Тип System.Enum
Console.WriteLine("## Тип System.Enum");
// ### Определение типа элемента перечисления
Console.WriteLine("### Определение типа элемента перечисления");
Console.WriteLine($"Тип элемента Season.Spring: {Season.Spring.GetType()}");
Console.WriteLine($"Базовый тип элемента Season.Spring: {Enum.GetUnderlyingType(Season.Spring.GetType())}");
Console.WriteLine();

// ### Конвертация числа в константу перечисления
Console.WriteLine("### Конвертация числа в константу перечисления");
Type enumType = Season.Spring.GetType();
int n1 = 3;
int n2 = 0;
Console.WriteLine($"Преобразование числа {n1} в перечисление Season: {Enum.ToObject(enumType, n1)}");
Console.WriteLine($"Преобразование числа {n2} в перечисление Season: {Enum.ToObject(enumType, n2)}");

int n3 = 5;
Console.WriteLine($"Преобразование числа {n3} в перечисление Season {Enum.ToObject(enumType, n3)}");
Console.WriteLine();

// ### Проверка наличия целочисленного (или строкового) значения в заданном перечислении
Console.WriteLine("### Проверка наличия целочисленного (или строкового) значения в заданном перечислении");
int n4 = 5;
Console.WriteLine($"Существует ли элемент под номером {n4} в перечислении: {Enum.IsDefined(enumType, n4)}");
Console.WriteLine();

// ### Форматированное строковое представление значения перечисления
Console.WriteLine("### Форматированное строковое представление значения перечисления");
var season = Season.Winter;
Console.WriteLine($"Численное значение времени года {season}: {Enum.Format(typeof(Season), season, "d")}.");
Console.WriteLine($"Значение в формате hex времени года {season}: {Enum.Format(typeof(Season), season, "x")}.");
Console.WriteLine();

// ### Преобразование строки или числа в значение перечисления
Console.WriteLine("### Преобразование строки или числа в значение перечисления");
string[] arr = { "5", "0", "3", "Autumn", "Summer, Winter" };
foreach (var strVal in arr)
{
    var seasonVal = (Season)Enum.Parse(typeof(Season), strVal, true);
    Console.WriteLine($"Преобразовали \"{strVal}\" в {seasonVal}");
}
Console.WriteLine();

// ### Получение имен элементов перечисления их численных значений в виде массивов
Console.WriteLine("### Получение имен элементов перечисления их численных значений в виде массивов");
Console.WriteLine("Элементы перечисления Season:");
foreach (string s in Enum.GetNames(typeof(Season)))
{
    Console.WriteLine(s);
}
Console.WriteLine("Численные значения элементов перечисления Season:");
foreach (int s in Enum.GetValues(typeof(Season)))
{
    Console.WriteLine(s);
}

// ## Битовые флаги
Console.WriteLine("## Битовые флаги");

Mounts summerMount = Mounts.June | Mounts.July | Mounts.August;
Console.WriteLine($"Летние месяцы: {summerMount}");
Mounts secondSemester = summerMount | Mounts.September | Mounts.October | Mounts.November;
Console.WriteLine($"Осенние месяцы: {summerMount ^ secondSemester}");
        }

        static void WorkAtDay(WeekDay wd)
{
    switch (wd)
    {
        case WeekDay.Monday:
            Console.WriteLine($"{wd} - Физкультура");
            break;
        case WeekDay.Friday:
            Console.WriteLine($"{wd} - Литература");
            break;
        case WeekDay.Wednesday:
            Console.WriteLine($"{wd} - Математика");
            break;
        default:
            Console.WriteLine($"{wd} - День отдыха");
            break;
    }
}