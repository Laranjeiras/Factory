using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using Ltec.Factory.Models;
using System.Collections.Generic;
using Excel_ = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Drawing;

namespace Factory
{
    public partial class FrmPrincipal : Form
    {
        decimal taxaJuros = Convert.ToDecimal(1.0d);

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            txtTaxaJuros.Text = Math.Round(taxaJuros, 2).ToString("N3");            
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            Calcular(0, 0);
        }

        private void Calcular(int RowIndex, int ColumnIndex)
        {
            int counter;
            int dias;
            decimal totalBruto = 0;
            decimal totalDesconto = 0;
            decimal totalLiquido = 0;
            taxaJuros = Math.Round(decimal.Parse(txtTaxaJuros.Text), 2);
            var dataBase = txtData.Value.Date;

            for (counter = 1; counter < (Grid.Rows.Count); counter++)
            {
                var bomPara = Convert.ToDateTime(Grid.Rows[counter-1].Cells["BomPara"].Value.ToString());
                dias = (int)bomPara.Subtract(dataBase).TotalDays;

                var valorBruto = Math.Round(Convert.ToDecimal(Grid.Rows[counter-1].Cells["ValorBruto"].Value.ToString().Replace("R$","")),2);
                var desconto = Math.Round((taxaJuros / 30) * dias,2);
                var descontoReal = Math.Round(valorBruto * (desconto / 100), 2);
                var valorLiq = Math.Round(valorBruto - descontoReal,2);

                totalBruto += valorBruto;
                totalDesconto += descontoReal;
                totalLiquido += valorLiq;

                Grid.Rows[counter - 1].Cells["Dias"].Value = dias.ToString();
                Grid.Rows[counter - 1].Cells["ValorBruto"].Value = valorBruto.ToString("C");
                Grid.Rows[counter - 1].Cells["desconto"].Value = desconto.ToString("N2");
                Grid.Rows[counter - 1].Cells["DescontoReal"].Value = descontoReal.ToString("C");
                Grid.Rows[counter - 1].Cells["ValorLiq"].Value = valorLiq.ToString("C");
            }
            lblTotalBruto.Text = Math.Round(totalBruto,2).ToString("C");
            lblTotalDesconto.Text = Math.Round(totalDesconto, 2).ToString("C");
            lblTotalLiquido.Text = Math.Round(totalLiquido, 2).ToString("C");
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btBuscarCobrancas_Click(object sender, EventArgs e)
        {
            ImportarJson();
        }


        void ImportarJson()
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            IList<Cobranca> lista;

            using (StreamReader file = File.OpenText(dialog.FileName))
            {
                var serializer = new JsonSerializer();
                lista = (IList<Cobranca>) serializer.Deserialize(file, typeof(IList<Cobranca>));
            }

            Grid.Rows.Clear();
            foreach (var item in lista)
            {
                var row = Grid.Rows.Add();

                Grid.Rows[row].Cells["colDocumento"].Value = item.Documento;
                Grid.Rows[row].Cells["BomPara"].Value = item.DataVcto.ToString("dd/MM/yyyy");
                Grid.Rows[row].Cells["ValorBruto"].Value = item.Valor;

            }
            Calcular(0,0);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            ExportarHtml(Grid);
        }

