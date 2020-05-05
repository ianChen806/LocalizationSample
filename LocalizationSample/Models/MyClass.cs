using System.ComponentModel.DataAnnotations;

namespace LocalizationSample.Models
{
    public class MyClass
    {
        [Display(Name = "MyClass.Id")]
        public string Id { get; set; }
        
        [Display(Name = "MyClass.Name")]
        public string Name { get; set; }
    }
}