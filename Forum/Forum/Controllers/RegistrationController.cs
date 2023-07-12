using Forum.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.IO;
using System.Text;

namespace Forum.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public RegistrationController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }
            
        [HttpPost]
        public async Task<IActionResult> Index(RegistrationBinding model)
        {

            if (ModelState.IsValid)
            {
                // Генерируем уникальное имя файла
                DateTime curentTime = DateTime.UtcNow;
                // string uniqueFileName = model.psevdonim + "_" + curentTime);
                StringBuilder sb = new StringBuilder(model.psevdonim + "_" + curentTime).Replace(" ", "").Replace(".", "").Replace(":", "");
                string uniqueFileName = sb.ToString();

                // Определяем путь к папке, где будут храниться загруженные фото
                string uploadPath = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");

                // Полный путь к файлу
                string filePath = Path.Combine(uploadPath, uniqueFileName);

                // Создаем поток для сохранения файла
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await model.photo.CopyToAsync(fileStream);
                }

                model.registration_time = curentTime;

                return Redirect("~/Home/Index");
            }

            return View(model);   
        }
    }
}
