using ApplicationApp.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Ecommerce.Controllers
{
 
    [Authorize]
    public class ProductController : Controller
    {
        public readonly InterfaceProduct _InterfaceProduct;
        public ProductController(InterfaceProduct InterfaceProduct)
        {
            _InterfaceProduct = InterfaceProduct;
        }

        // GET: ProductController
        public async Task<IActionResult> Index()
        {
            return View(await _InterfaceProduct.List());
        }

        // GET: ProductController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            return View(await _InterfaceProduct.GetEntityById(id));
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            try
            {
                await _InterfaceProduct.AddProduct(product);
                if (product.Notitycoes.Any())
                {
                    foreach (var item in product.Notitycoes)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.Message);
                    }
                    return View("Edit", product);
                }
            }
            catch
            {
                return View("Edit", product);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            return View(await _InterfaceProduct.GetEntityById(id));
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            try
            {
                await _InterfaceProduct.UpdateProduct(product);
                if (product.Notitycoes.Any())
                {
                    foreach (var item in product.Notitycoes)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.Message);
                    }
                    return View("Edit", product);
                }
            }
            catch
            {
                return View("Edit", product);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _InterfaceProduct.GetEntityById(id));
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Product product)
        {
            try
            {
                var productDelete = await _InterfaceProduct.GetEntityById(id);

                await _InterfaceProduct.Delete(productDelete);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
