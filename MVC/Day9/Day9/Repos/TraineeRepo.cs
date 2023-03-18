using System.Collections.Generic;
using System.Linq;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Repos
{
    public class TraineeRepo : ITrainee
    {
        public ApplicationDbContext Context { get; set; }
        public TraineeRepo(ApplicationDbContext context)
        {
            Context = context;
        }
        public void DeleteTrainee(int id)
        {
            Trainee trainee = Context.traines.Find(id);
            Context.traines.Remove(trainee);
            Context.SaveChanges();
        }

        public List<Trainee> GetAll()
        {
            return Context.traines.ToList();
        }

        public Trainee GetTrainee(int id)
        {
            Trainee trainee = Context.traines.Find(id);
            return trainee;

        }

        public void InsertTrainee(Trainee trainee)
        {
            Context.traines.Add(trainee);
            Context.SaveChanges();
        }

        public void UpdateTrainee(int id, Trainee trainee)
        {
            Trainee trainee1 = Context.traines.Find(id);
             trainee1.Name = trainee.Name;
             trainee1.email = trainee.email;
             trainee1.MobileNo= trainee.MobileNo;
             trainee1.TrackID= trainee.TrackID;

            Context.SaveChanges();


        }
    }
}
