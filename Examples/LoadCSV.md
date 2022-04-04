```cs
using Microsoft.VisualBasic.FileIO;

        public void LoadCSV(string path)
        {
            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.ReadFields(); // Skip first line

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    // do something.. with fields
                }
            }
        }

```