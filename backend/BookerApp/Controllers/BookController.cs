using Microsoft.AspNetCore.Mvc;
using BookerApp.Entities;
using System.Runtime.Versioning;
using System.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using BookerApp.Data;

namespace BookerApp.Controllers;
[ApiController]
[Route("api/books")]
public class BookController : ControllerBase
{
    /*private readonly AppDbContext _context;

    public BookController(AppDbContext context)
    {
        _context = context;
    }*/

}