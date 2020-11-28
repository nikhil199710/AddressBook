// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Nikhil kumar yadav"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace Redo_AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Multiple Address Book ");
            MultipleAddressBook multipleAddressBook = new MultipleAddressBook();
            while (true)
            {
                bool flag = true;

                Console.WriteLine("enter the name of Addressbook");
                string name = Console.ReadLine();
                if (name == "")
                    break;
                AddressBook addressBook = new AddressBook();
                while (flag == true)
                {
                    Console.WriteLine("Enter First Name:");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("Enter last Name:");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("Enter Address:");
                    string Address = Console.ReadLine();
                    Console.WriteLine("Enter City:");
                    string City = Console.ReadLine();
                    Console.WriteLine("Enter State:");
                    string State = Console.ReadLine();
                    Console.WriteLine("Enter Zip:");
                    int Zip = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter PhoneNo:");
                    int PhoneNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Email:");
                    string Email = Console.ReadLine();
                    addressBook.AddContact(FirstName, LastName, Address, City, State, Zip, PhoneNo, Email);
                    Console.WriteLine("Want to Add more Contact: Type YES or NO");
                    string check = Console.ReadLine();
                    if (check == "YES")
                        flag = true;
                    else
                        flag = false;


                }
                addressBook.DisplayContact();

                //UC3
                Console.WriteLine("Enter First Name which u have to edit:");
                string editFirstName = Console.ReadLine();
                addressBook.EditContact(editFirstName);
                addressBook.DisplayContact();

                //UC4
                Console.WriteLine("Enter First Name which u have to delete:");
                string DeleteContact = Console.ReadLine();
                addressBook.deleteContact(DeleteContact);
                addressBook.DisplayContact();
                
                //UC5-UC6
                multipleAddressBook.AddMultipleAddressBook(name, addressBook);
            }
            Console.WriteLine("enter the name of Addressbook which you want to display:");
            string nameCheck = Console.ReadLine();
            multipleAddressBook.Display(nameCheck);

        }

        }
    }


                 
