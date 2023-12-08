// Span<int> array = new(Enumerable.Range(1, 10000).ToArray());
// Span<int> slice = array.Slice(2000, 1000);
// Console.WriteLine(slice[0]);

int[] array = Enumerable.Range(1, 10000).ToArray();
int[] slice = array[2000..3000];
Console.WriteLine(slice[0]);

Span<int> asSpan = Enumerable.Range(1, 10000).ToArray().AsSpan();
