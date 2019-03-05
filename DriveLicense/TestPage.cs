using DriveLicense_PCL.Implementacions;
using DriveLicense_PCL.Implementacions.Service;
using DriveLicense_PCL.Implementacions.Service.GetRandomTicketsService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriveLicense
{
    public partial class TestPage : Form
    {
        private List<Label> TestPageLabels = new List<Label>();
        private List<DriverLicenseTopicsModel> SelectedTopics = new List<DriverLicenseTopicsModel>();
        private List<DriverLicenseTicketsModel> AllTickets = new List<DriverLicenseTicketsModel>();
        private List<DriverLicenseTicketsModel> SelectedTickets = new List<DriverLicenseTicketsModel>();
        private GetTicketsModels getTickets = new GetTicketsModels();
        private string ImageFileURL = $"{Directory.GetCurrentDirectory()}/images/";
        private GetTopicsRandomTicket randomTIcketsService = new GetTopicsRandomTicket();
        private Dictionary<DriverLicenseTicketsModel,int> MyClicketAnswers = new Dictionary<DriverLicenseTicketsModel, int>();
        private CorrectAnswerLogicService CorrectLogicService = new CorrectAnswerLogicService();
        private int Index = 0;
        private int CorrectAnswers = 0;
        private int FalseAnswers = 0;
        private int AnswerCounter = 0;

        public TestPage()
        {
            InitializeComponent();
            AddEventOnLabels();
            StartApp();
        }

        private void AddEventOnLabels()
        {
            TestPageLabels = this.Controls.OfType<Label>()
               .Where(o => o.Name.StartsWith("lab"))
               .ToList();

            foreach (var lb in TestPageLabels)
            {
                lb.MouseEnter += OnMouseEnterLabel;
                lb.MouseLeave += OnMouseLeaveLabel;
                lb.MouseClick += OnMouseClick;
            }
        }
        private void OnMouseEnterLabel(object sender, EventArgs e)
        {
            var MyLabel = (Label)sender;
            MyLabel.Padding = new Padding(12, 12, 0, 0);
        }
        private void OnMouseLeaveLabel(object sender, EventArgs e)
        {
            var MyLabel = (Label)sender;
            MyLabel.Padding = new Padding(10, 10, 0, 0);
        }

        public void GetSelectedTopics(List<DriverLicenseTopicsModel> topics)
        {
            SelectedTopics = topics;
        }

        private async void StartApp()
        {
            AllTickets = await Task<List<DriverLicenseTicketsModel>>.Run(()=> {
                return getTickets.GetTicketsDataAsync();
            });

            if(SelectedTopics.Count == 1)
            {
                var Topic = SelectedTopics[0];
                SelectedTickets = await Task<List<DriverLicenseTicketsModel>>.Run(() => {
                    return randomTIcketsService.GetRandomTickets(Topic, AllTickets);
                });
            }

            else
            {
                SelectedTickets = await Task<List<DriverLicenseTicketsModel>>.Run(() => {
                    return randomTIcketsService.GetRandomTickets(SelectedTopics, AllTickets);
                });
            }

            AddTickets(SelectedTickets[0]);

            SeeDesc.Visible = false;
        }

        private void AddTickets(DriverLicenseTicketsModel model)
        {
                SeeDesc.Visible = false;
                LabelShow(model);
                AnswerCounter++;
                AnswerCount.Text = $"{AnswerCounter}/{SelectedTickets.Count}";
                Question.Text = model.Question;

                for (var i = 0; i < model.TestAnswers.Count; i++)
                {
                    TestPageLabels[i].Text = model.TestAnswers[i];
                }

                QuestionImage.Image = Image.FromFile(ImageFileURL + model.Filename);

        }

        private void LabelShow(DriverLicenseTicketsModel Data)
        {
            TestPageLabels[2].Hide();
            TestPageLabels[3].Hide();

            for (var i = 0; i < Data.TestAnswers.Count; i++)
            {
                TestPageLabels[i].BackColor = SystemColors.ScrollBar;
                TestPageLabels[i].Show();
            }

            if(MyClicketAnswers.Any(o => o.Key == Data))
            {
                var ClickedAnswer = MyClicketAnswers.First(o => o.Key == Data);
                if(ClickedAnswer.Key.ClickedOrNot == 1)
                {
                    TestPageLabels[ClickedAnswer.Value].BackColor = Color.Green;
                }
                else
                {
                    TestPageLabels[ClickedAnswer.Value].BackColor = Color.Red;
                }
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (SelectedTickets == null)
            {
                MessageBox.Show("You mast start first");
                return;
            }


            if (Index == 0)
                Index = SelectedTickets.Count-1;

            Index--;
            AddTickets(SelectedTickets[Index]);

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (SelectedTickets == null)
            {
                MessageBox.Show("You mast start first");
                return;
            }

            Index++;

            if (Index == SelectedTickets.Count-1)
                Index = 0;

            AddTickets(SelectedTickets[Index]);
        }

        private async void OnMouseClick(object sender, EventArgs e)
        {
            Label CurrentLabel = sender as Label;
            int CurrentLabelIndex = TestPageLabels.IndexOf(CurrentLabel);
            DriverLicenseTicketsModel CurrentModel = SelectedTickets[Index];

            if(CurrentModel.ClickedOrNot == -1)
            {
                CurrentModel.ClickedOrNot = CorrectLogicService.CorrectAnswerLogic(CurrentModel,CurrentLabelIndex);
                MyClicketAnswers.Add(CurrentModel, CurrentLabelIndex);

                if (CurrentModel.ClickedOrNot == 1)
                {
                    CurrentLabel.BackColor = Color.Green;
                    CorrectAnswers++;
                    CorrectAns.Text = CorrectAnswers.ToString();

                    await Task.Delay(2000);
                    Next_Click(sender, e);
                }

                else
                {
                    CurrentLabel.BackColor = Color.Red;
                    FalseAnswers++;
                    FalseAns.Text = FalseAnswers.ToString();
                    SeeDesc.Visible = true;
                }
                CheckFalseAnswersCount();
            }
            
        }

        private async void SeeDesc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SelectedTickets[Index].Desc);
            await Task.Delay(1000);
            Next_Click(sender, e);
        }

        private async void CheckFalseAnswersCount()
        {
            if(FalseAnswers == 3)
            {
                await Task.Delay(500);
                MessageBox.Show("სამწუხაროდ თქვენ მოიხსენით გამოცდიდან");
                this.Hide();
                MainPage mainMenu = new MainPage();
                mainMenu.Show();
            }
        }
    }

}
