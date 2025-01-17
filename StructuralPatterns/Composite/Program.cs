using Composite;

LearningResourse root = new Bundle(name: "Zero to hero Clean Architecture");

LearningResourse leafA = new Course(name: "Getting Started with clean architecture",
    duration: TimeSpan.FromHours(3),
    price: 100);

LearningResourse leafB = new Course(name: "Depp dive clean architecture",
    duration: TimeSpan.FromHours(4),
    price: 120);

root.Add(leafA);
root.Add(leafB);

Console.WriteLine(root.GetPrice());

Console.WriteLine(root.GetDurantion());