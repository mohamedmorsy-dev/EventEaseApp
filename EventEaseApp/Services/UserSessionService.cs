using System;

namespace EventEaseApp.Services
{
    public class UserSessionService
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime SessionStartTime { get; private set; }

        public void StartSession(string userName, string email)
        {
            UserName = userName;
            Email = email;
            SessionStartTime = DateTime.Now;
        }

        public void EndSession()
        {
            UserName = null;
            Email = null;
            SessionStartTime = default;
        }

        public bool IsSessionActive => !string.IsNullOrEmpty(UserName);
    }
}