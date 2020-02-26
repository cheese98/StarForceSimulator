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
            int level = 0, cost = 0, start = 0, target = 0, count = 0, eventtype = 0, prot = 0, mvp = 0;
            double starcatch = 0;
            bool pcb = false;
            try
            {
                level = int.Parse(itemLevel.Text);
                if (level < 1 || level > 200) throw new Exception(nameof(itemLevel));
                starcatch = double.Parse(catchBonus.Text);
                if (starcatch < 0 || starcatch > 100) throw new Exception(nameof(catchBonus));
                cost = int.Parse(itemCost.Text);
                if (cost < 0) throw new Exception(nameof(itemCost));
                start = int.Parse(startingStar.Text);
                target = int.Parse(targetStar.Text);
                if (start < 0 || start > 25) throw new Exception(nameof(startingStar));
                if (target < 0 || target > 25) throw new Exception(nameof(targetStar));
                if (start >= target) throw new Exception(nameof(startingStar) + ", " +nameof(targetStar));
                count = int.Parse(itemTimes.Text);
                if (count < 1) throw new Exception(nameof(itemTimes));
                eventtype = getEventType();
                if (eventtype == -1) throw new Exception(nameof(eventTypeGroup));
                prot = getProt();
                if (prot == -1) throw new Exception(nameof(protectGroup));
                mvp = getMVP();
                if (mvp == -1) throw new Exception(nameof(mvpGroup));
                pcb = pcRoomRadio1.Checked;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("입력값 중에 잘못된 값이 있습니다. \n \"" + ex.Message + "\"의 값을 수정해주세요.");
            }
            return new Simulator(level, starcatch, cost, start, target, count, eventtype, prot, mvp, pcb);
        }

        private int getEventType()
        {
            /*
             * 0 = 없음, 1 = 30% 세일, 2 = 5, 10, 15성 100%, 3 = 1+1 강화, 4 = 무료파방
             * 일단 if문 노가다로 작성. 더 나은 방법 있으면 교체 필요.
             */
            if (eventRadio1.Checked) return 0;
            if (eventRadio2.Checked) return 1;
            if (eventRadio3.Checked) return 2;
            if (eventRadio4.Checked) return 3;
            if (eventRadio5.Checked) return 4;
            return -1;
        }
        private int getProt()
        {
            /*
             * 0 = 없음, 1 = 15~16성, 2 = 12~16성
             * 일단 if문 노가다로 작성. 더 나은 방법 있으면 교체 필요.
             */
            if (protectRadio1.Checked) return 0;
            if (protectRadio2.Checked) return 1;
            if (protectRadio3.Checked) return 2;
            return -1;
        }
        private int getMVP()
        {
            /*
             * 0 = 브론즈, 1 = 실버, 2 = 골드, 3 = 다이아
             * 일단 if문 노가다로 작성. 더 나은 방법 있으면 교체 필요.
             */
            if (mvpRadio1.Checked) return 0;
            if (mvpRadio2.Checked) return 1;
            if (mvpRadio3.Checked) return 2;
            if (mvpRadio4.Checked) return 3;
            return -1;
        }
    }
}
