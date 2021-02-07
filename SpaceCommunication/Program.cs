using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceCommunication {
	class Program {
		static void Main(string[] args) {
			Converter converter = new Converter();

			string message = "Hello World";

			List<string> result = converter.convertToBytes(inputMessage: message);

			List<string> corruptData = converter.corruptData(result);

			Console.WriteLine(converter.convertToString(corruptData));
			
		}
	}
}
