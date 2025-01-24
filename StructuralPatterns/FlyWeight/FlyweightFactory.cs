using Key = string;
namespace FlyWeight
{
    public class FlyweightFactory
    {
        public readonly Dictionary<Key, Flyweight> _flyweights = [];
        
        public Flyweight GetFlyweight(Key key)
        {
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new ConcreteFlyweight(instrisicState: key);
            }

            return _flyweights[key];
        }
    }
}
