using System;
using System.Text.Json;

namespace SimplyMobile.Text.FastJson
{
	public class JsonSerializer : JsonParser, IJsonSerializer
	{
		#region ITextSerializer implementation

//		public string Serialize (object obj)
//		{
//			return ServiceStack.Text.JsonSerializer.SerializeToString (obj);
//		}

		public string Serialize(object obj)
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
		}

		public T Deserialize<T> (string data)
		{
			return Parse<T> (data);
		}

		public Format Format 
		{
			get
			{
				return Format.Json;
			}
		}

		#endregion
	}
}

