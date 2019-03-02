using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample
{
    class Candy
    {
        public string Flavor { get; set; }
        public int Rating { get; set; } = 1; // <-- Property Initailizer.  Can set default value. Do not need to set in CTOR
        public string Review { get; set; }
        public string Name { get; set; }
        public CandyType Type { get; set; }

        const int MinRatingValue = 1;
        const int MaxRatingValue = 10;

        public Candy(string flavor, string name, CandyType type)
        {
            Flavor = flavor;
            Name = name;
            Type = type;
        }

        // Methods
        public void SetRating(int userRating)
        {
            // Needs to be between 1 & 10
            if (userRating >= MinRatingValue && userRating <= MaxRatingValue)
            {
                Rating = userRating;
            }
            else
            {
                throw new Exception($"You are dumb. Ratings are {MinRatingValue}-{MaxRatingValue}. You moron");
            }
        }

        public void SetRating(int userRating, string review)
        {
            SetRating(userRating);
            Review = review;
        }

        // Expression Body Members
        // Akin to the JS Fat Arrow function - Typically used for small chunks of code, WOuld not use for more complicated function/Method
        public void SetRating(bool likedIt) => Rating = likedIt ? 10 : 1;

        public override string ToString()
        {
            return $"This is {Type} {Name}, with a(n) {Flavor} flavor, rated {Rating}";
        }

    }

    

    enum CandyType
    {
        Chocolate,
        HardCandy,
        Caramel,
        Sour,
        Stretchy,
        Nut
    }
}
