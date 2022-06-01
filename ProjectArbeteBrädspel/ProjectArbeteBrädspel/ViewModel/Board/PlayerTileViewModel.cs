using ProjectArbeteBrädspel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArbeteBrädspel.ViewModel.Board
{
    public class PlayerTileViewModel : PlayerViewModel
    {
        private int column;
        public int Column
        {
            get { return column; }
            set
            {
                column = value;
                Change("Column");
            }
        }

        private int row;
        public int Row
        {
            get { return row; }
            set
            {
                row = value;
                Change("Row");
            }
        }

        public PlayerTileViewModel(int column, int row, Player player) : base(player)
        {
            this.column = column;
            this.row = row;
        }
    }
}
