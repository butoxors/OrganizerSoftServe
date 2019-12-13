using Organizer.Interfaces;
using Organizer.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizer.Entities
{
    public class APICaller : IAPIManager
    {
        public void Call(string url)
        {
            BrowshotClient browshotClient = new BrowshotClient("HWtSDlzrhGhxbhyyhyTdMgjtoFMpr");
            Hashtable arguments = new Hashtable();
            arguments.Add("cache", 8600);
            Dictionary<string, object> result = browshotClient.ScreenshotCreate(url, arguments);

            if (result != null && result["status"].ToString() == "ok" || result["status"].ToString() == "finished")
            {
                string id = result["id"].ToString();
                Image thumbnail = browshotClient.Thumbnail(int.Parse(id), null);
                SaveImage(thumbnail);
            }
        }

        private void SaveImage(Image img)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Image files (*.png) | *.png";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                img.Save(sfd.FileName);
            }
        }
    }
}
