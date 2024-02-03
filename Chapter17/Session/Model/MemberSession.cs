using System;
namespace TestApi.Model
{
	public class MemberSession
	{
		public string SessionId { get; set; } = null!;

        public Dictionary<string, object> Values { get; set; } = new Dictionary<string, object>();
    }
}

