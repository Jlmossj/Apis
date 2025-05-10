namespace APIExplorer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Controles para Pokémon
        private System.Windows.Forms.TextBox txtPokemon;
        private System.Windows.Forms.Button btnSearchPokemon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.PictureBox picPokemon;
        private System.Windows.Forms.Label label1;

        // Controles para Clima
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnSearchWeather;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblFeelsLike;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.PictureBox picWeatherIcon;
        private System.Windows.Forms.Label label2;

        // Controles generales
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPokemon = new System.Windows.Forms.TextBox();
            this.btnSearchPokemon = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblTypes = new System.Windows.Forms.Label();
            this.picPokemon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnSearchWeather = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblFeelsLike = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            
            // 
            // txtPokemon
            // 
            this.txtPokemon.Location = new System.Drawing.Point(20, 40);
            this.txtPokemon.Name = "txtPokemon";
            this.txtPokemon.Size = new System.Drawing.Size(150, 20);
            this.txtPokemon.TabIndex = 0;
            // 
            // btnSearchPokemon
            // 
            this.btnSearchPokemon.Location = new System.Drawing.Point(180, 38);
            this.btnSearchPokemon.Name = "btnSearchPokemon";
            this.btnSearchPokemon.Size = new System.Drawing.Size(100, 23);
            this.btnSearchPokemon.TabIndex = 1;
            this.btnSearchPokemon.Text = "Buscar Pokémon";
            this.btnSearchPokemon.UseVisualStyleBackColor = true;
            this.btnSearchPokemon.Click += new System.EventHandler(this.btnSearchPokemon_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 2;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(20, 110);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(0, 13);
            this.lblHeight.TabIndex = 3;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(20, 130);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(0, 13);
            this.lblWeight.TabIndex = 4;
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Location = new System.Drawing.Point(20, 150);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(0, 13);
            this.lblTypes.TabIndex = 5;
            // 
            // picPokemon
            // 
            this.picPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPokemon.Location = new System.Drawing.Point(180, 80);
            this.picPokemon.Name = "picPokemon";
            this.picPokemon.Size = new System.Drawing.Size(150, 150);
            this.picPokemon.TabIndex = 6;
            this.picPokemon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar Pokémon";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(400, 40);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(150, 20);
            this.txtCity.TabIndex = 8;
            // 
            // btnSearchWeather
            // 
            this.btnSearchWeather.Location = new System.Drawing.Point(560, 38);
            this.btnSearchWeather.Name = "btnSearchWeather";
            this.btnSearchWeather.Size = new System.Drawing.Size(100, 23);
            this.btnSearchWeather.TabIndex = 9;
            this.btnSearchWeather.Text = "Buscar Clima";
            this.btnSearchWeather.UseVisualStyleBackColor = true;
            this.btnSearchWeather.Click += new System.EventHandler(this.btnSearchWeather_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(400, 80);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(0, 20);
            this.lblCity.TabIndex = 10;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(400, 110);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 13);
            this.lblTemp.TabIndex = 11;
            // 
            // lblFeelsLike
            // 
            this.lblFeelsLike.AutoSize = true;
            this.lblFeelsLike.Location = new System.Drawing.Point(400, 130);
            this.lblFeelsLike.Name = "lblFeelsLike";
            this.lblFeelsLike.Size = new System.Drawing.Size(0, 13);
            this.lblFeelsLike.TabIndex = 12;
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(400, 150);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(0, 13);
            this.lblHumidity.TabIndex = 13;
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Location = new System.Drawing.Point(400, 170);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(0, 13);
            this.lblWeather.TabIndex = 14;
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWeatherIcon.Location = new System.Drawing.Point(560, 80);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(100, 100);
            this.picWeatherIcon.TabIndex = 15;
            this.picWeatherIcon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buscar Clima";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(300, 250);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(300, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Location = new System.Drawing.Point(20, 350);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(640, 23);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Estado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picWeatherIcon);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblFeelsLike);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnSearchWeather);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPokemon);
            this.Controls.Add(this.lblTypes);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSearchPokemon);
            this.Controls.Add(this.txtPokemon);
            this.Name = "Form1";
            this.Text = "Explorador de APIs";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
