using System;
using System.Collections.Generic;
using FileManager.Models;

namespace FileManager
{
    public static class DataReader
    {
        public static List<Plant> ReadPlantData()
        {

            var allPlants = new List<Plant>();
            //const string connectionString = "";
            //var queryString = "SELECT EmpNo, EName FROM Emp";
            //using (var connection = new OracleConnection(connectionString))
            //{
            //    var command = new OracleCommand(queryString, connection);
            //    connection.Open();
            //    using (var reader = command.ExecuteReader())
            //    {
            //        // Always call Read before accessing data.
            //        while (reader.Read())
            //        {
            //            Console.WriteLine(reader.GetInt32(0) + ", " + reader.GetString(1));
            //        }
            //    }
            //}

            var reader = DataReaderGenerator.Plants();
            while (reader.Read())
            {
                var plant = new Plant();
                plant.Name = reader["name"] as string;
                plant.ID = reader["id"] as string;
                plant.Description = reader["desc"] as string;

                allPlants.Add(plant);
            }
            return allPlants;
        }

        public static List<Area> ReadAreaData()
        {
            var allAreas = new List<Area>();
            
            var reader = DataReaderGenerator.Areas();
            while (reader.Read())
            {
                var area = new Area();
                area.Name = reader["name"] as string;
                area.ID = reader["id"] as string;
                area.Description = reader["desc"] as string;
                area.PlantId = reader["plant_id"] as string;
                allAreas.Add(area);
            }
            return allAreas;
        }

        public static List<Unit> ReadUnitData()
        {
            var allUnits = new List<Unit>();

            var reader = DataReaderGenerator.Units();
            while (reader.Read())
            {
                var unit = new Unit();
                unit.Name = reader["name"] as string;
                unit.ID = reader["id"] as string;
                unit.Description = reader["desc"] as string;
                unit.AreaId = reader["area_id"] as string;
                allUnits.Add(unit);
            }
            return allUnits;
        }

        internal static List<Tag> ReadTagData()
        {
            var allTags = new List<Tag>();

            var reader = DataReaderGenerator.Tags();
            while (reader.Read())
            {
                var tag = new Tag();
                tag.Name = reader["name"] as string;
                tag.ID = reader["id"] as string;
                tag.Description = reader["desc"] as string;
                tag.UnitId = reader["unit_id"] as string;
                allTags.Add(tag);
            }
            return allTags;
        }

        public static List<DMSVersion> ReadDocData()
        {
            var dmsVersions = new List<DMSVersion>();

            var reader = DataReaderGenerator.Docs();
            while (reader.Read())
            {
                var dmsVersion = new DMSVersion();
                dmsVersion.Name = reader["name"] as string;
                dmsVersion.ID = reader["id"] as string;
                dmsVersion.Description = reader["desc"] as string;
                dmsVersion.UnitId = reader["unit_id"] as string;
                dmsVersion.TagId = reader["tag_id"] as string;
                dmsVersions.Add(dmsVersion);
            }
            return dmsVersions;
        }
    }
}
