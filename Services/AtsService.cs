using atsapi.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atsapi.Services
{
    public class AtsService
    {
        private readonly IMongoCollection<Users> _users;
        public AtsService(IAtsDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _users = database.GetCollection<Users>(settings.AtsCollectionName);
        }

        public List<Users> Get() =>
            _users.Find(user => true).ToList();

        public Users Get(string id) =>
            _users.Find<Users>(user => user.id == id).FirstOrDefault();

        public Users Create(Users user)
        {
            _users.InsertOne(user);
            return user;
        }

        public void Update(string id, Users userIn) =>
            _users.ReplaceOne(user => user.id == id, userIn);

        public void Remove(Users userIn) =>
            _users.DeleteOne(user => user.id == userIn.id);

        public void Remove(string id) =>
            _users.DeleteOne(user => user.id == id);
    }
}
