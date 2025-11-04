using System;
using System.IO;
using System.Text.RegularExpressions;

//          Раздел 1: Основы ООП


// Задание 1
//class Animal
//{
//    public void MakeSound()
//    {
//        Console.WriteLine("Some sound");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Animal animal = new Animal();
//        animal.MakeSound(); // Выведет: Some sound
//    }
//}

// Задание 2
//class Car
//{
//    public string Brand { get; set; }
//    public string Model { get; set; }
//    public int Year { get; set; }

//    public Car(string brand, string model, int year)
//    {
//        Brand = brand;
//        Model = model;
//        Year = year;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Car car = new Car("Toyota", "Camry", 2020);
//        Console.WriteLine($"{car.Brand} {car.Model} {car.Year}");
//    }
//}

// Задание 3
//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person person = new Person("Анна", 25);
//        Console.WriteLine($"Имя: {person.Name}, Возраст: {person.Age}");
//    }
//}

// Задание 4
//class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public double Area()
//    {
//        return Width * Height;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Rectangle rect = new Rectangle(5, 3);
//        Console.WriteLine($"Площадь: {rect.Area()}");
//    }
//}

// Задание 5
// Класс - это шаблон, определяющий структуру данных
//class Student
//{
//    public string Name;
//    public int Age;
//    public double GPA;
//}

//class Program
//{
//    static void Main()
//    {
//        // Объект - это конкретный экземпляр класса
//        Student student1 = new Student();
//        student1.Name = "Иван";
//        student1.Age = 18;
//        student1.GPA = 4.5;

//        // Другой объект того же класса
//        Student student2 = new Student();
//        student2.Name = "Мария";
//        student2.Age = 19;
//        student2.GPA = 4.8;

//        Console.WriteLine($"Студент 1: {student1.Name}, возраст: {student1.Age}, GPA: {student1.GPA}");
//        Console.WriteLine($"Студент 2: {student2.Name}, возраст: {student2.Age}, GPA: {student2.GPA}");
//    }
//}

// Задание 6
//class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }
//    public int Pages { get; set; }

//    public Book(string title, string author, int pages)
//    {
//        Title = title;
//        Author = author;
//        Pages = pages;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Book book = new Book("1984", "Джордж Оруэлл", 328);
//        Console.WriteLine($"Книга: {book.Title}, Автор: {book.Author}, Страниц: {book.Pages}");
//    }
//}

// Задание 7
//class Circle
//{
//    public double Radius { get; set; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    public double Area()
//    {
//        return Math.PI * Radius * Radius;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Circle circle = new Circle(5);
//        Console.WriteLine($"Площадь круга: {circle.Area():F2}");
//    }
//}

// Задание 8
//class BankAccount
//{
//    public decimal Balance { get; private set; }

//    public BankAccount(decimal initialBalance = 0)
//    {
//        Balance = initialBalance;
//    }

//    public void Deposit(decimal amount)
//    {
//        if (amount > 0) Balance += amount;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount account = new BankAccount(1000);
//        account.Deposit(500);
//        Console.WriteLine($"Баланс: {account.Balance}");
//    }
//}

// Задание 9
//class Temperature
//{
//    public double Celsius { get; set; }

//    public Temperature(double celsius)
//    {
//        Celsius = celsius;
//    }

//    public double ToFahrenheit()
//    {
//        return (Celsius * 9.0 / 5.0) + 32;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Temperature temp = new Temperature(25);
//        Console.WriteLine($"25°C = {temp.ToFahrenheit():F1}°F");
//    }
//}

// Задание 10
//class Time
//{
//    public int Hours { get; set; }
//    public int Minutes { get; set; }
//    public int Seconds { get; set; }

//    public Time(int hours, int minutes, int seconds)
//    {
//        Hours = hours;
//        Minutes = minutes;
//        Seconds = seconds;
//    }

//    public override string ToString()
//    {
//        return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Time time = new Time(14, 5, 30);
//        Console.WriteLine($"Время: {time}");
//    }
//}

// Задание 11
//class Point
//{
//    public double X { get; set; }
//    public double Y { get; set; }

//    public Point(double x, double y)
//    {
//        X = x;
//        Y = y;
//    }

//    public double DistanceTo(Point other)
//    {
//        return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Point p1 = new Point(0, 0);
//        Point p2 = new Point(3, 4);
//        Console.WriteLine($"Расстояние: {p1.DistanceTo(p2)}"); // 5
//    }
//}

// Задание 12
//class Color
//{
//    public byte R { get; set; }
//    public byte G { get; set; }
//    public byte B { get; set; }

