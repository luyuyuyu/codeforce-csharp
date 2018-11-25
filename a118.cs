using System;
using System.Collections.Generic;

class A118 {
	public static void Main() {
		var input = Console.ReadLine().ToLower();
		var output = new List<char>();
		foreach (char i in input) {
			if ("aeiouy".IndexOf(i) == -1) {
				output.Add('.');
				output.Add(i);
			}
		}
		Console.WriteLine(string.Concat(output));
	}
}
