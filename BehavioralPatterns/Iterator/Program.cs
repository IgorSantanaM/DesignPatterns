using IteratorPattern;

Aggregate<string> aggregate = new ConcreteAggregate<string>();

aggregate.Add("1");
aggregate.Add("2");
aggregate.Add("3");
aggregate.Add("4");

Iterator<string> iterator = aggregate.CreateIterator();

    while (iterator.HasNext())
    {
        Console.Write(iterator.Next() + ", ");
    }


