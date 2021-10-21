using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.IO;

namespace BuscaOrdenada
{
    public partial class Form1 : Form
    {
        List<String> nomes = new List<String>();
        String[] cidades = new string[100];
        //Campos
        private IconButton btnAtual;
        private Panel leftBorderBtn;
        private bool btnBinClick = false;
        private bool btnSeqClick = false;
        private bool btnOrdClick = false;

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        // Structs Cores
        private struct RGBCores
        {
            public static Color cor1 = Color.FromArgb(172,126,241);
            public static Color cor2 = Color.FromArgb(0, 54, 255);
            public static Color cor3 = Color.FromArgb(253, 138, 114);
            public static Color cor4 = Color.FromArgb(95, 77, 221);
            public static Color cor5 = Color.FromArgb(249, 88, 155);
        }
        //Metodos
        private void AtivaBtn(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DesativaBtn();
                //botão
                btnAtual = (IconButton)senderBtn;
                btnAtual.BackColor = Color.FromArgb(37, 36, 81);
                btnAtual.ForeColor = color;
                btnAtual.TextAlign = ContentAlignment.MiddleCenter;
                btnAtual.IconColor = color;
                btnAtual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnAtual.ImageAlign = ContentAlignment.MiddleRight;
                //borda esquerda 
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, btnAtual.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }


        // Busca Binária
        static int BinarySearch(List<string> list, string word, int min, int max)
        {
            if (min > max)
            {
                return -1;
            }
            else
            {
                int mid = (min + max) / 2;
                if (word == list[mid])
                {
                    return 1;
                }
                else if (String.Compare(word, list[mid]) < 0)
                {
                    return BinarySearch(list, word, min, mid - 1);
                }
                else
                {
                    return BinarySearch(list, word, mid + 1, max);
                }
            }
        }

        // Função que realiza uma Busca Linear/Sequencial
        static int BuscaSequencial(List<string> list, int tl, string word) //tl = tamanho total do array
        {
            int i = 0;
            while (i < tl && list[i] != word)
            {
                i++;
            }
            if (i >= tl)
            {
                i = -1;
            }
            return i;
        }

        private void ResetBtnClic()
        {
            btnSeqClick = false;
            btnBinClick = false;
        }


        private void DesativaBtn()
        {
            if(btnAtual != null)
            {
                btnAtual.BackColor = Color.FromArgb(60, 65, 70);
                btnAtual.ForeColor = Color.WhiteSmoke;
                btnAtual.TextAlign = ContentAlignment.MiddleLeft;
                btnAtual.IconColor = Color.WhiteSmoke;
                btnAtual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnAtual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        void salvar()
        {
            StreamWriter arquivo = new StreamWriter("Ordenado.txt");
            foreach (string n in nomes)
                arquivo.WriteLine(n);
            MessageBox.Show("Dados Salvos");
            arquivo.Close();
        }
        void mostra()
        {
            listDados.Items.Clear();
            foreach (String n in nomes)
                listDados.Items.Add(n);
        }
        void carregar()
        {
            if (File.Exists("Ordenado.txt"))
            {
                btnOrdClick = true; // Caso abra o arquivo ordenado, evita possíveis erros
                StreamReader arquivo = new StreamReader("Ordenado.txt");
                string linha;
                int c = 0;
                int n = 100;
                do
                {
                    linha = arquivo.ReadLine();
                    listDados.Items.Add(linha);
                    nomes.Add(linha);
                    cidades[c] = linha;
                    c++;
                } while (c < n);
                arquivo.Close();
                MessageBox.Show("Dados Ordenados Carregados", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else if(File.Exists("DUPLA (9).txt"))
                {
                    StreamReader arquivo = new StreamReader("Ordenado.txt");
                    string linha;
                    int c = 0;
                    int n = 100;
                    
                    do
                    {
                        linha = arquivo.ReadLine();
                        listDados.Items.Add(linha);
                        nomes.Add(linha);
                        cidades[c] = linha;
                        c++;
                    } while (c < n);
                arquivo.Close();
                MessageBox.Show("Dados Carregados");
            }
            /*
                OpenFileDialog f = new OpenFileDialog();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    listDados.Items.Clear();

                    List<string> lines = new List<string>();
                    using (StreamReader r = new StreamReader(f.OpenFile()))
                    {
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            listDados.Items.Add(line);

                        }
                    }
                }
            */
        }
        void ordenarAlf()
        {
            nomes.Sort();
            listDados.Items.Clear();
            foreach (String n in nomes)
            {
                listDados.Items.Add(n);
            }
            MessageBox.Show("Dados Ordenados");
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AtivaBtn(sender, RGBCores.cor1);
            ResetBtnClic();
        }

        private void btn_buscaByn_Click(object sender, EventArgs e)
        {
            AtivaBtn(sender, RGBCores.cor2);
            btnBinClick = true;
            btnSeqClick = false;
        }

        private void btn_buscaSeq_Click(object sender, EventArgs e)
        {
            AtivaBtn(sender, RGBCores.cor2);
            btnBinClick = false;
            btnSeqClick = true;
        }
        private void btnOrdenar_Click_1(object sender, EventArgs e)
        {
            AtivaBtn(sender, RGBCores.cor3);
            ordenarAlf();
            ResetBtnClic();
            btnOrdClick = true;
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            AtivaBtn(sender, RGBCores.cor4);
            ResetBtnClic();
            if (btnOrdClick == true && listDados.Items != null)
            {
                salvar();
            }
            else
                MessageBox.Show("Dados Não Ordenados ou Lista Vazia!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCarregar_Click_1(object sender, EventArgs e)
        {
            AtivaBtn(sender, RGBCores.cor5);
            ResetBtnClic();
            carregar();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            ResetBtnClic();
        }
        private void Reset()
        {
            DesativaBtn();
            leftBorderBtn.Visible = false;
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string imputWord = txtSearch.Text;
            int pesqSeq = 0;
            int pesqBin = 0;

            if (btnSeqClick == true && btnBinClick == false)
            {
                pesqSeq = BuscaSequencial(nomes, 100, imputWord);
                if (pesqSeq == -1)
                {
                    MessageBox.Show("Cidade não Encontrada!");
                    listDados.SelectedIndex = listDados.FindString(" ");
                }
                else
                {
                    MessageBox.Show("Cidade Encontrada!");
                    listDados.SelectedIndex = listDados.FindString(txtSearch.Text);
                }
            }
            //--------------------------------------------------------------------
            else if (btnBinClick == true && btnSeqClick == false)
            {
                pesqBin = BinarySearch(nomes, imputWord, 0, 100);
                if (pesqBin == 1)
                {
                    MessageBox.Show("Cidade Encontrada!");
                    listDados.SelectedIndex = listDados.FindString(txtSearch.Text);
                }
                    else
                    {
                        MessageBox.Show("Cidade não Encontrada!");
                        listDados.SelectedIndex = listDados.FindString(" ");
                    }
            }
                else
                {
                    MessageBox.Show("Nenhuma Pesquisa Selecionada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    listDados.SelectedIndex = listDados.FindString(" ");
                }
        }
    }
}
