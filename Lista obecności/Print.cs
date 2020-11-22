using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing.Layout;
using Lista_obecności.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Components;

namespace Lista_obecności
{
    public class Print
    {

        string CalendarMonth(int month)
        {
            string sMonth = "";
            if (string.IsNullOrEmpty(month.ToString())) month = DateTime.Now.Month;
            switch (month)
            {

                case 1: sMonth = "STYCZEŃ"; break;
                case 2: sMonth = "LUTY"; break;
                case 3: sMonth = "MARZEC"; break;
                case 4: sMonth = "KWIECIEŃ"; break;
                case 5: sMonth = "MAJ"; break;
                case 6: sMonth = "CZERWIEC"; break;
                case 7: sMonth = "LIPIEC"; break;
                case 8: sMonth = "SIERPIEŃ"; break;
                case 9: sMonth = "WRZESIEŃ"; break;
                case 10: sMonth = "PAŹDZiERNIK"; break;
                case 11: sMonth = "LISTOPAD"; break;
                case 12: sMonth = "GRUDZIEŃ"; break;
            }
            return sMonth;
        }
        public void PrintPDF(List<WorkersDTO> workers, string nameOfSection, string month, string year, bool allSection, 
                            List<string> sections, List<int> redDays)
        {
            List<int> iRedDays = new List<int>();
            iRedDays = redDays;
            List<string> AllSections=new List<string>();
            AllSections = sections;
            List<WorkersDTO> workersDTO = new List<WorkersDTO>();
            workersDTO = workers;
            string sNameOfSection = "";
            string sMonth = "";
            string sYear = "";
            bool bAllSection = false;
            int iDaysInMonth = 0;

            sNameOfSection = nameOfSection;
            if (string.IsNullOrEmpty(month)) sMonth = DateTime.Now.Month.ToString();
            else sMonth = month;
            if (string.IsNullOrEmpty(year)) sYear = DateTime.Now.Year.ToString();
            else sYear = year;
            bAllSection = allSection;
            iDaysInMonth= DateTime.DaysInMonth(Convert.ToInt32(sYear), Convert.ToInt32(sMonth));
            sMonth = CalendarMonth(Convert.ToInt32(sMonth));


            PdfDocument document = new PdfDocument();
            PdfPage page;
            XGraphics gfx;
            XFont font = new XFont("Cambria", 10, XFontStyle.Bold);
            XPen pen = new XPen(XColor.FromName("Black"));
            XTextFormatter tf;
            XBrush xBrush = new XSolidBrush(XColor.FromArgb(100, 83, 83,83));

            //drukuje bez nazwisk jeden dział i sortowanie descending by kier był pierwszy
            double x1 = 80;
            double x2 = 80;
            double y1 = 68;
            double y2 = 198;

            double xx1 = 85;

            int iHowMuchWorkers = 0;
            int iHowMuchWorkersIs = 0;
            int iHowMuchPages = 0;
            workersDTO = workersDTO.OrderBy(x => x.Section).ThenByDescending(x => x.IsManager).ThenBy(x => x.Surname).ThenBy(x => x.Name).ToList();
            for(int i=0; i<workersDTO.Count; i++)
            {
                if (string.IsNullOrEmpty(workersDTO[i].Name)) workersDTO.RemoveAt(i);
            }
            if (allSection == false) workersDTO = workersDTO.FindAll(x => x.Section == sNameOfSection).ToList();
            AllSections = AllSections.OrderBy(x => x).ToList();
            if (allSection == true)
            {
                sNameOfSection = AllSections[0];
                iHowMuchPages = AllSections.Count;
                string section = sNameOfSection;
                int WorkersCount = 0;
                for (int i = 0; i < workersDTO.Count; i++)
                {
                    if(workersDTO[i].Section==section)
                    {
                        WorkersCount++;
                    }
                    else
                    {
                        section = workersDTO[i].Section;
                        if (WorkersCount >= 10)
                        {
                            iHowMuchPages = iHowMuchPages + 1;
                            WorkersCount = 0;
                        }
                    }
                }
                if (WorkersCount >= 10)
                {
                    iHowMuchPages = iHowMuchPages + 1;
                    WorkersCount = 0;
                }
            }
            else
            {
                iHowMuchPages = iHowMuchPages + 1;
                string section = sNameOfSection;
                int WorkersCount = 0;
                for (int i = 0; i < workersDTO.Count; i++)
                {
                    if (workersDTO[i].Section == section)
                    {
                        WorkersCount++;
                    }
                    else
                    {
                        section = workersDTO[i].Section;
                        if (WorkersCount >= 10)
                        { 
                            iHowMuchPages = iHowMuchPages + 1;
                            WorkersCount = 0;
                        }
                    }
                }
                if (WorkersCount >= 10)
                {
                    iHowMuchPages = iHowMuchPages + 1;
                    WorkersCount = 0;
                }
            }
        

            foreach (var worker in workersDTO)
            {
                if (!string.IsNullOrEmpty(worker.Name)) iHowMuchWorkers++;
            }
            for (int a  = 0; a <iHowMuchPages ; a++)
            {
                page = document.AddPage();
                gfx = XGraphics.FromPdfPage(page);
                tf = new XTextFormatter(gfx);
                //wiersze co 25 kolumny co

                gfx.DrawLine(pen, 50, 45, 550, 45);
                gfx.DrawLine(pen, 50, 45, 50, 65);
                gfx.DrawLine(pen, 550, 45, 550, 65);
                gfx.DrawLine(pen, 50, 65, 550, 65);

                XRect rect = new XRect(70, 50, 500, 20);
                tf.DrawString("Nazwa komórki organizacyjnej: " + sNameOfSection, font, XBrushes.Black, rect, XStringFormats.TopLeft);

                //linie poziome głownej tabeli
                gfx.DrawLine(pen, 50, 68, 550, 68);
                gfx.DrawLine(pen, 50, 198, 550, 198);


                //poziome
                gfx.DrawLine(pen, 50, 68, 50, 198);
                gfx.Save();
                gfx.RotateAtTransform(270, new XPoint(60, 190));
                XRect rectMiesiac = new XRect(60, 190, 130, 30);
                tf.DrawString("M-c " + sMonth + " " + sYear, font, XBrushes.Black, rectMiesiac, XStringFormats.TopLeft);
                gfx.Restore();
                gfx.DrawLine(pen, 80, 68, 80, 198);
                

                for (int i = 0; i < 10; i++)
                {
                    if (iHowMuchWorkersIs < workersDTO.Count && workersDTO[iHowMuchWorkersIs].Name!="")
                    {
                        if (workersDTO[iHowMuchWorkersIs].Section == sNameOfSection)
                        {
                            gfx.Save();
                            gfx.RotateAtTransform(270, new XPoint(xx1, 190));
                            XRect rectUserX1 = new XRect(xx1, 190, 130, 20);
                            tf.DrawString(workersDTO[iHowMuchWorkersIs].Surname, font, XBrushes.Black, rectUserX1, XStringFormats.TopLeft);
                            gfx.Restore();
                            gfx.Save();
                            gfx.RotateAtTransform(270, new XPoint(xx1 + 15, 190));
                            XRect rectUserX2 = new XRect(xx1 + 15, 190, 130, 20);
                            tf.DrawString(workersDTO[iHowMuchWorkersIs].Name, font, XBrushes.Black, rectUserX2, XStringFormats.TopLeft);
                            gfx.Restore();
                            iHowMuchWorkersIs++;
                        }
                        else
                        {
                            //sNameOfSection = workersDTO[iHowMuchWorkersIs].Section;
                            //break;
                            //goto endOfWorkers;
                        }
                    }
                    //endOfWorkers:
                    xx1 =xx1+43;
                    x1 = x1 + 43;
                    x2 = x2 + 43;
                    gfx.DrawLine(pen, x1, y1, x2, y2);
                }
                if (iHowMuchWorkersIs < workersDTO.Count)sNameOfSection = workersDTO[iHowMuchWorkersIs].Section;
                //iHowMuchWorkersIs++;
                x1 = 80;
                x2 = 80;
                y1 = 68;
                y2 = 198;

                xx1 = 85;

                gfx.Save();
                gfx.RotateAtTransform(270, new XPoint(525, 190));
                XRect rectPodpis = new XRect(525, 190, 130, 40);
                tf.DrawString("Podpis kier. jedn. org.", font, XBrushes.Black, rectPodpis, XStringFormats.TopLeft);
                gfx.Restore();



                gfx.DrawLine(pen, 550, 68, 550, 198);
                //za tabelą
                //522 pixele
                double ysize = 0;
                if (iDaysInMonth == 31) ysize = 16.84; //16px
                if (iDaysInMonth == 30) ysize = 17.4; //17px
                if (iDaysInMonth == 29) ysize = 18; //18px
                if (iDaysInMonth == 28) ysize = 18.64; //18px

                double ySizeRows = 198;
                double xSizeRows = 123;
                for (int i = 0; i < iDaysInMonth; i++)
                {
                    //linie poziome dolne
                    gfx.DrawLine(pen, 50, ySizeRows + ysize, 550, ySizeRows + ysize);
                    //pionowe linie wiersza
                    //piersza komorka dwie linie
                    gfx.DrawLine(pen, 50, ySizeRows, 50, ySizeRows + ysize);
                    XRect rectDays = new XRect(55, ySizeRows + 2, 20, 20);
                    tf.DrawString((i + 1).ToString(), font, XBrushes.Black, rectDays, XStringFormats.TopLeft);
                    gfx.DrawLine(pen, 80, ySizeRows, 80, ySizeRows + ysize);
                    //ostatnia linia komórki

                    gfx.DrawLine(pen, 550, ySizeRows, 550, ySizeRows + ysize);

                    //reszta lini
                    foreach (var redDay in iRedDays)
                    {
                        if ((i + 1) == redDay)
                        {
                            XRect rectGray = new XRect(80, ySizeRows, 470, ysize);
                            gfx.DrawRectangle(xBrush, rectGray);
                        }
                    }
                    for (int z = 0; z < 10; z++)
                    {
                        gfx.DrawLine(pen, xSizeRows, ySizeRows, xSizeRows, ySizeRows + ysize);
                        xSizeRows = xSizeRows + 43;
                    }
                    ySizeRows = ySizeRows + ysize;
                    xSizeRows = 123;
                }


                gfx.DrawLine(pen, 50, 720, 550, 720);
                //dolna tabelka
                //linie poziome
                gfx.DrawLine(pen, 50, 730, 550, 730);
                gfx.DrawLine(pen, 50, 780, 550, 780);
                //linie pionowe i pomiedzy zawartosci
                gfx.DrawLine(pen, 50, 730, 50, 780);
                XRect rect1 = new XRect(60, 750, 50, 40);
                tf.DrawString("Razem dni", font, XBrushes.Black, rect1, XStringFormats.TopLeft);
                gfx.DrawLine(pen, 120, 730, 120, 780);


                XRect rect2 = new XRect(138, 737, 50, 40);
                tf.DrawString("C", font, XBrushes.Black, rect2, XStringFormats.TopLeft);
                gfx.DrawLine(pen, 163, 730, 163, 780);


                XRect rect3 = new XRect(178, 737, 50, 40);
                tf.DrawString("C(s)", font, XBrushes.Black, rect3, XStringFormats.TopLeft);
                gfx.DrawLine(pen, 206, 730, 206, 780);



                XRect rect4 = new XRect(224, 737, 50, 40);
                tf.DrawString("K", font, XBrushes.Black, rect4, XStringFormats.TopLeft);
                gfx.DrawLine(pen, 249, 730, 249, 780);



                XRect rect5 = new XRect(263, 737, 50, 40);
                tf.DrawString("M", font, XBrushes.Black, rect5, XStringFormats.TopLeft);
                gfx.DrawLine(pen, 293, 730, 293, 780);



                XRect rect6 = new XRect(311, 737, 50, 40);
                tf.DrawString("P", font, XBrushes.Black, rect6, XStringFormats.TopLeft);
                gfx.DrawLine(pen, 336, 730, 336, 780);



                XRect rect7 = new XRect(354, 737, 50, 40);
                tf.DrawString("S", font, XBrushes.Black, rect7, XStringFormats.TopLeft);
                gfx.DrawLine(pen, 379, 730, 379, 780);



                XRect rect8 = new XRect(397, 737, 50, 40);
                tf.DrawString("O", font, XBrushes.Black, rect8, XStringFormats.TopLeft);
                gfx.DrawLine(pen, 422, 730, 422, 780);



                XRect rect9 = new XRect(440, 737, 50, 40);
                tf.DrawString("R", font, XBrushes.Black, rect9, XStringFormats.TopLeft);
                gfx.DrawLine(pen, 465, 730, 465, 780);



                XRect rect10 = new XRect(483, 737, 50, 40);
                tf.DrawString("U", font, XBrushes.Black, rect10, XStringFormats.TopLeft);
                gfx.DrawLine(pen, 508, 730, 508, 780);




                XRect rect11 = new XRect(526, 737, 50, 40);
                tf.DrawString("N", font, XBrushes.Black, rect11, XStringFormats.TopLeft);
                gfx.DrawLine(pen, 550, 730, 550, 780);

                //pozioma linia tabela dolna linia w środku
                gfx.DrawLine(pen, 120, 755, 550, 755);

                //dolny wpis
                XRect rectDown = new XRect(50, 790, 550, 790);
                tf.DrawString("Razem spóźnienia: usprawiedliwione - min.: ................................... nieusprawiedliwione - min.: ................................... ",
                    font, XBrushes.Black, rectDown, XStringFormats.TopLeft);

                
            }

            
            // Save 
            const string filename = @"C:\inetpub\wwwroot\ListaObecnosci.pdf";
            //var savePath = Path.Combine(Environment.GetFolderPath((Environment.SpecialFolder.ApplicationData)), "Lista obecności");
            //var path = savePath + "\\" + filename;
            document.Save(filename);
            //PdfFilePrinter.AdobeReaderPath = @"C:\Program Files\Adobe\Reader 9.0\Reader\AcroRd32.exe";
            //PdfFilePrinter printer = new PdfFilePrinter(pdfFileName, printerName);
            //printer.Print();

            RedirectToPDF=true;

        }

        public bool RedirectToPDF = false;
        
    }
}
