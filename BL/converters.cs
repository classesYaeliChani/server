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
    }
}
