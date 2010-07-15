namespace Server
{
    partial class Main
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_serv_on = new System.Windows.Forms.Button();
            this.bt_serv_off = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_serv_statue = new System.Windows.Forms.Label();
            this.gb_userlist = new System.Windows.Forms.GroupBox();
            this.lb_user = new System.Windows.Forms.ListBox();
            this.gb_serverlog = new System.Windows.Forms.GroupBox();
            this.lb_serverlog = new System.Windows.Forms.ListBox();
            this.gb_userlist.SuspendLayout();
            this.gb_serverlog.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_serv_on
            // 
            this.bt_serv_on.Location = new System.Drawing.Point(157, 12);
            this.bt_serv_on.Name = "bt_serv_on";
            this.bt_serv_on.Size = new System.Drawing.Size(75, 23);
            this.bt_serv_on.TabIndex = 0;
            this.bt_serv_on.Text = "서버 On";
            this.bt_serv_on.UseVisualStyleBackColor = true;
            this.bt_serv_on.Click += new System.EventHandler(this.bt_serv_on_Click);
            // 
            // bt_serv_off
            // 
            this.bt_serv_off.Location = new System.Drawing.Point(241, 12);
            this.bt_serv_off.Name = "bt_serv_off";
            this.bt_serv_off.Size = new System.Drawing.Size(75, 23);
            this.bt_serv_off.TabIndex = 1;
            this.bt_serv_off.Text = "서버 Off";
            this.bt_serv_off.UseVisualStyleBackColor = true;
            this.bt_serv_off.Click += new System.EventHandler(this.bt_serv_off_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "서버 상태";
            // 
            // lb_serv_statue
            // 
            this.lb_serv_statue.AutoSize = true;
            this.lb_serv_statue.Location = new System.Drawing.Point(79, 17);
            this.lb_serv_statue.Name = "lb_serv_statue";
            this.lb_serv_statue.Size = new System.Drawing.Size(29, 12);
            this.lb_serv_statue.TabIndex = 3;
            this.lb_serv_statue.Text = "꺼짐";
            // 
            // gb_userlist
            // 
            this.gb_userlist.Controls.Add(this.lb_user);
            this.gb_userlist.Location = new System.Drawing.Point(16, 43);
            this.gb_userlist.Name = "gb_userlist";
            this.gb_userlist.Size = new System.Drawing.Size(299, 163);
            this.gb_userlist.TabIndex = 4;
            this.gb_userlist.TabStop = false;
            this.gb_userlist.Text = "접속자";
            // 
            // lb_user
            // 
            this.lb_user.FormattingEnabled = true;
            this.lb_user.ItemHeight = 12;
            this.lb_user.Location = new System.Drawing.Point(10, 18);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(277, 124);
            this.lb_user.TabIndex = 0;
            // 
            // gb_serverlog
            // 
            this.gb_serverlog.Controls.Add(this.lb_serverlog);
            this.gb_serverlog.Location = new System.Drawing.Point(19, 222);
            this.gb_serverlog.Name = "gb_serverlog";
            this.gb_serverlog.Size = new System.Drawing.Size(296, 224);
            this.gb_serverlog.TabIndex = 5;
            this.gb_serverlog.TabStop = false;
            this.gb_serverlog.Text = "로그";
            // 
            // lb_serverlog
            // 
            this.lb_serverlog.FormattingEnabled = true;
            this.lb_serverlog.ItemHeight = 12;
            this.lb_serverlog.Location = new System.Drawing.Point(8, 17);
            this.lb_serverlog.Name = "lb_serverlog";
            this.lb_serverlog.Size = new System.Drawing.Size(275, 196);
            this.lb_serverlog.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 467);
            this.Controls.Add(this.gb_serverlog);
            this.Controls.Add(this.gb_userlist);
            this.Controls.Add(this.lb_serv_statue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_serv_off);
            this.Controls.Add(this.bt_serv_on);
            this.Name = "Main";
            this.Text = "테스트 서버";
            this.gb_userlist.ResumeLayout(false);
            this.gb_serverlog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_serv_on;
        private System.Windows.Forms.Button bt_serv_off;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_serv_statue;
        private System.Windows.Forms.GroupBox gb_userlist;
        private System.Windows.Forms.ListBox lb_user;
        private System.Windows.Forms.GroupBox gb_serverlog;
        private System.Windows.Forms.ListBox lb_serverlog;
    }
}

