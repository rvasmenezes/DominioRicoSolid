using RoomBooking.Console_.Repositories;
using RoomBooking.Console_.Services;
using RoomBooking.Domain.Contracts;
using RoomBooking.Domain.Contracts.Services;
using RoomBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;

namespace RoomBooking.Console_
{
    public class Program
    {
        static void Main(string[] args)
        {

            var container = new UnityContainer();

            container.RegisterType<IBookRepository, BookRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IBookService, BookService>(new HierarchicalLifetimeManager());

            var bookRepository = container.Resolve<IBookRepository>();
            var bookService = container.Resolve<IBookService>();

            var room = new Room(DateTime.Now, DateTime.Now.AddHours(8), "Sala 1");
            
            //var book = new Book(room, DateTime.Now.AddHours(1), DateTime.Now.AddHours(2));
            //book.MarkAsCompleted();
            //bookRepository.Save(book);

            bookService.PlaceBook(DateTime.Now.AddHours(2), DateTime.Now.AddHours(3), room.Id);

            
        }
    }
}
