using Encapsulation.Invoicing;
using Encapsulation.Employment;
using System;
using Encapsulation.Calendar;
using Encapsulation.Banking;
using Encapsulation.Extra;
namespace Encapsulation;

public class Program
{
    static void Main(string[] args)
    {
        // Invoicing
        Invoice invoice1 = new Invoice("001", "Hammer", 5, 75.0);
        Console.WriteLine($"Part Number: {invoice1.PartNumber}");
        Console.WriteLine($"Part Description: {invoice1.PartDescription}");
        Console.WriteLine($"Quantity: {invoice1.Quantity}");
        Console.WriteLine($"Price per item: {invoice1.Price}");
        Console.WriteLine($"Total Invoice Amount: {invoice1.GetInvoiceAmount()}");

        // Employee
        Employee employee1 = new Employee("John", "Doe", 3000.0);
        Employee employee2 = new Employee("Jane", "Doe", 3500.0);

        Console.WriteLine($"Yearly Salary of {employee1.FirstName} {employee1.LastName}: {employee1.GetYearlySalary()}");
        Console.WriteLine($"Yearly Salary of {employee2.FirstName} {employee2.LastName}: {employee2.GetYearlySalary()}");

        // Raise salary by 10%
        employee1.RaiseSalary(10);
        employee2.RaiseSalary(10);

        Console.WriteLine($"Yearly Salary after 10% raise for {employee1.FirstName} {employee1.LastName}: {employee1.GetYearlySalary()}");
        Console.WriteLine($"Yearly Salary after 10% raise for {employee2.FirstName} {employee2.LastName}: {employee2.GetYearlySalary()}");

        // Date
        Date validDate = new Date(12, 15, 2021);
        Date invalidDate = new Date(13, 32, 2021); // Ini akan diset ke 1/1/1970

        Console.WriteLine("Valid date:");
        validDate.DisplayDate();
        Console.WriteLine("Invalid date set to default:");
        invalidDate.DisplayDate();

        // Banking

        BankAccount account = new BankAccount("123456789", "John Doe", 1000.0);
        Console.WriteLine($"Initial balance: {account.GetBalance()}");

        account.Deposit(500.0);
        Console.WriteLine($"Balance after deposit: {account.GetBalance()}");

        account.Withdraw(200.0);
        Console.WriteLine($"Balance after withdrawal: {account.GetBalance()}");

        // Extra
        Plane plane1 = new Plane("Lockheed Martin", "F16", "Pratt & Whitney F100-PW-200/220", 2124, 18000000.00, 22, 9, 2024);
        Plane plane2 = new Plane("Grumman", "F14", "Pratt & Whitney F110-GE-400", 2480, 38000000.00, 20, 9, 2006);   
        Plane plane3 = new Plane("Mikoyan", "MiG-21MF", "Tumansky R-11F-300", 2175, 1000000.00, 15, 12, 1984);

        Car car1 = new Car("Bugatti", "Chiron", "W16 quad-turbocharged", 490, 3000000.00, 22, 9, 2024);
        Car car2 = new Car("McLaren", "F1", "BMW S70/2 V12", 386, 1000000.00, 31, 12, 1998);
        Car car3 = new Car("Ferrari", "F40", "2.9L twin-turbo V8", 324, 400000.00, 30, 4, 1992);   

        Ships ship1 = new Ships("General Dynamics Bath Iron Works", "Arleigh Burke-class Destroyer", "General Electric LM2500", 30, 1800000000.00, 22, 9, 2024);
        Ships ship2 = new Ships("Imperial Japanese Navy", "IJN Yamato", "4 × Kampon, 12-cyl. oil-fired steam turbines", 51, 100000000, 7, 4, 1945);
        Ships ship3 = new Ships("US Navy", "USS Missouri (BB-63)", "Steam turbine", 33, 100000000, 31, 3, 1992);

        Tank tank1 = new Tank("Krauss-Maffei Wegmann", "Leopard 2A7", "MTU MB 873 Ka-501", 72, 6500000, 22, 09, 2024);
        Tank tank2 = new Tank("Soviet Union Army Industries", "T-34/85", "V-2-34", 55, 30000, 19, 11, 1996);
        Tank tank3 = new Tank("Chrysler Defense", "M60A3", "Continental AVDS-1790-2A", 48, 500000, 15, 8, 2000);

        Console.WriteLine("");
        List<Plane> planes = new List<Plane>() { plane1, plane2, plane3 };
        foreach(Plane plane in planes)
        {
            plane.DisplayDateProduction();
            plane.DisplayInfo();
            plane.EditPrice(-5000);
            plane.Year = 2024;
            plane.Month = 9;
            plane.Day = 21;
            plane.DisplayInfo();
            plane.DisplaySpeed();
            plane.SpeedPerPrice();
            plane.CheckProduction();
            plane.EditPrice(-999999999999999);
            Console.WriteLine("");

        }
        Console.WriteLine("");


        List<Tank> tanks = new List<Tank>(){ tank1, tank2, tank3 };
        foreach (Tank tank in tanks)
        {
            tank.DisplayDateProduction();
            tank.DisplayInfo();
            tank.EditPrice(-5000);

            tank.Year = 2024;
            tank.Month = 9;
            tank.Day = 29;
            tank.DisplayDateProduction();
            Console.WriteLine("");
            tank.Year = 2023;
            tank.Month = 2;
            tank.Day = 29;
            tank.DisplayDateProduction();
            Console.WriteLine("");
            tank.Year = 2024;
            tank.Month = 2;
            tank.Day = 29;
            tank.DisplayDateProduction();
            Console.WriteLine("");
            tank.Year = 9;
            tank.Month = 9;
            tank.Day = 21;
            tank.DisplayDateProduction();
            Console.WriteLine("");
            tank.Year = 1999;
            tank.Month = 13;
            tank.Day = 21;
            tank.DisplayDateProduction();
            Console.WriteLine("");
            tank.Year = 1900;
            tank.Month = 12;
            tank.Day = 32;
            tank.DisplayDateProduction();
            Console.WriteLine("");
            tank.Year = 1900;
            tank.Month = 2;
            tank.Day = 29;
            tank.DisplayDateProduction();
            Console.WriteLine("");

            tank.DisplaySpeed();
            tank.SpeedPerPrice();
            tank.CheckProduction();
            tank.EditPrice(-999999999999999);
            Console.WriteLine("");

        }

        Console.WriteLine("");
        List<Car> cars = new List<Car>() { car1, car2, car3 };
        foreach (Car car in cars)
        {
            car.DisplayDateProduction();
            car.DisplayInfo();
            car.EditPrice(-5000);
            car.Year = 2024;
            car.Month = 9;
            car.Day = 21;
            car.DisplayInfo();
            car.DisplaySpeed();
            car.SpeedPerPrice();
            car.CheckProduction();
            car.EditPrice(-999999999999999);
            Console.WriteLine("");

        }
        Console.WriteLine("");
        List<Ships> shipss = new List<Ships>() { ship1, ship2, ship3 };
        foreach (Ships ship in shipss)
        {
            ship.DisplayDateProduction();
            ship.DisplayInfo();
            ship.EditPrice(-5000);
            ship.Year = 2024;
            ship.Month = 9;
            ship.Day = 21;
            ship.DisplayInfo();
            ship.DisplaySpeed();
            ship.SpeedPerPrice();
            ship.CheckProduction();
            ship.EditPrice(-999999999999999);
            Console.WriteLine("");

        }
    }
}
