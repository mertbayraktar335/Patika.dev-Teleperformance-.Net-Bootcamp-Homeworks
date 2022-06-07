using System.Collections.Generic;
using System.Linq;
using MertBayraktar.Homeworks.Week1.DTOs;
using MertBayraktar.Homeworks.Week1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace MertBayraktar.Homeworks.Week1.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        public static List<Product> productList = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name="A",
                Category="D",
                Price= 15

            },
            new Product
            {
                Id = 3,
                Name="B",
                Category="C",
                Price= 20,

            },
            new Product
            {
                Id = 5,
                Name="C",
                Category="B",
                Price= 25

            }


        };
        //POST api/products
        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            productList.Add(product);
            return Created("api/products", product);


        }

        //POST api/products
        [HttpPost("[action]")]
        public IActionResult AddFromQuery([FromQuery] Product product)
        {
            productList.Add(product);
            return Created("api/products", product);
        }

        //PUT api/products/id
        [HttpPut("[action]/{id}")]
        public IActionResult Put(int id, [FromBody] ProductUpdateDto productDto)
        {
            var product = productList.SingleOrDefault(a => a.Id == id);
            product.Name = productDto.Name;
            product.Category = productDto.Category;
            product.Price = productDto.Price;

            return NoContent();
        }

        //PUT api/products/id
        [HttpPut("{id}")]
        public IActionResult PutFromQuery(int id, [FromQuery] ProductUpdateDto productDto)
        {
            var product = productList.SingleOrDefault(a => a.Id == id);
            product.Name = productDto.Name;
            product.Category = productDto.Category;
            product.Price = productDto.Price;

            return NoContent();
        }

        //DELETE api/products/id
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var product = productList.FirstOrDefault(a => a.Id == id);
            if (product is null)
                return BadRequest("Ürün Bulunamadı");
            
                productList.Remove(product);
            return NoContent(); 
        }

        //PATCH api/products/id
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] JsonPatchDocument<ProductPatchDto> productDto)
        {
             return Created("api/products", productDto);
            
           
        }

        //GET api/products
        [HttpGet]
        public IActionResult GetProducts()
        {
            
            if (productList.Count == 0)
                return BadRequest("Liste Boş");
            else
                return Ok(productList);


        }

        //GET api/products/id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = new Product();
            product = productList.Where(x => x.Id == id).SingleOrDefault();
            if (product == null)
                return NotFound("Ürün Bulunamadı");
            else
                return Ok(product);
        }

        //GET api/products/list?name=abc
        [HttpGet("[action]")]
        public IActionResult GetProductsOrderedByName()
        {
            List<Product> SortedList = productList.OrderBy(x => x.Name).ToList();
            if (SortedList.Count == 0)
                return NotFound("Liste Boş");
            else
                return Ok(SortedList);

        }

    }
}

