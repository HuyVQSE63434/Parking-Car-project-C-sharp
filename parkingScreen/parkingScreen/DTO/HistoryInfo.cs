using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingScreen.DTO
{
    class HistoryInfo
    {
        public string historyId { get; set; }
        public string timeIn { get; set; }
        public string timeOut { get; set; }
        public string position { get; set; }
        public float money { get; set; }
        public string keyCode { get; set; }
        public string userId { get; set; }
        
        public HistoryInfo()
        {

        }
        public HistoryInfo(string hisid, string timeid, string timeout, string timein, string position, float money, string keycode, string userid)
        {
            this.historyId = hisid;
            this.timeIn = timein;
            this.timeOut = timeout;
            this.position = position;
            this.money = money;
            this.keyCode = keycode;
            this.userId = userid;
        }
    }
}
