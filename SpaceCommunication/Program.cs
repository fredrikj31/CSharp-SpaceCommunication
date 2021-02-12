using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceCommunication {
	class Program {
		static void Main(string[] args) {
			Converter converter = new Converter();

			string message = "";

			// Asks the user for a message
			Console.WriteLine("Enter you messages please: ");
			message = Console.ReadLine();

			// Converts the message into bytes
			List<string> result = converter.convertToBytes(inputMessage: message);

			// Writing the bytes out in the console
			Console.WriteLine("----------------------------------- Converted Message to Binary -----------------------------------");
			foreach (var item in result) {
				Console.Write(item);
				Console.Write(" ");
			}
			Console.WriteLine(" ");
			Console.WriteLine("----------------------------------- Converted Message to Binary -----------------------------------");

			Console.WriteLine(" ");
			Console.WriteLine(" ");

			// Corrupt the bytes
			List<string> corruptData = converter.corruptData(result);
			// Writing the corrupted bytes out in the console
			Console.WriteLine("----------------------------------- Corrupted Message to Binary -----------------------------------");
			foreach (var item in corruptData) {
				Console.Write(item);
				Console.Write(" ");
			}
			Console.WriteLine(" ");
			Console.WriteLine("----------------------------------- Corrupted Message to Binary -----------------------------------");

			Console.WriteLine(" ");
			Console.WriteLine(" ");

			// Printing the corruped message out in the console
			Console.WriteLine("------------------------------------ Corrupted Message to Text ------------------------------------");
			Console.WriteLine(converter.convertToString(corruptData));
			Console.WriteLine("------------------------------------ Corrupted Message to Text ------------------------------------");

		}
	}
}
