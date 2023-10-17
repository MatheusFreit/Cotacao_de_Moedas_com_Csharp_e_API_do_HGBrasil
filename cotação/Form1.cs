using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Globalization;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace cotação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1moedas.SelectedIndex)
            {
                case 0: //bitcoin
                    try
                    {
                        string strURL = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,BTC&key=e40e2324";
                        using (HttpClient client = new HttpClient())
                        {
                            var response = client.GetAsync(strURL).Result;
                            if (response.IsSuccessStatusCode)
                            {
                                var result = response.Content.ReadAsStringAsync().Result;

                                Market market = JsonConvert.DeserializeObject<Market>(result);
                                lblcompra.Text = string.Format(CultureInfo.GetCultureInfo("pt-Br"), "{0:C}", market.currency.Buy);
                                lblvenda.Text = string.Format(CultureInfo.GetCultureInfo("pt-Br"), "{0:C}", market.currency.Sell);
                                lblvariacao.Text = string.Format(CultureInfo.GetCultureInfo("pt-Br"), "{0:P}", market.currency.Variation / 100);
                            }
                            else
                            {
                                lblcompra.Text = "-";
                                lblvenda.Text = "-";
                                lblvariacao.Text = "-";
                            }
                        }
                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                    case 1:
                    try
                    {
                        string strURL2 = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=e40e2324";
                        using (HttpClient client = new HttpClient())
                        {
                            var response = client.GetAsync(strURL2).Result;
                            if (response.IsSuccessStatusCode)
                            {
                                var result = response.Content.ReadAsStringAsync().Result;
                                Market market = JsonConvert.DeserializeObject<Market>(result);
                                lblcompra.Text = string.Format(CultureInfo.GetCultureInfo("pt-Br"), "{0:C}", market.currency.Buy);
                                lblvenda.Text = string.Format(CultureInfo.GetCultureInfo("pt-Br"), "{0:C}", market.currency.Sell);
                                lblvariacao.Text = string.Format(CultureInfo.GetCultureInfo("pt-Br"), "{0:P}", market.currency.Variation/100);

                            }
                            else
                            {
                                lblcompra.Text = "-";
                                lblvenda.Text = "-";
                                lblvariacao.Text = "-";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                    case 2:
                    try
                    {
                        string strURL3 = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,EUR&key=e40e2324";
                        using (HttpClient client = new HttpClient())
                        {
                            var response = client.GetAsync(strURL3).Result;
                            if (response.IsSuccessStatusCode)
                            {
                                var result = response.Content.ReadAsStringAsync().Result;
                                Market market = JsonConvert.DeserializeObject<Market>(result);
                                lblcompra.Text = string.Format(CultureInfo.GetCultureInfo("pt-Br"), "{0:C3}", market.currency.Buy);
                                lblvenda.Text = string.Format(CultureInfo.GetCultureInfo("pt-Br"), "{0:C3}", market.currency.Sell);
                                lblvariacao.Text = string.Format(CultureInfo.GetCultureInfo("pt-Br"), "{0:P}", market.currency.Variation / 100);

                            }
                            else
                            {
                                lblcompra.Text = "-";
                                lblvenda.Text = "-";
                                lblvariacao.Text = "-";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                default:
                    MessageBox.Show("Desculpe, parece que houve um erro. A informação fornecida é inválida ou incorreta.", "Erro na Opção Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
        }

            private void button2_Click(object sender, EventArgs e)
            {
            comboBox1moedas.Text = "";
                lblcompra.Text = "0,0";
                lblvenda.Text = "0,0";
                lblvariacao.Text = "0,0";
            }
        }
    }
