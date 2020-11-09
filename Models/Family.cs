using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models {
public class Family {
    
    public int Id { get; set; }
    [Required]
    public string StreetName { get; set; }
    [Required]
    public int HouseNumber{ get; set; }
    public List<Adult> Adults { get; set; }
    public List<Child> Children{ get; set; }
    public List<Pet> Pets{ get; set; }

   //public Family() {
   //    Adults = new List<Adult>();     
   //}

    public string adultList()
    {
        string list = "";
        for (int i = 0; i < Adults.Count; i++)
        {
            list += Adults[i].Id + " ";
        }

        return list;
    }
    
    public string childList()
    {
        string list = "";
        for (int i = 0; i < Children.Count; i++)
        {
            list += Children[i].Id + " ";
        }

        return list;
    }
    
    public string petList()
    {
        string list = "";
        for (int i = 0; i < Pets.Count; i++)
        {
            list += Pets[i].Name + ", ";
        }

        return list;
    }

}


}