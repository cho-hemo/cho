using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveDungeon
{
    public class Player
    {
        // 플레이어 좌표
        public int playerY;
        public int playerX;
        // 보는 방향
        public int view = 0;
        // 체력
        public int health;
        // 점수
        public int point;
        // 클리어 체크
        public bool clearCheck = false;


        // { 플레이어 이동
        public int PlayerUp(int y)
        {
            y--;
            view = 0;
            return y;
        }

        public int PlayerDown(int y) 
        {
            y++;
            view = 1;
            return y;
        }

        public int PlayerLeft(int x) 
        {
            x--;
            view = 2;
            return x;
        }
        public int PlayerRight(int x)
        {
            x++;
            view = 3;
            return x;
        }
        // } 플레이어 이동


        // { 포인트 증가
        public int PlusPoint(int point)
        {
            point++;
            return point;
        }
        // } 포인트 증가

        // { 체력 감소
        public int MinusHP(int hp)
        {
            hp--;
            return hp;
        }
        // } 체력 감소
    }
}
