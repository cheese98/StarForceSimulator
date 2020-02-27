using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarForceSimulator
{
    class Simulator
    {
        private int level, cost, start, target, count, eventtype, prot, mvp;
        private double starcatch;
        private bool pcb;
        private double[] priceGraph = new double[25];
        readonly double[] successRate = { 0.95, 0.90, 0.85, 0.85, 0.80, 0.75, 0.70, 0.65, 0.60, 0.55, 0.50, 0.45, 0.40, 0.35, 0.30, 0.30, 0.30, 0.30, 0.30, 0.30, 0.30, 0.30, 0.03, 0.02, 0.01 };
        readonly double[] destroyRate = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.006, 0.013, 0.014, 0.021, 0.021, 0.021, 0.028, 0.028, 0.07, 0.07, 0.194, 0.294, 0.396 };
        readonly double[] discountMVP = { 0, 0.03, 0.05, 0.1 };
        private Random R;
        public Simulator(int _level, double _starcatch, int _cost, int _start, int _target, int _count, int _eventtype, int _prot, int _mvp, bool _pcb)
        {
            level = _level; starcatch = _starcatch; cost = _cost; start = _start; target = _target;
            count = _count; eventtype = _eventtype; prot = _prot; mvp = _mvp; pcb = _pcb;
            makeGraph();
            R = new Random();
        }

        /*
         * 성공 횟수와 실패 횟수를 따로 집계할 필요가 있다고 판단되면 소스코드 수정할것
         */
        public string startSimulator()
        {
            string result = "";
            Int64[] price_sum = new Int64[10000];
            int[] num_destroy = new int[10000];
            //int[] num_Suc = new int[10000];
            //int[] num_Fail = new int[10000];
            int[] num_attempt = new int[10000];
            Int64 sum = 0;
            int det = 0; int num_Suc, num_Fail;
            for (int i = 0; i < count; i++)
            {
                (price_sum[i], num_destroy[i], num_Suc, num_Fail) = oneEnhance();
                sum += price_sum[i];
                det += num_destroy[i];
                num_attempt[i] = num_Suc + num_Fail;
            }
            Int64 avg = sum / count;
            double detavg = (double)det / count;
            return "평균 소모량 = " + avg.ToString() + "\n평균 파괴 횟수 = " + detavg.ToString();
        }
        private (Int64, int, int, int) oneEnhance()
        {
            Int64 sum = 0;
            int destroy = 0, num_Suc = 0, num_Fail = 0, failStack = 0;
            int star = start;
            while (star < target)
            {
                double sucRate = successRate[star], detRate = destroyRate[star], priceRate = 1;
                bool flag = false, ptflag = false;
                
                if (failStack == 2) flag = true; // 2연속 실패시 반드시 성공
                //스타캐치는 곱연산으로 취급
                sucRate *= (1 + starcatch * 0.01);
                
                // 5, 10, 15성 이벤트
                if (eventtype == 2 && (star == 5 || star == 10 || star == 15)) flag = true;

                if (star < 17)
                {
                    priceRate -= discountMVP[mvp];
                    if (pcb) priceRate -= 0.05;
                }

                if (eventtype == 1) priceRate *= 0.7;

                // ~15 무료파방 이벤트
                if (eventtype == 4 && star < 15) ptflag = true;
                //파방
                if (prot > 0 && !ptflag)
                {
                    ptflag = true;
                    if (prot == 2 && star > 11 && star < 17) priceRate += 1;
                    if (prot == 1 && (star == 15 || star == 16)) priceRate += 1;
                }
                if (ptflag) detRate = 0;
                switch (tryEnhance(sucRate, detRate, flag))
                {
                    case 1:
                        {
                            if (eventtype == 3 && star < 10) star += 2;
                            else star++;
                            num_Suc++;
                            failStack = 0;
                            break;
                        }
                    case 0:
                        {
                            failStack++;
                            num_Fail++;
                            if ((star > 10 && star < 15) || (star > 15 && star < 20) || star > 20) star--;
                            break;
                        }
                    case -1:
                        {
                            failStack = 0; num_Fail++; destroy++;
                            star = 12;
                            sum += cost;
                            break;
                        }
                }
                sum += (int)(priceGraph[star] * priceRate);
            }
            return (sum, destroy, num_Suc, num_Fail);
        }
        
        private int tryEnhance(double suc, double det, bool flag)
        {
            /*
             * flag가 true일 경우 항상 성공
             * 1 = 성공
             * 0 = 실패 (하락 여부는 밖에서 판단)
             * -1 = 파괴
             */
            double randValue = R.NextDouble();
            if (flag || randValue <= suc) return 1;
            else if (randValue > 1 - det) return -1;
            return 0;
        }

        private void makeGraph()
        {
            int i;
            for (i = 0; i < 10; i++) priceGraph[i] = (1000 + (int)Math.Round(Math.Pow(level, 3) * (i + 1) / 25)) / 100 * 100;
            for (; i < 15; i++) priceGraph[i] = (1000 + (int)Math.Round(Math.Pow(level, 3) * Math.Pow(i + 1, 2.7) / 400)) / 100 * 100;
            for (; i < 25; i++) priceGraph[i] = (1000 + (int)Math.Round(Math.Pow(level, 3) * Math.Pow(i + 1, 2.7) / 200)) / 100 * 100;
        }
    }
}
