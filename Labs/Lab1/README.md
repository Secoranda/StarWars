# Laboratory Work No.1

## Task:
- Create a program/app that uses 5 creational patterns.

### Creational Patterns:
+ _Singleton_ pattern;
+ _Prototype_ pattern;
+ _Factory_ pattern;
+ _Abstract factory_ pattern;
+ _Builder_ pattern.

## Solution

- The __CommandCenter__ class uses the _Singleton_ pattern, it can have only one instance per lifetime. This class provides us with a  __Fleet__ instance.

- The __Fleet__ class (which implements the __IFleet__ interface) is an _Abstract factory_ that has one purpose: creating factories of _Spaceships_ and _Stormtroopers_.

- The __SpaceshipFactory__ and __StormtrooperFactory__ classes (implement __ISpaceshipFactory__ and __IStormtrooperFactory__ respectively) are obviously using the _Factory_ pattern to create _Spaceships_ and _Stormtroopers_.

  + The __SpaceshipFactory__ creates _Spaceships_ using the method `CreateSpaceship(string name, SpaceshipType type)`, where `type` is in charge of creating specific types of  _Spaceships_ (_Combat_, _Defense_ or _Transport_ types).

  + The __StormtrooperFactory__ supplies us with _Stormtroopers_, but these are not as customized as _Spaceships_, since they are, well, _Stormtroopers_. (Still, in the future , if I want to implement more types of _Stormtroopers_, like a Deathtrooper, Sandtrooper, Scouttrooper, etc... it will be easier. I will only change the method inside the factory, and add different functionalities to my base __Stormtrooper__ class, or even better if I create a __StormtrooperBuilder__ class like the one for _Spaceships_)

- The __Spaceships__ are created using the _Builder_ pattern.

  + The __SpaceshipBuilder__ class (implements __ISpaceshipBuilder__) has a couple of methods that build customizable parts of a _Spaceship_ (_Fuselage_, _Engines_, _Avionics_ and _Weaponry_), and the `Spaceship BuildSpaceship()` method which returns the resulted _Spaceship_.

- The _Stormtroopers_ are created using the _Prototype_ pattern.

  + The _Stormtrooper_ class (implements _IStormtrooper_) has a method `IStormtrooper Clone()` that returns the clone of a default _Stormtrooper_ (aka Jango Fett) which has to be created beforehand (I should've done it inside the class, but I need an instance of _Spaceship_ to create a _Stormtrooper_, so I just dropped it).


Check the [Main](https://github.com/skidne/TMPS-Labs/blob/master/Client/Program.cs) to see how these patterns are used.
