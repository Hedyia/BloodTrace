using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodTrace.Models
{
    public static class StaticDonators
    {
        public static ObservableCollection<Donator> Donators { get; set; } = new ObservableCollection<Donator>()
        {
            new Donator()
            {
                Id = 1,
                Name = "Muhammed",
                Email = "muo.cpp@gmail.com",
                Phone = "01069505019",
                BloodGroup = "A+",
                Country = "Egypt"
            },
            new Donator()
            {
                Id = 2,
                Name = "John",
                Email = "john@gmail.com",
                Phone = "8100999991",
                BloodGroup = "O+",
                Country = "USA"
            },
            new Donator()
            {
                Id = 3,
                Name = "Saad",
                Email = "Saad@uae.com",
                Phone = "991199199",
                BloodGroup = "B-",
                Country = "UAE"
            },
        };
        public static ObservableCollection<Donator> SearchedDontrors = new ObservableCollection<Donator>();
    }
}
