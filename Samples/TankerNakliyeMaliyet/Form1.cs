namespace TankerNakliyeMaliyet
{
    public partial class Form1 : Form
    {
        private readonly float _litreMazotFiyat = 18.79F;
        private readonly float _kmBasinaLitreGidis = 0.7F;
        private readonly float _kmBasinaLitreGidisDonus = 0.35F;

        public Form1()
        {
            InitializeComponent();
        }
        //mustafa cingöz
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string mesafeMetin = txtMesafe.Text;

            if (string.IsNullOrWhiteSpace(mesafeMetin))
            {
                MessageBox.Show("Lütfen mesafe giriniz.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            string aylikKiraBedeliMetin = txtTankerKiraBedeli.Text;

            if (string.IsNullOrWhiteSpace(aylikKiraBedeliMetin))
            {
                MessageBox.Show("Lütfen tanker aylýk kira bedeli giriniz.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            bool gidisDonusMu = chbGidisDonus.Checked;
            int mesafe = Convert.ToInt32(mesafeMetin);
            int kiraBedeli = Convert.ToInt32(aylikKiraBedeliMetin);

            float katsayi = KatSayiyiGetir(mesafe);

            if (katsayi == 0)
            {
                return;
            }

            double sonuc = (_litreMazotFiyat * mesafe * (gidisDonusMu ? _kmBasinaLitreGidisDonus : _kmBasinaLitreGidis)) + (katsayi * (kiraBedeli / 26));

            txtSonuc.Text = sonuc.ToString();
        }

        private float KatSayiyiGetir(int mesafe)
        {
            if (mesafe < 0)
            {
                MessageBox.Show("Mesafe sýfýrdan küçük olamaz.", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 0;
            }

            if (mesafe > 0 && mesafe <= 200)
            {
                return 1;
            }
            else if (mesafe > 200 && mesafe <= 250)
            {
                return 1.5F;
            }
            else if (mesafe > 250 && mesafe <= 400)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}