using EternaWithDatabase.Models;
using System.Collections.Generic;

namespace EternaWithDatabase.ViewModels
{
    public class HomeViewModel
    {
        public List<Feature> Features = new List<Feature>();

        public List<Service> Services = new List<Service>();

        public List<Slide> Slides = new List<Slide>();
    }
}
