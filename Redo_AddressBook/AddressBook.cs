// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Nikhil kumar yadav"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Redo_AddressBook
{
    class AddressBook
    {
        public List<Contacts> addressBookList = new List<Contacts>();

        /// <summary>
        /// UC2
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="phoneNo"></param>
        /// <param name="eMail"></param>
        public void AddContact(string firstName, string lastName, string address, string city, string state, int zip, long phoneNo, string eMail)
        {
            Contacts contacts = new Contacts(firstName,lastName,address,city,state,zip,phoneNo,eMail);
            addressBookList.Add(contacts);
        }

        /// <summary>
        /// UC3
        /// </summary>
        /// <param name="firstName"></param>
        public void EditContact(string firstName)
        {
            foreach (Contacts cont in addressBookList)
            {
                if (cont.firstName== firstName)
                {
                    Console.WriteLine("Contact Available");
                    Console.WriteLine("Upload Edited Contact.");
                    Console.WriteLine("Enter First Name:");
                    cont.firstName = Console.ReadLine();
                    Console.WriteLine("Enter last Name:");
                    cont.lastName = Console.ReadLine();
                    Console.WriteLine("Enter Address:");
                    cont.address = Console.ReadLine();
                    Console.WriteLine("Enter City:");
                    cont.city = Console.ReadLine();
                    Console.WriteLine("Enter State:");
                    cont.state = Console.ReadLine();
                    Console.WriteLine("Enter Zip:");
                    cont.zip = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter PhoneNo:");
                    cont.phoneNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Email:");
                    cont.eMail = Console.ReadLine();
                }
            }
        }


        public void DisplayContact()
        {
            foreach(Contacts cont in addressBookList)
            {
                Console.WriteLine(cont.firstName+" "+cont.lastName + " " +cont.address + " " +cont.city + " " +cont.state + " " +cont.zip + " " +cont.phoneNo + " " +cont.eMail);
            }
        }
    }
    
}
