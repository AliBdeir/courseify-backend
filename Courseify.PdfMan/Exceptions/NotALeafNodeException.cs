using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courseify.PdfMan.Exceptions
{

	[Serializable]
	public class NotALeafNodeException : Exception
	{
		public NotALeafNodeException() { }
		public NotALeafNodeException(string message) : base(message) { }
		public NotALeafNodeException(string message, Exception inner) : base(message, inner) { }
		protected NotALeafNodeException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
