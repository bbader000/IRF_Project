using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bead_program.Entities
{
    public class CSVWriter
    {

        public void writeCSV(BindingList<County> resultCounties)
        {

            List<CountyResult> tempList = new List<CountyResult>();

            for (int i = 0; i < resultCounties.Count; i++)
            {
                CountyResult temp = new CountyResult()
                {
                    name = resultCounties[i].name,
                    value = resultCounties[i].value,
                    oldvalue = resultCounties[i].oldvalue,
                    owner = resultCounties[i].owner,
                    mush = resultCounties[i].mush,
                    income = resultCounties[i].income,
                };



                tempList.Add(temp);
            }

            using (var mem = new MemoryStream())
            using (var writer = new StreamWriter("ertekelo.csv"))
            using (var csvWriter = new CsvWriter(writer, System.Globalization.CultureInfo.CurrentCulture))
            {
                csvWriter.Configuration.Delimiter = ";";

                csvWriter.WriteField("Megye");
                csvWriter.WriteField("Vetelar");
                csvWriter.WriteField("Eredeti ar");
                csvWriter.WriteField("Jogosult");
                csvWriter.WriteField("Goma mennyiseg (kg)");
                csvWriter.WriteField("Bevetel");
                csvWriter.NextRecord();

                foreach (CountyResult project in tempList)
                {
                    csvWriter.WriteField(project.name);
                    csvWriter.WriteField(project.value);
                    csvWriter.WriteField(project.oldvalue);
                    csvWriter.WriteField(project.owner);
                    csvWriter.WriteField(project.mush);
                    csvWriter.WriteField(project.income);
                    csvWriter.NextRecord();
                }

                writer.Flush();
                var result = Encoding.UTF8.GetString(mem.ToArray());
                Console.WriteLine(result);
            }


        }


    }
       


        
}
