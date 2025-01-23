using FlyWeight;


FlyweightFactory factory = new();
Client client = new(factory);

client.Operation("world!");
client.Operation("world");
client.Operation("hello");
client.Operation("hi");