using Sesion12.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion12
{
    public partial class Form1 : Form
    {
        List<Product> products;
        public Form1()
        {
            InitializeComponent();
            products = new List<Product>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = int.Parse(tbCodigo.Text);
            product.Name = tbNombre.Text;
            product.Description = tbDescripcion.Text;
            product.Price = int.Parse(tbPrecio.Text);
            products.Add(product);
            showDate();
            clearText();
        }
        private void showDate()
        {
            dgbProduct.DataSource = null;
            dgbProduct.DataSource = products;
        }
        private void clearText()
        {
            tbCodigo.Clear();
            tbNombre.Clear();
            tbDescripcion.Clear();
            tbPrecio.Clear();
            tbCodigo.Focus();
        }
    }
}
