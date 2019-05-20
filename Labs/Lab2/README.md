# Laboratory Work No.2

## Task:
- Create a program/app that uses 5 structural patterns.

### Structural Patterns:
+ _Bridge_ pattern;
+ _Adapter_ pattern;
+ _Proxy_ pattern;
+ _Decorator_ pattern;
+ _Facade_ pattern.

## Solution

- The __SpceshipFlightFacade__ class implements the _Facade_ pattern, it hides the complex implementation of a spaceship's flight, making it easier to use. Also, inside it implements the _Proxy_ pattern.

- The __FlightProxy__ class is a _Proxy_ that provides access to the method, depending on its access code (in my case, it's just a boolean), if the value is true, then the Spaceship is allowed to depart, otherwise it's not.

- The __StormtrooperFighting__ class (implements __IStormtrooperFighting__) is a _Bridge_ that decouples the implementation of the 'fighting' part so that it varies independently. It also uses the _Adapter_ pattern and the _Decorator_ pattern inside.

  + The __RangeWeapon__ class (implements __IRangeWeapon__) has a method _Shoot_ that is used inside the __StormtrooperFighting__ method _Fight_, that's why we need an _Adapter_ for the __MeleeWeapon__ class, that has a method _Cut_

  + The __MeleeToRangeAdapter__ class is the _Adapter_, it wraps an interface to use another interface, like I do with __IRangeWeapon__ and __IMeleeWeapon__.

- The __StormtrooperSpecialAttackDecorator__ class is a simple  _Decorator_ that dynamically adds functionality to a class, without affecting it's objects.


Check the [Main](https://github.com/skidne/TMPS-Labs/blob/master/Client/Program.cs) to see how these patterns are used.
