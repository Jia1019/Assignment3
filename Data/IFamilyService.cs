﻿using System.Collections.Generic;
using Models;

namespace Assignment.Data
{
    public interface IFamilyService
    {
        IList<Family> GetFamilies();
        IList<Adult> GetAdults();
        IList<Child> GetChildren();
        Adult getAdultById(int Id);
        Child getChildById(int Id);
        void AddFamily(Family family);
        string AddAdult(Adult adult);
        string AddChildren(Child child);
        void RemoveFamily(int familyId);
        void RemoveAdult(int adultId);
        void RemoveChild(int childId);
        void UpdateFamily(Family family);
        void UpdateAdult(Adult adult);
        void UpdateChild(Child child);
        public string getFamilyError();
        IList<User> GetUsers();
    }
}