using System;
using Lab3_sharp.Model;
using System.Windows.Forms;

namespace Lab3_sharp.View
{
    public partial class RoomForm : Form
    {
        
        public Studio Studio { get; set; }
        public RoomForm()
        {
            Program.f2 = this;
            InitializeComponent();
            btAdd.Click += OnAddClick;
            btCancel.Click += OnCancelClick;
        }

        public RoomForm SetRoom(Studio studio)
        {
            if (studio == null)
                return this;

            Studio = studio;
            numID.Value = Studio.Studio_name;
            numPrice.Value = Studio.Tune_price;
            numTime.Value = Studio.Tune_time;
            numWorkers.Value = Studio.Workers_count;
            numInstr.Value = Studio.Instruments;


            return this;
        }

        private void OnAddClick(object sender, System.EventArgs e)
        {
            int ABC = (int)numID.Value;
            foreach(var item in Program.rooms)
            {
                if(item == ABC)
                {
                    throw new IndexOutOfRangeException("Such id is already contained. Change the value of the id field");
                }    
            }
            Program.rooms.Add(ABC);
            Studio = new Studio(ABC, (int)numWorkers.Value, (int)numPrice.Value, (int)numTime.Value, (int)numInstr.Value);

            var new_instr = (int)numInstr.Value;
            var new_workers = (int)numWorkers.Value;
            int ZXC1 = 0, ZXC2 = 0;
            if (new_instr < Program.Instr)
            {
                ZXC1 = Program.Instr - new_instr;
            }
            else
            {
                Program.a += new_instr;
            }
            Program.a -= ZXC1;
            if (new_workers < Program.Worker)
            {
                ZXC2 = Program.Worker - new_workers;
            }
            else
            {
                Program.b += new_workers;
            }


            Program.b -= ZXC2;

            Program.f1.labelInstr.Text = Program.a.ToString();
            Program.f1.labelWorkers.Text = Program.b.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }
        private void OnCancelClick(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
