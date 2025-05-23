using Principles;

Animal leo =   new Lion("Leo");
//leo.Name = "Leo";
Console.WriteLine(leo.Name);
leo.Eat();
Zoo Miskolc = new Zoo();
Miskolc.AddAnimal(leo);
Miskolc.AddAnimal(new Monkey("Csita"));
Miskolc.ShowAnimals();
Miskolc.Feed();