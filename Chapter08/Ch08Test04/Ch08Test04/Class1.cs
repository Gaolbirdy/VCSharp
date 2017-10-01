using System;

namespace Ch08Test04
{
    public abstract class HotDrink
    {
        public void Drink() { }
        public void AddMilk() { }
        public void AddSugar() { }
        public bool milk { get; set; }
        public int sugar { get; set; }
    }

    public interface ICup
    {
        void Refill();
        void Wash();
        string Color { get; set; }
        float Volume { get; set; }
    }

    public class CupOfCoffee : HotDrink, ICup
    {
        public string BeanType;
        public void Refill() { }
        public void Wash() { }
        public string Color { get; set; }
        public float Volume { get; set; }
    }

    public class CupOfTea : HotDrink, ICup
    {
        public string LeafType;
        public void Refill() { }
        public void Wash() { }
        public string Color { get; set; }
        public float Volume { get; set; }
    }
}
