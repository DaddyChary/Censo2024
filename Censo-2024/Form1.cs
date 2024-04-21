using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;


namespace Censo_2024
{
    public partial class Form1 : Form
    {
        private List<RadioButton> listaRadiobuttons = new List<RadioButton>();
        private Thread monitorThread;
        private bool isRunning = true; 

        public Form1()
        {
            InitializeComponent();
            funcionSize();
            this.StartPosition = FormStartPosition.CenterScreen;
            InicializarListaRadiobuttons();
            monitorThread = new Thread(MonitorearHora);
            monitorThread.IsBackground = true;
            monitorThread.Start();
        }

        // cambiar dia noche
        private void MonitorearHora()
        {
            // Bucle infinito para monitorear la hora
            while (isRunning) 
            {
                // Obtener la hora actual
                DateTime currentTime = DateTime.Now;

                // Verificar si es de día (entre las 6:00 AM y las 11:59 PM)
                bool esDia = currentTime.Hour >= 6 && currentTime.Hour < 21;

                // Llamar a la función para cambiar día/noche
                TuFuncionCambiarDiaNoche(esDia);

                // Esperar tiempo antes de verificar la hora
                Thread.Sleep(1000);
            }
        }
        private void TuFuncionCambiarDiaNoche(bool esDia)
        {
            if (esDia)
            {
                changeColorText(Color.Black);
                changeComponentsColor(Color.White);
            }
            else
            {
                changeColorText(Color.White);
                changeComponentsColor(Color.DarkSlateGray);
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void funcionSize()
        {
            this.Size = new System.Drawing.Size(1034, 770);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage3;
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            
            clearCampsLabel();
            tablePanel2.SelectedTab = tabPage2;
        }

        private void verCenso_Click(object sender, EventArgs e)
        {
            RellenarRadiobuttons();
            tablePanel2.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage7;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage6;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage8;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage7;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage9;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage8;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage10;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage9;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage11;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage10;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage12;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage11;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage13;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage12;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage14;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage13;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage15;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage14;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage16;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage15;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage17;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage16;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage18;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage17;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage19;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage18;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage20;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage19;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage21;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage20;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage22;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage21;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage23;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage22;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage24;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage23;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage25;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage24;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage26;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage25;
        }

        private void button62_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage27;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage26;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage28;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage27;
        }

        private void btnSaveForm_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage1;
            saveDates();
            MessageBox.Show("Se han guardado los datos correctamente");
            GuardarEstadoRadiobuttons();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage8;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage8;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage15;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage16;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage19;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage21;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage21;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage24;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage24;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage25;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            tablePanel2.SelectedTab = tabPage25;

        }

        private void InicializarListaRadiobuttons()
        {
      
            for (int i = 1; i <= 320; i++) 
            {
                 listaRadiobuttons.Add((RadioButton)this.Controls["radioButton" + i.ToString()]);
            }
        }

        private void GuardarEstadoRadiobuttons()
        {
            
            foreach (RadioButton radioButton in listaRadiobuttons)
            {

            }
            
        }

        //changeColorText(Color.White);

        private void RellenarRadiobuttons()
        {
            
            foreach (RadioButton radioButton in listaRadiobuttons)
            {
             
            }
            
        }

