using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace InventoryAcc.Models
{
    public class ComponentViewModel
    {
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(150)]
        [Display(Name = "Наименование")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Комната")]
        public string Room { get; set; } = string.Empty;

        [Display(Name = "Отдел")]
        public string Department { get; set; } = string.Empty;

        [Display(Name = "Начальник")]
        public string Chief { get; set; } = string.Empty;

        [Display(Name = "Ответственный")]
        public string Responsible { get; set; } = string.Empty;

        [Range(0, long.MaxValue)]
        [Display(Name = "Номер заявки")]
        public long RequestNumber { get; set; }

        [Display(Name = "Статус")]
        public string Status { get; set; } = string.Empty;


        //public List<SelectListItem> Rooms { get; set; } = new ();
    }
}
