namespace Snake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.life_pic2 = new System.Windows.Forms.PictureBox();
            this.life_pic3 = new System.Windows.Forms.PictureBox();
            this.life_pic1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.life_pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // life_pic2
            // 
            this.life_pic2.Image = ((System.Drawing.Image)(resources.GetObject("life_pic2.Image")));
            this.life_pic2.Location = new System.Drawing.Point(690, 77);
            this.life_pic2.Name = "life_pic2";
            this.life_pic2.Size = new System.Drawing.Size(40, 40);
            this.life_pic2.TabIndex = 15;
            this.life_pic2.TabStop = false;
            // 
            // life_pic3
            // 
            this.life_pic3.Image = ((System.Drawing.Image)(resources.GetObject("life_pic3.Image")));
            this.life_pic3.Location = new System.Drawing.Point(753, 77);
            this.life_pic3.Name = "life_pic3";
            this.life_pic3.Size = new System.Drawing.Size(40, 40);
            this.life_pic3.TabIndex = 14;
            this.life_pic3.TabStop = false;
            // 
            // life_pic1
            // 
            this.life_pic1.Image = ((System.Drawing.Image)(resources.GetObject("life_pic1.Image")));
            this.life_pic1.Location = new System.Drawing.Point(626, 77);
            this.life_pic1.Name = "life_pic1";
            this.life_pic1.Size = new System.Drawing.Size(40, 40);
            this.life_pic1.TabIndex = 13;
            this.life_pic1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Life";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(108, 77);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(26, 37);
            this.lblState.TabIndex = 11;
            this.lblState.Text = " ";
            this.lblState.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(693, 14);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 37);
            this.lblScore.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Score";
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbCanvas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCanvas.BackgroundImage")));
            this.pbCanvas.Location = new System.Drawing.Point(12, 11);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(480, 480);
            this.pbCanvas.TabIndex = 8;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // imglist
            // 
            this.imglist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist.ImageStream")));
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist.Images.SetKeyName(0, "body.jpg");
            this.imglist.Images.SetKeyName(1, "down.jpg");
            this.imglist.Images.SetKeyName(2, "left.jpg");
            this.imglist.Images.SetKeyName(3, "right.jpg");
            this.imglist.Images.SetKeyName(4, "up.jpg");
            this.imglist.Images.SetKeyName(5, "food.jpg");
            this.imglist.Images.SetKeyName(6, "toxic.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.life_pic2);
            this.Controls.Add(this.life_pic3);
            this.Controls.Add(this.life_pic1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.life_pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life_pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox life_pic2;
        private System.Windows.Forms.PictureBox life_pic3;
        private System.Windows.Forms.PictureBox life_pic1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.ImageList imglist;
    }
}

