using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using System.Diagnostics;

namespace lesson3
{
    class CsvParser
    {
        public static List<Barcelona> Parse(string filePath, bool shouldParseId)
        {
            List<Barcelona> table = new List<Barcelona>();
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                var isFirstLine = true;
                while (!parser.EndOfData)
                {

                    string[] fields = parser.ReadFields();

                    if(isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }


                    if (fields.Length < 7)
                    {
                        continue;
                    }

                    try
                    {
                        int id = shouldParseId ?
                            Convert.ToInt32(fields[0].Split('/').Last()) :
                            Convert.ToInt32(fields[0]);

                        table.Add(new Barcelona(id, fields[1], fields[2], fields[3], fields[4],
                            Convert.ToDouble(fields[5], CultureInfo.InvariantCulture), Convert.ToDouble(fields[6], CultureInfo.InvariantCulture)));
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                }
            }

            return table;
        }
    }
}
