using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly string baseUrl = "https://appsheettest1.azurewebsites.net/sample";
        private readonly int numOfRecordsToReturn = 5;
        private readonly Regex phoneNumberRegex = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");

        public Form1()
        {
            List<UserDetails> outputPayload = new List<UserDetails>();
            string listUrl = $"{baseUrl}/list";

            using (WebClient wc = new WebClient())
            {
                while (!String.IsNullOrEmpty(listUrl))
                {
                    string userListJson = wc.DownloadString(listUrl);
                    UserIdList userListObj = JsonConvert.DeserializeObject<UserIdList>(userListJson);

                    if (String.IsNullOrEmpty(userListObj.token))
                    {
                        listUrl = "";
                    }
                    else
                    {
                        listUrl = $"{baseUrl}/list?token={userListObj.token}";
                    }

                    foreach (string userId in userListObj.result)
                    {
                        try
                        {
                            string userDetailsJson = wc.DownloadString($"{baseUrl}/detail/{userId}");
                            UserDetails userDetailsObj = JsonConvert.DeserializeObject<UserDetails>(userDetailsJson);
                            if (phoneNumberRegex.Match(userDetailsObj.number).Success)
                            {
                                outputPayload.Add(userDetailsObj);
                            }
                        }
                        catch
                        { 
                            //  eat the exception; skip the failed record download and continue  
                        }
                    }

                    outputPayload = outputPayload.OrderBy(o => o.age).Take(numOfRecordsToReturn).ToList();

                }
            }

            InitializeComponent(outputPayload);
        }

    }
}
