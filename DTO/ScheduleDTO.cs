using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class ScheduleDTO
    {
        public int scheduleId { get; set; }
        public int scheduleDay { get; set; }
        public int scheduleNumLesson { get; set; }
        public int scheduleCourseId { get; set; }
        public int scheduleGroupId { get; set; }
        public Nullable<int> scheduleClassRoomId { get; set; }
    }
}