//    public Color(byte r, byte g, byte b)
//    {
//        R = r; G = g; B = b;
//    }

//    public string ToHex()
//    {
//        return $"#{R:X2}{G:X2}{B:X2}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Color color = new Color(255, 105, 180);
//        Console.WriteLine($"Цвет в HEX: {color.ToHex()}");
//    }
//}

// Задание 13
//class Email
//{
//    public string Address { get; set; }

//    public Email(string address)
//    {
//        Address = address;
//    }

//    public bool IsValid()
//    {
//        return Regex.IsMatch(Address, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Email email = new Email("user@example.com");
//        Console.WriteLine($"Email валиден: {email.IsValid()}"); // True
//    }
//}

// Задание 14
//class PhoneNumber
//{
//    public string Number { get; set; }

//    public PhoneNumber(string number)
//    {
//        Number = number;
//    }

//    public string Format()
//    {
//        string digits = Regex.Replace(Number, @"[^\d]", "");
//        if (digits.Length == 11 && digits.StartsWith("7")) digits = digits.Substring(1);
//        if (digits.Length != 10) return Number;

//        return $"+7 ({digits.Substring(0, 3)}) {digits.Substring(3, 3)}-{digits.Substring(6, 2)}-{digits.Substring(8)}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        PhoneNumber phone = new PhoneNumber("+7 (999) 123-45-67");
//        Console.WriteLine($"Форматированный номер: {phone.Format()}");
//    }
//}

// Задание 15
//class URL
//{
//    public string FullUrl { get; set; }

//    public URL(string url)
//    {
//        FullUrl = url;
//    }

//    public string GetDomain()
//    {
//        Uri uri;
//        if (Uri.TryCreate(FullUrl.StartsWith("http") ? FullUrl : "http://" + FullUrl, UriKind.Absolute, out uri))
//            return uri.Host;
//        return "Некорректный URL";
//    }

//    public bool IsHttps()
//    {
//        return FullUrl.StartsWith("https://", StringComparison.OrdinalIgnoreCase);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        URL url = new URL("https://example.com/path?query=1");
//        Console.WriteLine($"Домен: {url.GetDomain()}");
//        Console.WriteLine($"HTTPS: {url.IsHttps()}");
//    }
//}


//             Раздел 2: Классы и Объекты


// Задание 16
//class Dog
//{
//    public string Name { get; set; }

//    public Dog(string name)
//    {
//        Name = name;
//    }

//    public void Bark()
//    {
//        Console.WriteLine($"{Name} говорит: Гав-гав!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Dog dog = new Dog("Рекс");
//        dog.Bark();
//    }
//}

// Задание 17
//class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }

//    public double CalculateArea()
//    {
//        return Width * Height;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Rectangle rect = new Rectangle(4, 5);
//        Console.WriteLine($"Площадь: {rect.CalculateArea()}"); // Выведет: Площадь: 20
//    }
//}

//Задание 18
//class Triangle
//{
//    public double A { get; set; }
//    public double B { get; set; }
//    public double C { get; set; }

//    public Triangle(double a, double b, double c)
//    {
//        A = a;
//        B = b;
//        C = c;
//    }

//    public void ShowSides()
//    {
//        Console.WriteLine($"Стороны треугольника: {A}, {B}, {C}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Triangle tri = new Triangle(3, 4, 5);
//        tri.ShowSides(); // Выведет: Стороны треугольника: 3, 4, 5
//    }
//}

//Задание 19
//class Employee
//{
//    public string Name { get; set; }
//    public decimal Salary { get; set; }

//    public Employee(string name, decimal salary)
//    {
//        Name = name;
//        Salary = salary;
//    }

//    public void ShowInfo()
//    {
//        Console.WriteLine($"Сотрудник: {Name}, Зарплата: {Salary}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee emp = new Employee("Анна", 75000);
//        emp.ShowInfo(); // Выведет: Сотрудник: Анна, Зарплата: 75000
//    }
//}

//Задание 20
//class Product
//{
//    public string Title { get; set; }
//    public decimal Price { get; set; }
//    public int Quantity { get; set; }

//    public Product(string title, decimal price, int quantity)
//    {
//        Title = title;
//        Price = price;
//        Quantity = quantity;
//    }

//    public void ShowProduct()
//    {
//        Console.WriteLine($"Товар: {Title}, Цена: {Price}, Кол-во: {Quantity}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Product prod = new Product("Яблоки", 99.90m, 50);
//        prod.ShowProduct();
//    }
//}

//Задание 21
//class Student
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public double GPA { get; set; }

//    public Student(string name, int age, double gpa)
//    {
//        Name = name;
//        Age = age;
//        GPA = gpa;
//    }

