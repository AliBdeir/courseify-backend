using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courseify.DataAccessLayer.Exceptions
{

	[Serializable]
	public class InvalidSessionIdException : Exception
	{
		public InvalidSessionIdException() { }
		public InvalidSessionIdException(string sessionId) : base($"Session ID {sessionId} is invalid or does not exist.") { }
		public InvalidSessionIdException(string message, Exception inner) : base(message, inner) { }
		protected InvalidSessionIdException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
