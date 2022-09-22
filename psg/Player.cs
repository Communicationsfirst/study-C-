using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psg
{
    public class player
    {
        public int hp = 100;
        public int at = 10;

        public void ADDAt(int _at)
        {
            //공격력을 올려주기 위한 함수
            at += _at;

        }
        
        public void Fight(int monsterAt)
        {
            hp -= monsterAt;
        }
        

    }
}
