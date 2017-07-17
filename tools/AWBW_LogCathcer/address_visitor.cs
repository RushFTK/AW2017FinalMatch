using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWBW_LogCathcer
{
    /// <summary> 通过访问某个特定的地址，下载其网页数据 </summary>
    class address_visitor
    {
        /// <summary>访问的目标网址 </summary>
        public string target_address { get; set; }

        public bool tester(ToolStripStatusLabel info_label)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(target_address);
                info_label.Text = "成功访问目标网页";
            }
            catch (Exception e)
            {
                info_label.Text = e.Message;
            }
            return true;
        }

        /// <summary> 下载全部数据 </summary>
        /// <returns> 是否下载成功，成功返回true </returns>
        public bool download_all()
        {
            return true;
        }

        /// <summary> 判断连接是否超时 </summary>
        /// <returns> 判断结果。超时返回true。 </returns>
        public bool istimeout()
        {
            return false;
        }
    }
}
