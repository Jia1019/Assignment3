using System.Collections.Generic;

namespace Models {
public class Child : Person {
    
    public List<Interest> ChildInterests { get; set; }
    public List<Pet> Pets { get; set; }
    
    public void Update(Child toUpdate) {
        base.Update(toUpdate);
        ChildInterests = toUpdate.ChildInterests;
        Pets = toUpdate.Pets;
    }

    public Child()
    {
        ChildInterests = new List<Interest>();
        Pets = new List<Pet>();
    }

    public string interestList()
    {
        string list = "";
        for (int i = 0; i < ChildInterests.Count; i++)
        {
            list += ChildInterests[i].Type+" ";
        }

        return list;
    }

    public string petList()
    {
        string list = "";
        for (int i = 0; i < Pets.Count; i++)
        {
            list += Pets[i].Name+" ";
        }

        return list;
    }

}
}