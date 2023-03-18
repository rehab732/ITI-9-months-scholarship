using System.Collections.Generic;
using System.ComponentModel;
using WebApplication3.Models;

namespace WebApplication3.Repos
{
    public interface ITrainee
    {
        public List<Trainee> GetAll();
        public Trainee GetTrainee(int id);
        public void InsertTrainee(Trainee trainee);
        public void UpdateTrainee(int id,Trainee trainee);
        public void DeleteTrainee(int id);


    }
}