        private void changeColorText(Color colorin)
        {

            label1.ForeColor = colorin;
            label3.ForeColor = colorin;
            label4.ForeColor = colorin;
            label5.ForeColor = colorin;
            label7.ForeColor = colorin;
            label9.ForeColor = colorin;
            label8.ForeColor = colorin;
            label10.ForeColor = colorin;
            label11.ForeColor = colorin;
            label12.ForeColor = colorin;
            label13.ForeColor = colorin;
            label14.ForeColor = colorin;
            label15.ForeColor = colorin;
            label16.ForeColor = colorin;
            label17.ForeColor = colorin;
            label18.ForeColor = colorin;
            label19.ForeColor = colorin;
            label20.ForeColor = colorin;
            label21.ForeColor = colorin;
            label25.ForeColor = colorin;
            label26.ForeColor = colorin;
            label27.ForeColor = colorin;
            label28.ForeColor = colorin;
            label29.ForeColor = colorin;
            label30.ForeColor = colorin;
            label31.ForeColor = colorin;
            label32.ForeColor = colorin;
            label33.ForeColor = colorin;
            label36.ForeColor = colorin;
            label37.ForeColor = colorin;
            label39.ForeColor = colorin;
            label40.ForeColor = colorin;
            label41.ForeColor = colorin;
            label42.ForeColor = colorin;
            label43.ForeColor = colorin;
            label44.ForeColor = colorin;
            label45.ForeColor = colorin;
            label47.ForeColor = colorin;
            label48.ForeColor = colorin;
            label49.ForeColor = colorin;
            label50.ForeColor = colorin;
            label51.ForeColor = colorin;
            label52.ForeColor = colorin;
            label53.ForeColor = colorin;
            label54.ForeColor = colorin;
            label55.ForeColor = colorin;
            label56.ForeColor = colorin;
            label58.ForeColor = colorin;
            label59.ForeColor = colorin;
            label60.ForeColor = colorin;
            label61.ForeColor = colorin;
            label63.ForeColor = colorin;
            label65.ForeColor = colorin;
            label66.ForeColor = colorin;
            label67.ForeColor = colorin;
            label68.ForeColor = colorin;
            label69.ForeColor = colorin;
            label70.ForeColor = colorin;
            label71.ForeColor = colorin;
            label72.ForeColor = colorin;
            label74.ForeColor = colorin;
            label75.ForeColor = colorin;
            label76.ForeColor = colorin;
            label77.ForeColor = colorin;
            label78.ForeColor = colorin;
            label80.ForeColor = colorin;
            label81.ForeColor = colorin;
            label82.ForeColor = colorin;
            label83.ForeColor = colorin;
            label84.ForeColor = colorin;
            label85.ForeColor = colorin;
            label86.ForeColor = colorin;
            label87.ForeColor = colorin;
            label88.ForeColor = colorin;
            label89.ForeColor = colorin;
            label90.ForeColor = colorin;
            label91.ForeColor = colorin;
            label92.ForeColor = colorin;
            label93.ForeColor = colorin;
            label94.ForeColor = colorin;
            label95.ForeColor = colorin;
            label96.ForeColor = colorin;
            label97.ForeColor = colorin;
            label104.ForeColor = colorin;
            label105.ForeColor = colorin;
            label107.ForeColor = colorin;
            label108.ForeColor = colorin;
            label109.ForeColor = colorin;
            label110.ForeColor = colorin;
            label111.ForeColor = colorin;
            label112.ForeColor = colorin;
            label113.ForeColor = colorin;
            label114.ForeColor = colorin;
            label115.ForeColor = colorin;
            label116.ForeColor = colorin;
            label117.ForeColor = colorin;
            label119.ForeColor = colorin;
            label120.ForeColor = colorin;
            label122.ForeColor = colorin;
            label123.ForeColor = colorin;
            label125.ForeColor = colorin;
            label127.ForeColor = colorin;
            label128.ForeColor = colorin;
            label130.ForeColor = colorin;
            label132.ForeColor = colorin;
            label133.ForeColor = colorin;
            label135.ForeColor = colorin;
            label136.ForeColor = colorin;
            label137.ForeColor = colorin;
            label138.ForeColor = colorin;
            label140.ForeColor = colorin;
            label141.ForeColor = colorin;
            label142.ForeColor = colorin;
            label144.ForeColor = colorin;
            label145.ForeColor = colorin;
            label146.ForeColor = colorin;
            label147.ForeColor = colorin;
            label150.ForeColor = colorin;
            label151.ForeColor = colorin;
            label154.ForeColor = colorin;
            label155.ForeColor = colorin;
            label156.ForeColor = colorin;
            label157.ForeColor = colorin;
            label158.ForeColor = colorin;
            label162.ForeColor = colorin;
            label163.ForeColor = colorin;
            label164.ForeColor = colorin;
            label166.ForeColor = colorin;
            label167.ForeColor = colorin;
            label168.ForeColor = colorin;
            label169.ForeColor = colorin;
            label171.ForeColor = colorin;
            label173.ForeColor = colorin;
            label174.ForeColor = colorin;
            label176.ForeColor = colorin;
            label177.ForeColor = colorin;
            label180.ForeColor = colorin;
            label181.ForeColor = colorin;
            label182.ForeColor = colorin;
            label183.ForeColor = colorin;
            label186.ForeColor = colorin;
            label187.ForeColor = colorin;
            label188.ForeColor = colorin;
            label189.ForeColor = colorin;
            label190.ForeColor = colorin;
            label191.ForeColor = colorin;
            label192.ForeColor = colorin;
            label193.ForeColor = colorin;
            label194.ForeColor = colorin;
            label197.ForeColor = colorin;
            label198.ForeColor = colorin;
            label200.ForeColor = colorin;
            label201.ForeColor = colorin;
            label203.ForeColor = colorin;
            label204.ForeColor = colorin;
            label205.ForeColor = colorin;
            label206.ForeColor = colorin;
            label207.ForeColor = colorin;
            label208.ForeColor = colorin;
            label209.ForeColor = colorin;
            label212.ForeColor = colorin;
            label213.ForeColor = colorin;
            label214.ForeColor = colorin;
            label215.ForeColor = colorin;
            label216.ForeColor = colorin;
            label217.ForeColor = colorin;
            label218.ForeColor = colorin;
            label219.ForeColor = colorin;
            label220.ForeColor = colorin;
            label221.ForeColor = colorin;
            label222.ForeColor = colorin;
            label224.ForeColor = colorin;
            label225.ForeColor = colorin;
            label227.ForeColor = colorin;
            label228.ForeColor = colorin;
            label229.ForeColor = colorin;
            label230.ForeColor = colorin;
            label231.ForeColor = colorin;
            label233.ForeColor = colorin;
            label235.ForeColor = colorin;
            label236.ForeColor = colorin;
            radioButton1.ForeColor = colorin;
            radioButton2.ForeColor = colorin;
            radioButton3.ForeColor = colorin;
            radioButton4.ForeColor = colorin;
            radioButton5.ForeColor = colorin;
            radioButton6.ForeColor = colorin;
            radioButton7.ForeColor = colorin;
            radioButton8.ForeColor = colorin;
            radioButton9.ForeColor = colorin;
            radioButton10.ForeColor = colorin;
            radioButton11.ForeColor = colorin;
            radioButton12.ForeColor = colorin;
            radioButton13.ForeColor = colorin;
            radioButton14.ForeColor = colorin;
            radioButton15.ForeColor = colorin;
            radioButton16.ForeColor = colorin;
            radioButton17.ForeColor = colorin;
            radioButton18.ForeColor = colorin;
            radioButton19.ForeColor = colorin;
            radioButton20.ForeColor = colorin;
            radioButton21.ForeColor = colorin;
            radioButton22.ForeColor = colorin;
            radioButton23.ForeColor = colorin;
            radioButton24.ForeColor = colorin;
            radioButton25.ForeColor = colorin;
            radioButton26.ForeColor = colorin;
            radioButton27.ForeColor = colorin;
            radioButton28.ForeColor = colorin;
            radioButton29.ForeColor = colorin;
            radioButton30.ForeColor = colorin;
            radioButton31.ForeColor = colorin;
            radioButton32.ForeColor = colorin;
            radioButton33.ForeColor = colorin;
            radioButton34.ForeColor = colorin;
            radioButton35.ForeColor = colorin;
            radioButton36.ForeColor = colorin;
            radioButton37.ForeColor = colorin;
            radioButton38.ForeColor = colorin;
            radioButton39.ForeColor = colorin;
            radioButton40.ForeColor = colorin;
            radioButton41.ForeColor = colorin;
            radioButton42.ForeColor = colorin;
            radioButton43.ForeColor = colorin;
            radioButton44.ForeColor = colorin;
            radioButton45.ForeColor = colorin;
            radioButton46.ForeColor = colorin;
            radioButton47.ForeColor = colorin;
            radioButton48.ForeColor = colorin;
            radioButton49.ForeColor = colorin;
            radioButton50.ForeColor = colorin;
            radioButton51.ForeColor = colorin;
            radioButton52.ForeColor = colorin;
            radioButton53.ForeColor = colorin;
            radioButton54.ForeColor = colorin;
            radioButton55.ForeColor = colorin;
            radioButton56.ForeColor = colorin;
            radioButton57.ForeColor = colorin;
            radioButton58.ForeColor = colorin;
            radioButton59.ForeColor = colorin;
            radioButton60.ForeColor = colorin;
            radioButton61.ForeColor = colorin;
            radioButton62.ForeColor = colorin;
            radioButton63.ForeColor = colorin;
            radioButton64.ForeColor = colorin;
            radioButton65.ForeColor = colorin;
            radioButton66.ForeColor = colorin;
            radioButton67.ForeColor = colorin;
            radioButton68.ForeColor = colorin;
            radioButton69.ForeColor = colorin;
            radioButton70.ForeColor = colorin;
            radioButton71.ForeColor = colorin;
            radioButton72.ForeColor = colorin;
            radioButton73.ForeColor = colorin;
            radioButton74.ForeColor = colorin;
            radioButton75.ForeColor = colorin;
            radioButton76.ForeColor = colorin;
            radioButton77.ForeColor = colorin;
            radioButton78.ForeColor = colorin;
            radioButton79.ForeColor = colorin;
            radioButton80.ForeColor = colorin;
            radioButton81.ForeColor = colorin;
            radioButton82.ForeColor = colorin;
            radioButton83.ForeColor = colorin;
            radioButton84.ForeColor = colorin;
            radioButton85.ForeColor = colorin;
            radioButton86.ForeColor = colorin;
            radioButton87.ForeColor = colorin;
            radioButton88.ForeColor = colorin;
            radioButton89.ForeColor = colorin;
            radioButton90.ForeColor = colorin;
            radioButton91.ForeColor = colorin;
            radioButton92.ForeColor = colorin;
            radioButton93.ForeColor = colorin;
            radioButton94.ForeColor = colorin;
            radioButton95.ForeColor = colorin;
            radioButton96.ForeColor = colorin;
            radioButton97.ForeColor = colorin;
            radioButton98.ForeColor = colorin;
            radioButton99.ForeColor = colorin;
            radioButton100.ForeColor = colorin;
            radioButton101.ForeColor = colorin;
            radioButton102.ForeColor = colorin;
            radioButton103.ForeColor = colorin;
            radioButton104.ForeColor = colorin;
            radioButton105.ForeColor = colorin;
            radioButton106.ForeColor = colorin;
            radioButton107.ForeColor = colorin;
            radioButton108.ForeColor = colorin;
            radioButton109.ForeColor = colorin;
            radioButton110.ForeColor = colorin;
            radioButton111.ForeColor = colorin;
            radioButton112.ForeColor = colorin;
            radioButton113.ForeColor = colorin;
            radioButton114.ForeColor = colorin;
            radioButton115.ForeColor = colorin;
            radioButton116.ForeColor = colorin;
            radioButton117.ForeColor = colorin;
            radioButton118.ForeColor = colorin;
            radioButton119.ForeColor = colorin;
            radioButton120.ForeColor = colorin;
            radioButton121.ForeColor = colorin;
            radioButton122.ForeColor = colorin;
            radioButton123.ForeColor = colorin;
            radioButton124.ForeColor = colorin;
            radioButton125.ForeColor = colorin;
            radioButton126.ForeColor = colorin;
            radioButton127.ForeColor = colorin;
            radioButton128.ForeColor = colorin;
            radioButton129.ForeColor = colorin;
            radioButton130.ForeColor = colorin;
            radioButton131.ForeColor = colorin;
            radioButton132.ForeColor = colorin;
            radioButton133.ForeColor = colorin;
            radioButton134.ForeColor = colorin;
            radioButton135.ForeColor = colorin;
            radioButton136.ForeColor = colorin;
            radioButton137.ForeColor = colorin;
            radioButton138.ForeColor = colorin;
            radioButton139.ForeColor = colorin;
            radioButton140.ForeColor = colorin;
            radioButton141.ForeColor = colorin;
            radioButton142.ForeColor = colorin;
            radioButton143.ForeColor = colorin;
            radioButton144.ForeColor = colorin;
            radioButton145.ForeColor = colorin;
            radioButton146.ForeColor = colorin;
            radioButton147.ForeColor = colorin;
            radioButton148.ForeColor = colorin;
            radioButton149.ForeColor = colorin;
            radioButton150.ForeColor = colorin;
            radioButton151.ForeColor = colorin;
            radioButton152.ForeColor = colorin;
            radioButton153.ForeColor = colorin;
            radioButton154.ForeColor = colorin;
            radioButton155.ForeColor = colorin;
            radioButton156.ForeColor = colorin;
            radioButton157.ForeColor = colorin;
            radioButton158.ForeColor = colorin;
            radioButton159.ForeColor = colorin;
            radioButton160.ForeColor = colorin;
            radioButton161.ForeColor = colorin;
            radioButton162.ForeColor = colorin;
            radioButton163.ForeColor = colorin;
            radioButton164.ForeColor = colorin;
            radioButton165.ForeColor = colorin;
            radioButton166.ForeColor = colorin;
            radioButton167.ForeColor = colorin;
            radioButton168.ForeColor = colorin;
            radioButton169.ForeColor = colorin;
            radioButton170.ForeColor = colorin;
            radioButton171.ForeColor = colorin;
            radioButton172.ForeColor = colorin;
            radioButton173.ForeColor = colorin;
            radioButton174.ForeColor = colorin;
            radioButton175.ForeColor = colorin;
            radioButton176.ForeColor = colorin;
            radioButton177.ForeColor = colorin;
            radioButton178.ForeColor = colorin;
            radioButton179.ForeColor = colorin;
            radioButton180.ForeColor = colorin;
            radioButton181.ForeColor = colorin;
            radioButton182.ForeColor = colorin;
            radioButton183.ForeColor = colorin;
            radioButton184.ForeColor = colorin;
            radioButton185.ForeColor = colorin;
            radioButton186.ForeColor = colorin;
            radioButton187.ForeColor = colorin;
            radioButton188.ForeColor = colorin;
            radioButton189.ForeColor = colorin;
            radioButton190.ForeColor = colorin;
            radioButton191.ForeColor = colorin;
            radioButton192.ForeColor = colorin;
            radioButton193.ForeColor = colorin;
            radioButton194.ForeColor = colorin;
            radioButton195.ForeColor = colorin;
            radioButton196.ForeColor = colorin;
            radioButton197.ForeColor = colorin;
            radioButton198.ForeColor = colorin;
            radioButton199.ForeColor = colorin;
            radioButton200.ForeColor = colorin;
            radioButton201.ForeColor = colorin;
            radioButton202.ForeColor = colorin;
            radioButton203.ForeColor = colorin;
            radioButton204.ForeColor = colorin;
            radioButton205.ForeColor = colorin;
            radioButton206.ForeColor = colorin;
            radioButton207.ForeColor = colorin;
            radioButton208.ForeColor = colorin;
            radioButton209.ForeColor = colorin;
            radioButton210.ForeColor = colorin;
            radioButton211.ForeColor = colorin;
            radioButton212.ForeColor = colorin;
            radioButton213.ForeColor = colorin;
            radioButton214.ForeColor = colorin;
            radioButton215.ForeColor = colorin;
            radioButton216.ForeColor = colorin;
            radioButton217.ForeColor = colorin;
            radioButton218.ForeColor = colorin;
            radioButton219.ForeColor = colorin;
            radioButton220.ForeColor = colorin;
            radioButton221.ForeColor = colorin;
            radioButton222.ForeColor = colorin;
            radioButton223.ForeColor = colorin;
            radioButton224.ForeColor = colorin;
            radioButton225.ForeColor = colorin;
            radioButton226.ForeColor = colorin;
            radioButton227.ForeColor = colorin;
            radioButton228.ForeColor = colorin;
            radioButton229.ForeColor = colorin;
            radioButton230.ForeColor = colorin;
            radioButton231.ForeColor = colorin;
            radioButton232.ForeColor = colorin;
            radioButton233.ForeColor = colorin;
            radioButton234.ForeColor = colorin;
            radioButton235.ForeColor = colorin;
            radioButton236.ForeColor = colorin;
            radioButton237.ForeColor = colorin;
            radioButton238.ForeColor = colorin;
            radioButton239.ForeColor = colorin;
            radioButton240.ForeColor = colorin;
            radioButton241.ForeColor = colorin;
            radioButton242.ForeColor = colorin;
            radioButton243.ForeColor = colorin;
            radioButton244.ForeColor = colorin;
            radioButton245.ForeColor = colorin;
            radioButton246.ForeColor = colorin;
            radioButton247.ForeColor = colorin;
            radioButton248.ForeColor = colorin;
            radioButton249.ForeColor = colorin;
            radioButton250.ForeColor = colorin;
            radioButton251.ForeColor = colorin;
            radioButton252.ForeColor = colorin;
            radioButton253.ForeColor = colorin;
            radioButton254.ForeColor = colorin;
            radioButton255.ForeColor = colorin;
            radioButton256.ForeColor = colorin;
            radioButton257.ForeColor = colorin;
            radioButton258.ForeColor = colorin;
            radioButton259.ForeColor = colorin;
            radioButton260.ForeColor = colorin;
            radioButton261.ForeColor = colorin;
            radioButton262.ForeColor = colorin;
            radioButton263.ForeColor = colorin;
            radioButton264.ForeColor = colorin;
            radioButton265.ForeColor = colorin;
            radioButton266.ForeColor = colorin;
            radioButton267.ForeColor = colorin;
            radioButton268.ForeColor = colorin;
            radioButton269.ForeColor = colorin;
            radioButton270.ForeColor = colorin;
            radioButton271.ForeColor = colorin;
            radioButton272.ForeColor = colorin;
            radioButton273.ForeColor = colorin;
            radioButton274.ForeColor = colorin;
            radioButton275.ForeColor = colorin;
            radioButton276.ForeColor = colorin;
            radioButton277.ForeColor = colorin;
            radioButton278.ForeColor = colorin;
            radioButton279.ForeColor = colorin;
            radioButton280.ForeColor = colorin;
            radioButton281.ForeColor = colorin;
            radioButton282.ForeColor = colorin;
            radioButton283.ForeColor = colorin;
            radioButton284.ForeColor = colorin;
            radioButton285.ForeColor = colorin;
            radioButton286.ForeColor = colorin;
            radioButton287.ForeColor = colorin;
            radioButton288.ForeColor = colorin;
            radioButton289.ForeColor = colorin;
            radioButton290.ForeColor = colorin;
            radioButton291.ForeColor = colorin;
            radioButton292.ForeColor = colorin;
            radioButton293.ForeColor = colorin;
            radioButton294.ForeColor = colorin;
            radioButton295.ForeColor = colorin;
            radioButton296.ForeColor = colorin;
            radioButton297.ForeColor = colorin;
            radioButton298.ForeColor = colorin;
            radioButton299.ForeColor = colorin;
            radioButton300.ForeColor = colorin;
            radioButton301.ForeColor = colorin;
            radioButton302.ForeColor = colorin;
            radioButton303.ForeColor = colorin;
            radioButton304.ForeColor = colorin;
            radioButton305.ForeColor = colorin;
            radioButton306.ForeColor = colorin;
            radioButton307.ForeColor = colorin;
            radioButton308.ForeColor = colorin;
            radioButton309.ForeColor = colorin;
            radioButton310.ForeColor = colorin;
            radioButton311.ForeColor = colorin;
            radioButton312.ForeColor = colorin;
            radioButton313.ForeColor = colorin;
            radioButton314.ForeColor = colorin;
            radioButton315.ForeColor = colorin;
            radioButton316.ForeColor = colorin;
            radioButton317.ForeColor = colorin;
            radioButton318.ForeColor = colorin;
            radioButton319.ForeColor = colorin;
            radioButton320.ForeColor = colorin;

        }

