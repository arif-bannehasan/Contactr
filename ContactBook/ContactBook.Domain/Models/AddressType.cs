﻿using ContactBook.Domain.Validations;
using System;
using System.ComponentModel.DataAnnotations;

namespace ContactBook.Domain.Models
{
    public class AddressType : IEquatable<AddressType>
    {
        public int AddressTypeId { get; set; }

        [TypeExists("BookId")]
        [Required(ErrorMessage = "Address type cannot be empty.")]
        [Display(Name = "AddressType")]
        public string AddressTypeName { get; set; }

        [ValidateBookId]
        public Nullable<long> BookId { get; set; }

        public bool Equals(AddressType other)
        {
            if (other != null)
            {
                return (this.AddressTypeId == other.AddressTypeId && this.AddressTypeName == other.AddressTypeName && this.BookId == other.BookId);
            }

            return false;
        }
    }
}