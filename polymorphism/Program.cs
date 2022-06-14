
public class Dog: Animal{
public Dog(string name): base(name){
    
}
///// specific subclass /// what is override?
public override string Talk(){
    return "Woof";
}
}

public class Cat : Animal{
public Cat(string name): base(name){
    
}

public override string Talk(){
    return "Meow";
}
}

public class jackalope: Animal{
public jackalope(string name): base(name){
    
}
public override string Talk(){
    return "SCREEAMMMMM!!";
}
}


Animal jackalope = new Animal("Bob");
Console.WriteLine(jackalope.Walk());
Console.WriteLine(jackalope.Dance());
Console.WriteLine(jackalope.Dance("Sprinkler"));
Console.WriteLine(jackalope.Dance("Moonwalk,1500"));
Console.WriteLine(jackalope.Talk());


Dog jeff = new Dog("Jeff");
Console.WriteLine(jeff.Talk());

public class Animal{
    string name;
    public Animal(string name){
        this.name = name;
    }
    public string Walk(){
        return $"{name} is walking";
    }

    ////public abstract string Wlak();
    public string Talk(){
        return $"I'm talking";
    }
}

/// funtionality? interface?? piramiter