        private void changeComponentsColor(Color ClComponents)
        {

            fondoLogo.BackColor = ClComponents;
            tabPage1.BackColor = ClComponents;
            tabPage2.BackColor = ClComponents;
            tabPage3.BackColor = ClComponents;
            tabPage4.BackColor = ClComponents;
            tabPage5.BackColor = ClComponents;
            tabPage6.BackColor = ClComponents;
            tabPage7.BackColor = ClComponents;
            tabPage8.BackColor = ClComponents;
            tabPage9.BackColor = ClComponents;
            tabPage10.BackColor = ClComponents;
            tabPage11.BackColor = ClComponents;
            tabPage12.BackColor = ClComponents;
            tabPage13.BackColor = ClComponents;
            tabPage14.BackColor = ClComponents;
            tabPage15.BackColor = ClComponents;
            tabPage16.BackColor = ClComponents;
            tabPage17.BackColor = ClComponents;
            tabPage18.BackColor = ClComponents;
            tabPage19.BackColor = ClComponents;
            tabPage20.BackColor = ClComponents;
            tabPage21.BackColor = ClComponents;
            tabPage22.BackColor = ClComponents;
            tabPage23.BackColor = ClComponents;
            tabPage24.BackColor = ClComponents;
            tabPage25.BackColor = ClComponents;
            tabPage26.BackColor = ClComponents;
            tabPage27.BackColor = ClComponents;
            tabPage28.BackColor = ClComponents;


        }

