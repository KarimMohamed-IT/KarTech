namespace KarTech.Web.Controllers
{
    using KarTech.Services.Data;
    using KarTech.Web.ViewModels.Computers;
    using Microsoft.AspNetCore.Mvc;
    using System.Text;

    public class ComputerController : Controller
    {
        private readonly ICpuItemsService cpuItemsService;
        private readonly IGpuItemsService gpuItemsService;
        private readonly IRamItemsService ramItemsService;

        public ComputerController(ICpuItemsService cpuItemsService, IGpuItemsService gpuItemsService, IRamItemsService ramItemsService)
        {
            this.cpuItemsService = cpuItemsService;
            this.gpuItemsService = gpuItemsService;
            this.ramItemsService = ramItemsService;
        }

        public IActionResult Add()
        {
            var viewModel = new CreateComputerViewModel();
            viewModel.CpuItems = this.cpuItemsService.GetAllCpuItems();
            viewModel.GpuItems = this.gpuItemsService.GetAllGpuItems();
            viewModel.RamItems = this.ramItemsService.GetAllRamItems();
            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Add(CreateComputerViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CpuItems = this.cpuItemsService.GetAllCpuItems();
                input.GpuItems = this.gpuItemsService.GetAllGpuItems();
                input.RamItems = this.ramItemsService.GetAllRamItems();

                return this.View(input);
            }

            return this.Json(input);
        }
    }
}
