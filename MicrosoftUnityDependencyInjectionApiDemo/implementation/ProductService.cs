using MicrosoftUnityDependencyInjectionApiDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MicrosoftUnityDependencyInjectionApiDemo.implementation
{

    //implementation of   IProductService 

    public class ProductService : IProductService
    {
        private List<Product> newproductList = new List<Product>();
        private Product newproduct = new Product();

        List<Product> IProductService.CreateProduct(Product product)
        {
            //creating new product
            newproduct.ProductId = product.ProductId;
            newproduct.ProductName = product.ProductName;
            newproduct.Price = product.Price;
            newproduct.IsAvailable = product.IsAvailable;
            newproduct.Launchdate = product.Launchdate;
            newproduct.Camera = product.Camera;
            newproduct.Category = product.Category;
            newproduct.Color = product.Color;
            newproduct.Description = product.Description;
            newproduct.Display = product.Display;
            newproduct.ImageUrl = product.ImageUrl;
            newproduct.Processor = product.Processor;
            newproduct.Storage = product.Storage;
            newproduct.Weight = product.Weight;
            
            newproductList.Add(newproduct);
            return newproductList;

        }

        List<Product> IProductService.DeleteProduct(int id)
        {
            //Deleting   product if it exists

            if (DBContext.GetProducts().Any(p => p.ProductId == id))
            {
                return DBContext.GetProducts().Where(p => p.ProductId != id).ToList();

            }
            return new List<Product>();
        }

        List<Product> IProductService.GetAllProduct()
        {
            //Get all products form you DB entity

            return DBContext.GetProducts();
        }

        List<Product> IProductService.GetProduct(int id)
        {
            //Search   product in DB 

            return DBContext.GetProducts().Where(p => p.ProductId == id).ToList();
        }

        List<Product> IProductService.UpdateProduct(Product product)
        {
            //Update new product  if it exists in db 
            if (DBContext.GetProducts().Any(p => p.ProductId == product.ProductId))
            {
                Product product2Update = DBContext.GetProducts().Where(p => p.ProductId == product.ProductId).SingleOrDefault();
                product2Update.ProductName = product.ProductName;
                product2Update.Price = product.Price;
                product2Update.IsAvailable = product.IsAvailable;
                product2Update.Launchdate = product.Launchdate;
                product2Update.Color = product.Color;
                product2Update.ImageUrl = product.ImageUrl;
                newproductList.Add(product2Update);
                return newproductList;
            }
            return new List<Product>();
        }
    }


    public static class DBContext    //Your DB context entity Configurations goes here 
    {
        private static List<Product> newproductList = new List<Product>();
        private static Product newproduct = new Product();
        public static List<Product> GetProducts()
        {
            List<Product> Products = new List<Product>()
            {
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
                    Camera ="Front Camera : 8.Megapixel Back Camera 16.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "30 GB",
                    Weight = "100.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                },
                new Product()
                {
                     ProductId = 1002,
                     ProductName = "Apple Iphone se",
                     Price = "30900",
                     IsAvailable = true.ToString(),
                     Launchdate = DateTime.Now.ToString(),
                     Category = "Mobile",
                     Color = "Gold",
                     ImageUrl = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/5859/5859415cv11d.jpg",
                     Camera ="Front Camera : 8.Megapixel Back Camera 12.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "30 GB",
                    Weight = "100.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                },
                new Product()
                {
                    ProductId = 1003,
                    ProductName = "Apple macbook air",
                    Price = "168900",
                    IsAvailable = true.ToString(),
                    Launchdate = DateTime.Now.ToString(),
                    Category = "Laptop" ,
                    Color = "Gold",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/G/01/img15/brawner/MacBookAir-Overview-amazon1_7._CB479646175_.jpg",
                     Camera ="Front Camera : 12.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "2 TB",
                    Weight = "250.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                },
                new Product()
                {
                    ProductId = 1004,
                    ProductName = "Apple Mac pro",
                    Price = "210900",
                    IsAvailable = false.ToString(),
                    Launchdate = DateTime.Now.ToString(),
                    Category = "Laptop",
                    Color = "Sliver",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRyolLO7Bd7aKy-NgfPDGmoMfgnnef0zV0FfkAzbpUdWRHg4zH8",
                     Camera ="Front Camera : 12.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "2 TB",
                    Weight = "250.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                }
                ,
                new Product()
                {
                    ProductId = 1005,
                    ProductName = "Apple Iphone x",
                    Price = "68900",
                    IsAvailable = true.ToString(),
                    Launchdate = DateTime.Now.ToString(),
                    Category = "Mobile",
                    Color = "Black",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTCFpcIAV4TLPa_4gza1dw94ay042R7LdWKXu0fZ7j3KFykowj2",
                     Camera ="Front Camera : 8.Megapixel Back Camera 16.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "30 GB",
                    Weight = "100.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                },
                new Product()
                {
                     ProductId = 1006,
                     ProductName = "Apple Iphone se",
                     Price = "30900",
                     IsAvailable = true.ToString(),
                     Launchdate = DateTime.Now.ToString(),
                     Category = "Mobile",
                     Color = "Gold",
                     ImageUrl = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/5859/5859415cv11d.jpg",
                      Camera ="Front Camera : 8.Megapixel Back Camera 12.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "30 GB",
                    Weight = "100.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                },
                new Product()
                {
                    ProductId = 1007,
                    ProductName = "Apple macbook air",
                    Price = "168900",
                    IsAvailable = true.ToString(),
                    Launchdate = DateTime.Now.ToString(),
                    Category = "Laptop" ,
                    Color = "Gold",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/G/01/img15/brawner/MacBookAir-Overview-amazon1_7._CB479646175_.jpg",
                     Camera ="Front Camera : 12.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "1 TB",
                    Weight = "250.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                },
                new Product()
                {
                    ProductId = 1008,
                    ProductName = "Apple Mac pro",
                    Price = "210900",
                    IsAvailable = false.ToString(),
                    Launchdate = DateTime.Now.ToString(),
                    Category = "Laptop",
                    Color = "Sliver",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRyolLO7Bd7aKy-NgfPDGmoMfgnnef0zV0FfkAzbpUdWRHg4zH8",
                     Camera ="Front Camera : 12.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "2 TB",
                    Weight = "250.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                },

                new Product()
                {
                    ProductId = 1009,
                    ProductName = "Apple Iphone x",
                    Price = "68900",
                    IsAvailable = true.ToString(),
                    Launchdate = DateTime.Now.ToString(),
                    Category = "Mobile",
                    Color = "White",
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQeJrwRSDqnwc1WlEw_geZwWLEa1Jr59bz4p6qXPhzrPFEZuGz4QQ",
                    Camera ="Front Camera : 8.Megapixel Back Camera 16.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "30 GB",
                    Weight = "100.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                },
                new Product()
                {
                     ProductId = 1010,
                     ProductName = "Apple Iphone se",
                     Price = "30900",
                     IsAvailable = true.ToString(),
                     Launchdate = DateTime.Now.ToString(),
                     Category = "Mobile",
                     Color = "Gold",
                     ImageUrl = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/5859/5859415cv11d.jpg",
                     Camera ="Front Camera : 8.Megapixel Back Camera 12.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "1 GB",
                    Weight = "100.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                },
                new Product()
                {
                    ProductId = 1011,
                    ProductName = "Apple macbook air",
                    Price = "168900",
                    IsAvailable = true.ToString(),
                    Launchdate = DateTime.Now.ToString(),
                    Category = "Laptop" ,
                    Color = "Rose",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/G/01/img15/brawner/MacBookAir-Overview-amazon1_7._CB479646175_.jpg",
                     Camera ="Front Camera : 12.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "2 TB",
                    Weight = "250.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                },
                new Product()
                {
                    ProductId = 1012,
                    ProductName = "Apple Mac pro",
                    Price = "210900",
                    IsAvailable = false.ToString(),
                    Launchdate = DateTime.Now.ToString(),
                    Category = "Laptop",
                    Color = "Rose",
                    ImageUrl = "https://tshop.r10s.com/e78/d5b/f47c/9062/b08d/f628/3ef1/114ae79736c454448095d5.jpg",
                     Camera ="Front Camera : 12.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "2 TB",
                    Weight = "250.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                },

                new Product()
                {
                    ProductId = 1013,
                    ProductName = "Apple Iphone x",
                    Price = "68900",
                    IsAvailable = true.ToString(),
                    Launchdate = DateTime.Now.ToString(),
                    Category = "Mobile",
                    Color = "White",
                    ImageUrl = "https://cdn2.gsmarena.com/vv/pics/apple/apple-iphone-x-new-2.jpg",
                     Camera ="Front Camera : 8.Megapixel Back Camera 16.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "30 GB",
                    Weight = "100.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                },
                new Product()
                {
                     ProductId = 1014,
                     ProductName = "Apple Iphone se",
                     Price = "30900",
                     IsAvailable = true.ToString(),
                     Launchdate = DateTime.Now.ToString(),
                     Category = "Mobile",
                     Color = "Sliver",
                     ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/71q6vIPWKSL._SY550_.jpg",
                    Camera ="Front Camera : 8.Megapixel Back Camera 12.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "1 GB",
                    Weight = "100.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                },
                new Product()
                {
                    ProductId = 1015,
                    ProductName = "Apple macbook air",
                    Price = "168900",
                    IsAvailable = true.ToString(),
                    Launchdate = DateTime.Now.ToString(),
                    Category = "Laptop" ,
                    Color = "Gold",
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/G/01/img15/brawner/MacBookAir-Overview-amazon1_7._CB479646175_.jpg",
                     Camera ="Front Camera : 12.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "2 TB",
                    Weight = "250.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                },
                new Product()
                {
                    ProductId = 1016,
                    ProductName = "Apple Mac pro",
                    Price = "210900",
                    IsAvailable = true.ToString(),
                    Launchdate = DateTime.Now.ToString(),
                    Category = "Laptop",
                    Color = "Gold",
                    ImageUrl = "https://cdn.vox-cdn.com/uploads/chorus_asset/file/13359581/macbook2.png",
                    Camera ="Front Camera : 12.Megapixel",
                    Display="Retina HD Display",
                    Processor="Apple Chip.",
                    Storage = "2 TB",
                    Weight = "250.G",
                    Description ="iPhone is a device presented by Apple Inc. performing the function of a mobile phone, MP3 player (iPod) and Instant Messenger, as it has been called by Apple Inc. ... iPhone enables listening to music (MP3 files), watching videos in mpeg format and taking photos with a 2.0 megapixel camera."

                }

            };

            return Products;

        }

    }


}