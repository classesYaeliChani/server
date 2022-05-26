using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL
{
   public class converters
    {
        public Cours Convert(CourseDTO courseDTO)
        {
            Cours cours = new Cours();
            cours.courseId = courseDTO.courseId;
            cours.courseName = courseDTO.courseName;
            cours.isEnternet = courseDTO.isEnternet;
            return cours;
        }
        public CourseDTO Convert( Cours cours)
        {
            CourseDTO courseDTO = new CourseDTO();
            courseDTO.courseId= cours.courseId;
            courseDTO.courseName= cours.courseName;
            courseDTO.isEnternet= cours.isEnternet;
            return courseDTO;
        }
        public Group Convert(GroupDTO groupDTO)
        {
            Group group = new Group();
            group.groupId = groupDTO.groupId;
            group.groupName = groupDTO.groupName;
            group.groupNumPupil = groupDTO.groupNumPupil;
            return group;
        }
        public GroupDTO Convert(Group group)
        {
            GroupDTO groupDTO = new GroupDTO();
            groupDTO.groupId = group.groupId;
            groupDTO.groupName = group.groupName;
            groupDTO.groupNumPupil = group.groupNumPupil;
            return groupDTO;
        }
    }
}
