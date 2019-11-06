using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
    // public int myProperty { get; set; } -->
    // public TeamModel()
    //     {
    //         TeamMembers = new List<PersonModel>();
    //     }
    public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }
    }
}