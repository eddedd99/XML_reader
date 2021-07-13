using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;   //Agregar

namespace XML_reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //using (XmlReader reader = XmlReader.Create(@"D:\Users\eduardo.cruces\Documents\Visual Studio 2013\Projects\SIVAC\SIVAC\bin\Debug\SIVAC.xml"))
            using (XmlReader reader = XmlReader.Create(@"SIVAC.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        //return only when you have START tag  
                        switch (reader.Name.ToString())
                        {
                            case "Ruta":
                                MessageBox.Show("Ruta es : " + reader.ReadString());
                                break;
                            case "Base":
                                MessageBox.Show("Base de datos es : " + reader.ReadString());
                                break;
                        }
                    }                    
                }
            }
            //MessageBox.Show("Finalizo");
        }
    }
}
