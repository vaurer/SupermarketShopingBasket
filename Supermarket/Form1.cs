using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> productsDictionary = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var produkt = tbProdukt.Text;
            int quantity = Convert.ToInt32(tbAnzahl.Text);

            if (!string.IsNullOrEmpty(produkt) && quantity >= 1 && !productsDictionary.ContainsKey(produkt))
            {
                productsDictionary.Add(produkt, quantity);
                updateList();
            } else  if (!string.IsNullOrEmpty(produkt) && quantity >= 1 && productsDictionary.ContainsKey(produkt)){
                var currentQuantit = productsDictionary[produkt];
                productsDictionary[produkt] = currentQuantit + quantity;
                updateList();
            }

        }
        public void updateList()
        {
            listProdukt.DataSource = productsDictionary.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var produkt = tbProdukt.Text;
            int quantity = Convert.ToInt32(tbAnzahl.Text);

            if (productsDictionary.ContainsKey(produkt))
            {
                var currentQuantit = productsDictionary[produkt];
                if (quantity >= currentQuantit)
                {
                    productsDictionary.Remove(produkt);
                    updateList();
                }
                else
                {
                    productsDictionary[produkt] = currentQuantit - quantity;
                    updateList();
                }

            }
        }
    }
}

