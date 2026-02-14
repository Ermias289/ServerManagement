using System.Runtime.CompilerServices;

namespace ServerManagement.Models
{
    public class ServersRepository
    {
        private static List<Server> _servers = new List<Server>
        {
            new Server { ServerId = 1, Name = "Server 1", City = "New York" },
            new Server { ServerId = 2, Name = "Server 2", City = "Los Angeles" },
            new Server { ServerId = 3, Name = "Server 3", City = "New York" },
            new Server { ServerId = 4, Name = "Server 4", City = "New York" },
            new Server { ServerId = 5, Name = "Server 5", City = "New York" },
            new Server { ServerId = 6, Name = "Server 6", City = "New York" },
            new Server { ServerId = 7, Name = "Server 7", City = "Seattle" },
            new Server { ServerId = 8, Name = "Server 8", City = "Seattle" },
            new Server { ServerId = 9, Name = "Server 9", City = "New York" },
            new Server { ServerId = 10, Name = "Server 10", City = "New York" },
            new Server { ServerId = 11, Name = "Server 11", City = "Seattle" },
            new Server { ServerId = 12, Name = "Server 12", City = "Seattle" },
            new Server { ServerId = 13, Name = "Server 13", City = "Los Angeles" },
            new Server { ServerId = 14, Name = "Server 14", City = "Los Angeles" },
            new Server { ServerId = 15, Name = "Server 15", City = "Seattle" },
            new Server { ServerId = 16, Name = "Server 16", City = "Addis Ababa" },
            new Server { ServerId = 17, Name = "Server 17", City = "Addis Ababa" },
            new Server { ServerId = 18, Name = "Server 18", City = "Addis Ababa" },
            new Server { ServerId = 19, Name = "Server 19", City = "Addis Ababa" },
            new Server { ServerId = 20, Name = "Server 20", City = "Addis Ababa" },
            new Server { ServerId = 21, Name = "Server 21", City = "Addis Ababa" },
            new Server { ServerId = 22, Name = "Server 22", City = "Addis Ababa" },
            new Server { ServerId = 23, Name = "Server 23", City = "Addis Ababa" },
            new Server { ServerId = 24, Name = "Server 24", City = "Addis Ababa" },
            new Server { ServerId = 25, Name = "Server 25", City = "Addis Ababa" }

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

        public static List<Server> GetSeversByCity(string city)
        {
            if (string.IsNullOrWhiteSpace(city) || city.ToLower() == "non")
                return _servers;

            return _servers.Where(s => s.City.ToLower() == city.ToLower()).ToList();
            
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
