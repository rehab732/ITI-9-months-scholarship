using System.Collections.Generic;
using System.Linq;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Repos
{
    public class Trackrepo:ITrack
    {
        public ApplicationDbContext Context { get; set; }
        public Trackrepo(ApplicationDbContext context)
        {
            Context = context;
        }

        public List<Track> GetAll()
        {
            return Context.tracks.ToList();
        }

        public Track GetTrack(int id)
        {
            Track track = Context.tracks.Find(id);
            return track;
        }

        public void InsertTrack(Track Track)
        {
           Context.tracks.Add(Track);
            Context.SaveChanges();
        }

        public void UpdateTrack(int id, Track Track)
        {
            Track track = Context.tracks.Find(id);
            track.Name=track.Name;
            track.Description=track.Description;

        }

        public void DeleteTrack(int id)
        {
            Track track = Context.tracks.Find(id);
            Context.tracks.Remove(track);
            Context.SaveChanges();
            
        }
    }
}
