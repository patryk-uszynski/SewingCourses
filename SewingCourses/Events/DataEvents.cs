using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingCourses.Events
{
    public static class DataEvents
    {
        public static event EventHandler DataChanged;

        internal static void RaiseDataChanged()
        {
            var handler = DataChanged;
            if (handler != null)
                handler(null,null);
        }
    }
}