        private void saveDates()
        {

            string identificadorVivienda = textBox1.Text;
            string cuestionario = textBox2.Text;
            string comuna = textBox4.Text;
            string nVivienda = textBox5.Text;
            string nHogar = textBox3.Text;
            string nomCalle = textBox6.Text;
            string nDomiciliario = textBox7.Text;
            string nBlock = textBox8.Text;
            string nPiso = textBox9.Text;
            string nDepto = textBox10.Text;
            string distrito = textBox11.Text;
            string entidad = textBox12.Text;
            string zona = textBox13.Text;
            string manzana = textBox14.Text;
            string areaLevantamiento = textBox15.Text;
            string preguntaOnce = textBox16.Text;
            string preguntaOnceDos = textBox17.Text;
            string nombreCompletoPersonaUno = textBox18.Text;
            string nombreCompletoPersonaDos = textBox19.Text;
            string nombreCompletoPersonaTres = textBox20.Text;
            string nombreCompletoPersonaCuatro = textBox21.Text;
            string nombreCompletoPersonaCinco = textBox22.Text;
            string nombreCompletoPersonaSeis = textBox23.Text;
            string nombreCompletoPersonaSiete = textBox24.Text;
            string nombreCompletoPersonaOcho = textBox25.Text;
            string nombreCompletoPersonaNueve = textBox26.Text;
            string edadCumplidaPersonaUno = textBox28.Text;
            string edadCumplidaPersonaDos = textBox29.Text;
            string edadCumplidaPersonaTres = textBox30.Text;
            string edadCumplidaPersonaCuatro = textBox31.Text;
            string edadCumplidaPersonaCinco = textBox32.Text;
            string edadCumplidaPersonaSeis = textBox33.Text;
            string edadCumplidaPersonaSiete = textBox35.Text;
            string edadCumplidaPersonaNueve = textBox36.Text;
            string edadCumplidaPersonaOcho = textBox37.Text;
            string relacionParentescoPersonaUno = textBox39.Text;
            string relacionParentescoPersonaDos = textBox40.Text;
            string relacionParentescoPersonaTres = textBox41.Text;
            string relacionParentescoPersonaCuatro = textBox42.Text;
            string relacionParentescoPersonaCinco = textBox43.Text;
            string relacionParentescoPersonaSeis = textBox44.Text;
            string relacionParentescoPersonaSiete = textBox45.Text;
            string relacionParentescoPersonaOcho = textBox46.Text;
            string relacionParentescoPersonaNueve = textBox47.Text;
            string cantidadHombre = textBox49.Text;
            string cantidadMujer = textBox50.Text;
            string cantidadTotal = textBox51.Text;
            string datosPersonaNombreCompleto = textBox27.Text;
            string datosPersonaNPersona = textBox38.Text;
            string datosPersonaEdadCumplida = textBox34.Text;
            string datosPersonaDiaNacido = textBox48.Text;
            string datosPersonaMesNacido = textBox52.Text;
            string datosPersonaYearNacido = textBox53.Text;
            string preguntaVeintiCuatro_Uno = textBox54.Text;
            string preguntaVeintiCuatro_Dos = textBox55.Text;
            string preguntaVeintiCinco_Uno = textBox56.Text;
            string preguntaVeintiCinco_Dos = textBox57.Text;
            string preguntaVeintiSeis = textBox58.Text;
            string preguntaVeintiSiete = textBox59.Text;
            string preguntaVeintiOcho = textBox60.Text;
            string preguntaTreintaUno = textBox61.Text;
            string preguntaCuarentaUno = textBox62.Text;
            string preguntaCuarentaDos = textBox63.Text;
            string preguntaCuarentaTres = textBox64.Text;
            string preguntaCuarentaCuatro_Uno = textBox65.Text;
            string preguntaCuarentaCuatro_Dos = textBox66.Text;
            string preguntaCuarentaSeis_Uno = textBox67.Text;
            string preguntaCuarentaSeis_Dos = textBox68.Text;
            string preguntaCuarentaSeis_Tres = textBox69.Text;
            string preguntaCuarentaSieteMujeres = textBox74.Text;
            string preguntaCuarentaSieteHombres = textBox75.Text;
            string preguntaCuarentaOcho_Uno = textBox70.Text;
            string preguntaCuarentaOcho_Dos = textBox71.Text;
            string preguntaCuarentaNueve = textBox72.Text;
            string observacionesDireccion = textBox73.Text;

        }

