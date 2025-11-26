using System.Collections;

namespace _08_MavanOtomasyon
{
    public partial class Form1 : Form
    {
        ArrayList halMeyveler = new ArrayList() { "ELMA", "ARMUT", "MUZ", "PORTAKAL", "MANDALÝNA" };
        ArrayList halSebzeler = new ArrayList() { "DOMATES", "BÝBER", "PATLICAN", "PATATES", "KEREVÝZ" };
        ArrayList manavMeyveler = new ArrayList();
        ArrayList manavMeyveKilo = new ArrayList();
        ArrayList manavSebze = new ArrayList();
        ArrayList manavSebzeKilo = new ArrayList();
        ArrayList musteri = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }
    }
}
