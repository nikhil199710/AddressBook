// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Nikhil kumar yadav"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Redo_AddressBook
{
    public class MultipleAddressBook
    {
        Dictionary<string, AddressBook> addressBookDict;
        public MultipleAddressBook()
        {
            addressBookDict = new Dictionary<string, AddressBook>();
        }
        public void AddMultipleAddressBook(string name, AddressBook addressBook)
        {
            addressBookDict.Add(name, addressBook);
        }
        public void Display(string name)
        {
            addressBookDict[name].DisplayContact();
        }
    }
}
