namespace PizzaCalories
{
    using PizzaCalories.DoughType;
    using PizzaCalories.ToppingType;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Pizza
    {
        private const int MAX_SYMBOLS = 15;
        private const int MAX_TOPPINGS = 10;

        private readonly List<Topping> _toppings = new List<Topping>();
        private string _name;

        public string Name
        {
            get => this._name;
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > MAX_SYMBOLS)
                {
                    throw new ArgumentException($"Pizza name should be between 1 and {MAX_SYMBOLS} symbols.");
                }
                this._name = value;
            }
        }
        public Dough Dough { get; private set; }
        public double Calories => this.Dough.Calories + this._toppings.Sum(t => t.Calories);

        public Pizza(string name)
        {
            this.Name = name;
        }

        public void AddDough(Dough dough) => this.Dough = dough;

        public void AddTopping(Topping topping)
        {
            if (this._toppings.Count == MAX_TOPPINGS)
            {
                throw new InvalidOperationException($"Number of toppings should be in range [0..{MAX_TOPPINGS}].");
            }
            this._toppings.Add(topping);
        }

        public override string ToString() => $"{this.Name} - {this.Calories:F2} Calories.";
    }
}