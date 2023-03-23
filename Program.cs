namespace Day36AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Repo ! ");


            AddressBookRepo repo = new AddressBookRepo();

            AddressBookModel addressBookModel = new AddressBookModel();

            repo.GetAddressBook();





        }
    }
}