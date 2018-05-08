using Eve;
using System.Windows.Forms;

namespace GetAtc
{
    public class AppContext : ApplicationContext
    {
        public readonly EveClient FaStatusServer = new EveClient("http://139.99.42.165:5000");

        private bool LoggedIn;

        public Form1 form1;

        public AppContext()
        {
            form1 = new Form1(this);
            form1.Show();
        }

    }
}
