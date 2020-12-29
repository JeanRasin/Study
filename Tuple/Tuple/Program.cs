using System;
    
    
/*Not type*/
var tNotType = (20, 35);
tNotType.Item1 += 10;

Console.WriteLine($"Item 1: {tNotType.Item1}, Item 2: {tNotType.Item2}");

/* Type */
(string, int, int) tType = ("text", 10, 758);

Console.WriteLine($"Item 1: {tType.Item1}, Item 2: {tType.Item2}, Item 3: {tType.Item3}");

/* Field name */
var tFieldName = (Field1: 1, Field2 :2);

Console.WriteLine($"Field1: {tFieldName.Field1}, Field2: {tFieldName.Field2}");

/* Variable */
var (name, age) = ("Ivan", 31);

Console.WriteLine($"Name: {name}, age: {age}");

/* Return value */
static (int, int) GetReturnValue(int i, int n) {

    var result = (i,n);
    return result;
}


var tReturnValue  = GetReturnValue(10, 23);

Console.WriteLine($"Item 1: {tReturnValue.Item1}, Item 2: {tReturnValue.Item2}");

/* Tuple param */
static (int i, int n, int count) GetParamValue((int i, int n) tuple, int count)
{
  var result = (tuple.i, tuple.n, ++count);
      return result;
}

var (i, n, count)  = GetParamValue((1,10), 100);

Console.WriteLine($"i: {i}, n: {n}, count: {count}");