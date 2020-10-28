using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEastEF
{
    public partial class Dashboard : Form
    {
        List<DataEastArcadeList> DataEastArcadeLists = new List<DataEastArcadeList>();
        public Dashboard()
        {
            InitializeComponent();
        }
        private void UpdateBinding()
        {
            GameFoundDataGrid.DataSource = DataEastArcadeLists;
            Refresh();

        }

        private void GameFoundDataGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Title_Button_Click(object sender, EventArgs e)
        {
            DataEastArcadeLists.Clear();
            using (var context = new DataEastDatabaseContext())
            {
                var games = context.DataEastArcadeList
                    .OrderBy(b => b.Title)
                    .ToList();

                DataEastArcadeLists.AddRange(games);
            }

            UpdateBinding();
        }

        private void Release_Button_Click(object sender, EventArgs e)
        {
            DataEastArcadeLists.Clear();
            using (var context = new DataEastDatabaseContext())
            {
                var games = context.DataEastArcadeList
                    .OrderBy(b => b.ReleaseDate)
                    .ToList();

                DataEastArcadeLists.AddRange(games);
            }


            UpdateBinding();
        }
        private void Genre_Button_Click(object sender, EventArgs e)
        {
            DataEastArcadeLists.Clear();
            using (var context = new DataEastDatabaseContext())
            {
                var games = context.DataEastArcadeList
                    .OrderBy(b => b.Genre)
                    .ToList();

                DataEastArcadeLists.AddRange(games);
            }

            UpdateBinding();
        }
        private void Hardware_Button_Click(object sender, EventArgs e)
        {
            DataEastArcadeLists.Clear();

            using (var context = new DataEastDatabaseContext())
            {
                var games = context.DataEastArcadeList
                    .OrderBy(b => b.HardwareType)
                    .ToList();

                DataEastArcadeLists.AddRange(games);
            }

            UpdateBinding();
        }
    }
}
