using CourseMenegment.Enums;
using CourseMenegment.Interfaces;
using CourseMenegment.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseMenegment.Services
{
    class CourseMenegmentService : ICourseMenegmentService
    {
        private Group[] _groups;
        public Group[] Groups => _groups;

        public CourseMenegmentService()
        {
            _groups = new Group[0];
        }

        public void AddGroup(GroupType groupType, int limit)
        {
            //Group group = new Group(groupType, limit);

            Array.Resize(ref _groups, _groups.Length + 1);
            _groups[_groups.Length - 1] = new Group(groupType, limit);
        }

        public void AddStudent(string groupno, string fullname, int age, StudentType studentType, bool isonline)
        {
            Group group = null;

            foreach (Group item in _groups)
            {
                if (item.No == groupno.Trim().ToUpper())
                {
                    group = item;
                }
            }

            if (group != null)
            {
                Student student = new Student(fullname, age, studentType, isonline, groupno);
                group.AddStudent(student);
                return;
            }
            Console.WriteLine("Daxil Edilen Nomreli Qrup Tapilmadi:");
        }

        public void EditGroup(string groupno, GroupType groupType, int limit)
        {
            throw new NotImplementedException();
        }

        public void EditStudent(string groupno, string fullname, int age, StudentType studentType, bool isonline)
        {
            throw new NotImplementedException();
        }

        public void RemoveStudent(string groupno, string fullname)
        {
            throw new NotImplementedException();
        }
    }
}
