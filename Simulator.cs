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
        private int[] priceGraph = new int[25];
        readonly double[] successRate = { 95, 90, 85, 85, 80, 75, 70, 65, 60, 55, 50, 45, 40, 35, 30, 30, 30, 30, 30, 30, 30, 30, 3, 2, 1 };
        readonly double[] destroyRate = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.6, 1.3, 1.4, 2.1, 2.1, 2.1, 2.8, 2.8, 7.0, 7.0, 19.4, 29.4, 39.6 };
        private Random R;
        public Simulator(int _level, double _starcatch, int _cost, int _start, int _target, int _count, int _eventtype, int _prot, int _mvp, bool _pcb)
        {
            level = _level; starcatch = _starcatch; cost = _cost; start = _start; target = _target;
            count = _count; eventtype = _eventtype; prot = _prot; mvp = _mvp; pcb = _pcb;
            makeGraph();
            R = new Random();
        }
        public string startSimulator()
        {
            string result = "";

            return result;
        }
        private (Int64, int, int) oneEnhance()
        {
            Int64 sum = 0;
            int destroy = 0, attempt = 0;

            return (sum, destroy, attempt);
        }
        private void makeGraph()
        {
            int i;
            for (i = 0; i < 10; i++) priceGraph[i] = (1000 + (int)Math.Round(Math.Pow(level, 3) * (i + 1) / 25)) / 100 * 100;
            for (; i < 15; i++) priceGraph[i] = (1000 + (int)Math.Round(Math.Pow(level, 3) * Math.Pow(i + 1, 2.7) / 400)) / 100 * 100;
            for (; i < 25; i++) priceGraph[i] = (1000 + (int)Math.Round(Math.Pow(level, 3) * Math.Pow(i + 1, 2.7) / 200)) / 100 * 100;
        }

        private int tryEnhance(double suc, double det, int _star)
        {
            /*
             * 2 = 성공
             * 1 = 실패(유지)
             * 0 = 하락
             * -1 = 파괴
             */
            double randValue = R.NextDouble();
            if (randValue <= suc) return 2;
            else if (randValue >= 1 - det) return -1;
            else if (_star < 10 || _star == 15 || _star == 20) return 1;
            else return 0;
        }
    }
}
