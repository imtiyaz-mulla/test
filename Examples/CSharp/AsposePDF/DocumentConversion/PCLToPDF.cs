using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class PCLToPDF
    {
        public static void Run()
        {
            try
            {
                // ExStart:PCLToPDF
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();

                // Instantiate LoadOption object using PCL load option
                Aspose.Pdf.LoadOptions loadopt = new Aspose.Pdf.PclLoadOptions();

                // Create Document object
                Aspose.Pdf.Document doc = new Aspose.Pdf.Document(dataDir + "hidetext.pcl", loadopt);

                // Save the resultant PDF document
                doc.Save(dataDir + "PCLToPDF_out.pdf");
                // ExEnd:PCLToPDF
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}