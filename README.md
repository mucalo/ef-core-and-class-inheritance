# EF Core and Class Inheritence

This repository goes with the EF Core and Class Inheritance blogpost: https://mariomucalo.com/efcore-and-class-inheritance

Depending on which class inheritance handling model in EF Core you want to model you need to uncomment the proper Context being used:

- `using (var ctx = new VehiclesContext())` for Table per Hierarchy
- `using (var ctx = new VehiclesTPTContext())` for Table per Type

If you're running for the first time on the given database, you can uncomment the code inside the `AddingDataToDatabase` region.
