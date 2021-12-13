using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AZCApi
{
    public class Station
    {
        [Key]
        public int Station_Id { get; set; }

        private string _address;
        public string Address
        {
            get => _address;
            set
            {
                if ((!string.IsNullOrWhiteSpace(value)) && (value.Length <= 100))
                    _address = value;

            }
        }

    }
}
