using System;
using Microsoft.AspNetCore.Mvc;
namespace SquareRootApp.Controllers {

    public class CalcController : Controller
     {

       [HttpGet]
        public IActionResult SquareRoot()
        {
            return View();
        }

          [HttpPost]
        public IActionResult SquareRoot(string FirstNumber, string SecondNumber) {
          
          double NumberOne = double.Parse(FirstNumber);
          double NumberTwo = (double.Parse(SecondNumber));

          double SqrtOne = Math.Sqrt(NumberOne);
          double SqrtTwo = Math.Sqrt(NumberTwo);
          
          ViewBag.First = double.Parse(FirstNumber);
          ViewBag.Second = double.Parse(SecondNumber);
          ViewBag.NumOne = NumberOne;
          ViewBag.NumTwo = NumberTwo;
          ViewBag.SqrtOne = SqrtOne;
          ViewBag.SqrtTwo = SqrtTwo;
          return View();
            
        } 
    }
}