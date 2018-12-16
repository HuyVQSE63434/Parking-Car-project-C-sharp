using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkingScreen.DAO
{
    class KeyCodeCheck
    {
        public tblHistory CheckKC(string keycode)
        {
            tblHistory result = null;

            DataClasses1DataContext db = new DataClasses1DataContext();

            var check = (from table in db.tblHistories where table.keyCode == keycode select table).Single();
            if (check != null)
            {
                result = check;
            }

            return result;
        }

    }
}
