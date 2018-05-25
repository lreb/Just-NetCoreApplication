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
        public async Task Details()
        {
            var result = await _moviesController.Details(2);

            //private readonly ModelContext _context;
            //var controller = new MoviesController(new ModelContext());
            //var result = movies.Details(3);
            Assert.IsFalse(result!=null);
        }
    }
}