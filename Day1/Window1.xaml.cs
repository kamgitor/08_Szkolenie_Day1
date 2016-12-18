using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Day1
{
    

    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Osoba[] osoby = new Osoba[10];

        public Window1()
        {
            byte i;
            InitializeComponent();

            i = 0;

            osoby[i] = new Osoba(); osoby[i].imie = "Kamil"; osoby[i].nazwisko = "Nowak"; osoby[i++].klasa = "1C";
            osoby[i] = new Osoba(); osoby[i].imie = "Kasia"; osoby[i].nazwisko = "Jedynak"; osoby[i++].klasa = "1A";
            osoby[i] = new Osoba(); osoby[i].imie = "Maja"; osoby[i].nazwisko = "Nowak"; osoby[i++].klasa = "1F";
            osoby[i] = new Osoba(); osoby[i].imie = "Ola"; osoby[i].nazwisko = "Nowak"; osoby[i++].klasa = "1D";
            osoby[i] = new Osoba(); osoby[i].imie = "Adam"; osoby[i].nazwisko = "Pytel"; osoby[i++].klasa = "1D";

            i = 0;
            listBox1.Items.Add(osoby[i].imie + " " + osoby[i].nazwisko + " " + osoby[i++].klasa);
            listBox1.Items.Add(osoby[i].imie + " " + osoby[i].nazwisko + " " + osoby[i++].klasa);
            listBox1.Items.Add(osoby[i].imie + " " + osoby[i].nazwisko + " " + osoby[i++].klasa);
            listBox1.Items.Add(osoby[i].imie + " " + osoby[i].nazwisko + " " + osoby[i++].klasa);
            listBox1.Items.Add(osoby[i].imie + " " + osoby[i].nazwisko + " " + osoby[i++].klasa);

            listBox1.KeyDown += new KeyEventHandler(listBox1_KeyDown);
            // listBox1.SelectionChanged += new SelectionChangedEventHandler(listBox1_SelectionChanged);
        }


        // zdazenie wcisniecia klawisza
        void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int index = listBox1.SelectedIndex;

            switch (e.Key)
            {
            case Key.Enter:
                    PersonEdit okno = new PersonEdit();
                    okno.Box_imie.Text = osoby[index].imie;
                    okno.Box_name.Text = osoby[index].nazwisko;
                    okno.Box_klasa.Text = osoby[index].klasa;

                    if (okno.ShowDialog().Value)
                    // if (okno.wynik)
                    {
                        osoby[index].imie = okno.Box_imie.Text;
                        osoby[index].nazwisko = okno.Box_name.Text;
                        osoby[index].klasa = okno.Box_klasa.Text;

                        // nie wiem jak zrobic edycje elementu listy
                        // listBox1.SelectedItem = osoby[index].imie + " " + osoby[index].nazwisko + " " + osoby[index].klasa;
                    }

                break;

            case Key.Insert:

                break;

            case Key.Delete:

                break;

            }

            

            // throw new NotImplementedException();
        }

        /*
        void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string temp;

            // throw new NotImplementedException();
        }
         * */




    }


    public class Osoba
    {
        public string imie;
        public string nazwisko;
        public string klasa;

        public Osoba()
        {
            imie = "";
            nazwisko = "";
            klasa = "";
        }
    }



}

