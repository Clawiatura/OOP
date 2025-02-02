using System;
using System.Collections.Generic;


ContactList contactList = new ContactList();


contactList.AddContact(new Contact { Name = "Иван", Address = "Сурикова", Number = "12345", Email = "ivan@mail.ru" });
contactList.DisplayContacts();
Contact updatedContact = new Contact
{
    Name = "Иван",
    Address = "Улица 2",
    Number = "67890", 
    Email = "ivan@icloud.com" 
};

contactList.UpdateContact("Иван", updatedContact);
contactList.DisplayContacts();
//contactList.RemoveContact("Иван"); если прописать выше то удалит контакты с именем Иван, так же можно создать через Windows Form как приложение и управлять или же через Console.WL.


class Contact
{
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Number { get; set; }
    public string? Email { get; set; }
}

class ContactList
{
    private List<Contact> contacts = new List<Contact>();

    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
    }

    public void RemoveContact(string name)
    {
        contacts.RemoveAll(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void UpdateContact(string name, Contact updatedContact)
    {
        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                contacts[i] = updatedContact;
                break;
            }
        }
    }

    public void DisplayContacts()
    {
        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Name}, {contact.Address}, {contact.Number}, {contact.Email}");
        }
    }
}


    
    
        

