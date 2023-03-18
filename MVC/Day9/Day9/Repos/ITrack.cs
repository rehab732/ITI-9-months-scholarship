using System.Collections.Generic;
using WebApplication3.Models;

namespace WebApplication3.Repos
{
    public interface ITrack
    {
        public List<Track> GetAll();
        public Track GetTrack(int id);
        public void InsertTrack(Track Track);
        public void UpdateTrack(int id, Track Track);
        public void DeleteTrack(int id);
    }
}
