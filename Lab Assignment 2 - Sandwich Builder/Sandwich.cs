using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_2___Sandwich_Builder
{
    public class Sandwich
    {
        public Dictionary<String, Double> breadType = new Dictionary<string, double> {

            { "Italian", .99 },
            { "Rye", 1.09},
            { "Flatbread", 1.19},
            { "Wheat", 1.29},
            { "Mult-grain", 1.39},
            { "Sourdough", 1.49},
        };

        public Dictionary<String, Double> size = new Dictionary<string, double>
        {
            { "Small", 1},
            { "Medium", 2},
            { "Large", 3},
            { "Extra-large", 4},
            { "Party-size", 5},
        };

        public Dictionary<String, Double> sauces = new Dictionary<string, double>
        {
            { "Mayo", 0.1},
            { "Mustard", 0.2},
            { "Oil", 0.3},
            { "Vinegar", 0.4},
            { "BBQ Sauce", 0.5},
            { "Ketchup", 0.6},
            { "Hot Sauce", 0.7},
            { "Ranch", 0.8},
        };
        public Dictionary<String, Double> meats = new Dictionary<string, double>
        {
            { "Roast Beef", 0.5},
            { "Tuna", 1},
            { "Turkey", 1.5},
            { "Meatballs", 2},
            { "Salami", 2.5},
            { "Pepperoni", 3},
            { "Ham", 3.5},
            { "Bacon", 4},
            { "Chicken", 4.5},
            { "Pastrami", 5},
        };
        public Dictionary<String, Double> cheeses = new Dictionary<string, double>
        {
            { "American", 0.20},
            { "Cheddar", 0.40},
            { "Swiss", 0.60},
            { "Provolone", 0.80},
            { "Mozzarella", 1},
        };
        public Dictionary<String, Double> toppings = new Dictionary<string, double>
        {
            { "Lettuce", 0.05},
            { "Tomatoes", 0.1},
            { "Onions", 0.15},
            { "Pickles", 0.20},
            { "Green Peppers", 0.25},
            { "Red Peppers", 0.30},
            { "Jalapenos", 0.35},
            { "Spinach", 0.40},
            { "Cucumbers", 0.45},
            { "Banana Peppers", 0.50},
        };
        public Dictionary<String, Double> premium = new Dictionary<string, double>
        {
            { "Extra Cheese", 0.15},
            { "Extra Meat", 0.30},
            { "Vegan Bacon", 0.45},
            { "Avocado", 0.60},
            { "Sundried Tomato", 0.75},
            { "Feta Cheese", 0.90},
            { "Pesto Sauce", 1.05},
            { "Olives", 1.20},
            { "Guacamole", 1.35},
            { "Sliced Egg", 1.50},
        };
        //public List<string> Sauces { get; set; }
        //public List<string> Meats { get; set; }
        //public List<string> Cheeses { get; set; }
        //public List<string> Toppings { get; set; }
        //public List<string> PremiumAdditions { get; set; }
        
        public Dictionary<String, Double> BreadType
        {
            get
            {
                return breadType;
            }
        }

        public Dictionary<String, Double> Size
        {
            get
            {
                return size;
            }
        }
        public string SelectedBreadType { get; set; }
        public string SelectedSizeType { get; set; }
        public List<string> SelectedSauces { get; set; } // To store selected sauces
        public List<string> SelectedCheeses { get; set; } // To store selected cheeses
        public List<string> SelectedPremium { get; set; } // To store selected Premium
        public List<string> SelectedToppings { get; set; } // To store selected cheeses
        public List<string> SelectedMeats { get; set; }

        public Sandwich(string bread, string size, List<string> selectedSauces, List<string> selectedCheeses, List<string> selectedPremium, List<string> selectedToppings, List<string> selectedMeats)
        {
            this.SelectedBreadType = bread;
            this.SelectedSizeType = size;
            this.SelectedSauces = selectedSauces;
            this.SelectedCheeses = selectedCheeses;
            this.SelectedPremium = selectedPremium;
            this.SelectedToppings = selectedToppings;
            this.SelectedMeats = selectedMeats;

        }

        public Dictionary<String, Double> Sauces
        {
            get
            {
                return sauces;
            }
        }
        public Dictionary<String, Double> Meats
        {
            get
            {
                return meats;
            }
        }
        public Dictionary<String, Double> Cheeses
        {
            get
            {
                return cheeses;
            }
        }
        public Dictionary<String, Double> Toppings
        {
            get
            {
                return toppings;
            }
        }
        public Dictionary<String, Double> Premium
        {
            get
            {
                return premium;
            }
        }

    }
}
