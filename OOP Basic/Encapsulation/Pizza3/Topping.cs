namespace PizzaCalories.ToppingType
{
    using System;

    class Topping
    {
        private const int CALORIES_PER_GRAM = 2;
        private const int MIN_WEIGHT = 1;
        private const int MAX_WEIGHT = 50;

        private string _name;
        private ToppingName _toppingType;
        private double _weight;

        public string Name
        {
            get => this._name;
            private set
            {
                if (Enum.TryParse(value, true, out this._toppingType) == false)
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this._name = value;
            }
        }
        public double Weight
        {
            get => this._weight;
            private set
            {
                if (value < MIN_WEIGHT || value > MAX_WEIGHT)
                {
                    throw new ArgumentException($"{this.Name} weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
                }
                this._weight = value;
            }
        }
        public double Calories => CALORIES_PER_GRAM * this.Weight * (int)this._toppingType / 10;

        public Topping(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
    }
}