//    public void ShowStudent()
//    {
//        Console.WriteLine($"Студент: {Name}, Возраст: {Age}, GPA: {GPA}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student stu = new Student("Мария", 20, 4.8);
//        stu.ShowStudent();
//    }
//}

//Задание 22
//class House
//{
//    public int Rooms { get; set; }
//    public double Area { get; set; }

//    public House(int rooms, double area)
//    {
//        Rooms = rooms;
//        Area = area;
//    }

//    public void ShowHouse()
//    {
//        Console.WriteLine($"Дом: {Rooms} комнат, площадь {Area} м²");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        House house = new House(4, 120.5);
//        house.ShowHouse();
//    }
//}

//Задание 23
//class Account
//{
//    public string Number { get; set; }
//    public decimal Balance { get; set; }

//    public Account(string number, decimal balance = 0)
//    {
//        Number = number;
//        Balance = balance;
//    }

//    public void ShowBalance()
//    {
//        Console.WriteLine($"Счёт {Number}: баланс {Balance} руб.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Account acc = new Account("12345-678", 15000);
//        acc.ShowBalance();
//    }
//}


//Задание 24
//class Bicycle
//{
//    public int Gears { get; set; }

//    public Bicycle(int gears)
//    {
//        Gears = gears;
//    }

//    public void ShowGears()
//    {
//        Console.WriteLine($"Велосипед с {Gears} передачами");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Bicycle bike = new Bicycle(21);
//        bike.ShowGears();
//    }
//}

//Задание 25
//class Computer
//{
//    public string Processor { get; set; }
//    public int RAM { get; set; }

//    public Computer(string processor, int ram)
//    {
//        Processor = processor;
//        RAM = ram;
//    }

//    public void ShowSpecs()
//    {
//        Console.WriteLine($"Компьютер: {Processor}, ОЗУ: {RAM} ГБ");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Computer pc = new Computer("Intel i7", 16);
//        pc.ShowSpecs();
//    }
//}

//Задание 26
//class Flower
//{
//    public string Name { get; set; }
//    public string Color { get; set; }

//    public Flower(string name, string color)
//    {
//        Name = name;
//        Color = color;
//    }

//    public void ShowFlower()
//    {
//        Console.WriteLine($"Цветок: {Name}, цвет: {Color}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Flower flower = new Flower("Роза", "красный");
//        flower.ShowFlower();
//    }
//}

//Задание 27
//class Laptop
//{
//    public double Screen { get; set; }
//    public int Battery { get; set; }

//    public Laptop(double screen, int battery)
//    {
//        Screen = screen;
//        Battery = battery;
//    }

//    public void ShowLaptop()
//    {
//        Console.WriteLine($"Ноутбук: экран {Screen}\", батарея {Battery} мАч");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Laptop lap = new Laptop(15.6, 5000);
//        lap.ShowLaptop();
//    }
//}

//Задание 28
//class Pen
//{
//    public string Color { get; set; }

//    public Pen(string color)
//    {
//        Color = color;
//    }

//    public void Write()
//    {
//        Console.WriteLine($"Ручка пишет {Color} цветом");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Pen pen = new Pen("синим");
//        pen.Write();
//    }
//}

//Задание 29
//class CoffeeCup
//{
//    public double Volume { get; set; }

//    public CoffeeCup(double volume)
//    {
//        Volume = volume;
//    }

//    public void Drink()
//    {
//        Console.WriteLine($"Пью кофе из кружки на {Volume} мл");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        CoffeeCup cup = new CoffeeCup(300);
//        cup.Drink();
//    }
//}

//Задание 30
//class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }
//    public int Year { get; set; }

//    public Book(string title, string author, int year)
//    {
//        Title = title;
//        Author = author;
//        Year = year;
//    }

//    public void ShowBook()
//    {
//        Console.WriteLine($"Книга: \"{Title}\" — {Author}, {Year}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Book book = new Book("Война и мир", "Лев Толстой", 1869);
//        book.ShowBook();
//    }
//}


//                    Раздел 3: Члены Класса


// Задание 31
//class Calculator
//{
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Calculator calc = new Calculator();
//        Console.WriteLine($"31. 5 + 3 = {calc.Add(5, 3)}");
//    }
//}

// Задание 32
//class StringHelper
//{
//    public string Reverse(string s)
//    {
//        char[] arr = s.ToCharArray();
//        Array.Reverse(arr);
//        return new string(arr);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        StringHelper helper = new StringHelper();
//        Console.WriteLine($"32. Reverse('hello') = {helper.Reverse("hello")}");
//    }
//}

