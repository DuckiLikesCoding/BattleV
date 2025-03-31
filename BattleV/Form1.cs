using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleV
{
    public partial class BattleV : Form
    {

        public BattleV()
        {
            InitializeComponent();
        }

        private void BattleV_Load(object sender, EventArgs e)
        {
            Animal tiger = new Animal("Tiger", 80, MoveSetRepository.tigerMoves);
        }
    }
}
