using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required (ErrorMessage = "A Name is Required")]
        public string Name { get; set; }

        [Required (ErrorMessage ="A Location is Required")]
        public string Location { get; set; }
    }
}
