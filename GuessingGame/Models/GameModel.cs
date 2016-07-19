using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingGame.Models
{
    //data model for our page controller will pull this and give to view
    //required gives consistent validation; tells system to create instance of required
    public class GameModel
    {
        [Display(Name = "Enter Your Name")]
        [Required(ErrorMessage = "You must enter your name")]
        [MinLength(2,ErrorMessage = "Name is too short")] 
        [MaxLength(20, ErrorMessage = "Name is too long")]
        
        public string PlayerName { get; set; }
     

        [Display(Name = "What is your guess?")]        
        [Required(ErrorMessage = "Guess is required")]
        [Range(1, 10, ErrorMessage = "Guess must be between 1 and 10")]

        public int Guess { get; set; }

        public override string ToString()
        {
            return $"{PlayerName} ({Guess})";
        }
    }
}