using MicrosoftUnityDependencyInjectionApiDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MicrosoftUnityDependencyInjectionApiDemo.Controllers
{
    public class ProductController : ApiController
    {
        
        private readonly IProductService _repository; 
        public ProductController(IProductService repository)
        {
            _repository = repository;
        }
         
        [HttpGet]
        public HttpResponseMessage GetProducts()
        {
           return  Request.CreateResponse(HttpStatusCode.OK, _repository.GetAllProduct());
        }

        [HttpGet]
        public HttpResponseMessage GetProductById([FromUri] string id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _repository.GetProduct(Convert.ToInt32(id)));
        }

        [HttpPost]
        public HttpResponseMessage CreateProduct([FromBody] Product prodcut)
        {
            if (ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.Created, _repository.CreateProduct(prodcut));
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest,"Data Missing.");
        }

        [HttpPatch]
        public HttpResponseMessage UpdateProduct([FromBody] Product prodcut)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _repository.UpdateProduct(prodcut));
        }

        [HttpDelete]
        public HttpResponseMessage DeleteProduct([FromUri] int Productid)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _repository.DeleteProduct(Convert.ToInt32(Productid)));
        }
    }
}
