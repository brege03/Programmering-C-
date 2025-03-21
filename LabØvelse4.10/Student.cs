using System;

class Student
{
    public string Name { get; set; }
    public string ID { get; set; }

    private decimal _mathGrade;
    private decimal _englishGrade;
    private decimal _spanishGrade;

    public Student(string studentName, string studentID, decimal mathGrade, decimal englishGrade, decimal spanishGrade)
    {
        Name = studentName;
        ID = studentID;
        MathGrade = mathGrade;  // Use the validated property
        EnglishGrade = englishGrade;
        SpanishGrade = spanishGrade;
    }

    public decimal MathGrade
    {
        get { return _mathGrade; }
        private set
        {
            if (value >= 0.0m && value <= 50.00m) // Allow 0.0 as a valid grade
            {
                _mathGrade = value;
            }
            else
            {
                Console.WriteLine("Invalid Math grade. Must be between 0.00 and 50.00.");
                _mathGrade = 0.0m;  // Default to 0.00 if invalid
            }
        }
    }

    public decimal EnglishGrade
    {
        get { return _englishGrade; }
        private set
        {
            if (value >= 0.0m && value <= 50.00m)
            {
                _englishGrade = value;
            }
            else
            {
                Console.WriteLine("Invalid English grade. Must be between 0.00 and 50.00.");
                _englishGrade = 0.0m;
            }
        }
    }

    public decimal SpanishGrade
    {
        get { return _spanishGrade; }
        private set
        {
            if (value >= 0.0m && value <= 50.00m)
            {
                _spanishGrade = value;
            }
            else
            {
                Console.WriteLine("Invalid Spanish grade. Must be between 0.00 and 50.00.");
                _spanishGrade = 0.0m;
            }
        }
    }
    public void GetAggregate()
    {
        decimal aggregate = _mathGrade + _englishGrade + _spanishGrade;
        Console.WriteLine($"Aggregate: {aggregate}");
    }

    public void GetPercentage()
    {
        decimal percentageMath = _mathGrade / 50 * 100;
        decimal percentageEnglish = _englishGrade / 50 * 100;
        decimal percentageSpanish = _spanishGrade / 50 * 100;
        Console.WriteLine($"Math percentage: {percentageMath}, English percentage: {percentageEnglish}, Spanish percentage: {percentageSpanish}");
    }


    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Student: {Name} (ID: {ID})");
        Console.WriteLine($"Math Grade: {MathGrade}");
        Console.WriteLine($"English Grade: {EnglishGrade}");
        Console.WriteLine($"Spanish Grade: {SpanishGrade}");
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student("Brage", "6969", 24.00m, 50.00m, 49.99m);
        student1.DisplayStudentInfo();
        student1.GetAggregate();
        student1.GetPercentage();
    }
}