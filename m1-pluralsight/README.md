GENERICS

Module 1 : (M1) Why Generics?

Generics alllow you to write code that is type safe and performant. You 
defer type specification to the client.

Generics types allow code reuse with type safety. Avoids type casting
and boxing. (You can see box and unbox operations using ILDASM)

You can have generic classes, interfaces, structs and delegates.

Convention is to use T for the placeholder.

Here's an example:

public class CircularBuffer<T>
{
	private T[] _buffer;

	// ...
}

Then you specify type when you instantiate it:

var buffer = new CircularBuffer<double>();