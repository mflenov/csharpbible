using System;
using TestApi.Model;

namespace TestApi.BL
{
	public class SessionStorage
	{
		static Dictionary<string, MemberSession> storage =
			new Dictionary<string, MemberSession>();

		public MemberSession? GetSession(string sessionId)
		{
			if (sessionId != null && storage.ContainsKey(sessionId))
				return storage[sessionId];
			return null;
		}

        public MemberSession CreateSession()
        {
			MemberSession session = new MemberSession();
            session.SessionId = Guid.NewGuid().ToString();
            storage.Add(session.SessionId, session);
			return session;
        }
    }
}

