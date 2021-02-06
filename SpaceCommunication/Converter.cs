using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceCommunication {
	class Converter {
		public byte[] convertToBytes(string inputMessage) {
			return Encoding.ASCII.GetBytes(inputMessage);
		}

		public byte[] corruptData(byte[] inputBytes) {
			Random rnd = new Random();

			byte[] data = inputBytes;

			rnd.NextBytes(data);

			return data;
		}

		public string convertToString(byte[] inputBytes) {

			return Encoding.ASCII.GetString(inputBytes);
		}

	}
}
