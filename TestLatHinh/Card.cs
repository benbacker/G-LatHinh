using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLatHinh
{   
    [Serializable]
    public class Card
    {
        public int cardnum;
        public int cardimagename;
        public int status;
        public bool isBonusTimeCard = false;
        public bool isBonusScoreCard = false;
        public bool isDangerousCard = false;
        public int getcardnum()
        {
            return this.cardnum;
        }
        public int getcardimagename()
        {
            return this.cardimagename;
        }
        public int getcardstatus()
        {
            return this.status;
        }
        public void setcardnum(int num)
        {
            this.cardnum = num;
        }
        public void setcardimage(int num)
        {
            this.cardimagename = num;
        }
        public void setcardstatus(int num)
        {
            this.status = num;
        }

    }
}
