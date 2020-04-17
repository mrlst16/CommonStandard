using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace CommonStandard.Helpers
{
    public static class FileHelper
    {

        public static bool TryLoadEmbeddedResource<TCaller>(string fileName, out string result)
        {
            result = null;
            try
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(TCaller)).Assembly;
                Stream stream = assembly.GetManifestResourceStream(fileName);
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
