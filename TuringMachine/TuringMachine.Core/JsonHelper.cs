namespace Turing.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Json;
    using System.IO;

    public class JsonHelper
    {
        public static string JsonSerializer<T>(T t)
        {
            DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();

            settings.EmitTypeInformation = System.Runtime.Serialization.EmitTypeInformation.Always;

            DataContractJsonSerializer ser = new DataContractJsonSerializer(t.GetType(), settings);

            MemoryStream ms = new MemoryStream();

            ser.WriteObject(ms, t);

            string jsonString = Encoding.UTF8.GetString(ms.ToArray());

            ms.Close();

            return jsonString;
        }
    }
}
