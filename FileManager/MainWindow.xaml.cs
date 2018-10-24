using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using FileManager.Database;
using FileManager.Models;
using MahApps.Metro.Controls;
using Path = System.IO.Path;

namespace FileManager
{
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
            Tags=new List<Tag>();
            Docs=new List<DMSVersion>();
            AddElementsInList();
            BindDummyDataForDropDown();
        }

        //private void AddElementsInList()
        //{
        //    Tags.Add(new Tag()
        //    {
        //        Check_Status = false, Description = "PlantA-AreaA-UnitA-0001-IKEA", ID = "PlantA-AreaA-UnitA-0001-IKEA", Name = "PlantA-AreaA-UnitA-0001-IKEA",
        //        Files = new List<IDMSFile>()
        //        {
        //            new DMSFile()
        //            {
        //                Name = "IKEA Store Hyd",
        //                FilePath = "IKEA.jpg",
        //                Description = "IKEA-02-A1"
        //            }
        //        }
        //    });
        //    Tags.Add(new Tag()
        //    {
        //        Check_Status = false, Description = "PlantA-AreaA-UnitA-0002-MetroHyd", ID = "PlantA-AreaA-UnitA-0002-MetroHyd", Name = "PlantA-AreaA-UnitA-0002-MetroHyd",
        //        Files = new List<IDMSFile>()
        //        {
        //            new DMSFile()
        //            {
        //                Name = "MetroHyd structure",
        //                FilePath = "Metro.jpg",
        //                Description = "L&TMetroHYD-02-A1"
        //            }
        //        }
        //    });
        //    Tags.Add(new Tag()
        //    {
        //        Check_Status = false, Description = "PlantA-AreaA-UnitA-0003-P&GPlantHyd", ID = "PlantA-AreaA-UnitA-0003-P&GPlantHyd", Name = "PlantA-AreaA-UnitA-0003-P&GPlantHyd",
        //        Files = new List<IDMSFile>()
        //        {
        //            new DMSFile()
        //            {
        //                Name = "P&GPlantHyd",
        //                FilePath = "P&G to build largest Indian plant in Hyderabad - The Economic Times.pdf",
        //                Description = "P&GPlantHyd-03-A2"
        //            }
        //        }
        //    });
        //    Tags.Add(new Tag()
        //    {
        //        Check_Status = false, Description = "PlantA-AreaA-UnitA-0004-RGIATopView", ID = "PlantA-AreaA-UnitA-0004-RGIATopView", Name = "PlantA-AreaA-UnitA-0004-RGIATopView",
        //        Files = new List<IDMSFile>()
        //        {
        //            new DMSFile()
        //            {
        //                Name = "RGIATopView",
        //                FilePath = "RGIA.jpg",
        //                Description = "RGIA-view-01-B1"
        //            }
        //        }
        //    });
        //    Tags.Add(new Tag()
        //    {
        //        Check_Status = false, Description = "PlantA-AreaA-UnitA-0005-HydBusiness", ID = "PlantA-AreaA-UnitA-0005-HydBusiness", Name = "PlantA-AreaA-UnitA-0005-HydBusiness",
        //        Files = new List<IDMSFile>()
        //        {
        //            new DMSFile()
        //            {
        //                Name = "HydBusiness-01-C1",
        //                FilePath = "StockUpdate.jpg",
        //                Description = "HydBusiness-01-C1"
        //            }
        //        }
        //    });


        //    Docs.Add(new DMSVersion()
        //    {
        //        Check_Status = false,
        //        Description = "PlantA-AreaA-UnitA-0001-IKEA Design Doc",
        //        ID = "PlantA-AreaA-UnitA-0001-IKEA",
        //        Name = "PlantA-AreaA-UnitA-0001-IKEA Design Doc",
        //        Files = new List<IDMSFile>()
        //        {
        //            new DMSFile()
        //            {
        //                Name = "IKEA Store Hyd",
        //                FilePath = "IKEA.jpg",
        //                Description = "IKEA-02-A1"
        //            }
        //        }
        //    });
        //    Docs.Add(new DMSVersion()
        //    {
        //        Check_Status = false,
        //        Description = "PlantA-AreaA-UnitA-0002-MetroHyd Layout Design",
        //        ID = "PlantA-AreaA-UnitA-0002-MetroHyd",
        //        Name = "PlantA-AreaA-UnitA-0002-MetroHyd Layout Design",
        //        Files = new List<IDMSFile>()
        //        {
        //            new DMSFile()
        //            {
        //                Name = "MetroHyd structure",
        //                FilePath = "Metro.jpg",
        //                Description = "L&TMetroHYD-02-A1"
        //            }
        //        }
        //    });
        //    Docs.Add(new DMSVersion()
        //    {
        //        Check_Status = false,
        //        Description = "PlantA-AreaA-UnitA-0003-P&GPlantHyd P&ID Design ",
        //        ID = "PlantA-AreaA-UnitA-0003-P&GPlantHyd",
        //        Name = "PlantA-AreaA-UnitA-0003-P&GPlantHyd P&ID Design",
        //        Files = new List<IDMSFile>()
        //        {
        //            new DMSFile()
        //            {
        //                Name = "P&GPlantHyd",
        //                FilePath = "P&G to build largest Indian plant in Hyderabad - The Economic Times.pdf",
        //                Description = "P&GPlantHyd-03-A2"
        //            }
        //        }
        //    });
        //    Docs.Add(new DMSVersion()
        //    {
        //        Check_Status = false,
        //        Description = "PlantA-AreaA-UnitA-0004-RGIA SPI Loop",
        //        ID = "PlantA-AreaA-UnitA-0004-RGIATopView",
        //        Name = "PlantA-AreaA-UnitA-0004-RGIA SPI Loop",
        //        Files = new List<IDMSFile>()
        //        {
        //            new DMSFile()
        //            {
        //                Name = "RGIATopView",
        //                FilePath = "RGIA.jpg",
        //                Description = "RGIA-view-01-B1"
        //            }
        //        }
        //    });
        //    Docs.Add(new DMSVersion()
        //    {
        //        Check_Status = false,
        //        Description = "PlantA-AreaA-UnitA-0005-PO Invoice Status doc",
        //        ID = "PlantA-AreaA-UnitA-0005-HydBusiness",
        //        Name = "PlantA-AreaA-UnitA-0005-PO Invoice Status doc",
        //        Files = new List<IDMSFile>()
        //        {
        //            new DMSFile()
        //            {
        //                Name = "HydBusiness-01-C1",
        //                FilePath = "StockUpdate.jpg",
        //                Description = "HydBusiness-01-C1"
        //            }
        //        }
        //    });
        //}

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
