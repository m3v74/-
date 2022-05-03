class Person
{
    public string name;            // Это типа имя работника по умолчанию  (значимая переменная)
    public int age;                // Это типа его возраст                 (значимая переменная)
    public Company company;        // А это типа место его работы  (экземпляр класса Company),
                                                                           //(ссылочная переменная)

    public Person()
    {
        name = "Неизвестно";
        age = 0;
        company = new Company { title = "Unknown" };  	// В конструкторе, для ссылочных переменных, 
    }                                                 	// требуется резервирование памяти 

    
    public Person(string name) 
    {
        this.name = name; 
        age = 0;
        company = new Company{ title = "Unknown" };  	// В конструкторе, для ссылочных переменных,
    }                                                 	// требуется резервирование памяти

    
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age; 
        company = new Company{ title = "Unknown" };  	// В конструкторе, для ссылочных переменных,
    }                                                 	// требуется резервирование памяти

    public Person(string name, int age, Company company)
    {
        this.name = name;
        this.age = age; 
        this.company = company;
    }

    public void Print() => 
        Console.WriteLine($"Имя: {name},  Возраст: {age},  Компания: {company.title} ");
}




class Company
{
    public string? title; 
}



class Program
{
    static void Main()
    {

         Person tom1 = new Person(); 

         Person tom2 = new Person ("Tom");

         Person tom3 = new Person ("Tom", 58);

         Person tom4 = new Person("Tom", 58, new Company { title = "Microsoft" });


        tom1.Print();               // Имя: Неизвестно,  Возраст: 0,   Компания: Unknown
        tom2.Print();               // Имя: Tom,         Возраст: 0,   Компания: Unknown
        tom3.Print();               // Имя: Tom,         Возраст: 58,  Компания: Unknown
        tom4.Print();
    }
}









