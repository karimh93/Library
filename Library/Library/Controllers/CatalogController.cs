using Library.Models.Catalog;
using LibraryData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Library.Controllers
{
    public class CatalogController:Controller
    {

        private readonly ILibraryAsset _libraryAssets;

        public CatalogController(ILibraryAsset libraryAssets)
        {
            _libraryAssets = libraryAssets;
        }
    
        public IActionResult Index()
        {
            var assetModels = _libraryAssets.GetAll();

            var listingResult = assetModels.Select(result => new AssetIndexListingModel
            {

                Id = result.Id,
                ImageUrl = result.ImageUrl,
                AuthorOrDirector = _libraryAssets.GetAuthorOrDirector(result.Id),
                Title = result.Title,
                Type = _libraryAssets.GetType(result.Id)


            });

            var model = new AssetIndexModel()
            {
                Assets = listingResult
            };
            return View(model);
        }
    
    }
}
