using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceCommunication {
	class Converter {
		public List<string> convertToBytes(string inputMessage) {
			// Declaring list of characters
			List<string> result = new List<string>();
			// Splitting string into characters
			foreach (char c in inputMessage) {
				// Adding characters to list
				result.Add(Convert.ToString(c, 2).PadLeft(8, '0'));
			}
			// Returning the list of bytes in string format
			return result;
		}
		public List<string> corruptData(List<string> inputBytes) {
			// Making a new instance of the random class
			Random rnd = new Random();

			// Looping 8 times
			for (int i = 0; i < 8; i++) {
				// Generate random number between 0 and list of bytes
				int randomItem = rnd.Next(0, inputBytes.Count);
				// Generate random number between 0 and 8
				int randomBytePlace = rnd.Next(0, 8);
				// Declaring array of characters with a length of random number
				char[] charMessage = inputBytes[randomItem].ToCharArray();
				// Checking if the bit is 1
				if (charMessage[randomBytePlace] == '1') {
					// Setting the bit to 0
					charMessage[randomBytePlace] = '0';
					// Else if the bit is 0
				} else {
					// Setting the bit to 1
					charMessage[randomBytePlace] = '1';
				}
				// Making a new instance of the StringBuilder class
				StringBuilder stringByte = new StringBuilder();
				// Appending the characters to a string
				foreach (var item in charMessage) {
					stringByte.Append(item);
				}
				// Removing the right bit and replacing it with the corrupted bit
				inputBytes.RemoveAt(randomItem);
				inputBytes.Insert(randomItem, stringByte.ToString());
			}
			// Returning the list of bytes in string format
			return inputBytes;
		}

		public string convertToString(List<string> inputBytes) {
			// Making a new instance of the StringBuilder class
			StringBuilder result = new StringBuilder();
			// Looping through every character in the inputted string
			foreach (string charByte in inputBytes) {
				// Appending the characters into the string builder
				result.Append((char)Convert.ToInt32(charByte, 2));
			}
			// Returning the fully appending string, and parsing it into a string
			return result.ToString();
		}
	}
}
