using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MultiServerChat
{
	public class MultiServerChatSettings
	{
        public List<string> RestURLs = new List<string>();
        public string Token = "abcdef";
        public string ChatFormat = "[{0}] {1}";
        public string JoinFormat = "[{0}] {1} has joined.";
        public string LeaveFormat = "[{0}] {1} has left.";
        public bool SendChat = true;
        public bool SendJoinLeave = true;
        public bool DisplayChat = true;
        public bool DisplayJoinLeave = true;
	}
}
