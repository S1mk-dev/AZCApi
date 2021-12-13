using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AZCApi
{
    public class Date
    {
        [Key]
        public int Id_Data { get; set; }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if ((!string.IsNullOrWhiteSpace(value)) && (value.Length <= 100))
                    _name = value;

            }
        }

        private string _price;
        public string Price
        {
            get => _price;
            set
            {
                if ((!string.IsNullOrWhiteSpace(value)) && (value.Length <= 100))
                    _price = value;
            }
        }

        private int _amountOfFuel;
        public int AmountOfFuel
        {
            get => _amountOfFuel;
            set
            {
                if (value.ToString().Length == 3)
                    _amountOfFuel = value;
            }
        }

        [ForeignKey("Station_Id")]
        public int Station_Id { get; set; }


    }
}

