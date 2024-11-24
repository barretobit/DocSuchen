using Tesseract;
using UglyToad.PdfPig;

namespace DocSuchen.Controllers
{
    public static class OCRController
    {
        public static Bitmap RenderPageToImage(PdfDocument document, int pageIndex)
        {
            var bitmap = new Bitmap(200, 200);
            return bitmap;
        }

        public static Task ProcessPdfFolder(string folderPath)
        {
            foreach (var file in Directory.GetFiles(folderPath, "*.pdf"))
            {
                using var pdf = PdfDocument.Open(file);
                int pageIndex = 1;

                foreach (UglyToad.PdfPig.Content.Page page in pdf.GetPages())
                {
                    var image = RenderPageToImage(pdf, pageIndex);

                    if (image != null)
                    {
                        string text = PerformOCR(image);
                        SaveOCRResult(file, pageIndex, text);
                        return Task.CompletedTask;
                    }
                    pageIndex++;
                }
            }

            return Task.CompletedTask;
        }

        private static string PerformOCR(Bitmap image)
        {
            using var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default);

            using var pix = ConvertBitmapToPix(image);

            using var page = engine.Process(pix);

            return page.GetText();
        }

        private static void SaveOCRResult(string pdfFile, int pageIndex, string text)
        {
            string outputDir = Path.Combine(Path.GetDirectoryName(pdfFile), "OCRResults");
            Directory.CreateDirectory(outputDir);
            string outputFile = Path.Combine(outputDir, $"{Path.GetFileNameWithoutExtension(pdfFile)}_Page{pageIndex}.txt");
            File.WriteAllText(outputFile, text);
        }

        private static Pix ConvertBitmapToPix(Bitmap bitmap)
        {
            using var ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            ms.Position = 0;
            return Pix.LoadFromMemory(ms.ToArray());
        }
    }
}