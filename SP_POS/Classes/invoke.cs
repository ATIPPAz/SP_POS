﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_POS.Classes
{
    public class invoke
    {
        public void print(DataTable data, string Header,string username ,string address,int total,string rec,string change)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF|*.pdf" })
            {

                /*  string path = @"test.pdf";*/
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportDataTableToPdf(data, sfd.FileName, Header,username, address,total, rec, change);
                    System.Diagnostics.Process.Start(sfd.FileName);
                }

            }
        }
        private void ExportDataTableToPdf(DataTable dtblTable, string strPdfPath, string strHeader, string username,string address, int total, string rec, string change)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            iTextSharp.text.pdf.PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author 
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor, 8, 2, BaseColor.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk($"Pay by name : {username}", fntAuthor));
            prgAuthor.Add(new Chunk("\nAt Date : " + DateTime.Now.ToShortDateString(), fntAuthor));
            prgAuthor.Add(new Chunk($"\nAddress {address} : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 10, 1, BaseColor.WHITE);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = BaseColor.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);
            Paragraph pl = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(pl);
            document.Add(new Chunk("\n", fntAuthor));
            Paragraph totals = new Paragraph();
            totals.Alignment = Element.ALIGN_RIGHT;
            totals.Add(new Chunk($"\ntotal : {total} bath", fntAuthor));
            totals.Add(new Chunk($"\npay   : {rec} bath", fntAuthor));
            totals.Add(new Chunk($"\nChange : {change} bath", fntAuthor));

           
            document.Add(totals);
            document.Close();
            writer.Close();
            fs.Close();
        }
    }
}
