namespace ConsultorioMedico
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pescador = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.txt_quiosque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_busca_reserva = new System.Windows.Forms.Button();
            this.txt_data = new System.Windows.Forms.DateTimePicker();
            this.txt_horario = new System.Windows.Forms.ComboBox();
            this.btn_agenda = new System.Windows.Forms.Button();
            this.btn_busca_cliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Localizar Pescadores :";
            // 
            // txt_pescador
            // 
            this.txt_pescador.BackColor = System.Drawing.SystemColors.Info;
            this.txt_pescador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pescador.Location = new System.Drawing.Point(183, 35);
            this.txt_pescador.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pescador.Name = "txt_pescador";
            this.txt_pescador.Size = new System.Drawing.Size(146, 26);
            this.txt_pescador.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(369, 207);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 377);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(369, 192);
            this.dataGridView2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data da Reserva :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(443, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Horário da Reserva :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(463, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Observações Secundárias";
            // 
            // txt_obs
            // 
            this.txt_obs.BackColor = System.Drawing.SystemColors.Info;
            this.txt_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_obs.Location = new System.Drawing.Point(467, 220);
            this.txt_obs.Margin = new System.Windows.Forms.Padding(2);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_obs.Size = new System.Drawing.Size(459, 272);
            this.txt_obs.TabIndex = 13;
            // 
            // txt_quiosque
            // 
            this.txt_quiosque.BackColor = System.Drawing.SystemColors.Info;
            this.txt_quiosque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quiosque.Location = new System.Drawing.Point(175, 334);
            this.txt_quiosque.Margin = new System.Windows.Forms.Padding(2);
            this.txt_quiosque.Name = "txt_quiosque";
            this.txt_quiosque.Size = new System.Drawing.Size(154, 26);
            this.txt_quiosque.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Localizar Quiosques :";
            // 
            // btn_busca_reserva
            // 
            this.btn_busca_reserva.BackColor = System.Drawing.Color.Silver;
            this.btn_busca_reserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busca_reserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busca_reserva.Image = global::ConsultorioMedico.Properties.Resources.Search_32;
            this.btn_busca_reserva.Location = new System.Drawing.Point(352, 332);
            this.btn_busca_reserva.Margin = new System.Windows.Forms.Padding(2);
            this.btn_busca_reserva.Name = "btn_busca_reserva";
            this.btn_busca_reserva.Size = new System.Drawing.Size(32, 28);
            this.btn_busca_reserva.TabIndex = 14;
            this.btn_busca_reserva.UseVisualStyleBackColor = false;
            this.btn_busca_reserva.Click += new System.EventHandler(this.btn_busca_medico_Click);
            // 
            // txt_data
            // 
            this.txt_data.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.txt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_data.Location = new System.Drawing.Point(627, 44);
            this.txt_data.Margin = new System.Windows.Forms.Padding(2);
            this.txt_data.MaxDate = new System.DateTime(2022, 12, 15, 0, 0, 0, 0);
            this.txt_data.MinDate = new System.DateTime(2020, 11, 11, 0, 0, 0, 0);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(299, 26);
            this.txt_data.TabIndex = 18;
            this.txt_data.Value = new System.DateTime(2020, 11, 14, 0, 0, 0, 0);
            // 
            // txt_horario
            // 
            this.txt_horario.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.txt_horario.BackColor = System.Drawing.Color.Silver;
            this.txt_horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_horario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txt_horario.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_horario.FormattingEnabled = true;
            this.txt_horario.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_horario.Items.AddRange(new object[] {
            "07:50",
            "09:00",
            "10:30",
            "12:40",
            "13:45",
            "14:25",
            "15:30",
            "16:10",
            "17:25",
            "18:00"});
            this.txt_horario.Location = new System.Drawing.Point(704, 101);
            this.txt_horario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_horario.Name = "txt_horario";
            this.txt_horario.Size = new System.Drawing.Size(147, 35);
            this.txt_horario.TabIndex = 19;
            // 
            // btn_agenda
            // 
            this.btn_agenda.BackColor = System.Drawing.Color.Silver;
            this.btn_agenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agenda.Image = global::ConsultorioMedico.Properties.Resources.apply_48;
            this.btn_agenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agenda.Location = new System.Drawing.Point(467, 520);
            this.btn_agenda.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agenda.Name = "btn_agenda";
            this.btn_agenda.Padding = new System.Windows.Forms.Padding(8, 8, 15, 8);
            this.btn_agenda.Size = new System.Drawing.Size(245, 49);
            this.btn_agenda.TabIndex = 17;
            this.btn_agenda.Text = "Confirmar Reserva";
            this.btn_agenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agenda.UseVisualStyleBackColor = false;
            this.btn_agenda.Click += new System.EventHandler(this.btn_agenda_Click);
            // 
            // btn_busca_cliente
            // 
            this.btn_busca_cliente.BackColor = System.Drawing.Color.Silver;
            this.btn_busca_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busca_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busca_cliente.Image = global::ConsultorioMedico.Properties.Resources.Search_32;
            this.btn_busca_cliente.Location = new System.Drawing.Point(352, 35);
            this.btn_busca_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.btn_busca_cliente.Name = "btn_busca_cliente";
            this.btn_busca_cliente.Size = new System.Drawing.Size(32, 28);
            this.btn_busca_cliente.TabIndex = 0;
            this.btn_busca_cliente.UseVisualStyleBackColor = false;
            this.btn_busca_cliente.Click += new System.EventHandler(this.btn_busca_cliente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(694, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 57);
            this.label6.TabIndex = 20;
            this.label6.Text = "}<((((°>  ♛";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(948, 594);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_horario);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.btn_agenda);
            this.Controls.Add(this.txt_quiosque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_busca_reserva);
            this.Controls.Add(this.txt_obs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_pescador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_busca_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sistema de Consultas e Registros REI DA PESCARIA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_busca_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pescador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_obs;
        private System.Windows.Forms.TextBox txt_quiosque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_busca_reserva;
        private System.Windows.Forms.Button btn_agenda;
        private System.Windows.Forms.DateTimePicker txt_data;
        private System.Windows.Forms.ComboBox txt_horario;
        private System.Windows.Forms.Label label6;
    }
}

