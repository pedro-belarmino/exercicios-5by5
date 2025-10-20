using List;

ContactList contacts = new ContactList();

Contact c1 =  new Contact() { Name = "Alice", Number = "23847023"};
Contact c2 =  new Contact() { Name = "Carlos", Number = "23847023"};
Contact c3 =  new Contact() { Name = "Pedro", Number = "23847023"};
Contact c4 =  new Contact() { Name = "Zimbabue", Number = "23847023"};

contacts.putContact(c3);
contacts.putContact(c4);
contacts.putContact(c1);
contacts.putContact(c2);