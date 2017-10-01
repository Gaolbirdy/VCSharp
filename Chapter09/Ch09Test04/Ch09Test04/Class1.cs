using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
    }

    public abstract class Car : Vehicle
    {
    }

    public abstract class Train : Vehicle
    {
    }

    public interface IPassengerCarrier
    {

    }

    public interface IHeavyLoadCarrier
    {

    }

    public class Compact : Car, IPassengerCarrier
    {
    }

    public class SUV : Car, IPassengerCarrier
    {
    }

    public class Pickup : Car, IHeavyLoadCarrier, IPassengerCarrier
    {
    }

    public class PassengerTrain : Train, IPassengerCarrier
    {
    }

    public class FreightTrain : Train, IHeavyLoadCarrier
    {
    }

    public class _424DoubleBogey : Train, IHeavyLoadCarrier
    {

    }
}
