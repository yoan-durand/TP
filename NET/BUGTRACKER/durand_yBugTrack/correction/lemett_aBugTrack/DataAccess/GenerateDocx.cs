using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using System.Text;

namespace lemett_aBugTrack.DataAccess
{
    public class GenerateDocx
    {
        /// <summary>
        /// permet de générer le rapport de bug
        /// </summary>
        /// <param name="bugReport">la structure contenant les informations du report</param>
        /// <returns>le nom du fichier si tout se passe bien sinon une chaine vide</returns>
        public static string GenerateReportBug(DBO.BugReport bugReport)
        {
            Guid fileName = Guid.NewGuid();
            StringBuilder path = new StringBuilder();
            path.Append(HttpContext.Current.Server.MapPath("./Download/"));
            path.Append(fileName + ".docx");
            try
            {

                using (WordprocessingDocument package = WordprocessingDocument.Create(path.ToString(), WordprocessingDocumentType.Document))
                {

                    // Ajouter une partie de contenu au document 
                    package.AddMainDocumentPart();

                    // Créer le contenu de votre document 
                    package.MainDocumentPart.Document =
                        new Document(
                            new Body(
                                new Paragraph(new ParagraphProperties(new ParagraphStyleId() { Val = "Title" }),
                                    new Run(
                                        new Text("Rapport de bug")))));//génération du titre



                    package.MainDocumentPart.Document.Save();

                    //construction du style
                    StyleDefinitionsPart stylePart = package.MainDocumentPart.AddNewPart<StyleDefinitionsPart>();
                    
                    Styles styles = new Styles(
                            new Style(
                            new Name() { Val = "Title" },
                            new BasedOn() { Val = "Normal" },
                            new NextParagraphStyle() { Val = "Normal" },
                            new LinkedStyle() { Val = "TitleChar" },
                            new UIPriority() { Val = 10 },
                            new PrimaryStyle(),
                            new Rsid() { Val = "002C2DBE" },
                            new ParagraphProperties(
                                new ParagraphBorders(
                                    new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt64)4UL, Space = (UInt64)1UL }),
                                new SpacingBetweenLines() { Line = 240, LineRule = LineSpacingRuleValues.Auto },
                                new ContextualSpacing()),
                            new RunProperties(
                                new RunFonts() { AsciiTheme = ThemeFontValues.MajorHighAnsi, HighAnsiTheme = ThemeFontValues.MajorHighAnsi, EastAsiaTheme = ThemeFontValues.MajorEastAsia, ComplexScriptTheme = ThemeFontValues.MajorBidi },
                                new Spacing() { Val = 5 },
                                new FontSize() { Val = (UInt64)52UL },
                                new FontSizeComplexScript() { Val = (UInt64)52UL })
                        ) { Type = StyleValues.Paragraph, StyleId = "Title" });
                    // Enregistrement des styles 
                    styles.Save(stylePart);

                    //titre du bug
                    Paragraph paraTitle = new Paragraph(new Run(new Text("Titre : " + bugReport.Title)));
                    package.MainDocumentPart.Document.Body.Append(paraTitle);
                    //personne responsable
                    Paragraph paraResp = new Paragraph(new Run(new Text("Personne Responsable : " + bugReport.Responsable)));
                    package.MainDocumentPart.Document.Body.Append(paraResp);
                    //statut du bug
                    Paragraph paraStatut = new Paragraph(new Run(new Text("Statut : " + bugReport.Statut)));
                    package.MainDocumentPart.Document.Body.Append(paraStatut);
                    //on fait un saut de ligne
                    Paragraph paraEmpty = new Paragraph(new Run(new Text(" ")));
                    package.MainDocumentPart.Document.Body.Append(paraEmpty);

                    //ajout de tous les commentaires.
                    foreach (string item in bugReport.Comments)
                    {
                        Paragraph paraComment = new Paragraph(new Run(new Text(item + " \n")));
                        package.MainDocumentPart.Document.Body.Append(paraComment);
                    }
                    package.MainDocumentPart.Document.Save();
                    return fileName + ".docx";
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }

    }
}