// Задание 33
//class MathHelper
//{
//    public int Max(int a, int b)
//    {
//        return a > b ? a : b;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        MathHelper mh = new MathHelper();
//        Console.WriteLine($"33. Max(10, 7) = {mh.Max(10, 7)}");
//    }
//}

//// Задание 34
//class Temperature
//{
//    public double CelsiusToFahrenheit(double c)
//    {
//        return c * 9.0 / 5.0 + 32;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Temperature temp = new Temperature();
//        Console.WriteLine($"34. 25°C = {temp.CelsiusToFahrenheit(25)}°F");
//    }
//}

//// Задание 35
//class LengthConverter
//{
//    public double MetersToFeet(double meters)
//    {
//        return meters * 3.28084;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        LengthConverter lc = new LengthConverter();
//        Console.WriteLine($"35. 10 м = {lc.MetersToFeet(10):F2} футов");
//    }
//}

//// Задание 36
//class WeightConverter
//{
//    public double KgToPounds(double kg)
//    {
//        return kg * 2.20462;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        WeightConverter wc = new WeightConverter();
//        Console.WriteLine($"36. 70 кг = {wc.KgToPounds(70):F2} фунтов");
//    }
//}

//// Задание 37
//class ArrayHelper
//{
//    public int FindMax(int[] arr)
//    {
//        if (arr == null || arr.Length == 0) return -1;
//        int max = arr[0];
//        for (int i = 1; i < arr.Length; i++)
//            if (arr[i] > max) max = arr[i];
//        return max;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ArrayHelper ah = new ArrayHelper();
//        int[] nums = { 4, 2, 9, 7, 5 };
//        Console.WriteLine($"37. Max в массиве = {ah.FindMax(nums)}");
//    }
//}

//// Задание 38
//class StringValidator
//{
//    public bool IsValidEmail(string email)
//    {
//        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
//        return Regex.IsMatch(email, pattern);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        StringValidator sv = new StringValidator();
//        string email = "test@example.com";
//        Console.WriteLine($"38. '{email}' — валидный email: {sv.IsValidEmail(email)}");
//    }
//}

//// Задание 39
//class NumberChecker
//{
//    public bool IsPrime(int n)
//    {
//        if (n < 2) return false;
//        for (int i = 2; i * i <= n; i++)
//            if (n % i == 0) return false;
//        return true;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        NumberChecker nc = new NumberChecker();
//        int num = 17;
//        Console.WriteLine($"39. {num} — простое: {nc.IsPrime(num)}");
//    }
//}

//// Задание 40
//class DateHelper
//{
//    public string GetDayOfWeek(DateTime date)
//    {
//        return date.ToString("dddd");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        DateHelper dh = new DateHelper();
//        DateTime today = DateTime.Today;
//        Console.WriteLine($"40. Сегодня — {dh.GetDayOfWeek(today)}");
//    }
//}

//// Задание 41
//class FileHelper
//{
//    public string ReadFile(string path)
//    {
//        try
//        {
//            return File.ReadAllText(path);
//        }
//        catch (Exception ex)
//        {
//            return $"Ошибка: {ex.Message}";
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        FileHelper fh = new FileHelper();
//        // Создадим временный файл для примера
//        string tempFile = Path.GetTempFileName();
//        File.WriteAllText(tempFile, "Привет из файла!");
//        Console.WriteLine($"41. Содержимое файла:\n{fh.ReadFile(tempFile)}");
//        File.Delete(tempFile);
//    }
//}

//// Задание 42
//class Logger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"[ЛОГ {DateTime.Now:HH:mm:ss}] {message}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Logger logger = new Logger();
//        logger.Log("Система запущена");
//    }
//}

//// Задание 43
//class Validator
//{
//    public bool IsStrongPassword(string password)
//    {
//        return password.Length >= 8 &&
//               Regex.IsMatch(password, @"\d") &&
//               Regex.IsMatch(password, @"[A-Z]") &&
//               Regex.IsMatch(password, @"[a-z]");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Validator val = new Validator();
//        string pwd = "MyPass123";
//        Console.WriteLine($"43. Пароль '{pwd}' сильный: {val.IsStrongPassword(pwd)}");
//    }
//}

//// Задание 44
//class Formatter
//{
//    public string ToTitleCase(string text)
//    {
//        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Formatter fmt = new Formatter();
//        string input = "привет мир";
//        Console.WriteLine($"44. '{input}' → '{fmt.ToTitleCase(input)}'");
//    }
//}

// Задание 45
//class Counter
//{
//    public int Value { get; private set; }

//    public Counter(int start = 0)
//    {
//        Value = start;
//    }

