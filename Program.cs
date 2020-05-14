using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV6
{
    class Program
    {
        static void Main(string[] args)
        {

            /*          1. zadatak testiranje
            Notebook notebook = new Notebook();
            notebook.AddNote(new Note("note1","first note"));
            notebook.AddNote(new Note("note2", "second note"));
            notebook.AddNote(new Note("note3", "third note"));
            notebook.AddNote(new Note("note4", "fourth note"));

            IAbstractIterator notebookIterator = notebook.GetIterator();

            while (true)
            {
                notebookIterator.Current.Show();
                if(notebookIterator.Next() == null)
                {
                    break;
                }
            }
            */






            /*             2. zadatak testiranje
            Box box = new Box();
            box.AddProduct(new Product("Apples",5.99));
            box.AddProduct(new Product("Pears", 6.99));

            IAbstractIteratorII BoxIterator = box.GetIterator();

            while (true)
            {
                Console.WriteLine(BoxIterator.Current.ToString());
                if (BoxIterator.Next() == null)
                {
                    break;
                }
            }*/








            /*          3. zadatak testiranje
            ToDoItem toDoItem = new ToDoItem("Meeting", "Attend meeting", new DateTime(2020,5,13,6,0,0));

            CareTaker careTaker = new CareTaker();

            careTaker.AddMemento(toDoItem.StoreState());
            Console.WriteLine(toDoItem.ToString());

            toDoItem.Rename("Next meeting");
            toDoItem.ChangeTask("Attend next meeting");
            toDoItem.ChangeTimeDue(new DateTime(2020, 5, 14, 6, 30,0));
            careTaker.AddMemento(toDoItem.StoreState());
            Console.WriteLine(toDoItem.ToString());

            toDoItem.RestoreState(careTaker.GetMementoAt(0));
            Console.WriteLine(toDoItem.ToString());
            */



            BankAccount bankAccount = new BankAccount("James Bond","007 Street",700);

            CareTaker careTaker = new CareTaker();

            careTaker.AddMemento(bankAccount.StoreState());
            Console.WriteLine(bankAccount.OwnerName + ", " + bankAccount.OwnerAddress + ", " + bankAccount.Balance);

            bankAccount.ChangeOwnerAddress("008 Street");
            bankAccount.UpdateBalance(800);
            careTaker.AddMemento(bankAccount.StoreState());
            Console.WriteLine(bankAccount.OwnerName +", "+ bankAccount.OwnerAddress +", "+ bankAccount.Balance);

            bankAccount.RestoreState(careTaker.GetMementoAt(0));
            Console.WriteLine(bankAccount.OwnerName + ", " + bankAccount.OwnerAddress + ", " + bankAccount.Balance);


        }
    }
}
