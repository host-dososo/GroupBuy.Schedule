using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GroupBuy.Schedule.Binders
{
    public static class SignalRKeys
    {
        private static string GetName([CallerMemberName] string memberName = "")
        {
            return memberName;
        }
        private static string GetClassName()
        {
            return typeof(SignalRKeys).Name;
        }

        public class BaseKey { 

            public static string JoinGroup { get { return GetName(); } }

        }

        public class Hub
        {
            public static string LineHub { get { return GetName(); } }
            public static string FBHub { get { return GetName(); } }
        }

        public class Group { 
            public static string MerUsr { get { return GetName(); } }
            public static string LineSelfbot { get { return GetName(); } }
        }

        public class MerUsr : BaseKey
        {

            private static string GetClassName()
            {
                return typeof(MerUsr).Name;
            }

            public static string CreatePost { get { return GetName(); } }
        }


        public class LineSelfbot : BaseKey
        {

            private static string GetClassName()
            {
                return typeof(LineSelfbot).Name;
            }

            public static string CreatePost { get { return GetName(); } }
        }

        public class FBSelfbot : BaseKey
        {

            private static string GetClassName()
            {
                return typeof(LineSelfbot).Name;
            }

            public static string ScheduleEnqueqed { get { return GetName(); } }
        }
    }

    
}
