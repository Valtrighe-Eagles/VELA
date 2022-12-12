// VELA - Valtrighe Eagles Logistic Agency
// Programma di Graziano Filippo

namespace VELA
{
    public partial class Form1 : Form
    {
        int nRighe = 0;
        int nColonne = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaTabella_Click(object sender, EventArgs e)
        {
            tabellaDati.Rows.Clear();
            tabellaDati.Columns.Clear();

            nRighe = (int)numRighe.Value;
            nColonne = (int)numColonne.Value;

            tabellaDati.ColumnCount = (int)numColonne.Value + 1;
            tabellaDati.RowCount = (int)numRighe.Value + 1;

            for (int i = 0; i < numColonne.Value; i++)
            {
                tabellaDati.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                tabellaDati.Columns[i].HeaderCell.Value = "D" + (i + 1);
            }

            for (int i = 0; i < numRighe.Value; i++)
            {
                tabellaDati.Rows[i].HeaderCell.Value = "UP" + (i + 1);
            }

            tabellaDati.Columns[nColonne].HeaderCell.Value = "Totali";
            tabellaDati.Rows[nRighe].HeaderCell.Value = "Totali";

            datiCasuali();
        }

        private void datiCasuali()
        {
            Random casuale = new Random();
            int totale = casuale.Next(300, 1000);

            tabellaDati.Rows[nRighe].Cells[nColonne].Value = totale;

            int[] righe = sommaCasualeTotale(totale, nRighe);
            int[] colonne = sommaCasualeTotale(totale, nColonne);

            for (int i = 0; i < nRighe; i++)
            {
                tabellaDati.Rows[i].Cells[nColonne].Value = righe[i];
            }

            for (int i = 0; i < nColonne; i++)
            {
                tabellaDati.Rows[nRighe].Cells[i].Value = colonne[i];
            }

            for (int i = 0; i < nRighe; i++)
            {
                for (int j = 0; j < nColonne; j++)
                {
                    tabellaDati.Rows[i].Cells[j].Value = casuale.Next(10, 81);
                }
            }

        }

        public static int[] sommaCasualeTotale(int somma, int quantita)
        {
            int[] numeri = new int[quantita];
            var casuale = new Random();
            for (int i = 0; i < somma; i++)
            {
                numeri[casuale.Next(0, quantita)]++;
            }
            return numeri;
        }

