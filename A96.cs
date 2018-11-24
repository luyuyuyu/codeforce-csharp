using System;

class A96 {
	public static string Result(string input) {
		var current = 'x';
		var count = 0;
		foreach (char i in input) {
			if (current == i) {
				++count;
			} else {
				current = i;
				count = 1;
			}
			if (count == 7) return "YES";
		}
		return "NO";
	}
	
	public static void Main() {
		var input = Console.ReadLine();
		Console.WriteLine(Result(input));
	}
}
