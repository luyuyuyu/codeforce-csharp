using System;

class A339 {
    public static void Main() {
        var input = Console.ReadLine();
        var newInput = new char[input.Length / 2 + 1];
        for (int i = 0; i < input.Length; i += 2) {
            newInput[i / 2] = input[i];
        }
        // Alternative:
        // var newSize = 0;
        // foreach (var i in input) newInput[newSize++] = i;
        Array.Sort(newInput);
        Console.Write(newInput[0]);
        for (int i = 1; i < newInput.Length; ++i) {
            Console.Write("+" + newInput[i]);
        }
        // Alternative:
        // bool isFirst = true;
        // foreach (var i in newInput) {
        //     if (!isFirst) Console.Write('+');
        //     isFirst = false;
        //     Console.Write(i);
        // }
        Console.WriteLine();
    }
}