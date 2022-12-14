using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_AGN
{
    class Book
    {
        public int bookId;
        public string bookName;
        public string bookAuthor;
        public int bookPrice;
        public int bookCount;
        public int x;
    }
 
    class Newspaper
    {
        public int paperId;
        public string paperName;
        public int paperPrice;
        public int paperCount;
        public int y;
    }

    class BorrowDetails1
    {
        public int userID;
        public string userName;
        public string userAddress;
        public int borrowPaperId;
        public DateTime borrowDate;
        public int borrowCount;
    }

    class BorrowDetails
    {
        public int userId;
        public string userName;
        public string userAddress;
        public int borrowBookId;
        public DateTime borrowDate;
        public int borrowCount;
    }

    public class Program
    {
        static List<Book> bookList = new List<Book>();
        static List<BorrowDetails> borrowList = new List<BorrowDetails>();
        static Book book = new Book();
        static BorrowDetails borrow = new BorrowDetails();

        static List<Newspaper> newsList = new List<Newspaper>();
        static List<BorrowDetails1> borrowList1 = new List<BorrowDetails1>();
        static Newspaper news = new Newspaper();
        static BorrowDetails1 borrow1 = new BorrowDetails1();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Library!!");
            Console.WriteLine("-----------------");
            Console.WriteLine("1. Librarian");
            Console.WriteLine("2. Borrower");
            Console.WriteLine(" Enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
            {
                Console.WriteLine("\nMenu\n" +
                    "1. Books\n" +
                    "2. Newspapers\n");

            }
            else if (ch == 2)
            {
                Console.WriteLine("\nMenu\n" +
                                    "1. Borrow  Book \n" +
                                    "2.  Return Book\n");
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

            int user = int.Parse(Console.ReadLine());

            if (user == 1)
            {
                Console.Write("Welcome to the Library !!!\nEnter your password :");
                string password = Console.ReadLine();

                if (password == "12345")
                {

                    bool close = true;
                    while (close)
                    {

                        Console.WriteLine("\nMenu\n" +
                        "1)Add book\n" +
                        "2)Delete book\n" +
                        "3)Search book\n" +
                        "4)Borrow book\n" +
                        "5)Return book\n" +
                        "6)Close\n");
                        Console.Write("Choose your option from menu :");

                        int option = int.Parse(Console.ReadLine());

                        if (option == 1)
                        {
                            AddBook();
                        }
                        else if (option == 2)
                        {
                            RemoveBook();
                        }
                        else if (option == 3)
                        {
                            SearchBook();
                        }
                        else if (option == 4)
                        {
                            Borrow();
                        }
                        else if (option == 5)
                        {
                            ReturnBook();
                        }
                        else if (option == 6)
                        {
                            Console.WriteLine("Thank you !!!");
                            Console.WriteLine("\nMenu\n" +
                                   "1. Books\n" +
                                   "2. Newspapers\n");
                            Console.WriteLine(close);
                            close = false;
                            Console.WriteLine(close);
                            //Console.WriteLine(" Newspaper Category");
                            //GetNewspaper();
                           
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid password");
                }
            }
            else if (user == 2)
            {
                Console.WriteLine("Welcome to the library!!");
                Console.WriteLine(" Newspapers");
                GetNewspaper();


            }
            Console.ReadLine();
        }

        public static void AddBook()
        {
            Book book = new Book();
            {
                Console.WriteLine("Book Id:{0}", book.bookId = bookList.Count + 1);
                Console.Write("Book Name:");
                book.bookName = Console.ReadLine();
                Console.Write("Book Author Name:");
                book.bookAuthor = Console.ReadLine();
                Console.Write("Book Price:");
                book.bookPrice = int.Parse(Console.ReadLine());
                Console.Write("Number of Books:");
                book.x = book.bookCount = int.Parse(Console.ReadLine());
                bookList.Add(book);
                Console.WriteLine("Book added successfully.");
            }
        }
 
        public static void RemoveBook()
        {
            Book book = new Book();


            Console.Write("Enter Book id to delete : ");

            int Del = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == Del))
            {
                bookList.RemoveAt(Del - 1);
                Console.WriteLine("Book id - {0}  deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }

            bookList.Add(book);

        }

        public static void SearchBook()
        {
            Book book = new Book();

            Console.Write("Search Book id :");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(x => x.bookId == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookId == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book Name :{1}\n" +
                        "Book Author name: {2}\n" +
                        "Book price :{3}\n" +
                        "Book Count :{4}", searchId.bookId, searchId.bookName, searchId.bookAuthor, searchId.bookPrice, searchId.bookCount);
                    }

                }
            }

            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }


        }

        public static void Borrow()
        {
            Book book = new Book();
            BorrowDetails borrow = new BorrowDetails();
            Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
            Console.Write("Name :");

            borrow.userName = Console.ReadLine();

            Console.Write("Book id :");
            borrow.borrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            borrow.borrowCount = int.Parse(Console.ReadLine());
            Console.Write("Address :");
            borrow.userAddress = Console.ReadLine();
            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());

            if (bookList.Exists(x => x.bookId == borrow.borrowBookId))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookCount >= searchId.bookCount - borrow.borrowCount && searchId.bookCount - borrow.borrowCount >= 0)
                    {
                        if (searchId.bookId == borrow.borrowBookId)
                        {
                            searchId.bookCount = searchId.bookCount - borrow.borrowCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} books found", searchId.bookCount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", borrow.borrowBookId);
            }
            borrowList.Add(borrow);
        }


        public static void ReturnBook()
        {
            Book book = new Book();
            Console.WriteLine("Enter  details :");

            Console.Write("Book id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (bookList.Exists(y => y.bookId == returnId))
            {
                foreach (Book addReturnBookCount in bookList)
                {
                    if (addReturnBookCount.x >= returnCount + addReturnBookCount.bookCount)
                    {
                        if (addReturnBookCount.bookId == returnId)
                        {
                            addReturnBookCount.bookCount = addReturnBookCount.bookCount + returnCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not Found");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", returnId);
            }
        }

 
        public static void GetNewspaper()
        {
            Console.Write("Welcome to the Library !!!\nEnter your password :");
            string password = Console.ReadLine();

            if (password == "12345")
            {
                bool clos1 = true;
                while (clos1)
                {


                    Console.WriteLine("\nMenu\n" +
                                "1)Add Newspaper\n" +
                                "2)Delete Newspaper\n" +
                                "3)Search Newspaper \n" +
                                "4)Borrow Newspaper\n" +
                                "5)Return Newspaper\n" +
                                "6)Close\n\n");
                    Console.Write("Choose your option from menu :");

                    int option1 = int.Parse(Console.ReadLine());

                    switch (option1)
                    {
                        case 1:
                            AddNewspaper();
                            break;
                        case 2:
                            RemoveNewspaper();
                            break;
                        case 3:
                            SearchNewspaper();
                            break;
                        case 4:
                            Borrow1();
                            break;
                        case 5:
                            ReturnNewspaper();
                            break;

                        case 6:
                            {
                                Console.WriteLine("Thank you");
                                clos1 = false;
                                break;
                            }
                    }
                }
            }



            else
            {
                Console.WriteLine("Invalid password");
            }
        }


        public static void AddNewspaper()
        {
            Newspaper paper = new Newspaper();

            {
                Console.WriteLine("Newspaper Id:{0}", paper.paperId = newsList.Count + 1);
                Console.Write("Newspaper Name:");
                paper.paperName = Console.ReadLine();

                Console.Write("Newspaper Price:");
                paper.paperPrice = int.Parse(Console.ReadLine());
                Console.Write("Number of Newspaper:");
                paper.y = paper.paperCount = int.Parse(Console.ReadLine());
                newsList.Add(paper);
                Console.WriteLine("Newspapers added Successfully.");
            }
        }

        public static void RemoveNewspaper()
        {
            Newspaper paper = new Newspaper();
            Console.Write("Enter Newspaper id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (newsList.Exists(x => x.paperId == Del))
            {
                newsList.RemoveAt(Del - 1);
                Console.WriteLine("Newspaper id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Newspaper id");
            }

            newsList.Add(news);
        }

        public static void SearchNewspaper()
        {
            Newspaper paper = new Newspaper();
            Console.Write("Search by Newspaper id :");
            int find = int.Parse(Console.ReadLine());

            if (newsList.Exists(x => x.paperId == find))
            {
                foreach (Newspaper searchId in newsList)
                {
                    if (searchId.paperId == find)
                    {
                        Console.WriteLine("Newspaper id :{0}\n" +
                        "Newspaper Name :{1}\n" +
                        "Newspaper price :{2}\n" +
                        "Newspaper Count :{3}", searchId.paperId, searchId.paperName, searchId.paperPrice, searchId.paperCount);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }


        public static void Borrow1()
        {
            Newspaper paper = new Newspaper();
            BorrowDetails1 borrow1 = new BorrowDetails1();
            Console.WriteLine("User id : {0}", (borrow1.userID = borrowList.Count + 1));
            Console.Write("Name :");

            borrow1.userName = Console.ReadLine();

            Console.Write("Newspaper id :");
            borrow1.borrowPaperId = int.Parse(Console.ReadLine());
            Console.Write("Number of copies: ");
            borrow1.borrowCount = int.Parse(Console.ReadLine());
            Console.Write("Enter your address :");
            borrow1.userAddress = Console.ReadLine();
            borrow1.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow1.borrowDate.ToShortDateString(), borrow1.borrowDate.ToShortTimeString());

            if (newsList.Exists(x => x.paperId == borrow1.borrowPaperId))
            {
                foreach (Newspaper searchId in newsList)
                {
                    if (searchId.paperCount >= searchId.paperCount - borrow1.borrowCount && searchId.paperCount - borrow1.borrowCount >= 0)
                    {
                        if (searchId.paperId == borrow1.borrowPaperId)
                        {
                            searchId.paperCount = searchId.paperCount - borrow1.borrowCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} Newspaper are found", searchId.paperCount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", borrow1.borrowPaperId);
            }
            borrowList.Add(borrow);
        }


        public static void ReturnNewspaper()
        {
            Newspaper paper = new Newspaper();
            Console.WriteLine("Enter following details :");

            Console.Write("Newspaperid : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Newspaper:");
            int returnCount = int.Parse(Console.ReadLine());

            if (newsList.Exists(y => y.paperId == returnId))
            {
                foreach (Newspaper addReturnBookCount in newsList)
                {
                    if (addReturnBookCount.y >= returnCount + addReturnBookCount.paperCount)
                    {
                        if (addReturnBookCount.paperId == returnId)
                        {
                            addReturnBookCount.paperCount = addReturnBookCount.paperCount + returnCount;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Newspaper not found");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Newspaper id {0} not found", returnId);
            }
        }

    }
}