using System;
using Lab3_sharp.Model;
using System.Windows.Forms;

namespace Lab3_sharp.View
{
    public partial class WorkerForm : Form
    {
        public Workers Worker { get; set; }
        public WorkerForm()
        {
            InitializeComponent();
            btAddWorker.Click += OnAddWorker;
            btRemoveWorker.Click += OnRemoveWorker;
        }
        public WorkerForm SetWorker(Workers worker)
        {
            if (worker == null)
                return this;

            Worker = worker;
            tbWorkName.Text = Worker.Worker_name;
            tbWorkSur.Text = Worker.Worker_family;
            numId.Value = Worker.Worker_ID;
            var X = double.Parse(tbWorkSalary.Text.Replace('.', ','));
            X = Worker.Worker_salary;
            return this;
        }
        private void OnAddWorker(object sender, EventArgs e)
        {
            int ABC = (int)numId.Value;
            foreach (var item in Program.workers)
            {
                if (item == ABC)
                {
                    throw new IndexOutOfRangeException("Such id is already contained. Change the value of the id field");
                }
            }
            Program.workers.Add(ABC);
            var X = double.Parse(tbWorkSalary.Text.Replace('.', ','));
            Worker = new Workers(tbWorkName.Text, tbWorkSur.Text, (int)numId.Value, X);
            lbxWorkers.Items.Clear();
            Storage.AddWorker(Worker);
            lbxWorkers.Items.AddRange(Storage.Worker);
        }
        private void OnRemoveWorker(object sender, EventArgs e)
        {
            if (lbxWorkers.SelectedIndex < 0)
                return;
            var worker = Storage.Worker[lbxWorkers.SelectedIndex];
            Program.workers.Remove(worker.Worker_ID);
            Storage.RemoveWorkerByIndex(lbxWorkers.SelectedIndex, worker);

            lbxWorkers.Items.Clear();
            lbxWorkers.Items.AddRange(Storage.Worker);
        }
    }
}