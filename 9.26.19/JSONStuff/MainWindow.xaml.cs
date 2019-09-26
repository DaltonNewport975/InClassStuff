using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace JSONStuff
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
/* Template for below
https://got-quotes.herokuapp.com/quotes

using (HttpClient client = new HttpClient())
{
var response = client.GetAsync(@"").Result;
if (response.IsSuccessStatusCode)
{
var content = response.Content.ReadAsStringAsync().Result;
VARIABLE = JsonConvert.DeserializeObject<Type>(content);

var x =JsonConvert.SerializeObject(VARIABLE);
}
}
*/
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        //https://got-quotes.herokuapp.com/quotes

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = client.GetAsync(@"https://got-quotes.herokuapp.com/quotes").Result;
            if (response.IsSuccessStatusCode)
            {
                string content = response.Content.ReadAsStringAsync().Result;
                //content = {Some quote}
                GOTQuote quote = JsonConvert.DeserializeObject<GOTQuote>(content);

                    //serialization not needed here
                    //var x = JsonConvert.SerializeObject();

                    TBLQuote.Text = $"{quote.Quote} \n\t-{quote.Character}";
            }
        }
    }
}
}
