using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.IO;

namespace PDFMerger
{
    public partial class PdfMergerForm : Form
    {
        
        private List<string> pdfPaths = new List<string>();

        public PdfMergerForm()
        {       
            InitializeComponent();
        }

        private List<int> GetAllIndices()
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < listBox.Items.Count; i++) indices.Add(i);
            return indices;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Arquivos PDF (*.pdf)|*.pdf"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in dialog.FileNames)
                {
                    pdfPaths.Add(file);
                    listBox.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            try { 
                if(listBox.Items.Count == 0)
                {
                    throw new IOException("Não é possível salvar um PDF vazio!");
                }
                    SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "PDF unificado (*.pdf)|*.pdf"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                   PdfDocument output = new PdfDocument();

                   var indices = listBox.SelectedIndices.Count > 0 ? listBox.SelectedIndices.Cast<int>().ToList() : GetAllIndices();
                   foreach (int index in indices)
                   {
                      string path = pdfPaths[index];
                     PdfDocument input = PdfReader.Open(path, PdfDocumentOpenMode.Import);

                      for (int i = 0; i < input.PageCount; i++)
                      {
                           output.AddPage(input.Pages[i]);
                        }
                 }

                output.Save(saveDialog.FileName);
                MessageBox.Show("PDF unificado salvo com sucesso!");
                 }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            pdfPaths.Clear();
            listBox.Items.Clear();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string itemSelecionado = listBox.SelectedItem.ToString();
                // Faça algo com o item selecionado, por exemplo:
                if((MessageBox.Show("Item selecionado: " + itemSelecionado + " Deseja excluir?", "Excluir item?",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)){
                    listBox.Items.Remove(listBox.SelectedItem);
                    listBox.Refresh();
                }
            }
        }
    }
}
