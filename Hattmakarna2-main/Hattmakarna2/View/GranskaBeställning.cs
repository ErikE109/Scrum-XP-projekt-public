using BLL;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using Models;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using Color = iText.Kernel.Colors.Color;
using Image = iText.Layout.Element.Image;
using Tab = iText.Layout.Element.Tab;
using TabAlignment = iText.Layout.Properties.TabAlignment;
using Table = iText.Layout.Element.Table;
using Text = iText.Layout.Element.Text;

namespace View
{
    public partial class GranskaBeställning : Form
    {
        private Beställning beställning;
        private Kund kund;
        private Personal personal;
        private Hatt hatt;
        private BeställningController beställningscontroller;
        private KundController kundController;
        private PersonalController personalController;
        private HattController hattController;
        private MaterialController materialController;
        private DekorationController dekorationController;
        private List<int> antalDekorationer;
        private List<double> mängdTyg;
        private List<Hatt> hattar;
        private DataGridView startDataGrid;
        private DataGridView beställningDataGrid;
        private Form1 _parentForm;

        List<Material> material = new List<Material>();
        List<Dekoration> dekorationer = new List<Dekoration>();

        int beställningsID;


        public GranskaBeställning(int beställningsID, DataGridView datagrid1, DataGridView datagrid2, Form1 form)
        {
            InitializeComponent();
            materialController = new MaterialController();
            dekorationController = new DekorationController();
            beställningscontroller = new BeställningController();
            kundController = new KundController();
            hattController = new HattController();
            personalController = new PersonalController();
            beställning = beställningscontroller.GranskaBeställning(beställningsID);
            personal = new Personal();
            hattController = new HattController();
            hattar = hattController.GetAllaHattar().Where(h => h.BeställningsID == beställning.Id).ToList();
            hatt = new Hatt();
            antalDekorationer = new List<int>();
            mängdTyg = new List<double>();
            startDataGrid = datagrid2;
            beställningDataGrid = datagrid1;
            _parentForm = form;
            kund = kundController.hämtaEnKund(beställning.KundID);

            label19.Text = label19.Text;

            cbbTyg.DisplayMember = "Typ";
            cbbTyg.Items.AddRange(materialController.hämtaMaterialer().ToArray());

            cbbDekoration.DisplayMember = "Typ";
            cbbDekoration.Items.AddRange(dekorationController.hämtaAllaDekorationer().ToArray());

            this.beställningsID = beställningsID;

            fyllInfo(beställning);
        }

        public void fyllInfo(Beställning beställning)
        {
            List<Kund> kunder = kundController.hämtaKunder().ToList();
            foreach (var kund in kunder)
            {
                cbbKund.Items.Add(kund.Name);
                if (kund.Id == beställning.KundID)
                {
                    cbbKund.SelectedItem = kund.Name;
                    this.kund = kund;
                }
            }

            tbxAdress.Text = beställning.LeveransAdress;
            tbxPostNummer.Text = beställning.Postnummer;
            tbxOrt.Text = beställning.Ort;
            tbxLand.Text = beställning.Land;

            List<Personal> personal = personalController.GetAll().ToList();
            foreach (var p in personal)
            {
                cbbSkapadAv.Items.Add(p.Name);
                if (p.Id == beställning.PersonalId)
                {
                    cbbSkapadAv.SelectedItem = p.Name;
                    this.personal = p;
                }
            }
            hatt = hattController.GetAllaHattar().Where(h => h.BeställningsID == beställning.Id).FirstOrDefault();
            cbbHuvudmmått.SelectedItem = hatt.Storlek;


            List<HattMaterial> hattMaterial = materialController.HämtaHattMaterial().Where(m => m.HattId == hatt.Id).ToList();
            foreach (var hm in hattMaterial)
            {
                Material ettMaterial = materialController.hämtaMaterialer().Where(m => m.Id == hm.MaterialId).FirstOrDefault();

                material.Add(ettMaterial);
                mängdTyg.Add(hm.Mängd);

                ListViewItem newList = new ListViewItem(ettMaterial.Typ);
                newList.SubItems.Add(hm.Mängd.ToString());
                lvTyg.Items.Add(newList);
            }


            List<HattDekoration> hattDekorationer = dekorationController.HämtaAllaHattDekorationer().Where(d => d.HattId == hatt.Id).ToList();
            foreach (var hd in hattDekorationer)
            {
                Dekoration enDekoration = dekorationController.hämtaAllaDekorationer().Where(d => d.Id == hd.DekorationId).FirstOrDefault();

                dekorationer.Add(enDekoration);
                antalDekorationer.Add(hd.Antal);

                if (enDekoration != null)
                {
                    ListViewItem newList = new ListViewItem(enDekoration.Typ);
                    newList.SubItems.Add(hd.Antal.ToString());
                    lvDekoration.Items.Add(newList);
                }

            }

            tbxTid.Text = hatt.TidsÅtgång.ToString();
            tbxBeskrivning.Text = beställning.Beskrivning;
            lblPris.Text = beställning.TotalPris.ToString() + " kr";
            if (kundController.HämtaAntalBeställningarKund(kund) >= 5)
            {
                var rabatteratPris = beställning.TotalPris * 0.9;
                lblPris.Font = new Font(lblPris.Font, FontStyle.Strikeout);

                lblNyttPris.Text = rabatteratPris.ToString() + " kr";

            }
            cbbOrderStatus.SelectedIndex = cbbOrderStatus.FindStringExact(beställning.Status);

            if (!hatt.Typ.Equals("Specialhatt"))
            {
                panTygDek.Hide();
            }

        }

