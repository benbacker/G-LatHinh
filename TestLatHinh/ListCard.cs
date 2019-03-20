using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLatHinh
{   
    [Serializable]
    public class ListCard

    {   
        static Random _random = new Random();
        int tempcount = 1;
        public string typecard;
        public int numCardbonustime;
        public int numCardbonusscore;
        public int numCardDangerous;
        public int _NUMCOLUMN_;
    
        public int _NUMROW_;
        
        public Card[] listCard;
        

        public void setListCard(int _numcolumn, int _numrow, int _numbstime=0, int _numbsscore=0, int _numdanger=0,string _typecard="")
        {
            typecard = _typecard;
            _NUMCOLUMN_ = _numcolumn;
            _NUMROW_ = _numrow;
            numCardbonusscore = _numbsscore;
            numCardbonustime = _numbstime;
            numCardDangerous = _numdanger;
            listCard = new Card[_NUMROW_ * _NUMCOLUMN_+1];
        }
        public void randomimage()
        {   
            
            int socard = _NUMCOLUMN_ * _NUMROW_;
            


            for (int i = 1; i <= socard; i++)
            {
                listCard[i] = new Card();
            }
            int[] imagearray = new int[socard];
            for(int i=0;i<socard;i+=2)
            {
                imagearray[i] = tempcount;
                imagearray[i + 1] = tempcount;
                tempcount++;
            }

            Shuffle(imagearray);//dao lai list
            for (int i = 1; i <= socard; i++)
            {
                listCard[i].cardimagename = imagearray[i - 1];
                listCard[i].cardnum = i;
            }
            if (numCardbonusscore != 0 && numCardbonustime != 0)
            {
                int[] bonusarray = new int[socard];
                for (int count = 0; count < socard; count++)
                {
                    if (numCardbonusscore > 0)
                    {
                        bonusarray[count] = 1;
                        numCardbonusscore--;
                    }
                    else if (numCardbonustime > 0)
                    {
                        bonusarray[count] = 2;
                        numCardbonustime--;
                    }
                    else if (numCardDangerous > 0)
                    {
                        bonusarray[count] = 3;
                        numCardDangerous--;
                    }
                }
                Shuffle(bonusarray);
                for (int i = 1; i < socard + 1; i++)
                {
                    if (bonusarray[i - 1] == 1)
                    {
                        listCard[i].isBonusScoreCard = true;
                    }
                    else if (bonusarray[i - 1] == 2)
                    {
                        listCard[i].isBonusTimeCard = true;
                    }
                    else if (bonusarray[i - 1] == 3)
                    {
                        listCard[i].isDangerousCard = true;
                    }
                }
            }

        }
        public Card getCard(int num)
        {
            return listCard[num];
        }
        static void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                // Use Next on random instance with an argument.
                // ... The argument is an exclusive bound.
                //     So we will not go past the end of the array.
                int r = i + _random.Next(n - i);
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }

    }

}
