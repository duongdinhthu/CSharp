using System;
using System.Collections;

class Contact
{
    public string Name { get; set; }
    public string Phone { get; set; }

    public Contact(string name, string phone)
    {
        Name = name;
        Phone = phone;
    }
}

class ContactManager
{
    Hashtable addressBook = new Hashtable();

    public void AddContact()
    {
        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter phone number:");
        string phone = Console.ReadLine();

        Contact newContact = new Contact(name, phone);
        addressBook.Add(name, newContact);
        Console.WriteLine("Contact added successfully!\n");
    }

    public void FindContact()
    {
        Console.WriteLine("Enter name to find:");
        string name = Console.ReadLine();
        
        if (addressBook.ContainsKey(name))
        {
            Contact foundContact = (Contact)addressBook[name];
            Console.WriteLine($"Phone number: {foundContact.Phone}\n");
        }
        else
        {
            Console.WriteLine("Contact not found\n");
        }
    }

    public void DisplayContacts()
    {
        Console.WriteLine("Address Book:");
        foreach (DictionaryEntry entry in addressBook)
        {
            Contact contact = (Contact)entry.Value;
            Console.WriteLine($"Name: {contact.Name}, Phone: {contact.Phone}");
        }
        Console.WriteLine();
    }

    public void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("Contact Manager Menu:");
            Console.WriteLine("1. Add new contact");
            Console.WriteLine("2. Find a contact by name");
            Console.WriteLine("3. Display contacts");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddContact();
                    break;
                case 2:
                    FindContact();
                    break;
                case 3:
                    DisplayContacts();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        ContactManager manager = new ContactManager();
        manager.MainMenu();
    }
}