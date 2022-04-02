using EFCoreInheritanceTests.Commons.Enums;
using EFCoreInheritanceTests.Data;
using EFCoreInheritanceTests.Models;
using Microsoft.EntityFrameworkCore;

// using (var ctx = new VehiclesContext())
using (var ctx = new VehiclesTPTContext())
{
    /// This region adds data to the database
    /// If you're running the code for the first time on a given database, uncomment it.
    #region AddingDataToDatabase

    //List<Vehicle> vehicles = new List<Vehicle>();
    //vehicles.Add(new Car { Make = "Chevrolet Orlando", TrunkSizeInCm3 = 10000 });
    //vehicles.Add(new Motorbike { Make = "Suzuki", RacingClass = RacingClass.cc125 });
    //vehicles.Add(new Motorbike { Make = "Yamaha", RacingClass = RacingClass.cc250 });

    //await ctx.Vehicles.AddRangeAsync(vehicles);
    //await ctx.SaveChangesAsync();
    #endregion

    var myCars = await ctx.Cars.ToListAsync();
    var myMotorcycles = await ctx.Motorcycles.ToListAsync();
    var myVehicles = await ctx.Vehicles.ToListAsync();

}