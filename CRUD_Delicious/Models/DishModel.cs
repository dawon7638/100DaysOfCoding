using System;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Delicious.Models
{
    public class DishModel
    {
        [Key]//Required for all assignments
             ///////////////////DISH ID
        public int DishId { get; set; }

        ////////////////FOOD NAME
        [Required(ErrorMessage = "Please name your dish!")]
        [Display(Name = "Name of Dish:")]
        [MaxLength(45)]
        public string Name { get; set; }

        /////////////CHEF'S NAME
        [Required(ErrorMessage = "Who is the creator of this dish?!")]
        [Display(Name = "Chef's Name:")]
        [MaxLength(45)]
        public string Chef { get; set; }

        ////////////TASTINESS
        [Required]
        [Display(Name = "Tastiness:")]
        [Range(1, 5, ErrorMessage = "Tastiness must be between 1 and 5!")]
        public int Tastiness { get; set; }

        ///////////DESCRIPTION
        [Required(ErrorMessage = "Description required!")]
        [Display(Name = "Description:")]
        public string Description { get; set; }

        //////////CREATED AT DATE AND TIME
        public DateTime CreatedAt {get; set;} = DateTime.Now;

        //////////UPDATED AT DATE AND TIME
        public DateTime UpdatedAt {get; set;} = DateTime.Now;


    }
}