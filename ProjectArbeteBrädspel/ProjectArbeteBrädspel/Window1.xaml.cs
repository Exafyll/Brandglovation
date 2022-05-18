using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjectArbeteBrädspel
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();


            var doc = XElement.Parse(tempXml);
            var target = doc.Elements("Project")
                    .Where(e => e.Attribute("ID").Value == "2")
                    .Single();

            target.Attribute("Name").Value = "Project2_Update";
            doc.Save(Console.Out);
            Console.WriteLine();

        }
    }
}
