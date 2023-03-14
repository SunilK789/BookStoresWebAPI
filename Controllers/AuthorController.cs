using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoresWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
       
        [HttpGet]
        public IEnumerable<Author> Get()
        {
            using(var context  = new BookStoresDBContext())
            {
                //get all authors
                //return context.Author.ToList();



                //add a new author
                //Author author = new Author();
                //author.FirstName = "Sunil";
                //author.LastName = "Kumar";

                //context.Author.Add(author);
                //context.SaveChanges();

                //edit author
                //Author author = context.Author.Where(auth => auth.FirstName == "Sunil").FirstOrDefault();
                //author.Phone = "999556664787";
                //context.SaveChanges();

                //remove author from db
                Author author = context.Author.Where(auth => auth.FirstName == "Sunil").FirstOrDefault();
                context.Author.Remove(author);
                context.SaveChanges();

                //get all authors by id
                return context.Author.Where(auth => auth.FirstName == "Sunil").ToList();
            }
        }
    }
}
