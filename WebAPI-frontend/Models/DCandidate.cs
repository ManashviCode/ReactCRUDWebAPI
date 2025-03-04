﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_frontend.Models
{
    public class DCandidate
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string fullname {  get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string mobile {  get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string email {  get; set; }

        public int age {  get; set; }

        [Column(TypeName = "nvarchar(3)")]
        public string bloodgroup {  get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string address {  get; set; }


    }
}
