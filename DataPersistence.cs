using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Assignment3_Bank_App
{
    // Handles saving and loading data
    public static class DataPersistence
    {
        // Folder path
        private static readonly string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

        // File path
        private static readonly string filePath = Path.Combine(folderPath, "bank_data.xml");

        // Save customers to XML
        public static void SaveData(List<Customer> customers)
        {
            // Create folder if not exists
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            // Create serializer
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

            // Write data to file
            using (FileStream file = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(file, customers);
            }
        }

        // Load customers from XML
        public static List<Customer> LoadData()
        {
            // Create folder if not exists
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            // Return empty if file not found
            if (!File.Exists(filePath))
                return new List<Customer>();

            // Create serializer
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));

            // Read data from file
            using (FileStream file = new FileStream(filePath, FileMode.Open))
            {
                return (List<Customer>)serializer.Deserialize(file);
            }
        }
    }
}