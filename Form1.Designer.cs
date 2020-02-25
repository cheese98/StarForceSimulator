namespace StarForceSimulator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.itemLevel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.catchBonus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startingStar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tragetStar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.itemTimes = new System.Windows.Forms.TextBox();
            this.eventTypeGroup = new System.Windows.Forms.GroupBox();
            this.eventRadio1 = new System.Windows.Forms.RadioButton();
            this.eventRadio2 = new System.Windows.Forms.RadioButton();
            this.eventRadio3 = new System.Windows.Forms.RadioButton();
            this.eventRadio4 = new System.Windows.Forms.RadioButton();
            this.eventRadio5 = new System.Windows.Forms.RadioButton();
            this.protectGroup = new System.Windows.Forms.GroupBox();
            this.protectRadio1 = new System.Windows.Forms.RadioButton();
            this.protectRadio2 = new System.Windows.Forms.RadioButton();
            this.protectRadio3 = new System.Windows.Forms.RadioButton();
            this.mvpGroup = new System.Windows.Forms.GroupBox();
            this.mvpRadio1 = new System.Windows.Forms.RadioButton();
            this.mvpRadio2 = new System.Windows.Forms.RadioButton();
            this.mvpRadio3 = new System.Windows.Forms.RadioButton();
            this.mvpRadio4 = new System.Windows.Forms.RadioButton();
            this.pcRoomGroup = new System.Windows.Forms.GroupBox();
            this.pcRoomRadio1 = new System.Windows.Forms.RadioButton();
            this.pcRoomRadio2 = new System.Windows.Forms.RadioButton();
            this.startEnhance = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.eventTypeGroup.SuspendLayout();
            this.protectGroup.SuspendLayout();
            this.mvpGroup.SuspendLayout();
            this.pcRoomGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이템 레벨";
            // 
            // itemLevel
            // 
            this.itemLevel.Location = new System.Drawing.Point(107, 12);
            this.itemLevel.Name = "itemLevel";
            this.itemLevel.Size = new System.Drawing.Size(100, 21);
            this.itemLevel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "스타캐치(%p)";
            // 
            // catchBonus
            // 
            this.catchBonus.Location = new System.Drawing.Point(107, 58);
            this.catchBonus.Name = "catchBonus";
            this.catchBonus.Size = new System.Drawing.Size(100, 21);
            this.catchBonus.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "복구비용";
            // 
            // itemCost
            // 
            this.itemCost.Location = new System.Drawing.Point(107, 104);
            this.itemCost.Name = "itemCost";
            this.itemCost.Size = new System.Drawing.Size(100, 21);
            this.itemCost.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "시작 레벨";
            // 
            // startingStar
            // 
            this.startingStar.Location = new System.Drawing.Point(107, 150);
            this.startingStar.Name = "startingStar";
            this.startingStar.Size = new System.Drawing.Size(100, 21);
            this.startingStar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "목표 레벨";
            // 
            // tragetStar
            // 
            this.tragetStar.Location = new System.Drawing.Point(107, 196);
            this.tragetStar.Name = "tragetStar";
            this.tragetStar.Size = new System.Drawing.Size(100, 21);
            this.tragetStar.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "아이템 제작 수";
            // 
            // itemTimes
            // 
            this.itemTimes.Location = new System.Drawing.Point(107, 242);
            this.itemTimes.Name = "itemTimes";
            this.itemTimes.Size = new System.Drawing.Size(100, 21);
            this.itemTimes.TabIndex = 11;
            // 
            // eventTypeGroup
            // 
            this.eventTypeGroup.Controls.Add(this.eventRadio5);
            this.eventTypeGroup.Controls.Add(this.eventRadio4);
            this.eventTypeGroup.Controls.Add(this.eventRadio3);
            this.eventTypeGroup.Controls.Add(this.eventRadio2);
            this.eventTypeGroup.Controls.Add(this.eventRadio1);
            this.eventTypeGroup.Location = new System.Drawing.Point(223, 12);
            this.eventTypeGroup.Name = "eventTypeGroup";
            this.eventTypeGroup.Size = new System.Drawing.Size(216, 86);
            this.eventTypeGroup.TabIndex = 12;
            this.eventTypeGroup.TabStop = false;
            this.eventTypeGroup.Text = "이벤트";
            // 
            // eventRadio1
            // 
            this.eventRadio1.AutoSize = true;
            this.eventRadio1.Checked = true;
            this.eventRadio1.Location = new System.Drawing.Point(6, 20);
            this.eventRadio1.Name = "eventRadio1";
            this.eventRadio1.Size = new System.Drawing.Size(47, 16);
            this.eventRadio1.TabIndex = 0;
            this.eventRadio1.TabStop = true;
            this.eventRadio1.Text = "없음";
            this.eventRadio1.UseVisualStyleBackColor = true;
            // 
            // eventRadio2
            // 
            this.eventRadio2.AutoSize = true;
            this.eventRadio2.Location = new System.Drawing.Point(6, 42);
            this.eventRadio2.Name = "eventRadio2";
            this.eventRadio2.Size = new System.Drawing.Size(73, 16);
            this.eventRadio2.TabIndex = 1;
            this.eventRadio2.Text = "30% 세일";
            this.eventRadio2.UseVisualStyleBackColor = true;
            // 
            // eventRadio3
            // 
            this.eventRadio3.AutoSize = true;
            this.eventRadio3.Location = new System.Drawing.Point(87, 20);
            this.eventRadio3.Name = "eventRadio3";
            this.eventRadio3.Size = new System.Drawing.Size(113, 16);
            this.eventRadio3.TabIndex = 2;
            this.eventRadio3.Text = "5, 10, 15성 100%";
            this.eventRadio3.UseVisualStyleBackColor = true;
            // 
            // eventRadio4
            // 
            this.eventRadio4.AutoSize = true;
            this.eventRadio4.Location = new System.Drawing.Point(87, 42);
            this.eventRadio4.Name = "eventRadio4";
            this.eventRadio4.Size = new System.Drawing.Size(69, 16);
            this.eventRadio4.TabIndex = 3;
            this.eventRadio4.Text = "1+1 강화";
            this.eventRadio4.UseVisualStyleBackColor = true;
            // 
            // eventRadio5
            // 
            this.eventRadio5.AutoSize = true;
            this.eventRadio5.Location = new System.Drawing.Point(6, 64);
            this.eventRadio5.Name = "eventRadio5";
            this.eventRadio5.Size = new System.Drawing.Size(110, 16);
            this.eventRadio5.TabIndex = 4;
            this.eventRadio5.Text = "무료 파방 (~15)";
            this.eventRadio5.UseVisualStyleBackColor = true;
            // 
            // protectGroup
            // 
            this.protectGroup.Controls.Add(this.protectRadio3);
            this.protectGroup.Controls.Add(this.protectRadio2);
            this.protectGroup.Controls.Add(this.protectRadio1);
            this.protectGroup.Location = new System.Drawing.Point(223, 107);
            this.protectGroup.Name = "protectGroup";
            this.protectGroup.Size = new System.Drawing.Size(96, 85);
            this.protectGroup.TabIndex = 13;
            this.protectGroup.TabStop = false;
            this.protectGroup.Text = "파괴방지 여부";
            // 
            // protectRadio1
            // 
            this.protectRadio1.AutoSize = true;
            this.protectRadio1.Checked = true;
            this.protectRadio1.Location = new System.Drawing.Point(6, 20);
            this.protectRadio1.Name = "protectRadio1";
            this.protectRadio1.Size = new System.Drawing.Size(47, 16);
            this.protectRadio1.TabIndex = 0;
            this.protectRadio1.TabStop = true;
            this.protectRadio1.Text = "없음";
            this.protectRadio1.UseVisualStyleBackColor = true;
            // 
            // protectRadio2
            // 
            this.protectRadio2.AutoSize = true;
            this.protectRadio2.Location = new System.Drawing.Point(6, 42);
            this.protectRadio2.Name = "protectRadio2";
            this.protectRadio2.Size = new System.Drawing.Size(68, 16);
            this.protectRadio2.TabIndex = 1;
            this.protectRadio2.Text = "15~16성";
            this.protectRadio2.UseVisualStyleBackColor = true;
            // 
            // protectRadio3
            // 
            this.protectRadio3.AutoSize = true;
            this.protectRadio3.Location = new System.Drawing.Point(6, 64);
            this.protectRadio3.Name = "protectRadio3";
            this.protectRadio3.Size = new System.Drawing.Size(68, 16);
            this.protectRadio3.TabIndex = 2;
            this.protectRadio3.Text = "12~16성";
            this.protectRadio3.UseVisualStyleBackColor = true;
            // 
            // mvpGroup
            // 
            this.mvpGroup.Controls.Add(this.mvpRadio4);
            this.mvpGroup.Controls.Add(this.mvpRadio3);
            this.mvpGroup.Controls.Add(this.mvpRadio2);
            this.mvpGroup.Controls.Add(this.mvpRadio1);
            this.mvpGroup.Location = new System.Drawing.Point(325, 107);
            this.mvpGroup.Name = "mvpGroup";
            this.mvpGroup.Size = new System.Drawing.Size(114, 110);
            this.mvpGroup.TabIndex = 3;
            this.mvpGroup.TabStop = false;
            this.mvpGroup.Text = "MVP";
            // 
            // mvpRadio1
            // 
            this.mvpRadio1.AutoSize = true;
            this.mvpRadio1.Checked = true;
            this.mvpRadio1.Location = new System.Drawing.Point(6, 20);
            this.mvpRadio1.Name = "mvpRadio1";
            this.mvpRadio1.Size = new System.Drawing.Size(59, 16);
            this.mvpRadio1.TabIndex = 0;
            this.mvpRadio1.TabStop = true;
            this.mvpRadio1.Text = "브론즈";
            this.mvpRadio1.UseVisualStyleBackColor = true;
            // 
            // mvpRadio2
            // 
            this.mvpRadio2.AutoSize = true;
            this.mvpRadio2.Location = new System.Drawing.Point(6, 42);
            this.mvpRadio2.Name = "mvpRadio2";
            this.mvpRadio2.Size = new System.Drawing.Size(47, 16);
            this.mvpRadio2.TabIndex = 1;
            this.mvpRadio2.Text = "실버";
            this.mvpRadio2.UseVisualStyleBackColor = true;
            // 
            // mvpRadio3
            // 
            this.mvpRadio3.AutoSize = true;
            this.mvpRadio3.Location = new System.Drawing.Point(6, 64);
            this.mvpRadio3.Name = "mvpRadio3";
            this.mvpRadio3.Size = new System.Drawing.Size(47, 16);
            this.mvpRadio3.TabIndex = 2;
            this.mvpRadio3.Text = "골드";
            this.mvpRadio3.UseVisualStyleBackColor = true;
            // 
            // mvpRadio4
            // 
            this.mvpRadio4.AutoSize = true;
            this.mvpRadio4.Location = new System.Drawing.Point(6, 86);
            this.mvpRadio4.Name = "mvpRadio4";
            this.mvpRadio4.Size = new System.Drawing.Size(59, 16);
            this.mvpRadio4.TabIndex = 3;
            this.mvpRadio4.Text = "다이아";
            this.mvpRadio4.UseVisualStyleBackColor = true;
            // 
            // pcRoomGroup
            // 
            this.pcRoomGroup.Controls.Add(this.pcRoomRadio2);
            this.pcRoomGroup.Controls.Add(this.pcRoomRadio1);
            this.pcRoomGroup.Location = new System.Drawing.Point(223, 196);
            this.pcRoomGroup.Name = "pcRoomGroup";
            this.pcRoomGroup.Size = new System.Drawing.Size(96, 67);
            this.pcRoomGroup.TabIndex = 14;
            this.pcRoomGroup.TabStop = false;
            this.pcRoomGroup.Text = "PC방";
            // 
            // pcRoomRadio1
            // 
            this.pcRoomRadio1.AutoSize = true;
            this.pcRoomRadio1.Checked = true;
            this.pcRoomRadio1.Location = new System.Drawing.Point(3, 17);
            this.pcRoomRadio1.Name = "pcRoomRadio1";
            this.pcRoomRadio1.Size = new System.Drawing.Size(59, 16);
            this.pcRoomRadio1.TabIndex = 0;
            this.pcRoomRadio1.TabStop = true;
            this.pcRoomRadio1.Text = "미적용";
            this.pcRoomRadio1.UseVisualStyleBackColor = true;
            // 
            // pcRoomRadio2
            // 
            this.pcRoomRadio2.AutoSize = true;
            this.pcRoomRadio2.Location = new System.Drawing.Point(3, 39);
            this.pcRoomRadio2.Name = "pcRoomRadio2";
            this.pcRoomRadio2.Size = new System.Drawing.Size(47, 16);
            this.pcRoomRadio2.TabIndex = 1;
            this.pcRoomRadio2.Text = "적용";
            this.pcRoomRadio2.UseVisualStyleBackColor = true;
            // 
            // startEnhance
            // 
            this.startEnhance.Location = new System.Drawing.Point(331, 223);
            this.startEnhance.Name = "startEnhance";
            this.startEnhance.Size = new System.Drawing.Size(108, 40);
            this.startEnhance.TabIndex = 15;
            this.startEnhance.Text = "강화시작";
            this.startEnhance.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(445, 15);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(67, 12);
            this.resultLabel.TabIndex = 16;
            this.resultLabel.Text = "resultLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 291);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.startEnhance);
            this.Controls.Add(this.pcRoomGroup);
            this.Controls.Add(this.mvpGroup);
            this.Controls.Add(this.protectGroup);
            this.Controls.Add(this.eventTypeGroup);
            this.Controls.Add(this.itemTimes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tragetStar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startingStar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.itemCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.catchBonus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemLevel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.eventTypeGroup.ResumeLayout(false);
            this.eventTypeGroup.PerformLayout();
            this.protectGroup.ResumeLayout(false);
            this.protectGroup.PerformLayout();
            this.mvpGroup.ResumeLayout(false);
            this.mvpGroup.PerformLayout();
            this.pcRoomGroup.ResumeLayout(false);
            this.pcRoomGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox catchBonus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startingStar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tragetStar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox itemTimes;
        private System.Windows.Forms.GroupBox eventTypeGroup;
        private System.Windows.Forms.RadioButton eventRadio5;
        private System.Windows.Forms.RadioButton eventRadio4;
        private System.Windows.Forms.RadioButton eventRadio3;
        private System.Windows.Forms.RadioButton eventRadio2;
        private System.Windows.Forms.RadioButton eventRadio1;
        private System.Windows.Forms.GroupBox protectGroup;
        private System.Windows.Forms.RadioButton protectRadio3;
        private System.Windows.Forms.RadioButton protectRadio2;
        private System.Windows.Forms.RadioButton protectRadio1;
        private System.Windows.Forms.GroupBox mvpGroup;
        private System.Windows.Forms.RadioButton mvpRadio4;
        private System.Windows.Forms.RadioButton mvpRadio3;
        private System.Windows.Forms.RadioButton mvpRadio2;
        private System.Windows.Forms.RadioButton mvpRadio1;
        private System.Windows.Forms.GroupBox pcRoomGroup;
        private System.Windows.Forms.RadioButton pcRoomRadio2;
        private System.Windows.Forms.RadioButton pcRoomRadio1;
        private System.Windows.Forms.Button startEnhance;
        private System.Windows.Forms.Label resultLabel;
    }
}

