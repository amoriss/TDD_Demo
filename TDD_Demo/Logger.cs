using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Demo;
public class Logger
{
    private readonly List<string> _messages = new List<string>();

    public void LogMessage(string message)
    {
        _messages.Add(message);
    }

    // Method to expose messages for testing
    public IEnumerable<string> GetLoggedMessages()
    {
        return _messages.AsReadOnly();
    }
}
