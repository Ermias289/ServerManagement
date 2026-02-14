using System.Runtime.CompilerServices;

namespace ServerManagement.Models
{
    public class ServersRepository
    {
        private static List<Server> _servers = new List<Server>
        {
            new Server { ServerId = 1, Name = "Server 1", City = "New York" },
            new Server { ServerId = 2, Name = "Server 2", City = "Los Angeles" },
            new Server { ServerId = 3, Name = "Server 3", City = "Chicago" },
            new Server { ServerId = 4, Name = "Server 4", City = "Houston" },
            new Server { ServerId = 5, Name = "Server 5", City = "Phoenix" }
        };

        public static void AddServer(Server server)
        {
            var maxId = _servers.Max(s => s.ServerId);
            server.ServerId = maxId + 1;
            _servers.Add(server);
        }

        public static List<Server> GetAllServers()
        {
            return _servers;
        }

        public static Server GetServerById(int id)
        {
            return _servers.FirstOrDefault(s => s.ServerId == id);
        }

        public static void GetSeversByCity(string city, Action<List<Server>> callback)
        {
            var serversInCity = _servers.Where(s => s.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
            callback(serversInCity);
        }

        public static void UpdateServer(Server updatedServer)
        {
            var existingServer = _servers.FirstOrDefault(s => s.ServerId == updatedServer.ServerId);
            if (existingServer != null)
            {
                existingServer.Name = updatedServer.Name;
                existingServer.IsOnline = updatedServer.IsOnline;
                existingServer.City = updatedServer.City;
            }
        }   

        public static void DeleteServer(int id)
        {
            var serverToDelete = _servers.FirstOrDefault(s => s.ServerId == id);
            if (serverToDelete != null)
            {
                _servers.Remove(serverToDelete);
            }
        }

        public static List<Server> SearchServers(string searchTerm)
        {
            return _servers.Where(s => s.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) || s.City.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }

}
