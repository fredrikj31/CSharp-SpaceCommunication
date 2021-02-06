using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceCommunication {
	class Program {
		static void Main(string[] args) {
			Converter converter = new Converter();

			string message = "Hello World";

			byte[] result = converter.convertToBytes(inputMessage: message);

			result = converter.corruptData(result);

			Console.WriteLine(converter.convertToString(result));
			
		}
	}
}
