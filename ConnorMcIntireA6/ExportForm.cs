using System.Xml.Serialization;
using System.Text.Json;
using ConnorMcIntireA6.JSON;
using System.Text;
using System.Xml;

namespace ConnorMcIntireA6
{
    public partial class ExportForm : Form
    {

        List<BookData> books;


        public ExportForm()
        {
            InitializeComponent();
        }


        private void chooseBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "JSON Files|*.json";
            openFileDialog.Title = "Select the JSON File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string filePath = openFileDialog.FileName;
                string data = File.ReadAllText(filePath);
                books = JsonSerializer.Deserialize<List<BookData>>(data);


                if (books.Count > 0)
                {
                    fileLbl.Text = "Data was added successfully";
                }
                csvButton.Visible = true;
                jsonBtn.Visible = true;
                fileLbl.Visible = true;
            }

            totalLbl.Text = "Total Mapped Objects: " + books.Count();


        }

        private void csvButton_Click(object sender, EventArgs e)
        {

            if (books != null && books.Count > 0)
            {
                var csvContent = new StringBuilder();

                csvContent.AppendLine("Title,Author,Page Length,Genre,Year Published,MSRP");

                foreach (var book in books)
                {
                    string row = $"{book.Title},{book.Author},{book.Length},{book.Genre},{book.Year},{book.Msrp}";
                    csvContent.AppendLine(row);
                }


                using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
                {
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {

                        string selectedDirectory = folderBrowser.SelectedPath;
                        string filePath = Path.Combine(selectedDirectory, "BookData.csv");

                        File.WriteAllText(filePath, csvContent.ToString());

                        csvLbl.Text = "Success";
                        csvLbl.Visible = true;
                    }
                }
            }
            else
            {
                csvLbl.Text = "Fail";
                csvLbl.Visible = true;
            }


        }

        private void jsonBtn_Click(object sender, EventArgs e)
        {
            if (books != null && books.Count > 0)
            {

                var options = new JsonSerializerOptions { WriteIndented = true };
                string newJsonData = JsonSerializer.Serialize(books, options);




                using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
                {
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {

                        string selectedDirectory = folderBrowser.SelectedPath;
                        string filePath = Path.Combine(selectedDirectory, "BookData.json");

                        File.WriteAllText(filePath, newJsonData.ToString());

                        jsonLbl.Text = "Success";
                        jsonLbl.Visible = true;
                    }
                }
            }
            else
            {
                jsonLbl.Text = "Fail";
                jsonLbl.Visible = true;
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (books == null)
            {
                totalLbl.Text = "Total Mapped Objects: 0";
            }
            else
            {
                totalLbl.Text = "Total Mapped Objects: " + books.Count();
            }

        }
    }
}