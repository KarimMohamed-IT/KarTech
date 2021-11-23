namespace KarTech.Web.ViewModels.Computers
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using KarTech.Data.Models;

    public class CreateComputerViewModel
    {
        [Required(ErrorMessage = "The length of the Title must be between 5 and 70.")]
        [MinLength(5, ErrorMessage = "The length of the Title must be at least 5.")]
        [MaxLength(70, ErrorMessage = "The length of the Title must not be above 70.")]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Brand field is required.")]
        public Brand Brand { get; set; }

        [Required(ErrorMessage = "Type field is required.")]
        public bool Type { get; set; }

        [Required(ErrorMessage = "RAM field is required.")]
        public byte RamId { get; set; }

        [Required]
        [Range(50, 10000)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Processor field is required.")]

        public int CpuId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CpuItems { get; set; }

        [Required(ErrorMessage = "Graphics card field is required.")]
        public int GpuId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> GpuItems { get; set; }

        public IEnumerable<KeyValuePair<string, string>> RamItems { get; set; }

        [Required]
        public IEnumerable<StorageInputModel> Storages { get; set; }
    }
}
