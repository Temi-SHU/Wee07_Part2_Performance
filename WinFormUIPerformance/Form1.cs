using System;

namespace WinFormUIPerformance
{
    public partial class Form1 : Form
    {
        private delegate void UpdateDummyDelegate(string newData); // Delegate Type
        private UpdateDummyDelegate updateDummy; // Delegate Object
        public Form1()
        {
            InitializeComponent();
        }

        #region "Schronous"

        private void btnStart_Click1(object sender, EventArgs e)
        {
            EmulateLongRunningProcess();
        }
        private void EmulateLongRunningProcess()
        {
            decimal num = 0.0m;
            txtCount.Text = num.ToString();
            while (true)
            {
                num += 0.0000000000001m;
                txtCount.Text = num.ToString();
            }
        }

        #endregion

        #region "Threading"

        private async void btnStart_Click2(object sender, EventArgs e)
        {
            updateDummy = new UpdateDummyDelegate(DoDummyUpdate);

            Thread thread = new Thread(EmulateLongRunningProcessWithThread);
            thread.Start();
        }
        private void EmulateLongRunningProcessWithThread()
        {
            decimal num = 0.0m;
            while (true)
            {
                num += 0.0000000000001m;
                this.Invoke(updateDummy, num.ToString());
            }
        }

        private void DoDummyUpdate(string data)
        {
            txtCount.Text = data;
        }

        #endregion

        #region "Task asynchronous programming"
        // https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/task-asynchronous-programming-model
        private async void btnStart_Click3(object sender, EventArgs e)
        {
            await EmulateLongRunningProcessAsync();
        }
        private async Task EmulateLongRunningProcessAsync()
        {
            decimal num = 0.0m;
            txtCount.Text = num.ToString();
            while (true)
            {
                num += 0.0000000000001m;
                txtCount.Text = num.ToString();
                await Task.Delay(1); // Add a small delay to allow other tasks to run
            }
        }

        #endregion

    }
}