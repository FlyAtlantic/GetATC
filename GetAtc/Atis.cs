using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetAtc
{
    public partial class Atis : Form
    {
        public Atis()
        {
            InitializeComponent();
        }
            
        SoundPlayer audio;     

        private void playaudio() // defining the function
        {           
            string[] dd = txtMetar.Text.Split('[');
            
            foreach (string word22 in dd)
            {
                string[] aa = word22.Split(']');

                foreach (string word223 in aa)
                {                  
                    bool allDigits = Microsoft.VisualBasic.Information.IsNumeric(word223);

                    if (allDigits)
                    {
                        char[] tt = word223.ToString().ToCharArray();

                        foreach (char word224 in tt)
                        {
                            switch (word224.ToString())
                            {
                                case "0":
                                    audio = new SoundPlayer(Properties.Resources._0);
                                    audio.Play();
                                    MessageBox.Show(word224.ToString());
                                    break;

                                case "1":
                                    audio = new SoundPlayer(Properties.Resources._1);
                                    audio.Play();
                                    MessageBox.Show(word224.ToString());
                                    break;

                                case "2":
                                    audio = new SoundPlayer(Properties.Resources._2);
                                    audio.Play();
                                    MessageBox.Show(word224.ToString());
                                    break;

                                case "3":
                                    audio = new SoundPlayer(Properties.Resources._3);
                                    audio.Play();
                                    MessageBox.Show(word224.ToString());
                                    break;

                                case "4":
                                    audio = new SoundPlayer(Properties.Resources._4);
                                    audio.Play();
                                    MessageBox.Show(word224.ToString());
                                    break;

                                case "5":
                                    audio = new SoundPlayer(Properties.Resources._5);
                                    audio.Play();
                                    MessageBox.Show(word224.ToString());
                                    break;

                                case "6":
                                    audio = new SoundPlayer(Properties.Resources._6);
                                    audio.Play();
                                    MessageBox.Show(word224.ToString());
                                    break;

                                case "7":
                                    audio = new SoundPlayer(Properties.Resources._7);
                                    audio.Play();
                                    MessageBox.Show(word224.ToString());
                                    break;

                                case "8":
                                    audio = new SoundPlayer(Properties.Resources._8);
                                    audio.Play();
                                    MessageBox.Show(word224.ToString());
                                    break;

                                case "9":
                                    audio = new SoundPlayer(Properties.Resources._9);
                                    audio.Play();
                                    MessageBox.Show(word224.ToString());
                                    break;

                                default:

                                    break;
                            }  
                        }                       
                    }
                    else {
                        switch (word223)
                        {
                            case "LPPTinfo":
                                audio = new SoundPlayer(Properties.Resources.LPPT_ATIS);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "LPPRinfo":
                                audio = new SoundPlayer(Properties.Resources._1);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "H":
                                audio = new SoundPlayer(Properties.Resources.H);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "expect ILS":
                                audio = new SoundPlayer(Properties.Resources.EXP_ILS_APCH);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            ///tem erro
                            case "runway in use":
                                audio = new SoundPlayer(Properties.Resources.RWY_IN_USE_03);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "transition level":
                                audio = new SoundPlayer(Properties.Resources.TL);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            ///tem erro
                            case "vacate pos":
                                audio = new SoundPlayer(Properties.Resources.AFTER_LANDING_VACATE_VIA_HN);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "wind":
                                audio = new SoundPlayer(Properties.Resources.WND);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "degrees":
                                audio = new SoundPlayer(Properties.Resources.DEG);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "knots":
                                audio = new SoundPlayer(Properties.Resources.KT);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "variable netween":
                                audio = new SoundPlayer(Properties.Resources.VRB_BTN);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "and":
                                audio = new SoundPlayer(Properties.Resources.AND);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "visibility":
                                audio = new SoundPlayer(Properties.Resources.VIS);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            //case "more than 10 kms":
                            //    audio = new SoundPlayer(Properties.Resources.MOD);
                            //    audio.Play();
                            //    MessageBox.Show(word223);
                            //    break;

                            case "clouds":
                                audio = new SoundPlayer(Properties.Resources.CLD);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "BKN":
                                audio = new SoundPlayer(Properties.Resources.BKN);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "feet":
                                audio = new SoundPlayer(Properties.Resources.FT);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "temperature":
                                audio = new SoundPlayer(Properties.Resources.TEMP);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "dewpoint":
                                audio = new SoundPlayer(Properties.Resources.DP);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;
                            
                            ///tem erro
                            case "degrees C":
                                audio = new SoundPlayer(Properties.Resources.DEG);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "QNH":
                                audio = new SoundPlayer(Properties.Resources.QNH);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "endof":
                                audio = new SoundPlayer(Properties.Resources.ACK_LPPT_INFO);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            case "atis":
                                audio = new SoundPlayer(Properties.Resources.ATIS_OUT_OF_SERVICE);
                                audio.Play();
                                MessageBox.Show(word223);
                                break;

                            default:

                                break;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playaudio();
        }
    }
}