        private void clearCampsLabel()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
            textBox31.Text = "";
            textBox32.Text = "";
            textBox33.Text = "";
            textBox35.Text = "";
            textBox36.Text = "";
            textBox37.Text = "";
            textBox39.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";
            textBox42.Text = "";
            textBox43.Text = "";
            textBox44.Text = "";
            textBox45.Text = "";
            textBox46.Text = "";
            textBox47.Text = "";
            textBox49.Text = "";
            textBox50.Text = "";
            textBox51.Text = "";
            textBox27.Text = "";
            textBox38.Text = "";
            textBox34.Text = "";
            textBox48.Text = "";
            textBox52.Text = "";
            textBox53.Text = "";
            textBox54.Text = "";
            textBox55.Text = "";
            textBox56.Text = "";
            textBox57.Text = "";
            textBox58.Text = "";
            textBox59.Text = "";
            textBox60.Text = "";
            textBox61.Text = "";
            textBox62.Text = "";
            textBox63.Text = "";
            textBox64.Text = "";
            textBox65.Text = "";
            textBox66.Text = "";
            textBox67.Text = "";
            textBox68.Text = "";
            textBox69.Text = "";
            textBox74.Text = "";
            textBox75.Text = "";
            textBox70.Text = "";
            textBox71.Text = "";
            textBox72.Text = "";
            textBox73.Text = "";
        }



        private void btnDia_Click(object sender, EventArgs e)
        {
            changeColorText(Color.Black);
            changeComponentsColor(Color.White);
            isRunning = false;

        }

        private void btnNoche_Click(object sender, EventArgs e)
        {

            changeColorText(Color.White);
            changeComponentsColor(Color.DarkSlateGray);
            isRunning = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton104_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton235_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton277_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}