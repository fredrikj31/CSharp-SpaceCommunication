using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceCommunication {
	class Program {
		static void Main(string[] args) {
			Converter converter = new Converter();

			string message = "";

			Console.WriteLine("Enter you messages please: ");
			message = Console.ReadLine();

			List<string> result = converter.convertToBytes(inputMessage: message);

			Console.WriteLine("----------------------------------- Converted Message to Binary -----------------------------------");
			foreach (var item in result) {
				Console.Write(item);
				Console.Write(" ");
			}
			Console.WriteLine(" ");
			Console.WriteLine("----------------------------------- Converted Message to Binary -----------------------------------");

			Console.WriteLine(" ");
			Console.WriteLine(" ");

			List<string> corruptData = converter.corruptData(result);
			Console.WriteLine("----------------------------------- Corrupted Message to Binary -----------------------------------");
			foreach (var item in corruptData) {
				Console.Write(item);
				Console.Write(" ");
			}
			Console.WriteLine(" ");
			Console.WriteLine("----------------------------------- Corrupted Message to Binary -----------------------------------");

			Console.WriteLine(" ");
			Console.WriteLine(" ");

			Console.WriteLine("------------------------------------ Corrupted Message to Text ------------------------------------");
			Console.WriteLine(converter.convertToString(corruptData));
			Console.WriteLine("------------------------------------ Corrupted Message to Text ------------------------------------");

		}
	}
}
