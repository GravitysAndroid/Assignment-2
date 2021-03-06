﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Two
{
    [Serializable]
    public class ClsCompanyData
    {
        private static string fileNameTour = "TourStorage";
        private static Dictionary<string, ClsTour> _TourList = new Dictionary<string, ClsTour>();

        public static Dictionary<string, ClsTour> TourList
        {
            get => _TourList;
        }

        public static void Save()
        {
            using (FileStream lcFileStream = new FileStream(fileNameTour, FileMode.Create))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcFormatter.Serialize(lcFileStream, _TourList);
            }
        }

        public static void Retreive()
        {
            using (FileStream lcFileStream = new FileStream(fileNameTour, FileMode.Open))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                _TourList = (Dictionary<string, ClsTour>)lcFormatter.Deserialize(lcFileStream);
            }
        }
    }  
}