//    public void Increment() => Value++;
//    public void Decrement() => Value--;
//}

//class Program
//{
//    static void Main()
//    {
//        Counter counter = new Counter(10);
//        counter.Increment();
//        counter.Increment();
//        counter.Decrement();
//        Console.WriteLine($"45. Значение счётчика: {counter.Value}");
//    }
//}

////                   Раздел 4: Свойства



//// // Задание 46
//class Person
//{
//    private string name;

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person person = new Person();
//        person.Name = "Александр"; // Используем set
//        Console.WriteLine($"Имя: {person.Name}"); // Используем get

//        person.Name = "Мария";
//        Console.WriteLine($"Имя: {person.Name}");
//    }
//}

//// Задание 47
//class Student
//{
//    public double GPA { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Student s = new Student();
//        s.GPA = 4.7;
//        Console.WriteLine($"47. GPA: {s.GPA}");
//    }
//}

//// Задание 48
//class BankAccount
//{
//    public decimal Balance { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount acc = new BankAccount();
//        acc.Balance = 12500.50m;
//        Console.WriteLine($"48. Баланс: {acc.Balance} руб.");
//    }
//}

//// Задание 49
//class Product
//{
//    public decimal Price { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Product prod = new Product();
//        prod.Price = 899.99m;
//        Console.WriteLine($"49. Цена: {prod.Price} руб.");
//    }
//}

//// // Задание 50
//class Car
//{
//    public int Speed { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Car car = new Car();
//        car.Speed = 180;
//        Console.WriteLine($"50. Скорость: {car.Speed} км/ч");
//    }
//}

//// // Задание 51
//class Temperature
//{
//    public double Celsius { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Temperature t = new Temperature();
//        t.Celsius = 36.6;
//        Console.WriteLine($"51. Температура: {t.Celsius}°C");
//    }
//}

//// // Задание 52
//class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Rectangle r = new Rectangle();
//        r.Width = 10;
//        r.Height = 5;
//        Console.WriteLine($"52. Прямоугольник: {r.Width} x {r.Height}");
//    }
//}

//// // Задание 53
//class Circle
//{
//    public double Radius { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Circle c = new Circle();
//        c.Radius = 7.5;
//        Console.WriteLine($"53. Радиус круга: {c.Radius}");
//    }
//}

//// // Задание 54
//class Employee
//{
//    public decimal Salary { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee emp = new Employee();
//        emp.Salary = 95000m;
//        Console.WriteLine($"54. Зарплата: {emp.Salary} руб.");
//    }
//}

//// // Задание 55
//class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Book b = new Book();
//        b.Title = "Мастер и Маргарита";
//        b.Author = "Михаил Булгаков";
//        Console.WriteLine($"55. Книга: \"{b.Title}\" — {b.Author}");
//    }
//}

//// // Задание 56
//class House
//{
//    public double Area { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        House h = new House();
//        h.Area = 85.3;
//        Console.WriteLine($"56. Площадь дома: {h.Area} м²");
//    }
//}

//// // Задание 57
//class Computer
//{
//    public int RAM { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Computer comp = new Computer();
//        comp.RAM = 16;
//        Console.WriteLine($"57. ОЗУ: {comp.RAM} ГБ");
//    }
//}

//// // Задание 58
//class Account
//{
//    public string Username { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Account acc = new Account();
//        acc.Username = "user123";
//        Console.WriteLine($"58. Имя пользователя: {acc.Username}");
//    }
//}

//// Задание 59
//class Vehicle
//{
//    public string Brand { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Vehicle v = new Vehicle();
//        v.Brand = "Toyota";
//        Console.WriteLine($"59. Марка: {v.Brand}");
//    }
//}

// Задание 60
//class Color
//{
//    public int Red { get; set; }
//    public int Green { get; set; }
//    public int Blue { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Color c = new Color();
//        c.Red = 255;
//        c.Green = 105;
//        c.Blue = 180;
//        Console.WriteLine($"60. Цвет: RGB({c.Red}, {c.Green}, {c.Blue})");
//    }
//}

//           Раздел 5: ReadOnly Свойства



//Задание 61
//class Student
//{
//    private readonly int id;

//    public int ID
//    {
//        get { return id; }
//    }

//    // Конструктор для инициализации readonly свойства
//    public Student(int studentId)
//    {
//        id = studentId;
//    }

//    public string Name { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Student student = new Student(101);
//        Console.WriteLine($"ID студента: {student.ID}");
//        Console.WriteLine($"Имя студента: {student.Name}");

//        student.Name = "Иван Петров"; // Это разрешено
//        Console.WriteLine($"Имя студента: {student.Name}");

