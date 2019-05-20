# Laboratory Work No.3

## Task:
- Create a program/app that uses 5 behavioural patterns.

### Behavioural Patterns:
+ _Null Object_ pattern;
+ _Mediator_ pattern;
+ _Observer_ pattern;
+ _Template_ pattern;
+ _Command_ pattern.

## Solution

- The __ARetreat__ astract class implements the _Template_ pattern, it has a concrete method that "builds" an algorithm from other abstract methods that are implemented inside concrete classes. In my case, the Retreat method uses the abstract RetreatParty methods inside __Spaceship__ and __Stormtrooper__ classes, which are children of this abstract class. Also, the Retreat method updates the status of the concrete classes through an observer.

- The __StatusObserver__ class (implements __IStatusObserver__) is an _Observer_, it observes the concrete classes for changes, and then sends the _Status_ in our case to the _Mediator_.

- The __Mediator__ class (implements __IMediator__) is a _Mediator_. It makes the communication between objects much easier and readable. In this case, the _Mediator_ establishes communication between the __StatusObserver__ and the __CommandCenter__, so the later knows the status of each Unit on the battlefield.

- Also, the __CommandCenter__ uses the _Command_ pattern to set and execute commands to certain units.

  + The __CommandCenter__ is the _Invoker_.

  + The __RetreatCommand__, which implements __ICommand__ is the _Command_ itself, and the receivers are the __Stormtrooper__ and __Spaceship__ classes.

  + Lastly, the __NullCommand__ implements the _Null Object_ pattern, it provides a simpler approach to verify if an object is null, instead of checking every time for null.

Check the [Main](https://github.com/skidne/TMPS-Labs/blob/master/Client/Program.cs) to see how these patterns are used.
