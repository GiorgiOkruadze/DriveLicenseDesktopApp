using DriveLicense_PCL.Implementacions;
using DriveLicense_PCL.Implementacions.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveLicense
{
    public partial class MainPage : Form
    {
        private List<DriverLicenseTopicsModel> TopicsModels;
        private List<Label> MainPageLabels;
        private GetTopicsModels getTopics = new GetTopicsModels();
        private List<DriverLicenseTopicsModel> MySelectedTopics = new List<DriverLicenseTopicsModel>();
        public Action<List<DriverLicenseTopicsModel>> TicketsFilter;
        public MainPage()
        {
            InitializeComponent();

            MainPageLabels = this.panel1.Controls.OfType<Label>()
                .Where(o => o.Name.StartsWith("lab"))
                .ToList();

            StartAppliaction();

            AddEventOnLabels();
        }

        private void AddEventOnLabels()
        {
            foreach (var lb in MainPageLabels)
            {
                lb.MouseEnter += OnMouseEnterLabel;
                lb.MouseLeave += OnMouseLeaveLabel;
                lb.MouseClick += OnMouseClick;
            }
        }
        private void OnMouseEnterLabel(object sender, EventArgs e)
        {
            Label MyLable = sender as Label;
            if(MyLable.BackColor == SystemColors.ControlDark)
                MyLable.BackColor = SystemColors.Highlight;
        }
        private void OnMouseLeaveLabel(object sender, EventArgs e)
        {
            Label MyLable = sender as Label;
            if (MyLable.BackColor == SystemColors.Highlight)
                MyLable.BackColor = SystemColors.ControlDark;
        }
        private void OnMouseClick(object sender, EventArgs e)
        {
            Label ThisLabel = sender as Label;

            if(ThisLabel.BackColor == Color.Green)
            {
                ThisLabel.BackColor = SystemColors.ControlDark;

                if(ThisLabel == labAllTests)
                    MySelectedTopics.Clear();

                else
                    MySelectedTopics.Remove(TopicsModels.First(o => o.Name == ThisLabel.Text));
            }
            else
            {
                ThisLabel.BackColor = Color.Green;

                if (ThisLabel == labAllTests)
                {
                    MySelectedTopics = TopicsModels;
                    return;
                }

                MySelectedTopics.Add(TopicsModels.First(o => o.Name == ThisLabel.Text));
            }
        }


        private async void StartAppliaction()
        {
            if (TopicsModels == null)
                TopicsModels = new List<DriverLicenseTopicsModel>();
            else
                return;

            TopicsModels = await Task<List<DriverLicenseTopicsModel>>.Run(async()=> {
                return await getTopics.GetTopicsDataAsync();
            });

            LabelTextAdder();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StartTest_Click(object sender, EventArgs e)
        {
            if (MySelectedTopics.Count == 0)
            {
                MessageBox.Show("ირჩიეთ კატეგორია");
                return;
            }
            this.Hide();
            TestPage ticketsPage = new TestPage();
            this.TicketsFilter = ticketsPage.GetSelectedTopics;

            TicketsFilter.Invoke(MySelectedTopics);
            ticketsPage.Show();
           
        }

        private void LabelTextAdder()
        {
            for(var i = 0; i < TopicsModels.Count; i++)
            {
                MainPageLabels[i].Text = TopicsModels[i].Name;
            }
        }
    }
}
