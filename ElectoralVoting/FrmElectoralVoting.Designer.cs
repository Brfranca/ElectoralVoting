namespace ElectoralVoting
{
    partial class FrmElectoralVoting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmElectoralVoting));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.btnFinishRegister = new System.Windows.Forms.Button();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.picPhotoRegister = new System.Windows.Forms.PictureBox();
            this.txtNumberRegister = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameRegister = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabVote = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVote = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCandidates = new System.Windows.Forms.ComboBox();
            this.btnFinishVote = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picPhotoVt = new System.Windows.Forms.PictureBox();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.dtgResult = new System.Windows.Forms.DataGridView();
            this.lblPercVote = new System.Windows.Forms.Label();
            this.lblNumberResult = new System.Windows.Forms.Label();
            this.lblNameResult = new System.Windows.Forms.Label();
            this.picPhotoResult = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileImage = new System.Windows.Forms.OpenFileDialog();
            this.Candidate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Votes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percVote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhotoRegister)).BeginInit();
            this.tabVote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhotoVt)).BeginInit();
            this.tabResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhotoResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabRegister);
            this.tabControl.Controls.Add(this.tabVote);
            this.tabControl.Controls.Add(this.tabResult);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(418, 406);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.btnFinishRegister);
            this.tabRegister.Controls.Add(this.btnAddPhoto);
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.picPhotoRegister);
            this.tabRegister.Controls.Add(this.txtNumberRegister);
            this.tabRegister.Controls.Add(this.label3);
            this.tabRegister.Controls.Add(this.txtNameRegister);
            this.tabRegister.Controls.Add(this.label2);
            this.tabRegister.Controls.Add(this.label1);
            this.tabRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegister.Location = new System.Drawing.Point(4, 27);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(410, 375);
            this.tabRegister.TabIndex = 0;
            this.tabRegister.Text = "Cadastro";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // btnFinishRegister
            // 
            this.btnFinishRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFinishRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishRegister.Location = new System.Drawing.Point(27, 301);
            this.btnFinishRegister.Name = "btnFinishRegister";
            this.btnFinishRegister.Size = new System.Drawing.Size(154, 31);
            this.btnFinishRegister.TabIndex = 8;
            this.btnFinishRegister.Text = "Finalizar";
            this.btnFinishRegister.UseVisualStyleBackColor = false;
            this.btnFinishRegister.Click += new System.EventHandler(this.btnFinishRegister_Click);
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhoto.Location = new System.Drawing.Point(27, 204);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(154, 25);
            this.btnAddPhoto.TabIndex = 7;
            this.btnAddPhoto.Text = "Adicionar Foto";
            this.btnAddPhoto.UseVisualStyleBackColor = false;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(27, 235);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(154, 31);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // picPhotoRegister
            // 
            this.picPhotoRegister.Image = ((System.Drawing.Image)(resources.GetObject("picPhotoRegister.Image")));
            this.picPhotoRegister.Location = new System.Drawing.Point(232, 204);
            this.picPhotoRegister.Name = "picPhotoRegister";
            this.picPhotoRegister.Size = new System.Drawing.Size(122, 128);
            this.picPhotoRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhotoRegister.TabIndex = 5;
            this.picPhotoRegister.TabStop = false;
            // 
            // txtNumberRegister
            // 
            this.txtNumberRegister.Location = new System.Drawing.Point(27, 152);
            this.txtNumberRegister.Name = "txtNumberRegister";
            this.txtNumberRegister.Size = new System.Drawing.Size(354, 24);
            this.txtNumberRegister.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite o número:";
            // 
            // txtNameRegister
            // 
            this.txtNameRegister.Location = new System.Drawing.Point(27, 84);
            this.txtNameRegister.Name = "txtNameRegister";
            this.txtNameRegister.Size = new System.Drawing.Size(354, 24);
            this.txtNameRegister.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Candidatos";
            // 
            // tabVote
            // 
            this.tabVote.Controls.Add(this.label5);
            this.tabVote.Controls.Add(this.btnVote);
            this.tabVote.Controls.Add(this.btnRight);
            this.tabVote.Controls.Add(this.btnLeft);
            this.tabVote.Controls.Add(this.label7);
            this.tabVote.Controls.Add(this.label6);
            this.tabVote.Controls.Add(this.cboCandidates);
            this.tabVote.Controls.Add(this.btnFinishVote);
            this.tabVote.Controls.Add(this.lblNumber);
            this.tabVote.Controls.Add(this.lblName);
            this.tabVote.Controls.Add(this.picPhotoVt);
            this.tabVote.Location = new System.Drawing.Point(4, 27);
            this.tabVote.Name = "tabVote";
            this.tabVote.Padding = new System.Windows.Forms.Padding(3);
            this.tabVote.Size = new System.Drawing.Size(410, 375);
            this.tabVote.TabIndex = 1;
            this.tabVote.Text = "Votação";
            this.tabVote.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cadidato nº:";
            // 
            // btnVote
            // 
            this.btnVote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVote.Location = new System.Drawing.Point(27, 244);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(97, 29);
            this.btnVote.TabIndex = 16;
            this.btnVote.Text = "Votar";
            this.btnVote.UseVisualStyleBackColor = false;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(318, 267);
            this.btnRight.Margin = new System.Windows.Forms.Padding(0);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(20, 23);
            this.btnRight.TabIndex = 15;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(289, 267);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(0);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(20, 23);
            this.btnLeft.TabIndex = 14;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Votação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Selecione o candidato:";
            // 
            // cboCandidates
            // 
            this.cboCandidates.FormattingEnabled = true;
            this.cboCandidates.Location = new System.Drawing.Point(27, 84);
            this.cboCandidates.Name = "cboCandidates";
            this.cboCandidates.Size = new System.Drawing.Size(350, 26);
            this.cboCandidates.TabIndex = 11;
            this.cboCandidates.SelectedIndexChanged += new System.EventHandler(this.cboCandidates_SelectedIndexChanged);
            // 
            // btnFinishVote
            // 
            this.btnFinishVote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFinishVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishVote.Location = new System.Drawing.Point(27, 301);
            this.btnFinishVote.Name = "btnFinishVote";
            this.btnFinishVote.Size = new System.Drawing.Size(169, 31);
            this.btnFinishVote.TabIndex = 10;
            this.btnFinishVote.Text = "Encerrar Votações";
            this.btnFinishVote.UseVisualStyleBackColor = false;
            this.btnFinishVote.Click += new System.EventHandler(this.btnFinishVote_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Teal;
            this.lblNumber.Location = new System.Drawing.Point(132, 153);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(21, 20);
            this.lblNumber.TabIndex = 9;
            this.lblNumber.Text = "N";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Teal;
            this.lblName.Location = new System.Drawing.Point(24, 181);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Nome";
            // 
            // picPhotoVt
            // 
            this.picPhotoVt.Image = ((System.Drawing.Image)(resources.GetObject("picPhotoVt.Image")));
            this.picPhotoVt.Location = new System.Drawing.Point(252, 135);
            this.picPhotoVt.Name = "picPhotoVt";
            this.picPhotoVt.Size = new System.Drawing.Size(122, 128);
            this.picPhotoVt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhotoVt.TabIndex = 6;
            this.picPhotoVt.TabStop = false;
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.dtgResult);
            this.tabResult.Controls.Add(this.lblPercVote);
            this.tabResult.Controls.Add(this.lblNumberResult);
            this.tabResult.Controls.Add(this.lblNameResult);
            this.tabResult.Controls.Add(this.picPhotoResult);
            this.tabResult.Controls.Add(this.label4);
            this.tabResult.Location = new System.Drawing.Point(4, 27);
            this.tabResult.Name = "tabResult";
            this.tabResult.Size = new System.Drawing.Size(410, 375);
            this.tabResult.TabIndex = 2;
            this.tabResult.Text = "Apuração";
            this.tabResult.UseVisualStyleBackColor = true;
            // 
            // dtgResult
            // 
            this.dtgResult.AllowUserToAddRows = false;
            this.dtgResult.AllowUserToDeleteRows = false;
            this.dtgResult.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Candidate,
            this.Votes,
            this.percVote});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgResult.Location = new System.Drawing.Point(8, 56);
            this.dtgResult.Name = "dtgResult";
            this.dtgResult.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgResult.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgResult.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgResult.RowTemplate.Height = 30;
            this.dtgResult.Size = new System.Drawing.Size(394, 178);
            this.dtgResult.TabIndex = 13;
            this.dtgResult.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgResult_CellMouseClick);
            // 
            // lblPercVote
            // 
            this.lblPercVote.AutoSize = true;
            this.lblPercVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercVote.Location = new System.Drawing.Point(147, 324);
            this.lblPercVote.Name = "lblPercVote";
            this.lblPercVote.Size = new System.Drawing.Size(57, 20);
            this.lblPercVote.TabIndex = 12;
            this.lblPercVote.Text = "%Voto";
            // 
            // lblNumberResult
            // 
            this.lblNumberResult.AutoSize = true;
            this.lblNumberResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberResult.Location = new System.Drawing.Point(147, 265);
            this.lblNumberResult.Name = "lblNumberResult";
            this.lblNumberResult.Size = new System.Drawing.Size(65, 20);
            this.lblNumberResult.TabIndex = 11;
            this.lblNumberResult.Text = "Número";
            // 
            // lblNameResult
            // 
            this.lblNameResult.AutoSize = true;
            this.lblNameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameResult.Location = new System.Drawing.Point(147, 294);
            this.lblNameResult.Name = "lblNameResult";
            this.lblNameResult.Size = new System.Drawing.Size(51, 20);
            this.lblNameResult.TabIndex = 10;
            this.lblNameResult.Text = "Nome";
            // 
            // picPhotoResult
            // 
            this.picPhotoResult.Image = ((System.Drawing.Image)(resources.GetObject("picPhotoResult.Image")));
            this.picPhotoResult.Location = new System.Drawing.Point(8, 240);
            this.picPhotoResult.Name = "picPhotoResult";
            this.picPhotoResult.Size = new System.Drawing.Size(122, 128);
            this.picPhotoResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhotoResult.TabIndex = 7;
            this.picPhotoResult.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Resultado da Eleição";
            // 
            // openFileImage
            // 
            this.openFileImage.FileName = "openFileImage";
            // 
            // Candidate
            // 
            this.Candidate.HeaderText = "Candidato";
            this.Candidate.Name = "Candidate";
            this.Candidate.ReadOnly = true;
            this.Candidate.Width = 250;
            // 
            // Votes
            // 
            this.Votes.HeaderText = "Votos";
            this.Votes.Name = "Votes";
            this.Votes.ReadOnly = true;
            this.Votes.Width = 60;
            // 
            // percVote
            // 
            this.percVote.HeaderText = "%Votos";
            this.percVote.Name = "percVote";
            this.percVote.ReadOnly = true;
            this.percVote.Width = 81;
            // 
            // FrmElectoralVoting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 406);
            this.Controls.Add(this.tabControl);
            this.Name = "FrmElectoralVoting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmElectoralVoting_Load);
            this.tabControl.ResumeLayout(false);
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhotoRegister)).EndInit();
            this.tabVote.ResumeLayout(false);
            this.tabVote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhotoVt)).EndInit();
            this.tabResult.ResumeLayout(false);
            this.tabResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhotoResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.TabPage tabVote;
        private System.Windows.Forms.TextBox txtNumberRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabResult;
        private System.Windows.Forms.Button btnFinishRegister;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.PictureBox picPhotoRegister;
        private System.Windows.Forms.PictureBox picPhotoVt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCandidates;
        private System.Windows.Forms.Button btnFinishVote;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPercVote;
        private System.Windows.Forms.Label lblNumberResult;
        private System.Windows.Forms.Label lblNameResult;
        private System.Windows.Forms.PictureBox picPhotoResult;
        private System.Windows.Forms.DataGridView dtgResult;
        private System.Windows.Forms.OpenFileDialog openFileImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Candidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Votes;
        private System.Windows.Forms.DataGridViewTextBoxColumn percVote;
    }
}