        void ExportarExcel()
        {
            var salvar = new SaveFileDialog();


            Excel_.Application App; // Aplicação Excel
            Excel_.Workbook WorkBook; // Pasta
            Excel_.Worksheet WorkSheet; // Planilha
            object misValue = System.Reflection.Missing.Value;

            App = new Excel_.Application();
            WorkBook = App.Workbooks.Add(misValue);
            WorkSheet = (Excel_.Worksheet)WorkBook.Worksheets.get_Item(1);
            var i = 0;
            var j = 0;

            // passa as celulas do DataGridView para a Pasta do Excel
            for (i = 0; i <= Grid.RowCount - 1; i++)
            {
                for (j = 0; j <= Grid.ColumnCount - 1; j++)
                {
                    var cell = Grid[j, i];
                    WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            // define algumas propriedades da caixa salvar
            salvar.Title = "Exportar para Excel";
            salvar.Filter = "Arquivo do Excel *.xls | *.xls";
            salvar.ShowDialog(); // mostra

            // salva o arquivo
            WorkBook.SaveAs(salvar.FileName, Excel_.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,

            Excel_.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            WorkBook.Close(true, misValue, misValue);
            App.Quit(); // encerra o excel

            MessageBox.Show("Exportado com sucesso!");
            

        }

        void ExportarHtml(DataGridView dgv)
        {
            var caminho = Path.Combine(Application.StartupPath, "relat.html");
            var r = new StreamWriter(caminho, false);

            var fonte = dgv.ColumnHeadersDefaultCellStyle.Font;
            var tabSize = 0;
            foreach (DataGridViewColumn col in dgv.Columns)
                if (col.Visible) tabSize += col.Width;

            var conteudo = new string[dgv.Columns.Count];

            r.WriteLine("<html><head>");
            r.WriteLine("<meta http-equiv='Content-Type' "
                + "content='text/html; charset=utf-8' />");
            r.WriteLine("<title>" + dgv.Name + "</title>");
            r.WriteLine("</head><body>");

            r.WriteLine("<div style='position:static'>");
            r.WriteLine("<table style='border-collapse: collapse; width:" + tabSize.ToString() + "px'>");
            r.WriteLine("<tr>");
            r.WriteLine("<td style='padding: 2px 2px 2px 2px; "
                                   + "font-weight:bold; font-size:"
                                   + Convert.ToInt32(fonte.Size + 3).ToString()
                                   + "px; border-collapse: collapse; ' align='center' colspan='" + Grid.ColumnCount + "'>");
            r.WriteLine("<font face='" + fonte.Name + "'>");
            r.WriteLine(txtData.Value.ToString("dd/MM/yyyy"));
            r.WriteLine("</font>");
            r.WriteLine("</tr>");
            r.WriteLine("<tr>");

            foreach (DataGridViewColumn coluna in dgv.Columns)
            {
                if (coluna.Visible)
                {
                    r.WriteLine("<td style='padding: 2px 2px 2px 2px; "
                        + "font-weight:bold; font-size:"
                        + Convert.ToInt32(fonte.Size + 3).ToString()
                        + "px; border-collapse: collapse; ' align='"
                        + coluna.InheritedStyle.Alignment.ToString().Substring(6,
                            coluna.InheritedStyle.Alignment.ToString().Length - 6)
                        + "' width='" + coluna.Width + "'>");
                    r.WriteLine("<font face='" + fonte.Name + "'>");
                    r.WriteLine(coluna.HeaderText.ToString());
                    r.WriteLine("</font>");
                    r.WriteLine("</td>");
                }
            }
            r.WriteLine("</tr>");
            if (dgv.Rows.Count > 0)
            {
                foreach (DataGridViewRow linha in dgv.Rows)
                {
                    r.WriteLine("<tr>");
                    foreach (DataGridViewCell celula in linha.Cells)
                    {
                        if (celula.Visible)
                        {
                            r.WriteLine("<td style='padding: 2px 2px 2px 2px; font-size:"
                                + Convert.ToInt32(fonte.Size + 3).ToString()
                                + "; border-collapse: collapse; ' align='"
                                + celula.InheritedStyle.Alignment.ToString().Substring(6,
                                    celula.InheritedStyle.Alignment.ToString().Length - 6)
                                + "' width='" + celula.Size.Width + "'>");
                            r.Write("<font face='" + fonte.Name + "'>"
                                + celula.FormattedValue.ToString() + "</font>");
                            r.WriteLine("</td>");
                        }
                    }
                    r.WriteLine("</tr>");
                }
            }
            r.WriteLine("</table></div><br><br><br>");
            r.WriteLine("<div style='position:static font-weight:bold; font-size:" + Convert.ToInt32(fonte.Size + 4).ToString() + "'>");
            r.WriteLine("<font face = '" + fonte.Name + "' > ");
            r.WriteLine("Total Bruto: " + lblTotalBruto.Text + "<br>");
            r.WriteLine("Total Desconto: " + lblTotalDesconto.Text + "<br>");
            r.WriteLine("Total Liquido: " + lblTotalLiquido.Text + "<br>");
            r.WriteLine("</div>");
            r.WriteLine("</body></html>");
            r.Close();

            using (var p = new Process { StartInfo = new ProcessStartInfo(caminho) })
            {
                p.StartInfo.UseShellExecute = true;
                p.Start();
            }
        }

        private void TxtTaxaJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != ',' || !Decimal.TryParse(txtTaxaJuros.Text + ch, out x))
            {                
                e.Handled = true;
            }
            if (txtTaxaJuros.Text.Contains(".") && ch == '.') {
                e.Handled = true;
            }
        }
    }
}
