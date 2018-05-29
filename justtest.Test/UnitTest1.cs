using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using justtest.Controllers;
using justtest.Models;

namespace justtest.Test
{
    [TestClass]
    public class TestMoviesController
    {
        private readonly MoviesController _moviesController;
        private readonly ModelContext _modelContext;

        public TestMoviesController()
        {
            _moviesController = new MoviesController(_modelContext);
        }
        
        [TestMethod]
        [ExpectedException(typeof(Movie))]
        public async Task Details()
        {
            try
            {
                var result = await _moviesController.Details(2);
            }
            catch (System.Exception)
            {
                throw new Exception("Error");
            }

            //var resulta;
            //var result = 0;
            //var result = new Object();
            //Exception caughtException = null;


            //Assert.ThrowsException<DetailException>(()=>)
            //var result = false;
            
            //private readonly ModelContext _context;
            //var controller = new MoviesController(new ModelContext());
            //var result = movies.Details(3);
            // await Assert.ThrowsExceptionAsync( async () =>
            // {
            //   await _moviesController.Details(2);  
            // });
            //Assert.ThrowsExceptionAsync(result != null);
            //Assert.IsFalse(result!=null);

        }
    }
}