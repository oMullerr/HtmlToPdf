using System;
using SelectPdf;

class Program
{
    private static void Main(string[] args)
    {
        ConverterHtmlParaPdf();
    }
    public static void ConverterHtmlParaPdf()
    {
        // Template HTML fixo
        string templateHtml = @"
                <html>
                    <head>
                        <title>Exemplo de Template HTML</title>
                    </head>
                    <body>
                        <h1>Meu Template HTML</h1>
                        <p>Este é um exemplo de template HTML.</p>
                    </body>
                </html>";

        PdfPageSize pageSize = PdfPageSize.A4;
        PdfPageOrientation pdfOrientation = PdfPageOrientation.Portrait;
        int webPageWidth = 1024; // em pixels
        int webPageHeight = 0; // 0 para altura automática

        // Crie uma instância do conversor HtmlToPdf
        HtmlToPdf converter = new HtmlToPdf();

        converter.Options.PdfPageSize = pageSize;
        converter.Options.PdfPageOrientation = pdfOrientation;
        converter.Options.WebPageWidth = webPageWidth;
        converter.Options.WebPageHeight = webPageHeight;

        // Carregue o HTML da variável
        PdfDocument doc = converter.ConvertHtmlString(templateHtml);

        var caminho = "C:/Users/User/Desktop/HtmlToPdf/GeneratedPDFs/arquivo.pdf";

        // Salve o documento PDF
        doc.Save(caminho);

        // Feche o documento e liberar recursos
        doc.Close();

        Console.WriteLine("Conversão concluída. O arquivo PDF foi salvo.");
        Console.ReadLine();
    }
}