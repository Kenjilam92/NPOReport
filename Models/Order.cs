using System;
using System.ComponentModel.DataAnnotations;

namespace reportNPO.Models
{
    public class Order
    {
        [Key]
        public int OrderId {get;set;}
        [Required]
        public string OrderNumbers {get;set;}
        [Required]
        public string NPOName {get;set;}
        [Required]
        public double Total {get;set;}
    }
}