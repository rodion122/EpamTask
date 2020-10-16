using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.BLL
{
    class Validation
    {
        public bool IsValidInputData(string[] arrData)
        {
            double value;
            for (int i = 0; i < arrData.Length; i++)
                if (!double.TryParse(arrData[i], out value))
                    return false;
            

            if (arrData.Length < 3)
                return false;

            if (arrData.Length != 3)
            {
                if (arrData.Where(i => Array.IndexOf(arrData, i) % 2 == 0 && i.Count() > 1).Count() > 0)
                    return false;

                if (arrData.Where(i => Array.IndexOf(arrData, i) % 2 != 0 && i.Count() > 1).Count() > 0)
                    return false;
            }
            return true;
        }
    }
}
