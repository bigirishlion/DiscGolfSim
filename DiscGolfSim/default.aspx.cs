using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiscGolfSim
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Player player1 = new Player("Aaron");
            player1.Level = 1;

            Player player2 = new Player("Ian");
            player2.Level = 1;

            List<Player> players = new List<Player>();

            players.Add(player1);
            players.Add(player2);

            Game game = new Game(players,6);
            resultLabel.Text = game.DisplayResults();
        }
    }
}