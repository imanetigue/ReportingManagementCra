using System;
using System.ComponentModel.DataAnnotations;




namespace PROJECT.Models
{
    // Classe CRA
	public class Cra
    {
        public int Id { get; set; }

        [Display(Name = "Date de création du Cra : ")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Date de la dernière modif : ")]
        public DateTime UpdatedAt { get; set; }


       
       

        

        
    }
}

