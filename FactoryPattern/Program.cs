using System.ComponentModel;

using FactoryPattern;




var car = VehicleFactory.GetVehicle(2);

car.Drive();