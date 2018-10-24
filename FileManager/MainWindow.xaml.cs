using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using FileManager.Database;
using FileManager.Models;
using log4net;
using log4net.Config;
using MahApps.Metro.Controls;
using Path = System.IO.Path;

namespace FileManager
{

    private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private List<Tag> Tags;
        private List<DMSVersion> Docs;

        public MainWindow()
        {
            InitializeComponent();
            XmlConfigurator.Configure();
            Tags =new List<Tag>();
            Docs=new List<DMSVersion>();
            AddElementsInList();
            BindDummyDataForDropDown();
        }

        private void AddElementsInList()
        {
            Tags= DataReader.ReadTagData();
            Docs= DataReader.ReadDocData();
        }
        private void BindDummyDataForDropDown()
        {
            ddltags.ItemsSource = Tags;
            ddldocs.ItemsSource = Docs;
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    FileNameTextBox.Text = dialog.SelectedPath;
                }
            }
            
        }

        private void ProcessButton_OnClickButton_Click(object sender, RoutedEventArgs e)
        {
            string vaultPath = VaultTextBox.Text;
           // throw new NotImplementedException();

            foreach (var tag in Tags.Where(x=>x.Check_Status==true))
            {
                foreach (var file in tag.Files)
                {
                    File.Copy(Path.Combine(vaultPath, file.FilePath), Path.Combine(FileNameTextBox.Text, file.FilePath), true);
                }
                
            }

            foreach (var doc in Docs.Where(x => x.Check_Status == true))
            {
                foreach (var file in doc.Files)
                {
                    File.Copy(Path.Combine(vaultPath, file.FilePath), FileNameTextBox.Text, true);
                }

            }
        }

        private void VaultBrowseButton_Click(object sender, RoutedEventArgs e)
        {
            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    VaultTextBox.Text = dialog.SelectedPath;
                }
            }
        }

        private void Plant_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

        }

        private void LoadDataClick(object sender, RoutedEventArgs e)
        {
            var plants = DataReader.ReadPlantData();
            var areas = DataReader.ReadAreaData();
            var units = DataReader.ReadUnitData();

            foreach(var area in areas)
            {
                area.Units = units.Where(x => x.AreaId == area.ID).ToList();
            }
            foreach(var plant in plants)
            {
                plant.Areas = areas.Where(x => x.PlantId == plant.ID).ToList();
            }

            Plant.DataContext = plants;

            TbitemSelection.IsSelected = true;
        }

        private void TestDatabaseConnectionClicked(object sender, RoutedEventArgs e)
        {
            var dbConnector = new DbConnector();
            dbConnector.TestConnection();
        }
    }
}
