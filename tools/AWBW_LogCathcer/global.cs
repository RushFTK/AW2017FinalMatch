using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWBW_LogCathcer
{
    public static class global
    {
        /// <summary> 从远程下载所需要的步数(计算进度条等需求) </summary>
        public static int getinf_steps {get;set;}

        /// <summary> 是否是以debug模式运行，将显示一些debug模式下显示的资源</summary>
        public static bool debug_mode { get; set; }
    }
}
