using System;
using static System.Console;
using Space;
using Space.Out;
using Space.In;
using Ch08Ex00;

namespace Space
{
    namespace In
    {
        class Child
        {
            Extra myExtra = new Extra();
            //Program myMain = new Program();
            
            public void Main1()
            {
                Self mySelf = new Self();
                //myMain.Main();
                //WriteLine("Main() Called");
                //Program.Main();
                
                
            }
        }
    }

    class Self
    {
        
    }
}

namespace Space.Out
{
    class Extra
    {
        //Child myChild = new Child();
        Self mySelf = new Self();

        public void Main2()
        {
            
        }
    }
}

namespace SpaceTest
{
    class Test
    {
        //Self mySelf = new Self();
        Child myChild = new Child();
        Extra myExtra = new Extra();
        public void Main2()
        {
            myChild.Main1();
            myExtra.Main2();
        }
    }
}

namespace Ch08Ex00
{
    interface IHotDrink
    {
        byte AddSugar(byte amout);
    }

    class CupOfCoffee : IHotDrink, IDisposable
    {
        static public int myCupNums = 0;
        public const string brand = "星巴克";
        public string beanType;
        public bool instant;
        public bool milk;
        public byte sugar;
        public string description;

        public byte AddSugar(byte amout)
        {
            
            return amout;
        }
        
        public CupOfCoffee()
        {
            WriteLine("Class: CupOfCoffee()\n");
        }
        static CupOfCoffee()
        {

        }

        public void Dispose()
        {
            WriteLine("Dispose() Called\n");
        }
    }

    static class Shop
    {
        static public void Buy(int amout)
        {
        }
    }

    abstract class OldAnimal
    {
        public virtual void EatFood()
        {
            WriteLine("virtual: Animal's Food\n");
        }

        protected void Breed()
        {
            WriteLine("protected: Breed()\n");
        }

        public void Death()
        {

        }

        public OldAnimal()
        {
            WriteLine("Class: OldAnimal()\n");
        }
    }

    class Animal : IConsume
    {
        public int size;
        public virtual void EatFood()
        {
            WriteLine("virtual: Animal's Food\n");
        }

        protected void Breed()
        {
            WriteLine("protected: Breed()\n");
        }

        public virtual void Death()
        {
            WriteLine("interface: Animal Death()\n");
        }

        public Animal(bool father)
        {
            if(father)
                WriteLine("Father Class: Animal() Of Cow\n");
            else
                WriteLine("Father Class: Animal() Of Chicken\n");
        }

        public Animal()
        {
            WriteLine("Class: Animal()\n");
        }
    }

    interface IConsume
    {
        void Death();
    }

    class Udder
    {
        public void Milk()
        {
            WriteLine("ContainedClass: Udder.Milk()\n");
        }

        protected void ProtectedMilk()
        {

        }
    }

    class Cow : Animal
    {
        private Udder z = new Udder();
        int myPrivate;
        
        class NestedClass
        {
            public byte size;

            public void Boil()
            {
                WriteLine("NestedClass: Boil()\n");

            }
        }

        public void Moo()
        {
            
        }

        public void SupplyMilk()
        {
            Cow x = new Cow();
            x.Breed();
            
            NestedClass y = new NestedClass();
            y.Boil();
            y.size = 32;

            z.Milk();

        }

        override public void EatFood()
        {
            WriteLine("override: Cow's Food\n");
        }

        override public void Death()
        {
            WriteLine("interface: Cow Death()\n");
        }

        public Cow(bool father) : base(father)
        {
            WriteLine("Child Class: Cow()\n");
        }

        public Cow()
        {
            WriteLine("Class: Cow()\n");
        }
    }

    sealed class Chicken : Animal
    {
        public void Cluck()
        {

        }

        public void Layegg()
        {
            Chicken y = new Chicken();
            y.Breed();
        }

        override public void Death()
        {
            WriteLine("interface: Chicken Death()\n");
        }

        public Chicken(bool father) : base(father)
        {
            WriteLine("Child Class: Chicken()\n");
        }

        public Chicken()
        {
            WriteLine("Class: Chicken()\n");
        }
    }

    class Vegetable  : IConsume
    {
        public void Death()
        {
            WriteLine("interface: Vegetable Death()\n");
        }
    }

    class VenusFlyTrap : Vegetable
    {

    }

    class Program
    {
        public static void Main()
        {
            CupOfCoffee myCup = new CupOfCoffee();
            myCup.beanType = "myBean";
            myCup.instant = true;
            myCup.milk = false;
            myCup.sugar = 1;
            myCup.description = "zoo coffee shop";
            byte mySugar = myCup.AddSugar(5);

            for (int i = 1; i <= 10; i++)
            {
                CupOfCoffee.myCupNums++;

                WriteLine(CupOfCoffee.brand);
                WriteLine(myCup.beanType);
                WriteLine(myCup.instant);
                WriteLine(myCup.milk);
                WriteLine(myCup.sugar);
                WriteLine(myCup.description);
                WriteLine("interface: " + mySugar);
                WriteLine("myCupNums: " + CupOfCoffee.myCupNums + "\n");
            }

            //Shop myShop = new Shop();

            //myCup.Dispose();
            using (myCup)
            {
                //Auto Dispose()
            }


            Cow myCow = new Cow(true);
            Chicken myChicken = new Chicken(false);
            
            myCow.EatFood();
            myChicken.EatFood();
            myCow.SupplyMilk();

            Animal myAnimal = myCow;
            myAnimal.EatFood();
            Animal[] animals = new Animal[5];

            //myAnimal.Moo();
            Cow myNewCow = (Cow)myAnimal;
            myAnimal = (Cow)myAnimal;
            myNewCow.Moo();

            IConsume comsumeInterface;
            comsumeInterface = myCow;
            comsumeInterface.Death();
            comsumeInterface = myChicken;
            comsumeInterface.Death();

            Animal myDeathAnimal = new Animal();
            comsumeInterface = myDeathAnimal;
            comsumeInterface.Death();

            VenusFlyTrap myVenusFlyTrap = new VenusFlyTrap();
            comsumeInterface = myVenusFlyTrap;
            comsumeInterface.Death();

            Child myChild = new Child();
            myChild.Main1();

            WriteLine(myChild);
            
        }
    }
}
