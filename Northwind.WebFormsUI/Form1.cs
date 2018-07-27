using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Abstruct;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Business.Abstruct;
using Northwind.DataAccess.Concrete.NHibernate;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }

        private IProductService _productService;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bu Kod yerinde

            //ProductManager productManager= new ProductManager(new EfProductDal());
           // ProductManager productManager= new ProductManager(new NhProductDal());
            dgwProduct.DataSource = _productService.GetAll();
        }
    }
}
