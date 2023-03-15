using System.Reflection.Metadata.Ecma335;

namespace Lab_03
{
    public class UserService
    {
        private Dictionary<string, string> _users = new Dictionary<string, string>();

        public void Add(string connectionId, string username)
        {
            _users[username] = connectionId;
        }

        public void RemoveByName(string username)
        {
            _users.Remove(username);
        }

        public string? GetConnectionIdByName(string username)
        {

            return _users.TryGetValue(username, out var connectionId) ? connectionId : null;

        }

        public IEnumerable<(string ConnectionId, string Username)> GetAll()
        {
            foreach (var user in _users)
            {
                yield return (user.Value, user.Key);
            }
        }
    }
}
