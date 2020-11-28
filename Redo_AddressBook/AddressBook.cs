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
        
        public void DisplayContact()
        {
            foreach(Contacts cont in addressBookList)
            {
                Console.WriteLine(cont.firstName+" "+cont.lastName + " " +cont.address + " " +cont.city + " " +cont.state + " " +cont.zip + " " +cont.phoneNo + " " +cont.eMail);
            }
        }

    }
}
