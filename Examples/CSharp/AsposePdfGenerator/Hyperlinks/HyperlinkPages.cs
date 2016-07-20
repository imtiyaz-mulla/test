using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Hyperlinks
{
    public class HyperlinkPages
    {
        public static void Run()
        {            
            // ExStart:HyperlinkPages
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Hyperlinks();

            // Instantiate Pdf document object 
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf(); 
            // Create a section in the Pdf
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add(); 

            // Create text paragraph with the reference of a section
            Aspose.Pdf.Generator.Text text1 = new Aspose.Pdf.Generator.Text(sec1); 

            // Add the text paragraph in the paragraphs collection of the section
            sec1.Paragraphs.Add(text1); 

            // Create a text segment
            Aspose.Pdf.Generator.Segment segment1 = new Aspose.Pdf.Generator.Segment();

            // Add a text segment in the text paragraph
            segment1 = text1.Segments.Add("this is a local link"); 

            // Set the text in the text segment to be underlined
            segment1.TextInfo.IsUnderline = true; 

            // Set the link type of the text segment to Local 
            segment1.Hyperlink.LinkType = Aspose.Pdf.Generator.HyperlinkType.Local; 

            // Assign the id of the desired paragraph as a target id for the text segment
            segment1.Hyperlink.TargetID = "product1"; 

            // Create a text paragraph to be linked with the text segment
            Aspose.Pdf.Generator.Text text3 = new Aspose.Pdf.Generator.Text(sec1,"product 1 info ..."); 

            // Add the text paragraph to paragraphs collection of the section
            sec1.Paragraphs.Add(text3); 

            // Set this paragraph to be the first so that it can be displayed in a separate
            // page in the document
            text3.IsFirstParagraph = true; 

            // Set the id of this text paragraph to "product1"
            text3.ID = "product1"; 
            dataDir = dataDir + "HyperlinkPages_out_.pdf";
            // Save the Pdf
            pdf1.Save(dataDir);
            // ExEnd:HyperlinkPages           
        }
    }
}