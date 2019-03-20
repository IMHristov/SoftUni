namespace PizzaCalories.DoughType
{
    using System;

    class Dough
    {
        private const int CALORIES_PER_GRAM = 2;
        private const int MIN_WEIGHT = 1;
        private const int MAX_WEIGHT = 200;

        private double _weight;
        private FlourType _flourType;
        private BakingTechnique _bakingTechnique;

        public string FlourType
        {
            get => this._flourType.ToString();
            private set
            {
                if (Enum.TryParse(value, true, out this._flourType) == false)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
        public string BakingTechnique
        {
            get => this._bakingTechnique.ToString();
            private set
            {
                if (Enum.TryParse(value, true, out this._bakingTechnique) == false)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
            }
        }
        public double Weight
        {
            get => this._weight;
            private set
            {
                if (value < MIN_WEIGHT || value > MAX_WEIGHT)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
                }
                this._weight = value;
            }
        }
        public double Calories => CALORIES_PER_GRAM * this.Weight * (int)this._flourType * (int)this._bakingTechnique / 100;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }
    }
}