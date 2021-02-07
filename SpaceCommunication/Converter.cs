using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceCommunication {
	class Converter {
		// Opmærksom på 8 og 16 bit.

		public List<string> convertToBytes(string inputMessage) {
			List<string> result = new List<string>();

			foreach (char c in inputMessage) {
				result.Add(Convert.ToString(c, 2).PadLeft(8, '0'));
			}

			return result;
		}

		public List<string> corruptData(List<string> inputBytes) {
			Random rnd = new Random();

			for (int i = 0; i < 8; i++) {
				int randomItem = rnd.Next(0, inputBytes.Count);
				int randomBytePlace = rnd.Next(0, 8);


				char[] charMessage = inputBytes[randomItem].ToCharArray();

				if (charMessage[randomBytePlace] == '1') {
					charMessage[randomBytePlace] = '0';
				} else {
					charMessage[randomBytePlace] = '1';
				}

				StringBuilder stringByte = new StringBuilder();

				foreach (var item in charMessage) {
					stringByte.Append(item);
				}
				inputBytes.RemoveAt(randomItem);
				inputBytes.Insert(randomItem, stringByte.ToString());
			}

			return inputBytes;
		}

		public string convertToString(List<string> inputBytes) {
			StringBuilder result = new StringBuilder();

			foreach (string charByte in inputBytes) {
				Console.WriteLine(charByte);
				result.Append((char)Convert.ToInt32(charByte, 2));
			}

			return result.ToString();
		}

	}
}
