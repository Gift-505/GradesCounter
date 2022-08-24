using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradesCounter
{
    public partial class Form1 : Form
    {
        private List<int> _marks;
        public Form1()
        {
            InitializeComponent();
        _marks = new List<int>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            int mark = (int)_numMark.Value;
            _marks.Add(mark);
            _lstMarks.Items.Add(mark);
            Count();
        }
        private void Count()
        {
            int sum = 0;
            for(int i = 0; i < _marks.Count; i++)
            {
                sum += _marks[i];
            }
            double output = sum / (double)_marks.Count;
            _lblOutput.Text = output.ToString();
        }

        private void _btnRemove_Click(object sender, EventArgs e)
        {
            if (_lstMarks.SelectedIndex == -1)
                return;
            _marks.RemoveAt(_lstMarks.SelectedIndex);
            _lstMarks.Items.RemoveAt(_lstMarks.SelectedIndex);
            Count();
;        }
    }
}
