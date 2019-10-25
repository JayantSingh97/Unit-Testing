# Unit-Testing
 Web api 2 unit testing in c# using Vs 2019

# Api Unit testing code.
```
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MicrosoftUnityDependencyInjectionApiDemo.Interface;
using System.Collections.Generic;
using MicrosoftUnityDependencyInjectionApiDemo.implementation;
using MicrosoftUnityDependencyInjectionApiDemo.Controllers;
using System.Net.Http;
using System.Web.Http;

namespace MicrosoftWebApiUnitTest
{
    [TestClass]
    public class MicrosoftWebApiUnitTestController
    {

        private readonly IProductService _repository = new ProductService();
        private List<Product> _products;
        private Product _product;
        private Int32 Product_Id = 1001;

        [TestMethod]
        [HttpGet]
        public void Check_Api_response_for_products()
        { 
            var controller = new ProductController(_repository);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
             
            var response = controller.GetProducts();
             
            Assert.IsNotNull(response.TryGetContentValue<List<Product>>(out _products));
          
            Assert.IsTrue(response.IsSuccessStatusCode);

        }

        [TestMethod]
        [HttpGet]
        public void Check_Api_response_for_products_By_product_Id()
        {
            var controller = new ProductController(_repository);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            var response = controller.GetProductById(Product_Id.ToString()); 
            
            Assert.IsNotNull(response.TryGetContentValue(out _product));
            
            Assert.IsTrue(response.IsSuccessStatusCode);
             
        }

        [TestMethod]
        [HttpPost]
        public void Check_Api_response_for_create_new_product()
        {
            var controller = new ProductController(_repository);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            var response = controller.CreateProduct(
                  new Product()
                  {
                      ProductId = 2001,
                      ProductName = "Apple Iphone x",
                      Price = "68900",
                      IsAvailable = true.ToString(),
                      Launchdate = DateTime.Now.ToString(),
                      Category = "Mobile",
                      Color = "White",
                      ImageUrl = "https://cdn2.gsmarena.com/vv/pics/apple/apple-iphone-x-new-2.jpg",
                      Camera = "Front Camera : 8.Megapixel Back Camera 16.Megapixel",
                      Display = "Retina HD Display",
                      Processor = "Apple Chip.",
                      Storage = "30 GB",
                      Weight = "100.G",
                      Description = "iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."
                    }
                );
             
            Assert.IsTrue(response.IsSuccessStatusCode);
             
        }

        [TestMethod]
        [HttpPatch]
        public void Check_Api_response_for_Update_product()
        {
            var controller = new ProductController(_repository);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            var response = controller.UpdateProduct(
                  new Product()
                  {
                      ProductId = 1001,
                      ProductName = "Apple Iphone x",
                      Price = "68900",
                      IsAvailable = true.ToString(),
                      Launchdate = DateTime.Now.ToString(),
                      Category = "Mobile",
                      Color = "White",
                      ImageUrl = "https://cdn2.gsmarena.com/vv/pics/apple/apple-iphone-x-new-2.jpg",
                      Camera = "Front Camera : 8.Megapixel Back Camera 16.Megapixel",
                      Display = "Retina HD Display",
                      Processor = "Apple Chip.",
                      Storage = "30 GB",
                      Weight = "100.G",
                      Description = "iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."
                  }
                );

            Assert.IsTrue(response.IsSuccessStatusCode);

        }

        [TestMethod]
        [HttpDelete]
        public void Check_Api_response_for_Delete_product()
        {
            var controller = new ProductController(_repository);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            var response = controller.DeleteProduct(Product_Id);
             
            Assert.IsTrue(response.IsSuccessStatusCode);

        }

    }
}

```
