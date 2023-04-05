﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace modul6_kelompok_6
{
    public class DataMahasiswa1302204038
    {
        public class DataMahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public string address { get; set; }
            public string courses { get; set; }
        }
        public void ReadJSON()
        {
            string file = "jurnal6_1_1302204038.json";
            string dataStr = File.ReadAllText(file);
            DataMahasiswa dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(dataStr);
            Console.WriteLine($"First Name {dataMahasiswa.firstName} Last Name {dataMahasiswa.lastName} Gender {dataMahasiswa.gender} Address {dataMahasiswa.address} Courses {dataMahasiswa.courses}");
        }
    }
}
