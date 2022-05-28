using SP_POS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_POS.Controls
{
    public partial class ProductCard : UserControl
    {
        public Product productcardData = new Product();
        public ProductCard()
        {
            InitializeComponent();
        }
        public string getQty()
        {
            return productcardData.ProdQty;
        }
        public Product getProduct()
        {
            return productcardData;
        }
        public void setQty(string qty)
        {
            Console.WriteLine(qty);
            productcardData.ProdQty = qty;
        }
        public async Task<Image> GetImageAsync(string url)
        {
            var tcs = new TaskCompletionSource<Image>();
            Image webImage = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            await Task.Factory.FromAsync<WebResponse>(request.BeginGetResponse, request.EndGetResponse, null)
                .ContinueWith(task =>
                {
                    var webResponse = (HttpWebResponse)task.Result;
                    Stream responseStream = webResponse.GetResponseStream();
                    if (webResponse.ContentEncoding.ToLower().Contains("gzip"))
                        responseStream = new GZipStream(responseStream, CompressionMode.Decompress);
                    else if (webResponse.ContentEncoding.ToLower().Contains("deflate"))
                        responseStream = new DeflateStream(responseStream, CompressionMode.Decompress);

                    if (responseStream != null) webImage = Image.FromStream(responseStream);
                    tcs.TrySetResult(webImage);
                    webResponse.Close();
                    responseStream.Close();
                });
            return tcs.Task.Result;
        }
        public void setText() { Qty.Text = productcardData.ProdQty; }
        public void setcard(string img,string name,string qty,string price,string id,string cost)
        {
            /*var result = GetImageAsync(img);
            result.ContinueWith(task =>
            {
                image.Image = task.Result;
            });*/
            image.LoadAsync(img);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            productcardData.ProdQty = qty;
            Qty.Text = qty;
            PName.Text = name;
            Price.Text = price;
            productcardData.ProdCost = cost;
            productcardData.ProdPrice= price;
            productcardData.ProdName = name;
            productcardData.ProdID = id;
        }
    }
}
