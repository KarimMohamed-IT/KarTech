using System.ComponentModel.DataAnnotations;

namespace KarTech.Web.ViewModels.Computers
{
    public class StorageInputModel
    {

        [Required]
        public bool IsSSD { get; set; }

        [Required]
        public int Capacity { get; set; }
    }
}
