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
        private int level, starcatch, cost, start, target, count, eventtype, prot, mvp;
        private bool pcb;
        private int[] priceGraph = new int[25];
        public Simulator(int _level, int _starcatch, int _cost, int _start, int _target, int _count, int _eventtype, int _prot, int _mvp, bool _pcb)
        {
            level = _level; starcatch = _starcatch; cost = _cost; start = _start; target = _target;
            count = _count; eventtype = _eventtype; prot = _prot; mvp = _mvp; pcb = _pcb;
            makeGraph();
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
        public void makeGraph()
        {
            int i;
            for (i = 0; i < 10; i++) priceGraph[i] = 1000 + (int)Math.Round(Math.Pow(level, 3) * (i + 1) / 25, -2);
            for (; i < 15; i++) priceGraph[i] = 1000 + (int)Math.Round(Math.Pow(level, 3) * Math.Pow(i + 1, 2.7) / 400, -2);
            for (; i < 25; i++) priceGraph[i] = 1000 + (int)Math.Round(Math.Pow(level, 3) * Math.Pow(i + 1, 2.7) / 200, -2);
        }
    }
}
