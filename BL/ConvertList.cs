using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL
{
    public class ConvertList
    {
        public static List<Cours> Convert(List<CourseDTO> list_courseDTO)
        {
            List<Cours> list_cours = new List<Cours>();
            foreach (CourseDTO courseDTO in list_courseDTO)
            {
                list_cours.Add(converters.Convert(courseDTO));
            }
            return list_cours;
        }
        public static List<CourseDTO> Convert(List<Cours> list_cours)
        {
            List<CourseDTO> list_courseDTO = new List<CourseDTO>();
            foreach (Cours cours in list_cours)
            {
                list_courseDTO.Add(converters.Convert(cours));
            }
            return list_courseDTO;
        }
        public static List<Group> Convert(List<GroupDTO> list_groupDTO)
        {
            List<Group> list_group = new List<Group>();
            foreach (GroupDTO groupDTO in list_groupDTO)
            {
                list_group.Add(converters.Convert(groupDTO));
            }
            return list_group;
        }
        public static List<GroupDTO> Convert(List<Group> list_group)
        {
            List<GroupDTO> list_groupDTO = new List<GroupDTO>();
            foreach (Group group in list_group)
            {
                list_groupDTO.Add(converters.Convert(group));
            }
            return list_groupDTO;
        }
        public static List<RoomDTO> Convert(List<Room> list_room)
        {
            List<RoomDTO> list_roomDTO = new List<RoomDTO>();
            foreach (Room room in list_room)
            {
                list_roomDTO.Add(converters.Convert(room));
            }
            return list_roomDTO;
        }
        public static List<Room> Convert(List<RoomDTO> list_roomDTO)
        {
            List<Room> list_room = new List<Room>();
            foreach (RoomDTO roomDTO in list_roomDTO)
            {
                list_room.Add(converters.Convert(roomDTO));
            }
            return list_room;
        }
        public static List<ScheduleDTO> Convert(List<Schedule> list_schedule)
        {
            List<ScheduleDTO> list_scheduleDTO = new List<ScheduleDTO>();
            foreach (Schedule schedule in list_schedule)
            {
                list_scheduleDTO.Add(converters.Convert(schedule));
            }
            return list_scheduleDTO;
        }
        public static List<Schedule> Convert(List<ScheduleDTO> list_scheduleDTO)
        {
            List<Schedule> list_schedule = new List<Schedule>();
            foreach (ScheduleDTO scheduleDTO in list_scheduleDTO)
            {
                list_schedule.Add(converters.Convert(scheduleDTO));
            }
            return list_schedule;
        }
    }
}
