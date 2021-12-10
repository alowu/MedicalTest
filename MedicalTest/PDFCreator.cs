﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Model.Entity;

namespace MedicalTest
{
	class PDFCreator
	{
		private Patient patient;
		private List<Chart> charts;

		public PDFCreator(Patient patient, List<Chart> charts)
		{
			this.patient = patient;
			this.charts = charts;
		}

		public PDFCreator()
		{
		}

		public bool Create()
		{
			bool result = false;
			try
			{
				string filename = "H:\\MedicalTest\\PDF\\";
				string pat = patient.firstName.Trim() + "_" + patient.middleName.Trim() + "_" + patient.lastName.Trim();
				filename += DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + "_" + pat + ".pdf";
				PdfWriter writer = new PdfWriter(filename);
				PdfDocument pdf = new PdfDocument(writer);
				Document document = new Document(pdf);

				
				string t = patient.firstName.Trim() + " " + patient.middleName.Trim() + " " + patient.lastName.Trim() + " examination results";
				Text text = new Text(t)
					.SetFontSize(15)
					.SetHorizontalAlignment(HorizontalAlignment.CENTER);
				Paragraph paragraph = new Paragraph(text);
				document.Add(paragraph);

				foreach (Chart item in charts)
				{
					if (item.Visible == true)
					{
						string jps = "H:\\TEMP\\chart.jpeg";
						item.SaveImage(jps, ChartImageFormat.Jpeg);
						Image img = new Image(ImageDataFactory
							.Create("H:\\TEMP\\chart.jpeg"))
							.SetTextAlignment(TextAlignment.CENTER);
						document.Add(img);
					}
				}
				document.Close();
				result = true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("CAN'T CREATE PDF FILE" + ex.Message);
			}
			return result;
		}
	}
}