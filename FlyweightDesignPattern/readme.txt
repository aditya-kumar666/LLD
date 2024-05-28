It's one of the structural design patterns 
This pattern helps to reduce the memory usage by sharing data among multiple objects.

Ex: Word Procesor(Text Editor), Robot Game

Where & when to use this pattern
- When memory is limited.
- Creation of Object is expensive.
- When objects share data
    Intrinsic data - shared among objects and remain same once defined one value.
    Extrinnsic data - changes based on client input and differs from one object to another.


How to solve this issue:
- From Object, remove all the extrinsic data and keep intrinsic data(this object is called flyweight object).
- This flyweight class can be immutable.
- Extrinsic data can be passed to the flyweight class in method parameter.
- Once the flyweight object is created, it is cached and reused whenever required.