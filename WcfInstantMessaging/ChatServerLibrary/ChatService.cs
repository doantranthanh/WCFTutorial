using System.Diagnostics;

namespace ChatServerLibrary
{
    public class ChatService : IChatService
    {
        public void PostNote(string from, string note)
        {
            Debug.WriteLine("{0}: {1}", from, note);
        }
    }
}
