﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentDetailsCrudWeb.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; } = 0;


        [Column(TypeName ="nvarchar(100)")]
        public string CardOwnerName { get; set; } = "";


        [Column(TypeName ="nvarchar(16)")]
        public string CardNumebr { get; set; } = "";


 [Column(TypeName ="nvarchar(5)")]
        public string ExpirationDate { get; set; } = "";


        [Column(TypeName ="nvarchar(3)")]
        public string SecurityCode { get; set; } = "";

    }

   
}
