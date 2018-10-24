using System.Data;

namespace FileManager
{
    public static class DataReaderGenerator
    {
        public static IDataReader Plants()
        {
            var plantsDataTable = new DataTable();
            plantsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "name",
                DataType = typeof(string)
            });
            plantsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "id",
                DataType = typeof(string)
            });
            plantsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "desc",
                DataType = typeof(string)
            });
            //plantsDataTable.Columns.Add(new DataColumn()
            //{
            //    ColumnName = "check_status",
            //    DataType = typeof(bool)
            //});

            plantsDataTable.Rows.Add("PLANT1", "1", "THIS IS PLANT 1");
            plantsDataTable.Rows.Add("PLANT2", "2", "THIS IS PLANT 2");
            plantsDataTable.Rows.Add("PLANT3", "3", "THIS IS PLANT 3");
            plantsDataTable.Rows.Add("PLANT4", "4", "THIS IS PLANT 4");
            plantsDataTable.Rows.Add("PLANT5", "5", "THIS IS PLANT 5");
            plantsDataTable.Rows.Add("PLANT6", "6", "THIS IS PLANT 6");

            return plantsDataTable.CreateDataReader();
        }

        public static IDataReader Areas()
        {
            var areasDataTable = new DataTable();
            areasDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "name",
                DataType = typeof(string)
            });
            areasDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "id",
                DataType = typeof(string)
            });
            areasDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "desc",
                DataType = typeof(string)
            });
            areasDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "plant_id",
                DataType = typeof(string)
            });

            areasDataTable.Rows.Add("AREA1", "1", "THIS IS AREA 1", "1");
            areasDataTable.Rows.Add("AREA2", "2", "THIS IS AREA 2", "1");
            areasDataTable.Rows.Add("AREA3", "3", "THIS IS AREA 3", "2");
            areasDataTable.Rows.Add("AREA4", "4", "THIS IS AREA 4", "3");
            areasDataTable.Rows.Add("AREA5", "5", "THIS IS AREA 5", "4");
            areasDataTable.Rows.Add("AREA6", "6", "THIS IS AREA 6", "5");
            areasDataTable.Rows.Add("AREA7", "7", "THIS IS AREA 7", "6");

            return areasDataTable.CreateDataReader();
        }

        public static IDataReader Units()
        {
            var unitsDataTable = new DataTable();
            unitsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "name",
                DataType = typeof(string)
            });
            unitsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "id",
                DataType = typeof(string)
            });
            unitsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "desc",
                DataType = typeof(string)
            });
            unitsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "area_id",
                DataType = typeof(string)
            });

            unitsDataTable.Rows.Add("UNIT1", "1", "THIS IS UNIT 1", "1");
            unitsDataTable.Rows.Add("UNIT2", "2", "THIS IS UNIT 2", "1");
            unitsDataTable.Rows.Add("UNIT3", "3", "THIS IS UNIT 3", "2");
            unitsDataTable.Rows.Add("UNIT4", "4", "THIS IS UNIT 4", "3");
            unitsDataTable.Rows.Add("UNIT5", "5", "THIS IS UNIT 5", "4");
            unitsDataTable.Rows.Add("UNIT6", "6", "THIS IS UNIT 6", "5");
            unitsDataTable.Rows.Add("UNIT7", "7", "THIS IS UNIT 7", "6");

            return unitsDataTable.CreateDataReader();
        }


        public static IDataReader Docs()
        {
            var docsDataTable = new DataTable();
            docsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "name",
                DataType = typeof(string)
            });
            docsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "id",
                DataType = typeof(string)
            });
            docsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "desc",
                DataType = typeof(string)
            });
            docsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "unit_id",
                DataType = typeof(string)
            });
            docsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "tag_id",
                DataType = typeof(string)
            });

            docsDataTable.Rows.Add("DOC1", "1", "THIS IS DOC 1", "1","1");
            docsDataTable.Rows.Add("DOC2", "2", "THIS IS DOC 2", "1","2");
            docsDataTable.Rows.Add("DOC3", "3", "THIS IS DOC 3", "2","2");
            docsDataTable.Rows.Add("DOC4", "4", "THIS IS DOC 4", "3","3");
            docsDataTable.Rows.Add("DOC5", "5", "THIS IS DOC 5", "4","4");
            docsDataTable.Rows.Add("DOC6", "6", "THIS IS DOC 6", "5","5");
            docsDataTable.Rows.Add("DOC7", "7", "THIS IS DOC 7", "6","6");

            return docsDataTable.CreateDataReader();
        }


        public static IDataReader Tags()
        {
            var tagsDataTable = new DataTable();
            tagsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "name",
                DataType = typeof(string)
            });
            tagsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "id",
                DataType = typeof(string)
            });
            tagsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "desc",
                DataType = typeof(string)
            });
            tagsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "unit_id",
                DataType = typeof(string)
            });
            tagsDataTable.Columns.Add(new DataColumn()
            {
                ColumnName = "doc_id",
                DataType = typeof(string)
            });

            tagsDataTable.Rows.Add("TAG1", "1", "THIS IS UNIT 1", "1","1");
            tagsDataTable.Rows.Add("TAG2", "2", "THIS IS TAG 2", "1","1");
            tagsDataTable.Rows.Add("TAG3", "3", "THIS IS TAG 3", "2","2");
            tagsDataTable.Rows.Add("TAG4", "4", "THIS IS TAG 4", "3","3");
            tagsDataTable.Rows.Add("TAG5", "5", "THIS IS TAG 5", "4","4");
            tagsDataTable.Rows.Add("TAG6", "6", "THIS IS TAG 6", "5","5");
            tagsDataTable.Rows.Add("TAG7", "7", "THIS IS TAG 7", "6","6");

            return tagsDataTable.CreateDataReader();
        }
    }
}
