using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__project_1.Views.DashboardFls
{
    public partial class AddRoomAction : UserControl
    {
        public AddRoomAction()
        {
            InitializeComponent();

            // Set property value (in real case, this might come from DB)
            var room_types = new List<string> { "Hall", "Lab" };

            // Set ComboBox data source using the property
            roomType.DataSource = room_types;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
