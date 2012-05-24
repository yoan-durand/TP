using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

namespace durand_yBugTrack.DataAccess
{
    public class GenerateDocx
    {
        public static string GenerateReportBug(DBO.BugReport bugReport)
        {
            string docName = System.Web.HttpContext.Current.Server.MapPath("~/download/")+"test.docx"; 
            using (WordprocessingDocument package = WordprocessingDocument.Create( docName, WordprocessingDocumentType.Document)) 
            {
                Run run = new Run();

             //besoin de le faire si c'est une creation 
                package.AddMainDocumentPart(); 
                 foreach (string str in bugReport.Comment)
                {
                    run.Append(new Text(str), new Break());
	            }
                // Création du document. 
                package.MainDocumentPart.Document = 
                    new Document( 
                        new Body( 
                            new Paragraph( 
                                new Run( 
                                    new Text("Rapport de bug"))),
                                    new Run(
                                        new Text ("Titre :" + bugReport.Title),
                                        new Break(),
                                        new Text ("Personnable responble :" + bugReport.Responsable),
                                        new Break(),
                                        new Text ("Statut :" + bugReport.Statut),
                                        new Break (),
                                        new Text ("commentaire:")
                                        ),run)); 

                
                // Enregistrer le contenu dans le document  
                package.MainDocumentPart.Document.Save();
                return docName;
            }
        }
    }
}