//        // student.ID = 102; // Ошибка! Readonly свойство нельзя изменить
//    }
//}


//Задание 62
//class Student
//{
//    public string ID { get; }

//    public Student(string id)
//    {
//        ID = id;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student s = new Student("STU-00123");
//        Console.WriteLine($"Задание 62. ID студента: {s.ID}");
//    }
//}

//Задание 63
//class BankAccount
//{
//    public string AccountNumber { get; }

//    public BankAccount(string accountNumber)
//    {
//        AccountNumber = accountNumber;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount acc = new BankAccount("RU1234567890");
//        Console.WriteLine($"Задание 63. Номер счёта: {acc.AccountNumber}");
//    }
//}

//Задание 64
//class Product
//{
//    public string Code { get; }

//    public Product(string code)
//    {
//        Code = code;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Product prod = new Product("PRD-98765");
//        Console.WriteLine($"Задание 64. Код товара: {prod.Code}");
//    }
//}

//Задание 65
//class Employee
//{
//    public string EmployeeID { get; }

//    public Employee(string employeeID)
//    {
//        EmployeeID = employeeID;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee emp = new Employee("EMP-00456");
//        Console.WriteLine($"Задание 65. ID сотрудника: {emp.EmployeeID}");
//    }
//}

//Задание 66
//class Car
//{
//    public string VIN { get; }

//    public Car(string vin)
//    {
//        VIN = vin;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Car car = new Car("1HGBH41JXMN109186");
//        Console.WriteLine($"Задание 66. VIN автомобиля: {car.VIN}");
//    }
//}

//Задание 67
//class House
//{
//    public string Address { get; }

//    public House(string address)
//    {
//        Address = address;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        House h = new House("ул. Пушкина, д. 10");
//        Console.WriteLine($"Задание 67. Адрес дома: {h.Address}");
//    }
//}

//Задание 68
//class Book
//{
//    public string ISBN { get; }

//    public Book(string isbn)
//    {
//        ISBN = isbn;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Book b = new Book("978-5-699-12345-6");
//        Console.WriteLine($"Задание 68. ISBN книги: {b.ISBN}");
//    }
//}

//Задание 69
//class Computer
//{
//    public string SerialNumber { get; }

//    public Computer(string serialNumber)
//    {
//        SerialNumber = serialNumber;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Computer comp = new Computer("SN-2023-7890");
//        Console.WriteLine($"Задание 69. Серийный номер: {comp.SerialNumber}");
//    }
//}

//Задание 70
//class Document
//{
//    public DateTime CreatedDate { get; }

//    public Document()
//    {
//        CreatedDate = DateTime.Now;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Document doc = new Document();
//        Console.WriteLine($"Задание 70. Дата создания: {doc.CreatedDate:yyyy-MM-dd HH:mm:ss}");
//    }
//}

//Задание 71
//class Order
//{
//    public string OrderID { get; }

//    public Order(string orderID)
//    {
//        OrderID = orderID;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Order ord = new Order("ORD-2025-001");
//        Console.WriteLine($"Задание 71. Номер заказа: {ord.OrderID}");
//    }
//}

//Задание 72
//class Invoice
//{
//    public string InvoiceNumber { get; }

//    public Invoice(string invoiceNumber)
//    {
//        InvoiceNumber = invoiceNumber;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Invoice inv = new Invoice("INV-2025-0456");
//        Console.WriteLine($"Задание 72. Номер счёта: {inv.InvoiceNumber}");
//    }
//}

//Задание 73
//class User
//{
//    public Guid UID { get; }

//    public User()
//    {
//        UID = Guid.NewGuid();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        User u = new User();
//        Console.WriteLine($"Задание 73. UID пользователя: {u.UID}");
//    }
//}

//Задание 74
//class Device
//{
//    public string MAC { get; }

//    public Device(string mac)
//    {
//        MAC = mac;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Device dev = new Device("00:1A:2B:3C:4D:5E");
//        Console.WriteLine($"Задание 74. MAC-адрес: {dev.MAC}");
//    }
//}

//Задание 75
//class Ticket
//{
//    public string TicketNumber { get; }

//    public Ticket(string ticketNumber)
//    {
//        TicketNumber = ticketNumber;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Ticket t = new Ticket("TKT-2025-7890");
//        Console.WriteLine($"Задание 75. Номер билета: {t.TicketNumber}");
//    }
//}

//                  Раздел 6: WriteOnly Свойства

// Задание 76
//class User
//{
//    private string _password;
//    public string Password { set { _password = value; } }
//}

//class Program
//{
//    static void Main()
//    {
//        User u = new User();
//        u.Password = "secret123";
//        Console.WriteLine("Задание 76. Пароль установлен (write-only)");
//    }
//}

