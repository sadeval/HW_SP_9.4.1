using System;
using ContactValidationLibrary;

namespace ContactApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите ФИО:");
            string? fullName = Console.ReadLine();
            bool isFullNameValid = ContactValidator.IsValidFullName(fullName);
            Console.WriteLine(isFullNameValid ? "ФИО корректно" : "ФИО содержит недопустимые символы");

            Console.WriteLine("Введите возраст:");
            string? age = Console.ReadLine();
            bool isAgeValid = ContactValidator.IsValidAge(age);
            Console.WriteLine(isAgeValid ? "Возраст корректен" : "Возраст содержит недопустимые значения");

            Console.WriteLine("Введите номер телефона:");
            string? phoneNumber = Console.ReadLine();
            bool isPhoneNumberValid = ContactValidator.IsValidPhoneNumber(phoneNumber);
            Console.WriteLine(isPhoneNumberValid ? "Номер телефона корректен" : "Некорректный формат номера телефона");

            Console.WriteLine("Введите email:");
            string? email = Console.ReadLine();
            bool isEmailValid = ContactValidator.IsValidEmail(email);
            Console.WriteLine(isEmailValid ? "Email корректен" : "Некорректный формат email");

            Console.ReadLine();
        }
    }
}
