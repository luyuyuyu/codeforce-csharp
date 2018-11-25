using System;
using System.Linq;

class a231 {
	public static void Main() {
		var population = int.Parse(Console.ReadLine());
		var result = 0;
		for (int i = 0; i < population; ++i) {
			var game = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
			if (game.Sum() >= 2) ++result;
		}
		Console.WriteLine(result);
	}
}
