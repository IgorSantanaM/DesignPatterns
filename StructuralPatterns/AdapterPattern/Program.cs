using AdapterPattern;

ITarget target = new Adapter(new Adaptee());

target.Request();