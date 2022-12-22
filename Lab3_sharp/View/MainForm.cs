using System;
using Lab3_sharp.Model;
using System.Windows.Forms;

namespace Lab3_sharp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Program.f1 = this;

            InitializeComponent();
            btAdd.Click += OnAddRoom;
            btRemove.Click += OnRemoveRoom;
            lbxRooms.DoubleClick += OnEditRoom;
            btClone.Click += OnCloneRoom;
            btWorker.Click += OnAddWorker;


        }
        private void OnAddRoom(object sender, EventArgs e)
        {
            var dialog = new RoomForm();
            dialog.StartPosition = FormStartPosition.CenterParent;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lbxRooms.Items.Clear();
                Storage.AddRoom(dialog.Studio);
                lbxRooms.Items.AddRange(Storage.Room);
            }

        }
        private void OnRemoveRoom(object sender, EventArgs e)
        {
            if (lbxRooms.SelectedIndex < 0)
                return;
            var room = Storage.Room[lbxRooms.SelectedIndex];
            Program.rooms.Remove(room.Studio_name);
            Storage.RemoveRoomByIndex(lbxRooms.SelectedIndex, room);
            lbxRooms.Items.Clear();
            lbxRooms.Items.AddRange(Storage.Room);
        }
        private void OnEditRoom(object sender, EventArgs e)
        {
            if (lbxRooms.SelectedIndex < 0)
                return;

            var room = Storage.Room[lbxRooms.SelectedIndex];
            Program.Instr = room.Instruments;
            Program.Worker = room.Workers_count;
            Program.rooms.Remove(room.Studio_name);


            var dialog = new RoomForm().SetRoom(room);
            dialog.StartPosition = FormStartPosition.CenterParent;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Storage.Room[lbxRooms.SelectedIndex] =
                    dialog.Studio;

                lbxRooms.Items[lbxRooms.SelectedIndex] =
                    Storage.Room[lbxRooms.SelectedIndex];

            }
        }
        private void OnCloneRoom(object sender, EventArgs e)
        {
            if (lbxRooms.SelectedIndex < 0)
                return;
            var room = Storage.Room[lbxRooms.SelectedIndex];
            Program.Instr = room.Instruments;
            Program.Worker = room.Workers_count;

            lbxRooms.Items.Clear();
            Storage.CloneRoom(room);
            lbxRooms.Items.AddRange(Storage.Room);

            var new_instr = (int)Program.f2.numInstr.Value;
            var new_workers = (int)Program.f2.numWorkers.Value;
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
        }
        private void OnAddWorker(object sender, EventArgs e)
        {
            WorkerForm form = new WorkerForm();
            form.Show();
        }
    }
}
