using System;
using System.Collections.Generic;
using System.IO;
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

		public string Create()
		{
			string result = null;
			try
			{
				string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "/MD_RES/";
				if (!Directory.Exists(desktop))
				{
					Directory.CreateDirectory(desktop);
				}
				string filename = desktop;
				string pat = patient.firstName.Trim() + "_" + patient.middleName.Trim() + "_" + patient.lastName.Trim();
				filename += DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Second.ToString() + "_" + pat + ".pdf";
				PdfWriter writer = new PdfWriter(filename);
				PdfDocument pdf = new PdfDocument(writer);
				Document document = new Document(pdf);	

				Paragraph header = new Paragraph("RESULT")
				.SetTextAlignment(TextAlignment.CENTER)
				.SetFontSize(20);
				document.Add(header);

				string t = patient.firstName.Trim() + " " + patient.middleName.Trim() + " " + patient.lastName.Trim() + " examination results";
				Text text = new Text(t);
					
				Paragraph paragraph = new Paragraph(text).SetFontSize(15)
					.SetTextAlignment(TextAlignment.CENTER);
				document.Add(paragraph);

				LineSeparator ls = new LineSeparator(new SolidLine());
				document.Add(ls);

				foreach (Chart item in charts)
				{
					if (item.Visible == true)
					{
						string path = Path.GetTempPath();
						string jpeg = path + "/chart.jpeg";
						item.SaveImage(jpeg, ChartImageFormat.Jpeg);
						Image img = new Image(ImageDataFactory
							.Create(jpeg));
						document.Add(img);
					}
				}
				document.Close();
				result = desktop;
			}
			catch (Exception ex)
			{
				Console.WriteLine("CAN'T CREATE PDF FILE" + ex.Message);
			}
			return result;
		}
	}
}
