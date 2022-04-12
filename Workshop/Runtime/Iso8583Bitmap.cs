using System;

namespace DefaultNamespace
{
    public class Iso8583Bitmap
    {
        readonly string bitmap;
        
        public Iso8583Bitmap(string bitmap)
        {
            this.bitmap = bitmap;
        }

        public string Hex => FromBinaryToHex(bitmap);

        static string FromBinaryToHex(string source)
        {
            while(source.Length % 4 != 0)
                source = '0' + source;
            
            var result = string.Empty;
            for(var i = 0; i < source.Length; i += 4)
            {
                var hex = Convert.ToInt32(source.Substring(i, 4), 2).ToString("X");
                result += hex;
            }

            return result;
        }
    }
}