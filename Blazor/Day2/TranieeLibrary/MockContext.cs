using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranieeLibrary
{
    public class MockContext
    {
        public static List<Track> Tracks = new List<Track>
        {
            new Track() {TrackId=1,Name="SD",Description="System Development"},
            new Track() {TrackId=2,Name="UI",Description="User Interface"},
            new Track() {TrackId=3,Name="PD",Description="Profiessional Development"},
            new Track() {TrackId=4,Name="Mobile",Description="Mobile Development"},
            new Track() {TrackId=5,Name="AI",Description="Artificial Intelligance"},
        };
        public static List<Treniee> Treniees = new List<Treniee>
        {
            new Treniee
            {
                TraineeId=1,
                TraineeName="Rehab Zaki",
                Gender=Gender.Female,
                Birthdate=new DateTime(2000,5,18),
                Email="Rehabzaki@gmail.com",
                MobileNo="01003445985",
                TrackId=4,
                IsGraduated=true,
            },
            new Treniee
            {
                TraineeId=2,
                TraineeName="Nada Elaraby",
                Gender=Gender.Female,
                Birthdate=new DateTime(1998,5,18),
                Email="nada@gmail.com",
                MobileNo="0112112555",
                TrackId=3,
                IsGraduated=true,
            },
            new Treniee
            {
                TraineeId=3,
                TraineeName="Mahmoud",
                Gender=Gender.Male,
                Birthdate=new DateTime(1999,12,12),
                Email="mahmoud@gmail.com",
                MobileNo="0121233232",
                TrackId=2,
                IsGraduated=true,
            },
        };

    }
}
