using BackBizland.Models;
using System.Collections.Generic;

namespace BackBizland.ViewModels
{
    public class HomeViewModel
    {
        public List<Service> Services { get; set; }

        public List<TeamMember> TeamMembers { get; set; }
    }
}
