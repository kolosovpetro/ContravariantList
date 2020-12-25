# Contravariant List

Simple snippet to show the use of contravariance in C#.

## Example

```cs
IContravariantList<Wolf> list = new ContravariantList<IAnimal>();
list.Push(new Wolf());
list.Push(new Wolf());
Console.WriteLine(list.Count);
```