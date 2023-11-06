namespace StructureOfWinFormsProj
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // 1
            //MessageBox.Show("Hello World in WinForms!");

            // 2
            //Form form = new Form();
            //form.Show();
            //form.ShowDialog();

            // 3
            //Form form = new Form();
            //form.Text = "Form 1";
            //Button button1 = MakeButton("button1");
            //form.Controls.Add(button1);
            //Application.Run(form);

            //Form form2 = new Form();
            //form2.Text = "Form 2";
            //Button button2 = MakeButton("button2");
            //form2.Controls.Add(button2);
            //Application.Run(form2);

            // 4
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        private static Button MakeButton(string name)
        {
            Button button = new Button();
            button.Location = new System.Drawing.Point(10, 10);
            button.Name = name;
            button.Size = new System.Drawing.Size(75, 23);
            button.TabIndex = 0;
            button.Text = "button";
            button.UseVisualStyleBackColor = true;

            return button;
        }
    }
}