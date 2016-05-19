
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace GetWebSiteThumb1
{
    public class WebsiteToImage
    {
    }
    //public  Bitmap GenerateScreenshot(string url)
    //{
    //    // This method gets a screenshot of the webpage
    //    // rendered at its full size (height and width)
    //    return GenerateScreenshot(url, -1, -1);

    //}

    //        public Bitmap GenerateScreenshot(string url, int width, int height)
    //        {
    //            // Load the webpage into a WebBrowser control
    //            WebBrowser wb = new WebBrowser();
    //            wb.ScrollBarsEnabled = false;
    //            wb.ScriptErrorsSuppressed = true;
    //            wb.Navigate(url);
    //            while (wb.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }


    //            // Set the size of the WebBrowser control
    //            wb.Width = width;
    //            wb.Height = height;

    //            if (width == -1)
    //            {
    //                // Take Screenshot of the web pages full width
    //                wb.Width = wb.Document.Body.ScrollRectangle.Width;
    //            }

    //            if (height == -1)
    //            {
    //                // Take Screenshot of the web pages full height
    //                wb.Height = wb.Document.Body.ScrollRectangle.Height;
    //            }

    //            // Get a Bitmap representation of the webpage as it's rendered in the WebBrowser control
    //            Bitmap bitmap = new Bitmap(wb.Width, wb.Height);
    //            wb.DrawToBitmap(bitmap, new Rectangle(0, 0, wb.Width, wb.Height));
    //            wb.Dispose();

    //            return bitmap;
    //        }
    //    }
    //}
    ////public class WebsiteToImage
    ////{
    ////    private Bitmap m_Bitmap;
    ////    private string m_Url;
    ////    private string m_FileName = string.Empty;

    ////    public WebsiteToImage(string url)
    ////    {
    //        // Without file 
    //        m_Url = url;
    //    }

    //    public WebsiteToImage(string url, string fileName)
    //    {
    //        // With file 
    //        m_Url = url;
    //        m_FileName = fileName;
    //    }

    //    public Bitmap Generate()
    //    {
    //        // Thread 
    //        var m_thread = new Thread(_Generate);
    //        m_thread.SetApartmentState(ApartmentState.STA);
    //        m_thread.Start();
    //        m_thread.Join();
    //        return m_Bitmap;
    //    }
    //    private void _Generate()
    //    {
    //        var browser = new WebBrowser { ScrollBarsEnabled = false };
    //        browser.Navigate(m_Url);
    //        browser.DocumentCompleted += WebBrowser_DocumentCompleted;

    //        while (browser.ReadyState != WebBrowserReadyState.Complete)
    //        {
    //            Application.DoEvents();
    //        }

    //        browser.Dispose();
    //    }

    //    private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    //    {
    //        // Capture 
    //        var browser = (WebBrowser)sender;
    //        browser.ClientSize = new Size(browser.Document.Body.ScrollRectangle.Width, browser.Document.Body.ScrollRectangle.Bottom);
    //        browser.ScrollBarsEnabled = false;
    //        m_Bitmap = new Bitmap(browser.Document.Body.ScrollRectangle.Width, browser.Document.Body.ScrollRectangle.Bottom);
    //        browser.BringToFront();
    //        browser.DrawToBitmap(m_Bitmap, browser.Bounds);

    //        // Save as file? 
    //        if (m_FileName.Length > 0)
    //        {
    //            // Save 
    //            m_Bitmap.SaveJPG100(m_FileName);
    //        }
    //    }
    //}

    //public static class BitmapExtensions
    //{
    //    public static void SaveJPG100(this Bitmap bmp, string filename)
    //    {
    //        var encoderParameters = new EncoderParameters(1);
    //        encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);
    //        bmp.Save(filename, GetEncoder(ImageFormat.Jpeg), encoderParameters);
    //    }

    //    public static void SaveJPG100(this Bitmap bmp, Stream stream)
    //    {
    //        var encoderParameters = new EncoderParameters(1);
    //        encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);
    //        bmp.Save(stream, GetEncoder(ImageFormat.Jpeg), encoderParameters);
    //    }

    //    public static ImageCodecInfo GetEncoder(ImageFormat format)
    //    {
    //        var codecs = ImageCodecInfo.GetImageDecoders();

    //        foreach (var codec in codecs)
    //        {
    //            if (codec.FormatID == format.Guid)
    //            {
    //                return codec;
    //            }
    //        }

    //        // Return 
    //        return null;
    //    }
    //}
}