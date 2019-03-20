using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLatHinh
{
    public class ListGameLevel
    {
        public int numMaxlv = 9;
        public GameLevel[] listgl = new GameLevel[10];
        
        public void setListGameLevel()
        {
            for (int i = 0; i <=9; i++)
                listgl[i] = new GameLevel();
            listgl[0].setGameLevel(0, 6, 150, 3, 2,100,2,2,0,"a");
            listgl[1].setGameLevel(1, 12, 150, 4, 3,200,3,3,0,"b");
            listgl[2].setGameLevel(2, 24, 150, 6, 4,400,5,5,0,"a");
            listgl[3].setGameLevel(3, 28, 100, 7, 4,800,10,10,0,"");
            listgl[4].setGameLevel(4, 32, 120, 8, 4, 1000,7,7,0,"b");
            listgl[5].setGameLevel(5, 48, 100, 8, 6, 1500,10,10,0,"a");
            listgl[6].setGameLevel(6, 48, 100, 8, 6, 1400,9,9,0,"");
            listgl[7].setGameLevel(7, 48, 100, 8, 6, 1200,8,8,0,"a");
            listgl[8].setGameLevel(8, 48, 100, 8, 6, 1000,12,12,0,"");
            listgl[9].setGameLevel(9, 54, 100, 9, 6, 2000,14,14,0,"a");

        }
        public GameLevel  getlv(int i)
        {
            return listgl[i];
        }

    }
}
