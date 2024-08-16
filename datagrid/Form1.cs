using datagrid.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagrid
{
    public partial class Form1 : Form
    {
        private BindingList<Persona> personas;

        public Form1()
        {
            InitializeComponent();
            //CargarDatos();
            //CargarDatos2();

        }

        private void CargarDatos()
        {
            // Crear una lista de personas
            var listaPersonas = new List<Persona>
            {
                new Persona { Nombre = "Juan", Edad = 30, Ciudad = "Madrid" },
                new Persona { Nombre = "Ana", Edad = 25, Ciudad = "Barcelona" },
                new Persona { Nombre = "Pedro", Edad = 35, Ciudad = "Sevilla" }
            };

            // Asignar la lista al DataGridView
            dataGridView1.DataSource = listaPersonas;
        }

        private void CargarDatos2()
        {
            // Inicializamos la BindingList
            personas = new BindingList<Persona>
            {
                new Persona { Nombre = "Juan", Edad = 30, Ciudad = "Madrid" },
                new Persona { Nombre = "Ana", Edad = 25, Ciudad = "Barcelona" },
                new Persona { Nombre = "Pedro", Edad = 35, Ciudad = "Sevilla" }
            };

            // Asignamos la BindingList al DataGridView
            dataGridView1.DataSource = personas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet3.Categories' Puede moverla o quitarla según sea necesario.
            this.categoriesTableAdapter.Fill(this.northwindDataSet3.Categories);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet2.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet2.Customers);

        }
    }
}
