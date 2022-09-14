using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace listview
{
    public partial class MainPage : ContentPage
    {

        public IList<Cursos> LCursos { get; set; }
        public MainPage()
        {
            InitializeComponent();
            LCursos = new List<Cursos>();
            LCursos.Add(new Cursos 
            {
                Nombre = "Microsoft",
                Duracion = 2,
                Costo = 300 ,
                Logo = "word.jpg"
            });

            LCursos.Add(new Cursos
            {
                Nombre = "SQL",
                Duracion = 2,
                Costo = 300,
                Logo = "sqla.jpg"
            });

            LCursos.Add(new Cursos
            {
                Nombre = "JAVA",
                Duracion = 2,
                Costo = 300,
                Logo = "java.jpg"
            });

            LCursos.Add(new Cursos
            {
                Nombre = "Azure",
                Duracion = 2,
                Costo = 300,
                Logo = "azure.jpg"
            });

            LCursos.Add(new Cursos
            {
                Nombre = "Linux",
                Duracion = 2,
                Costo = 30,
                Logo = "linux.jpg"
            });
            BindingContext = this;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Cursos selectedItem = e.SelectedItem as Cursos;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Cursos tappedItem = e.Item as Cursos;
        }
    }
}
