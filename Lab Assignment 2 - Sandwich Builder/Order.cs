using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_2___Sandwich_Builder
{
    public class Order
    {

        //display the items that was selected
        public Customer Customer { get; set; }
        public string DeliveryMethod {get; set;}
        public string Tip { get; set; }
        public int Qty { get; set; }
        public DateTime OrderDateAndTime { get;  set; }
        public Sandwich sandwich { get; set; }
        public List<string> SelectedItems { get; set; } = new List<string>();
        public Order(Customer customer, string deliveryMethod, string tip, int qty, Sandwich sandwich)
        {
            Customer = customer;
            DeliveryMethod = deliveryMethod;
            Tip = tip;
            Qty = qty;
            this.sandwich = sandwich;
            OrderDateAndTime = DateTime.Now;
        }

        // Add methods to calculate the cost based on size, selections, and other factors.
        public Double CalculateTotalMeat()
        {
            double total = 0;
            foreach (var meats in sandwich.SelectedMeats)
            {
                if (sandwich.Meats.ContainsKey(meats))
                {
                    total += sandwich.Meats[meats];
                }
            }
            return total;
        }
        public Double CalculateTotalBread()
        {
            double total = 0;
            if (!string.IsNullOrEmpty(sandwich.SelectedBreadType) && sandwich.breadType.ContainsKey(sandwich.SelectedBreadType))
            {
                total += sandwich.breadType[sandwich.SelectedBreadType];
            }
            return total;
        }
        public Double CalculateTotalSize()
        {
            double total = 0;
            if (!string.IsNullOrEmpty(sandwich.SelectedSizeType) && sandwich.size.ContainsKey(sandwich.SelectedSizeType))
            {
                total += sandwich.Size[sandwich.SelectedSizeType];
            }
            return total;
        }

        public Double CalculateTotalSauce()
        {
            double total = 0;
            foreach (var sauce in sandwich.SelectedSauces)
            {
                if (sandwich.Sauces.ContainsKey(sauce))
                {
                    total += sandwich.Sauces[sauce];
                }
            }
            return total;

        }

        public Double CalculateTotalTopping()
        {
            double total = 0;
            foreach (var toppings in sandwich.SelectedToppings)
            {
                if (sandwich.Toppings.ContainsKey(toppings))
                {
                    total += sandwich.Toppings[toppings];
                }
            }
            return total;
        }

        public Double CalculateTotalCheese()
        {
            double total = 0;
            foreach (var cheeses in sandwich.SelectedCheeses)
            {
                if (sandwich.Cheeses.ContainsKey(cheeses))
                {
                    total += sandwich.Cheeses[cheeses];
                }
            }
            return total;
        }

        public Double CalculateTotalPremium()
        {
            double total = 0;
            foreach (var premium in sandwich.SelectedPremium)
            {
                if (sandwich.Premium.ContainsKey(premium))
                {
                    total += sandwich.Premium[premium];
                }
            }
            return total;
        }

        public Double CalculateTotalItem()
        {
            double total = 0;

            double totalCostOfBread = CalculateTotalBread();
            double totalCostofSize = CalculateTotalSize();
            double totalCostOfSauce = CalculateTotalSauce();
            double totalCostOfTopping = CalculateTotalTopping();
            double totalCostOfPremium = CalculateTotalPremium();
            double totalCostOfCheese = CalculateTotalCheese();
            double totalCostOfMeat = CalculateTotalMeat();

            total += totalCostOfPremium;
            total += totalCostOfCheese;
            total += totalCostOfTopping;
            total += totalCostOfSauce;
            total += totalCostOfBread;
            total += totalCostofSize;
            total += totalCostOfMeat;

            return Math.Round(total, 2);
        }
        public Double CalculateTax()
        {
            double taxRate = 0.06;
            double totalTax = taxRate * (CalculateTotalItem());

            return Math.Round(totalTax,2);
        }

        public Double CalculateTotalCost()
        {
            double displayTip = Convert.ToDouble(Tip);
            double totalCost;
            double totalItem = CalculateTotalItem();
            double totalTax = CalculateTax();
            totalCost = (totalItem*Qty) + totalTax + displayTip;
            return Math.Round(totalCost,2);
        }
        public string DisplayTotalMeat()
        {
            string displayMeat = Convert.ToString(CalculateTotalMeat());
            return displayMeat;
        }
        public string DisplayTotalBread()
        {
            string displayBread = Convert.ToString(CalculateTotalBread());
            return displayBread;
        }
        public string DisplayTotalSize()
        {
            string displaySize = Convert.ToString(CalculateTotalSize());
            return displaySize;
        }
        public string DisplayTotalSauce()
        {
            string displaySauce = Convert.ToString(CalculateTotalSauce());
            return displaySauce;
        }
        public string DisplayTotalTopping()
        {
            string displayTopping = Convert.ToString(CalculateTotalTopping());
            return displayTopping;
        }
        public string DisplayTotalPremium()
        {
            string displayPremium = Convert.ToString(CalculateTotalPremium());
            return displayPremium;
        }
        public string DisplayTotalCheese()
        {
            string displayCheese = Convert.ToString(CalculateTotalCheese());
            return displayCheese;
        }
        public String DisplayTotalItem()
        {
            string displayItem = Convert.ToString(CalculateTotalItem());
            return displayItem;
        }
        public String DisplayTotalTax()
        {
            string displayTaxes = Convert.ToString(CalculateTax());
            return displayTaxes;
        }

        public String DisplayTotalCost()
        {
            string displayTotal = Convert.ToString(CalculateTotalCost());
            return displayTotal;
        }
    }
}
