using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            UpdatePanelColor();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnCalculateResult_Click(object sender, EventArgs e)
        {
            decimal sred = numSnapRed.Value;
            decimal sgreen = numSnapGreen.Value;
            decimal sblue = numSnapBlue.Value;

            int gred = Convert.ToInt32(numGetRed.Value);
            int ggreen = Convert.ToInt32(numGetGreen.Value);
            int gblue = Convert.ToInt32(numGetBlue.Value);

            int rred = 0;
            int rgreen = 0;
            int rblue = 0;

            #region Red
            if (sred > 0)
            {
                for (int i = 1; i < 255; i++)
                {
                    decimal t = i * (1 + (sred / 100));

                    if (Math.Ceiling(t) >= gred)
                    {
                        rred = i;
                        break;
                    }
                }
            }
            else if (sred < 0)
            {
                int divisor = (int)(100M + sred);

                int res1 = gred * (int)(sred *-1);
                int res2 = res1 / divisor;
                rred = res2 + gred;

                //for (int i = 1; i <= 510; i++)
                //{
                //    decimal t = -1 * (i * (sred / 100));

                //    if (Math.Floor(i - t) >= gred)
                //    {
                //        rred = i;
                //        break;
                //    }
                //}
            }
            else
            {
                rred = gred;
            }
            #endregion

            #region Green
            if (sgreen > 0)
            {
                for (int i = 1; i < 255; i++)
                {
                    decimal t = i * (1 + (sgreen / 100));

                    if (Math.Ceiling(t) >= ggreen)
                    {
                        rgreen = i;
                        break;
                    }
                }
            }
            else if (sgreen < 0)
            {
                int divisor = (int)(100M + sgreen);

                int res1 = ggreen * (int)(sgreen * -1);
                int res2 = res1 / divisor;
                rgreen = res2 + ggreen;

                //for (int i = 1; i <= 510; i++)
                //{
                //    decimal t = -1 * (i * (sgreen / 100));

                //    if (Math.Floor(i - t) >= ggreen)
                //    {
                //        rgreen = i;
                //        break;
                //    }
                //}
            }
            else
            {
                rgreen = ggreen;
            }
            #endregion

            #region Blue
            if (sblue > 0)
            {
                for (int i = 1; i < 255; i++)
                {
                    decimal t = i * (1 + (sblue / 100));

                    if (Math.Ceiling(t) >= gblue)
                    {
                        rblue = i;
                        break;
                    }
                }
            }
            else if (sblue < 0)
            {
                int divisor = (int)(100M + sblue);

                int res1 = gblue * (int)(sblue * -1);
                int res2 = res1 / divisor;
                rblue = res2 + gblue;

                //for (int i = 1; i <= 510; i++)
                //{
                //    decimal t = -1 * (i * (sblue / 100));

                //    if (Math.Floor(i - t) >= gblue)
                //    {
                //        rblue = i;
                //        break;
                //    }
                //}
            }
            else
            {
                rblue = gblue;
            }
            #endregion

            txtResRed.Text = rred.ToString("0.#########################");
            txtResGreen.Text = rgreen.ToString("0.#########################");
            txtResBlue.Text = rblue.ToString("0.#########################");
        }

        private void numGetRed_ValueChanged(object sender, EventArgs e)
        {
            UpdatePanelColor();
        }

        public void UpdatePanelColor()
        {
            pnlGetColor.BackColor = Color.FromArgb((int)numGetRed.Value, (int)numGetGreen.Value, (int)numGetBlue.Value);
        }

        private void numGetGreen_ValueChanged(object sender, EventArgs e)
        {
            UpdatePanelColor();
        }

        private void numGetBlue_ValueChanged(object sender, EventArgs e)
        {
            UpdatePanelColor();
        }
    }
}
