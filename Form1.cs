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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            resultLabel.Text = "";
        }

        private void startEnhance_Click(object sender, EventArgs e)
        {
            Simulator sim = makeSimulator();

            sim.makeGraph();
            resultLabel.Text = sim.startSimulator();
        }

        private Simulator makeSimulator()
        {
            int level, starcatch, cost, start, target, count, eventtype, prot, mvp;
            bool pcb;
            try
            {
                level = int.Parse(itemLevel.Text);
                if (level < 1 || level > 200) throw new Exception(itemLevel.Text);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("입력값 중에 잘못된 값이 있습니다. \n \"%s\"의 값을 수정해주세요.", ex.Message);
            }
            return new Simulator(level, starcatch, cost, start, target, count, eventtype, prot, mvp, pcb);
        }
    }
}