        private void tabellaDati_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(tabellaDati_KeyPress);
            if (tabellaDati.CurrentCell.ColumnIndex == 0)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(tabellaDati_KeyPress);
                }
            }
        }

        private void tabellaDati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNordOvest_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                tabellaDati.Invoke(new Action(() =>
                {
                    tabellaDati.ReadOnly = true;
                    btnMinimiCosti.Enabled = false;
                    btnNordOvest.Enabled = false;
                    btnCreaTabella.Enabled = false;
                }));

                if (nRighe < 2 || nColonne < 2)
                {
                    MessageBox.Show("Tabella non valida", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabellaDati.Invoke(new Action(() =>
                    {
                        tabellaDati.ReadOnly = false;
                        btnMinimiCosti.Enabled = true;
                        btnNordOvest.Enabled = true;
                        btnCreaTabella.Enabled = true;
                    }));
                    return;
                }

                if (!ControlloTotali())
                {
                    MessageBox.Show("I totali non sono uguali", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabellaDati.Invoke(new Action(() =>
                    {
                        tabellaDati.ReadOnly = false;
                        btnMinimiCosti.Enabled = true;
                        btnNordOvest.Enabled = true;
                        btnCreaTabella.Enabled = true;
                    }));
                    return;
                }

                ScriviMessaggio("Metodo in uso: Nord Ovest");

                int costoTotale = 0;

                while (nColonne > 0 || nRighe > 0)
                {
                    tabellaDati.Invoke(new Action(() =>
                    {
                        tabellaDati.CurrentCell = tabellaDati[nColonne, nRighe];
                    }));

                    int totaleDestra = int.Parse(tabellaDati.Rows[0].Cells[nColonne].Value.ToString());
                    int totaleSotto = int.Parse(tabellaDati.Rows[nRighe].Cells[0].Value.ToString());

                    tabellaDati.Rows[0].Cells[0].Style.BackColor = Color.Yellow;

                    Thread.Sleep(250);

                    ScriviMessaggio("");
                    ScriviMessaggio(tabellaDati.Rows[0].HeaderCell.Value + " => " + tabellaDati.Columns[0].HeaderCell.Value);
                    if (totaleDestra > totaleSotto)
                    {
                        ScriviMessaggio(tabellaDati.Rows[0].Cells[0].Value + " * " + totaleSotto + " = " + int.Parse(tabellaDati.Rows[0].Cells[0].Value.ToString()) * totaleSotto);
                        costoTotale += int.Parse(tabellaDati.Rows[0].Cells[0].Value.ToString()) * totaleSotto;
                        ScriviMessaggio("Costo totale: " + costoTotale);
                        tabellaDati.Rows[0].Cells[nColonne].Value = totaleDestra - totaleSotto;

                        tabellaDati.Invoke(new Action(() =>
                        {
                            tabellaDati.Columns.RemoveAt(0);
                        }));

                        nColonne--;
                    }

                    if (totaleDestra < totaleSotto)
                    {
                        ScriviMessaggio(tabellaDati.Rows[0].Cells[0].Value + " * " + totaleDestra + " = " + int.Parse(tabellaDati.Rows[0].Cells[0].Value.ToString()) * totaleDestra);
                        costoTotale += int.Parse(tabellaDati.Rows[0].Cells[0].Value.ToString()) * totaleDestra;
                        ScriviMessaggio("Costo totale: " + costoTotale);
                        tabellaDati.Rows[nRighe].Cells[0].Value = totaleSotto - totaleDestra;
                        tabellaDati.Invoke(new Action(() =>
                        {
                            tabellaDati.Rows.RemoveAt(0);
                        }));
                        nRighe--;
                    }

                    if (totaleDestra == totaleSotto)
                    {
                        ScriviMessaggio(tabellaDati.Rows[0].Cells[0].Value + " * " + totaleDestra + " = " + int.Parse(tabellaDati.Rows[0].Cells[0].Value.ToString()) * totaleDestra);
                        costoTotale += int.Parse(tabellaDati.Rows[0].Cells[0].Value.ToString()) * totaleDestra;
                        ScriviMessaggio("Costo totale: " + costoTotale);
                        tabellaDati.Invoke(new Action(() =>
                        {
                            tabellaDati.Rows.RemoveAt(0);
                            tabellaDati.Columns.RemoveAt(0);
                        }));
                        nRighe--;
                        nColonne--;
                    }

                    AggiornaTotale();
                    Thread.Sleep(250);

                    tabellaDati.Rows[0].Cells[0].Style.BackColor = DefaultBackColor;
                }

                ScriviMessaggio("");
                ScriviMessaggio("Costo totale: " + costoTotale);
                ScriviMessaggio("");
                tabellaDati.Invoke(new Action(() =>
                {
                    tabellaDati.ReadOnly = false;
                    btnMinimiCosti.Enabled = true;
                    btnNordOvest.Enabled = true;
                    btnCreaTabella.Enabled = true;
                }));
            });

        }

        private bool ControlloTotali()
        {
            int totaleDestra = 0;
            int totaleSotto = 0;

            for (int i = 0; i < nRighe; i++)
            {
                totaleDestra += int.Parse(tabellaDati.Rows[i].Cells[nColonne].Value.ToString());
            }

            for (int i = 0; i < nColonne; i++)
            {
                totaleSotto += int.Parse(tabellaDati.Rows[nRighe].Cells[i].Value.ToString());
            }

            return totaleDestra == totaleSotto;
        }

        private void AggiornaTotale()
        {
            int totaleDestra = 0;

            for (int i = 0; i < nRighe; i++)
            {
                totaleDestra += int.Parse(tabellaDati.Rows[i].Cells[nColonne].Value.ToString());
            }

            tabellaDati.Rows[nRighe].Cells[nColonne].Value = totaleDestra;
        }

        private void ScriviMessaggio(string messaggio)
        {
            messaggi.Invoke(new Action(() =>
            {
                messaggi.AppendText(messaggio + Environment.NewLine);
            }));
        }

        private void btnCancellaMessaggi_Click(object sender, EventArgs e)
        {
            messaggi.Text = "";
        }

        private void btnMinimiCosti_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                tabellaDati.Invoke(new Action(() =>
                {
                    tabellaDati.ReadOnly = true;
                    btnMinimiCosti.Enabled = false;
                    btnNordOvest.Enabled = false;
                    btnCreaTabella.Enabled = false;
                }));

                if (nRighe < 2 || nColonne < 2)
                {
                    MessageBox.Show("Tabella non valida", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabellaDati.Invoke(new Action(() =>
                    {
                        tabellaDati.ReadOnly = false;
                        btnMinimiCosti.Enabled = true;
                        btnNordOvest.Enabled = true;
                        btnCreaTabella.Enabled = true;
                    }));
                    return;
                }

                if (!ControlloTotali())
                {
                    MessageBox.Show("I totali non sono uguali", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabellaDati.Invoke(new Action(() =>
                    {
                        tabellaDati.ReadOnly = false;
                        btnMinimiCosti.Enabled = true;
                        btnNordOvest.Enabled = true;
                        btnCreaTabella.Enabled = true;
                    }));
                    return;
                }

                ScriviMessaggio("Metodo in uso: Minimi Costi");

                int costoTotale = 0;

                while (nColonne > 0 || nRighe > 0)
                {
                    tabellaDati.Invoke(new Action(() =>
                    {
                        tabellaDati.CurrentCell = tabellaDati[nColonne, nRighe];
                    }));

                    int x = 0;
                    int y = 0;

                    int valore_minimo = int.MaxValue;

                    for (int i = 0; i < nRighe; i++)
                    {
                        for (int j = 0; j < nColonne; j++)
                        {
                            if (int.Parse(tabellaDati.Rows[i].Cells[j].Value.ToString()) < valore_minimo)
                            {
                                valore_minimo = int.Parse(tabellaDati.Rows[i].Cells[j].Value.ToString());
                                x = i;
                                y = j;
                            }
                        }
                    }

                    int totaleDestra = int.Parse(tabellaDati.Rows[x].Cells[nColonne].Value.ToString());
                    int totaleSotto = int.Parse(tabellaDati.Rows[nRighe].Cells[y].Value.ToString());

                    tabellaDati.Rows[x].Cells[y].Style.BackColor = Color.Yellow;

                    Thread.Sleep(250);

                    ScriviMessaggio("");
                    ScriviMessaggio(tabellaDati.Rows[x].HeaderCell.Value + " => " + tabellaDati.Columns[y].HeaderCell.Value);

                    if (totaleDestra > totaleSotto)
                    {
                        ScriviMessaggio(tabellaDati.Rows[x].Cells[y].Value + " * " + totaleSotto + " = " + int.Parse(tabellaDati.Rows[x].Cells[y].Value.ToString()) * totaleSotto);
                        costoTotale += int.Parse(tabellaDati.Rows[x].Cells[y].Value.ToString()) * totaleSotto;
                        ScriviMessaggio("Costo totale: " + costoTotale);
                        tabellaDati.Rows[x].Cells[nColonne].Value = totaleDestra - totaleSotto;

                        tabellaDati.Invoke(new Action(() =>
                        {
                            tabellaDati.Columns.RemoveAt(y);
                        }));

                        nColonne--;
                    }

                    if (totaleDestra < totaleSotto)
                    {
                        ScriviMessaggio(tabellaDati.Rows[x].Cells[y].Value + " * " + totaleDestra + " = " + int.Parse(tabellaDati.Rows[x].Cells[y].Value.ToString()) * totaleDestra);
                        costoTotale += int.Parse(tabellaDati.Rows[x].Cells[y].Value.ToString()) * totaleDestra;
                        ScriviMessaggio("Costo totale: " + costoTotale);
                        tabellaDati.Rows[nRighe].Cells[y].Value = totaleSotto - totaleDestra;
                        tabellaDati.Invoke(new Action(() =>
                        {
                            tabellaDati.Rows.RemoveAt(x);
                        }));
                        nRighe--;
                    }

                    if (totaleDestra == totaleSotto)
                    {
                        ScriviMessaggio(tabellaDati.Rows[x].Cells[y].Value + " * " + totaleDestra + " = " + int.Parse(tabellaDati.Rows[x].Cells[y].Value.ToString()) * totaleDestra);
                        costoTotale += int.Parse(tabellaDati.Rows[x].Cells[y].Value.ToString()) * totaleDestra;
                        ScriviMessaggio("Costo totale: " + costoTotale);
                        tabellaDati.Invoke(new Action(() =>
                        {
                            tabellaDati.Rows.RemoveAt(x);
                            tabellaDati.Columns.RemoveAt(y);
                        }));
                        nRighe--;
                        nColonne--;
                    }

                    AggiornaTotale();
                    Thread.Sleep(250);
                }

                ScriviMessaggio("");
                ScriviMessaggio("Costo totale: " + costoTotale);
                ScriviMessaggio("");

                tabellaDati.Invoke(new Action(() =>
                {
                    tabellaDati.ReadOnly = false;
                    btnMinimiCosti.Enabled = true;
                    btnNordOvest.Enabled = true;
                    btnCreaTabella.Enabled = true;
                }));
            });
        }
    }
}