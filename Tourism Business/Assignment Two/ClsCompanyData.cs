using System;
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
        private static string fileName = "BusinessStorage";
        private static Dictionary<string, ClsTour> _TourList = new Dictionary<string, ClsTour>();

        public static Dictionary<string, ClsTour> TourList
        {
            get => _TourList; /*set => _TourList = value;*/
        }

        public void Save()
        {
            using (FileStream lcFileStream = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcFormatter.Serialize(lcFileStream, _TourList);
            }
        }
        public void Retreive()
        {
            using (FileStream lcFileStream = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                _TourList = (Dictionary<string, ClsTour>)lcFormatter.Deserialize(lcFileStream);
            }
        }

        private System.Collections.Generic.List<ClsTour> _TourList;

    }
}