// Задание 77
//class BankAccount
//{
//    private int _pin;
//    public int PIN { set { _pin = value; } }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount acc = new BankAccount();
//        acc.PIN = 4321;
//        Console.WriteLine("Задание 77. PIN установлен (write-only)");
//    }
//}

// Задание 78
//class SecureDocument
//{
//    private string _encryptionKey;
//    public string EncryptionKey { set { _encryptionKey = value; } }
//}

//class Program
//{
//    static void Main()
//    {
//        SecureDocument doc = new SecureDocument();
//        doc.EncryptionKey = "AES256Key";
//        Console.WriteLine("Задание 78. Ключ шифрования установлен (write-only)");
//    }
//}

// Задание 79
//class Account
//{
//    private string _token;
//    public string Token { set { _token = value; } }
//}

//class Program
//{
//    static void Main()
//    {
//        Account acc = new Account();
//        acc.Token = "jwt.token.here";
//        Console.WriteLine("Задание 79. Токен установлен (write-only)");
//    }
//}

// Задание 80
//class Logger
//{
//    private string _apiKey;
//    public string ApiKey { set { _apiKey = value; } }
//}

//class Program
//{
//    static void Main()
//    {
//        Logger log = new Logger();
//        log.ApiKey = "log-api-xyz789";
//        Console.WriteLine("Задание 80. API-ключ установлен (write-only)");
//    }
//}

// Задание 81
//class EmailService
//{
//    private string _smtpPassword;
//    public string SMTPPassword { set { _smtpPassword = value; } }
//}

//class Program
//{
//    static void Main()
//    {
//        EmailService email = new EmailService();
//        email.SMTPPassword = "mailpass2025";
//        Console.WriteLine("Задание 81. SMTP-пароль установлен (write-only)");
//    }
//}

// Задание 82
//class SecureConnection
//{
//    private string _connectionString;
//    public string ConnectionString { set { _connectionString = value; } }
//}

//class Program
//{
//    static void Main()
//    {
//        SecureConnection conn = new SecureConnection();
//        conn.ConnectionString = "Server=secure;Password=xxx;";
//        Console.WriteLine("Задание 82. Строка подключения установлена (write-only)");
//    }
//}

// Задание 83
//class Authenticator
//{
//    private string _secret;
//    public string Secret { set { _secret = value; } }
//}

//class Program
//{
//    static void Main()
//    {
//        Authenticator auth = new Authenticator();
//        auth.Secret = "TOTP-SECRET-KEY";
//        Console.WriteLine("Задание 83. Секрет установлен (write-only)");
//    }
//}

// Задание 84
//class PaymentService
//{
//    private string _creditCard;
//    public string CreditCard { set { _creditCard = value; } }
//}

//class Program
//{
//    static void Main()
//    {
//        PaymentService pay = new PaymentService();
//        pay.CreditCard = "4532-1234-5678-9012";
//        Console.WriteLine("Задание 84. Карта установлена (write-only)");
//    }
//}

// Задание 85
//class VPNClient
//{
//    private string _vpnPassword;
//    public string VPNPassword { set { _vpnPassword = value; } }
//}

//class Program
//{
//    static void Main()
//    {
//        VPNClient vpn = new VPNClient();
//        vpn.VPNPassword = "vpnsecure2025";
//        Console.WriteLine("Задание 85. VPN-пароль установлен (write-only)");
//    }
//}


//            Раздел 7: Конструкторы

//Задание 86
//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    // Конструктор
//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public void ShowInfo()
//    {
//        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Создание объектов с использованием конструктора
//        Person person1 = new Person("Иван", 25);
//        Person person2 = new Person("Мария", 23);
//        Person person3 = new Person("Петр", 30);

//        person1.ShowInfo();
//        person2.ShowInfo();
//        person3.ShowInfo();
//    }
//}

// Задание 87
//class Student
//{
//    public string ID { get; }
//    public string Name { get; }

//    public Student(string id, string name)
//    {
//        ID = id;
//        Name = name;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student s = new Student("S123", "Мария");
//        Console.WriteLine($"Задание 87. Студент: {s.ID} — {s.Name}");
//    }
//}

// Задание 88
//class Rectangle
//{
//    public double Length { get; }
//    public double Width { get; }

//    public Rectangle(double length, double width)
//    {
//        Length = length;
//        Width = width;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Rectangle r = new Rectangle(10.5, 5.2);
//        Console.WriteLine($"Задание 88. Прямоугольник: {r.Length} × {r.Width}");
//    }
//}

