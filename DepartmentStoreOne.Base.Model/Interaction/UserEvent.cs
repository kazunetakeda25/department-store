using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Base.Model.Interaction
{
    public class UserEvent
    {
        public string Type { get; set; }

        public string Event { get; set; }

        public string TargetTag { get; set; }

        public string TargetClasses { get; set; }

        public string Content { get; set; }

        //        clientPosition: {
        //    x: e.clientX,
        //            y: e.clientY
        //        },
        //        screenPosition: {
        //    x: e.screenX,
        //            y: e.screenY
        //        },

        public DateTime? CreatedAt { get; set; }
    }
}