        private void tbxTid_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbKund_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Cell skapaCell(String text, TextAlignment alignment, Color color)
        {
            Cell cell = new Cell().Add(new Paragraph(text));
            cell.SetPaddingLeft(4);
            cell.SetTextAlignment(alignment);
            cell.SetBorder(new SolidBorder(ColorConstants.WHITE, 0, 5));
            cell.SetBackgroundColor(color);
            return cell;
        }

        public Cell skapaCellUtanBorder(String text, TextAlignment alignment, Color color)
        {
            Cell cell = new Cell().Add(new Paragraph(text));
            cell.SetPadding(4);
            cell.SetPaddingBottom(10);
            cell.SetPaddingTop(10);
            cell.SetTextAlignment(alignment);
            cell.SetBorder(Border.NO_BORDER);
            cell.SetBackgroundColor(color);
            return cell;
        }

        public String ÖversättTillEngelska(String word)
        {
            var toLanguage = "en";
            var fromLanguage = "sv";
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(word)}";
            var webClient = new WebClient
            {
                Encoding = Encoding.UTF8
            };
            var result = webClient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                return result;
            }
            catch
            {
                return "Error";
            }
        }


        private void btnSkapaFaktura_Click(object sender, EventArgs e)
        {
            String path = @".\faktura.pdf";
            PdfWriter writer = new PdfWriter(path);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document document = new Document(pdfDoc);


            document.Add(new Paragraph().Add(new Text("Hattmakarna")).SetFontSize(16).AddTabStops(new TabStop(1000, TabAlignment.RIGHT))
                .Add(new Tab())
                .Add(new Text("FAKTURA")).SetFontSize(20));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph().Add(new Text("")).AddTabStops(new TabStop(1000, TabAlignment.RIGHT))
                .Add(new Tab())
                .Add(new Text("Utskriftsdatum " + DateTime.Today.ToShortDateString())).SetFontSize(12));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));

            Table table = new Table(new float[] { 1, 1, 1 }).UseAllAvailableWidth().SetFixedLayout();
            table.AddCell(skapaCell("KundId ", TextAlignment.LEFT, ColorConstants.WHITE).SetBold());
            table.AddCell(skapaCell("FakturaId ", TextAlignment.LEFT, ColorConstants.WHITE).SetBold());
            table.AddCell(skapaCell("Betalningsvillkor", TextAlignment.RIGHT, ColorConstants.WHITE).SetBold());

            table.AddCell(skapaCell(kund.Id.ToString(), TextAlignment.LEFT, ColorConstants.WHITE));
            table.AddCell(skapaCell("9876543210", TextAlignment.LEFT, ColorConstants.WHITE));
            table.AddCell(skapaCell("30 dagar", TextAlignment.RIGHT, ColorConstants.WHITE));
            document.Add(table);

            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));

            Table table1 = new Table(new float[] { 1, 1, 1 }).UseAllAvailableWidth().SetFixedLayout();

            table1.AddCell(skapaCell(kund.Name, TextAlignment.LEFT, ColorConstants.WHITE));
            table1.AddCell(skapaCell(" ", TextAlignment.RIGHT, ColorConstants.WHITE));
            table1.AddCell(skapaCell("Förfallodatum", TextAlignment.RIGHT, ColorConstants.WHITE).SetBold());

            table1.AddCell(skapaCell(kund.Adress, TextAlignment.LEFT, ColorConstants.WHITE));
            table1.AddCell(skapaCell("", TextAlignment.RIGHT, ColorConstants.WHITE));
            table1.AddCell(skapaCell(DateTime.Today.AddDays(30).ToShortDateString(), TextAlignment.RIGHT, ColorConstants.WHITE));

            table1.AddCell(skapaCell(kund.Postnummer + " " + kund.Ort, TextAlignment.LEFT, ColorConstants.WHITE));
            table1.AddCell(skapaCell("", TextAlignment.RIGHT, ColorConstants.WHITE));
            table1.AddCell(skapaCell("", TextAlignment.RIGHT, ColorConstants.WHITE));



            document.Add(table1);


            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));

            document.Add(new LineSeparator(new SolidLine()));

            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));

            document.Add(new Paragraph("Beställningsbeskrivning: ").SetBold());
            document.Add(new Paragraph(beställning.Beskrivning));
            document.Add(new Paragraph(""));


            Table table2 = new Table(new float[] { 1, 1, 1, 1 }).UseAllAvailableWidth().SetFixedLayout();

            table2.AddCell(skapaCell("PRODUKT", TextAlignment.LEFT, ColorConstants.GRAY)).SetBorder(new SolidBorder(ColorConstants.WHITE, 1));
            table2.AddCell(skapaCell("ANTAL", TextAlignment.LEFT, ColorConstants.GRAY));
            table2.AddCell(skapaCell("STORLEK", TextAlignment.LEFT, ColorConstants.GRAY));
            table2.AddCell(skapaCell("BELOPP", TextAlignment.LEFT, ColorConstants.GRAY));


            foreach (Hatt hatt in hattar)
            {
                table2.AddCell(skapaCell(hatt.Typ, TextAlignment.LEFT, ColorConstants.WHITE));
                table2.AddCell(skapaCell("1", TextAlignment.LEFT, ColorConstants.WHITE));
                table2.AddCell(skapaCell(hatt.Storlek, TextAlignment.LEFT, ColorConstants.WHITE));
                table2.AddCell(skapaCell(hatt.Pris.ToString(), TextAlignment.LEFT, ColorConstants.WHITE));
            }

            document.Add(table2);

            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));

            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            if (kundController.HämtaAntalBeställningarKund(kund) >= 5)
            {
                document.Add(new Paragraph("10% rabatt")).SetTextAlignment(TextAlignment.RIGHT);
            }

            Table table3 = new Table(new float[] { 3, 1 }).UseAllAvailableWidth().SetFixedLayout();

            table3.AddCell(skapaCellUtanBorder("SUMMA ATT BETALA:", TextAlignment.RIGHT, ColorConstants.LIGHT_GRAY));
            if (kundController.HämtaAntalBeställningarKund(kund) >= 5)
            {
                var rabatteratPris = beställning.TotalPris * 0.9;
                table3.AddCell(skapaCellUtanBorder(rabatteratPris.ToString(), TextAlignment.LEFT, ColorConstants.LIGHT_GRAY));
            }
            else
            {
                table3.AddCell(skapaCellUtanBorder(beställning.TotalPris.ToString(), TextAlignment.LEFT, ColorConstants.LIGHT_GRAY));

            }


            document.Add(table3);

            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));

            Table table4 = new Table(new float[] { 3, 2 }).UseAllAvailableWidth().SetFixedLayout();

            table4.AddCell(skapaCell("", TextAlignment.RIGHT, ColorConstants.WHITE));
            table4.AddCell(skapaCell("BETALNINGSUPPGIFTER", TextAlignment.LEFT, ColorConstants.WHITE).SetBold());
            document.Add(table4);

            Table table5 = new Table(new float[] { 3, 1, 1 }).UseAllAvailableWidth().SetFixedLayout();

            table5.AddCell(skapaCell("", TextAlignment.RIGHT, ColorConstants.WHITE));
            table5.AddCell(skapaCell("Bankgiro", TextAlignment.LEFT, ColorConstants.WHITE));
            table5.AddCell(skapaCell(" 123-4567", TextAlignment.LEFT, ColorConstants.WHITE));

            table5.AddCell(skapaCell("", TextAlignment.RIGHT, ColorConstants.WHITE));
            table5.AddCell(skapaCell("OCR/Referens", TextAlignment.LEFT, ColorConstants.WHITE));
            table5.AddCell(skapaCell("9876543210", TextAlignment.LEFT, ColorConstants.WHITE));

            document.Add(table5);



            document.Close();
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@".\faktura.pdf")
            {
                UseShellExecute = true,
            };
            p.Start();
        }

        private void btnSkapaFraktsedel_Click(object sender, EventArgs e)
        {
            String path = @".\fraktsedel.pdf";
            PdfWriter writer = new PdfWriter(path);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document document = new Document(pdfDoc);

            if (!Regex.IsMatch(tbxVikt.Text, "[0-9]+") || string.IsNullOrEmpty(tbxVikt.Text))
            {
                MessageBox.Show("Vänligen ange vikt innan du skapar en fraktsedel");
                return;
            }
            //DESIGN

            document.Add(new Paragraph("FRAKTSEDEL").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));

            document.Add(new Paragraph(""));
            document.Add(new Paragraph("FROM: ").SetBold());
            document.Add(new Paragraph().Add(new Text(" ")).AddTabStops(new TabStop(80, TabAlignment.LEFT))
            .Add(new Tab())
            .Add(new Text("Hattmakarna")));
            document.Add(new Paragraph().Add(new Text(" ")).AddTabStops(new TabStop(80, TabAlignment.LEFT))
            .Add(new Tab())
            .Add(new Text("Hattmakaregatan 3")));
            document.Add(new Paragraph().Add(new Text(" ")).AddTabStops(new TabStop(80, TabAlignment.LEFT))
            .Add(new Tab())
            .Add(new Text("123 45 Örebro")));
            document.Add(new Paragraph().Add(new Text(" ")).AddTabStops(new TabStop(80, TabAlignment.LEFT))
            .Add(new Tab())
            .Add(new Text("SWEDEN")));
            document.Add(new Paragraph(""));
            document.Add(new LineSeparator(new SolidLine()));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph("TO: ").SetBold());
            document.Add(new Paragraph().Add(new Text(" ")).AddTabStops(new TabStop(80, TabAlignment.LEFT))
            .Add(new Tab())
            .Add(new Text(kund.Name)));
            document.Add(new Paragraph().Add(new Text(" ")).AddTabStops(new TabStop(80, TabAlignment.LEFT))
            .Add(new Tab())
            .Add(new Text(beställning.LeveransAdress)));
            document.Add(new Paragraph().Add(new Text(" ")).AddTabStops(new TabStop(80, TabAlignment.LEFT))
            .Add(new Tab())
            .Add(new Text($"{beställning.Postnummer} {beställning.Ort}")));
            document.Add(new Paragraph().Add(new Text(" ")).AddTabStops(new TabStop(80, TabAlignment.LEFT))
            .Add(new Tab())
            .Add(new Text(ÖversättTillEngelska(beställning.Land).ToUpper())));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new LineSeparator(new SolidLine()));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph("Weight: " + tbxVikt.Text + " kg").SetBold());
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph("Gift:").SetBold());
            Cell cell2 = new Cell(1, 1);
            Table table = new Table(1, false);
            if (cbxGåva.Checked)
            {

                cell2.SetTextAlignment(TextAlignment.CENTER).SetWidth(50).SetHeight(40)
                .Add(new Paragraph("X").SetFontSize(30));

                table.AddCell(cell2);
            }
            else
            {
                cell2.SetTextAlignment(TextAlignment.CENTER).SetWidth(50).SetHeight(40)
                .Add(new Paragraph(""));
            }
            document.Add(new Paragraph(""));

            table.AddCell(cell2);
            document.Add(table);

            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph().Add(new Text("Commodity Code:")).SetBold().SetFontSize(14).AddTabStops(new TabStop(80, TabAlignment.LEFT))
            .Add(new Tab())
            .Add(new Text("6504 00 00").SetBorder(new SolidBorder(3)).SetFontSize(16)));

            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));


            if (File.Exists(@"..\..\streckkod.jpg"))
            {
                Image img = new Image(ImageDataFactory.Create(@"..\..\streckkod.jpg"));
                document.Add(img).SetTextAlignment(TextAlignment.CENTER);
            }


            document.Close();
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@".\fraktsedel.pdf")
            {
                UseShellExecute = true,
            };
            p.Start();


        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            var adress = tbxAdress.Text;
            var postnummer = tbxPostNummer.Text;
            var ort = tbxOrt.Text;
            var land = tbxLand.Text;
            var beskrivning = tbxBeskrivning.Text;
            string orderstatus = cbbOrderStatus.SelectedItem.ToString();

            if (String.IsNullOrEmpty(adress) || String.IsNullOrEmpty(postnummer) || String.IsNullOrEmpty(ort) || String.IsNullOrEmpty(land))
            {
                MessageBox.Show("Vänligen kontrollera adressuppgifter");
                return;
            }

            if (postnummer.Length > 8)
            {
                MessageBox.Show("Postnummer får bestå av max 8 tecken");
                return;
            }
            if (!Regex.IsMatch(ort, "[a-zA-ZåäöÅÄÖ]+") || !Regex.IsMatch(land, "[a-zA-ZåäöÅÄÖ]+"))
            {
                MessageBox.Show("Rutorna ort och land accepterar bokstäver");
                return;
            }

            var storlek = cbbHuvudmmått.Text;



            if (cbbOrderStatus == null)
            {
                MessageBox.Show("Var vänlig ange orderstatus");
                return;
            }

            var tid = double.Parse(tbxTid.Text);


            hattar.Clear();
            if (hatt.Typ.Equals("Specialhatt"))
            {
                if (material.Count == 0 && dekorationer.Count == 0)
                {
                    MessageBox.Show("Du har varken valt några dekorationer eller tyger");
                    return;
                }

                if (String.IsNullOrEmpty(tbxTid.Text))
                {
                    MessageBox.Show("Du har inte angett någon arbetstid");
                    return;
                }


                hattar.Add(hattController.UppdateraSpecialhatt(hatt, tid, storlek, antalDekorationer, mängdTyg, dekorationer, material));
            }
            else
            {
                hattar.Add(hattController.UppdateraStandardHatt(hatt, storlek));
            }



            if (beställningscontroller.UppdateraBeställning(kund.Id, adress, personal.Id, beskrivning, postnummer, ort, land, hattar, beställning, orderstatus))
            {

                _parentForm.FyllDataGridBeställning(beställningDataGrid);
                _parentForm.FyllDataGridBeställning(startDataGrid);

                MessageBox.Show("Beställningen är uppdaterad");


                Dispose();
            }
            else
            {
                MessageBox.Show("Något gick fel");
                this.Dispose();
            }



        }

        public void PresenteraNyttPris(object sender, EventArgs e)
        {
            double pris = 0;

            var tid = tbxTid.Text;
            if (!Regex.IsMatch(tid, "[0-9]+") || string.IsNullOrEmpty(tid))
            {
                tid = "0";
            }

            pris = (double.Parse(tid) * 800) + dekorationController.DekorationsPriser(antalDekorationer, dekorationer) + materialController.MaterialPriser(mängdTyg, material);

            if (kundController.HämtaAntalBeställningarKund(kund) >= 5)
            {
                var rabatteratPris = pris * 0.9;
                lblPris.Text = pris.ToString() + " kr";
                lblPris.Font = new Font(lblPris.Font, FontStyle.Strikeout);

                lblNyttPris.Text = rabatteratPris.ToString() + " kr";

            }
            else
            {
                lblPris.Text = pris.ToString() + " kr";
            }



        }

        private void btnTAdd_Click(object sender, EventArgs e)
        {
            Material valtmaterial = (Material)cbbTyg.SelectedItem;

            lvTyg.Items.Clear();
            if (material.Contains(valtmaterial))
            {
                //MessageBox.Show($"{valtmaterial.Typ} finns redan tillagd i hatten");
                var index = material.IndexOf(valtmaterial);
                mängdTyg[index] = (int.Parse(tbxTygLängd.Text));

                for (int i = 0; i < material.Count; i++)
                {
                    ListViewItem newList = new ListViewItem(material[i].Typ);
                    newList.SubItems.Add(mängdTyg[i].ToString());
                    lvTyg.Items.Add(newList);

                }


            }
            else if (String.IsNullOrEmpty(tbxTygLängd.Text) || String.IsNullOrEmpty(cbbTyg.Text))
            {
                MessageBox.Show("Du har inte valt ett tyg eller lagt till tyglängd");
            }
            else
            {
                material.Add(valtmaterial);
                mängdTyg.Add(double.Parse(tbxTygLängd.Text));

                for (int i = 0; i < material.Count; i++)
                {
                    ListViewItem newList = new ListViewItem(material[i].Typ);
                    newList.SubItems.Add(mängdTyg[i].ToString());
                    lvTyg.Items.Add(newList);


                }


                btnTAdd.Text = "Uppdatera";


            }
        }

        private void cbbTyg_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material valtmaterial = (Material)cbbTyg.SelectedItem;

            if (material.Contains(valtmaterial))
            {
                int index = material.IndexOf(valtmaterial);
                tbxTygLängd.Text = mängdTyg[index].ToString();
                btnTAdd.Text = "Uppdatera";
            }
            else
            {
                tbxTygLängd.Clear();
                btnTAdd.Text = "Lägg till";
            }
        }

        private void btnDAdd_Click(object sender, EventArgs e)
        {
            lvDekoration.Items.Clear();
            var valdDekoration = (Dekoration)cbbDekoration.SelectedItem;
            if (dekorationer.Contains(valdDekoration))
            {

                var index = dekorationer.IndexOf(valdDekoration);
                antalDekorationer[index] = (int.Parse(tbxDekoration.Text));

                for (int i = 0; i < dekorationer.Count; i++)
                {
                    ListViewItem newList = new ListViewItem(dekorationer[i].Typ);
                    newList.SubItems.Add(antalDekorationer[i].ToString());
                    lvDekoration.Items.Add(newList);
                }




            }
            else if (String.IsNullOrEmpty(tbxDekoration.Text) || String.IsNullOrEmpty(cbbDekoration.Text))
            {
                MessageBox.Show("Du har inte lagt till en dekoration eller dekorationsantal");
            }
            else
            {
                dekorationer.Add(valdDekoration);
                antalDekorationer.Add(int.Parse(tbxDekoration.Text));
                var tid = tbxTid.Text;

                for (int i = 0; i < dekorationer.Count; i++)
                {
                    ListViewItem newList = new ListViewItem(dekorationer[i].Typ);
                    newList.SubItems.Add(antalDekorationer[i].ToString());
                    lvDekoration.Items.Add(newList);
                }

                btnDAdd.Text = "Uppdatera";
            }

        }

        private void cbbDekoration_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valdDekoration = (Dekoration)cbbDekoration.SelectedItem;
            if (dekorationer.Contains(valdDekoration))
            {
                int index = dekorationer.IndexOf(valdDekoration);
                tbxDekoration.Text = antalDekorationer[index].ToString();
                btnDAdd.Text = "Uppdatera";
            }
            else
            {
                tbxDekoration.Clear();
                btnDAdd.Text = "Lägg till";
            }
        }

        private void btnSkickaEpost_Click(object sender, EventArgs e)
        {
            var MailController = new MailController();
            MailController.SendConfirmationEmail(kund.Email);
            MailController.Stop();
            MessageBox.Show($"Ett email har skickats till {kund.Email}");
            cbbOrderStatus.SelectedIndex = cbbOrderStatus.FindStringExact("Förfrågan skickad");
            beställningscontroller.UppdateraBeställning(kund.Id, beställning.LeveransAdress, personal.Id, beställning.Beskrivning, beställning.Postnummer, beställning.Ort, beställning.Land, hattar, beställning, "Förfrågan skickad");
            _parentForm.FyllDataGridBeställning(beställningDataGrid);
            _parentForm.FyllDataGridBeställning(startDataGrid);
            foreach (var item in MailController.GetMailMessages())
            {
                MessageBox.Show(item.Body);
            }
        }

        private void cbbOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbOrderStatus.SelectedIndex >= cbbOrderStatus.Items.Count - 3)
            {
                btnBeställningTabort.Enabled = false;
            }
            else
            {
                btnBeställningTabort.Enabled = true;
            }
        }

        private void btnBeställningTabort_Click(object sender, EventArgs e)
        {
            beställningscontroller.Delete(beställningsID);
            MessageBox.Show("Ordern är borttagen");
            this.Close();
        }

    }
}

