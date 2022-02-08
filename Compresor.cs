#region Declare Using
using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
#endregion

namespace CompresorAC
{
    public partial class Compresor : Form
    {
        #region Declare vars
        public bool bFolder { get; set; }
        #endregion

        #region Initialize Components
        public Compresor()
        {
            InitializeComponent();
        }
        #endregion

        #region Valid Field in Window
        private bool IsFormValid()
        {
            if (this.txtFolder.Text.Trim() == string.Empty)
            {
                MessageBox.Show("La carpeta de trabajo del usuario no puede quedar vacia...", "Esta información es necesaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        #endregion

        #region Buttom events
        private void btnCarpetas_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.txtFolder.Text = fbd.SelectedPath;
                    bFolder = true;
                }
            }

            lbltotalarchivos.Text = "";
        }

        private void btnZip_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                SaveFileDialog savefiles = new SaveFileDialog();
                savefiles.Title = "Guardar archivo comprimido";
                savefiles.Filter = "Archivos comprimidos zip|*.zip";

                if (savefiles.ShowDialog().Equals(DialogResult.OK))
                {
                    int SkipFiles = 0, CounterFile = 1, ItemFile = 0, cntCount = 1;
                    int.TryParse(this.txtZips.Text, out SkipFiles);

                    DirectoryInfo dirInfo = new DirectoryInfo(this.txtFolder.Text);
                    int countFiles = dirInfo.GetFiles("*.*", SearchOption.AllDirectories).Count();

                    progressBar.Maximum = countFiles;

                    List<string> filesToArchive = new List<string>();
                    string archivoZip = Path.GetFileNameWithoutExtension(savefiles.FileName) + CounterFile.ToString() + ".zip";
                    string archivozipped = Path.Combine(Path.GetDirectoryName(savefiles.FileName), archivoZip);

                    foreach (var archivo in dirInfo.GetFiles("*.*", SearchOption.AllDirectories))
                    {
                        if (archivo.Extension != ".ini")
                        {
                            filesToArchive.Add(archivo.FullName);
                            ItemFile++;
                        }
                        if (ItemFile == SkipFiles && cntCount < countFiles)
                        {
                            AddToArchive(archivozipped, filesToArchive, CompressionLevel.Optimal);
                            ItemFile = 0;
                            CounterFile++;
                            archivoZip = Path.GetFileNameWithoutExtension(savefiles.FileName) + CounterFile.ToString() + ".zip";
                            archivozipped = Path.Combine(Path.GetDirectoryName(savefiles.FileName), archivoZip);
                            filesToArchive = new List<string>();
                        }
                        else if (ItemFile != SkipFiles && cntCount >= countFiles)
                        {
                            AddToArchive(archivozipped, filesToArchive, CompressionLevel.Optimal);
                        }
                        progressBar.Value = cntCount;
                        cntCount++;

                        lbltotalarchivos.Text = "OK... Total Archivos comprimidos : " + cntCount.ToString();
                    }
                    MessageBox.Show("El proceso ha finalizado...", "Fin de proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region AddToArchive
        public static void AddToArchive(string archiveFullName, List<string> files, CompressionLevel compression = CompressionLevel.Optimal)
        {
            ZipArchiveMode mode = ZipArchiveMode.Create;

            if (File.Exists(archiveFullName)) File.Delete(archiveFullName);

            using (ZipArchive zipFile = ZipFile.Open(archiveFullName, mode))
            {
                foreach (string file in files)
                {
                    zipFile.CreateEntryFromFile(file, Path.GetFileName(file), compression);
                }
            }
        }
        #endregion
    }
}
