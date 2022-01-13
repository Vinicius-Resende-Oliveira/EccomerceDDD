using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProduct _IProduct;
        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }
        public async Task AddProduct(Product product)
        {
            var validatorName = product.ValidatorPropertyString(product.Name, "Name");

            var validatorPrice = product.ValidatorPropertyDecimal(product.Price, "Price");

            if (validatorName && validatorPrice)
            {
                product.Status = true;

                await _IProduct.Add(product);
            }
        }

        public async Task UpdateProduct(Product product)
        {
            var validatorName = product.ValidatorPropertyString(product.Name, "Name");

            var validatorPrice = product.ValidatorPropertyDecimal(product.Price, "Price");

            if (validatorName && validatorPrice)
            {

                await _IProduct.Update(product);
            }
        }
    }
}
