using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLatHinh
{
    public class GameLevel
    {
        public int level;
        public int CardNum;
        public int CardSize;
        public int NumColumn;
        public int NumRow;
        public int time;
        public int numCardbonustime;
        public int numCardbonusscore;
        public int numCardDangerous;
        public string typeCard;
        

        public void  setGameLevel(int _level, int _cardnum, int _cardsize, int _numcolumn, int _numrow, int _time,int _numbstime,int _numbsscore,int _numdanger,string _typeCard="")
        {
            typeCard = _typeCard;
            level = _level;
            CardNum = _cardnum;
            CardSize = _cardsize;
            NumColumn = _numcolumn;
            NumRow = _numrow;
            time = _time;
            numCardbonusscore = _numbsscore;
            numCardbonustime = _numbstime;
            numCardDangerous = _numdanger;

        }


    }
}
