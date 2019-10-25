using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MicrosoftUnityDependencyInjectionApiDemo.Interface
{
    public interface IProductService   //Declaration of   IProductService 
    {

        List<Product> GetAllProduct();

        List<Product> GetProduct(int id);

        List<Product> UpdateProduct(Product product);

        List<Product> CreateProduct(Product product);

        List<Product> DeleteProduct(int id);

    }

     
    public class Product  // product calss Like DbobjectSets<Object>  in entity fremwork 6.0
    {
        
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Product Name is Required")]  
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Price is Required")]
        public string Price { get; set; }
        [Required(ErrorMessage = "IsAvailable is Required")]
        public string IsAvailable { get; set; }
        [Required(ErrorMessage = "Launchdate is Required")]
        [DataType(DataType.DateTime)]
        public string Launchdate { get; set; }
        [Required(ErrorMessage = "Category is Required")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Color is Required")]
        public string Color { get; set; }
        [Required(ErrorMessage = "ImageUrl is Required")]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Product Description is Required")]
        public string Description { get; set; }
        public string Camera { get; set; }
        public string Display { get; set; }
        public string Processor { get; set; }
        public string Storage { get; set; }
        public string Weight { get; set; }


    }
}