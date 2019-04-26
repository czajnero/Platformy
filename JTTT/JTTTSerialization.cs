using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Data;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace JTTT
{
    class JtttSerialization
    {

        public void Serialize(object data, string filename)
        {
            Log Jtttlog = new Log();
            FileStream fileStream = new FileStream(filename, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            try
            {
                binaryFormatter.Serialize(fileStream, data);

            }
            catch(SerializationException ex)
            {

                Jtttlog.log("Unsuccessful attempt to serialize " + ex.Message);
            }
            finally
            {
                fileStream.Close();
            }
        }

       public object Deserialize( string filename)
        {
            Log Jtttlog = new Log();

            FileStream fileStream = new FileStream(filename, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            try
            {
                return binaryFormatter.Deserialize(fileStream);

            }
            catch (SerializationException ex)
            {

                Jtttlog.log("Unsuccessful attempt to deserialize " + ex.Message);
            }
            finally
            {
                fileStream.Close(); 
            }
            return null; 
        }

    }
}