// Задание 89
//class Circle
//{
//    public double Radius { get; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Circle c = new Circle(7.3);
//        Console.WriteLine($"Задание 89. Радиус круга: {c.Radius}");
//    }
//}

// Задание 90
//class BankAccount
//{
//    public string AccountNumber { get; }
//    public decimal Balance { get; }

//    public BankAccount(string accountNumber, decimal initialBalance)
//    {
//        AccountNumber = accountNumber;
//        Balance = initialBalance;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount acc = new BankAccount("RU987654321", 15000.75m);
//        Console.WriteLine($"Задание 90. Счёт {acc.AccountNumber}: {acc.Balance} руб.");
//    }
//}

// Задание 91
//class Car
//{
//    public string Brand { get; }
//    public string Model { get; }
//    public int Year { get; }

//    public Car(string brand, string model, int year)
//    {
//        Brand = brand;
//        Model = model;
//        Year = year;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Car car = new Car("Toyota", "Camry", 2023);
//        Console.WriteLine($"Задание 91. Автомобиль: {car.Brand} {car.Model} ({car.Year})");
//    }
//}

// Задание 92
//class Book
//{
//    public string Title { get; }
//    public string Author { get; }
//    public int Pages { get; }

//    public Book(string title, string author, int pages)
//    {
//        Title = title;
//        Author = author;
//        Pages = pages;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Book b = new Book("1984", "Джордж Оруэлл", 328);
//        Console.WriteLine($"Задание 92. Книга: \"{b.Title}\" — {b.Author}, {b.Pages} стр.");
//    }
//}

// Задание 93
//class Employee
//{
//    public string Name { get; }
//    public decimal Salary { get; }

//    public Employee(string name, decimal salary)
//    {
//        Name = name;
//        Salary = salary;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee emp = new Employee("Анна", 85000m);
//        Console.WriteLine($"Задание 93. Сотрудник: {emp.Name}, зарплата: {emp.Salary} руб.");
//    }
//}

// Задание 94
//class Product
//{
//    public string Name { get; }
//    public decimal Price { get; }

//    public Product(string name, decimal price)
//    {
//        Name = name;
//        Price = price;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Product p = new Product("Ноутбук", 79990.99m);
//        Console.WriteLine($"Задание 94. Товар: {p.Name}, цена: {p.Price} руб.");
//    }
//}

// Задание 95
//class House
//{
//    public string Address { get; }
//    public int Rooms { get; }

//    public House(string address, int rooms)
//    {
//        Address = address;
//        Rooms = rooms;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        House h = new House("ул. Ленина, 15", 3);
//        Console.WriteLine($"Задание 95. Дом: {h.Address}, комнат: {h.Rooms}");
//    }
//}

// Задание 96
//class Triangle
//{
//    public double A { get; }
//    public double B { get; }
//    public double C { get; }

//    public Triangle(double a, double b, double c)
//    {
//        A = a;
//        B = b;
//        C = c;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Triangle t = new Triangle(3, 4, 5);
//        Console.WriteLine($"Задание 96. Треугольник: стороны {t.A}, {t.B}, {t.C}");
//    }
//}

// Задание 97
//class Time
//{
//    public int Hours { get; }
//    public int Minutes { get; }
//    public int Seconds { get; }

//    public Time(int hours, int minutes, int seconds)
//    {
//        Hours = hours;
//        Minutes = minutes;
//        Seconds = seconds;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Time t = new Time(14, 30, 45);
//        Console.WriteLine($"Задание 97. Время: {t.Hours:D2}:{t.Minutes:D2}:{t.Seconds:D2}");
//    }
//}

// Задание 98
//class Temperature
//{
//    public double Celsius { get; }

//    public Temperature(double celsius)
//    {
//        Celsius = celsius;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Temperature temp = new Temperature(25.5);
//        Console.WriteLine($"Задание 98. Температура: {temp.Celsius}°C");
//    }
//}

// Задание 99
//class Color
//{
//    public byte R { get; }
//    public byte G { get; }
//    public byte B { get; }

//    public Color(byte r, byte g, byte b)
//    {
//        R = r;
//        G = g;
//        B = b;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Color c = new Color(255, 105, 180);
//        Console.WriteLine($"Задание 99. Цвет: RGB({c.R}, {c.G}, {c.B})");
//    }
//}

// Задание 100
//class Point
//{
//    public double X { get; }
//    public double Y { get; }

//    public Point(double x, double y)
//    {
//        X = x;
//        Y = y;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Point p = new Point(3.5, -2.1);
//        Console.WriteLine($"Задание 100. Точка: ({p.X}, {p.Y})");
//    }
//}