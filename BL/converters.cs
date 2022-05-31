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
       public static Cours Convert(CourseDTO courseDTO)
        {
            Cours cours = new Cours();
            cours.courseId = courseDTO.courseId;
            cours.courseName = courseDTO.courseName;
            cours.isEnternet = courseDTO.isEnternet;
            return cours;
        }
        public static CourseDTO Convert(Cours cours)
        {
            CourseDTO courseDTO = new CourseDTO();
            courseDTO.courseId = cours.courseId;
            courseDTO.courseName = cours.courseName;
            courseDTO.isEnternet = cours.isEnternet;
            return courseDTO;
        }
        public static Group Convert(GroupDTO groupDTO)
        {
            Group group = new Group();
            group.groupId = groupDTO.groupId;
            group.groupName = groupDTO.groupName;
            group.groupNumPupil = groupDTO.groupNumPupil;
            return group;
        }
        public static GroupDTO Convert(Group group)
        {
            GroupDTO groupDTO = new GroupDTO();
            groupDTO.groupId = group.groupId;
            groupDTO.groupName = group.groupName;
            groupDTO.groupNumPupil = group.groupNumPupil;
            return groupDTO;
        }
        public static RoomDTO Convert(Room room)
        {
            RoomDTO roomDTO = new RoomDTO();
            roomDTO.calssRoomNumComputer = room.calssRoomNumComputer;
            roomDTO.classRoomId = room.classRoomId;
            roomDTO.classRoomIsEnternet = room.classRoomIsEnternet;
            roomDTO.classRoomName = room.classRoomName;
            return roomDTO;
        }
        public static Room Convert(RoomDTO roomDTO)
        {
            Room room = new Room();
            room.calssRoomNumComputer = roomDTO.calssRoomNumComputer;
            room.classRoomId = roomDTO.classRoomId;
            room.classRoomIsEnternet = roomDTO.classRoomIsEnternet;
            room.classRoomName = roomDTO.classRoomName;
            return room;
        }
        public static ScheduleDTO Convert(Schedule schedule)
        {
            ScheduleDTO scheduleDTO = new ScheduleDTO();
            scheduleDTO.scheduleClassRoomId = schedule.scheduleClassRoomId;
            scheduleDTO.scheduleCourseId = schedule.scheduleCourseId;
            scheduleDTO.scheduleDay = schedule.scheduleDay;
            scheduleDTO.scheduleGroupId = schedule.scheduleGroupId;
            scheduleDTO.scheduleId = schedule.scheduleId;
            scheduleDTO.scheduleNumLesson = schedule.scheduleNumLesson;
            return scheduleDTO;
        }
        public static Schedule Convert(ScheduleDTO scheduleDTO)
        {
            Schedule schedule = new Schedule();
            schedule.scheduleClassRoomId = scheduleDTO.scheduleClassRoomId;
            schedule.scheduleCourseId = scheduleDTO.scheduleCourseId;
            schedule.scheduleDay = scheduleDTO.scheduleDay;
            schedule.scheduleGroupId = scheduleDTO.scheduleGroupId;
            schedule.scheduleId = scheduleDTO.scheduleId;
            schedule.scheduleNumLesson = scheduleDTO.scheduleNumLesson;
            return schedule;
        }
    }
}
