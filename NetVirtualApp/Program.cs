using NetVirtualApp;

//VirtualExample();


Rectangle rectangle = new Rectangle(2, 2, 30, 65);

Console.WriteLine(rectangle);
Console.WriteLine($"Area: {rectangle.Area()}, Perimetr: {rectangle.Perimetr()}");
Console.WriteLine();


Shape shape = new Rectangle(1, 1, 40, 50);
Console.WriteLine(shape);
Console.WriteLine($"Area: {shape.Area()}, Perimetr: {shape.Perimetr()}");
Console.WriteLine();

shape = new Circle(2, 2, 20);
Console.WriteLine(shape);
Console.WriteLine($"Area: {shape.Area()}, Perimetr: {shape.Perimetr()}");
Console.WriteLine();

Rectangle r1 = new(1, 1, 10, 20);
Rectangle r2 = new(5, 2, 10, 30);
Circle c1 = new(1, 1, 10);
Console.WriteLine(r1.Equals(c1));


void VirtualExample()
{
    Employee employee = new Employee() { Name = "Tom", Age = 23, Salary = 60000 };
    Person person = new Person() { Name = "Sam", Age = 35 };

    employee.Info();
    Console.WriteLine();
    Console.WriteLine($"Id: {employee.Id}");

    person.Age = 10;
    person.Info();
    Console.WriteLine($"Id: {person.Id}");


    person = new Employee() { Name = "Leo", Age = 41, Salary = 100000 };
    person.Age = 10;
    person.Info();
}


