using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeZhilin2020
{
    class ObjectInfoSystem
    {
        public class User
        {
            public string first_name, last_name, phone, email;
        }
        public class Player
        {
            public int id, goals_scored, asissts, yellow_cards, red_cards, voices;
            public string first_name, last_name, nationality, positions, date_of_birth;
            public char work_foot;
        }
        public class Coach
        {
            public int Id, yellow_cards, red_cards;
            public string first_name, last_name, nationality, date_of_birth;
        }
        public class Club
        {
            public string club_location, club_info, creator_info, capitain_info, top_scorer_info, rudest_player_info, coach_info;
                   
            public int creator_id, captain_id, top_scorer_id, rudest_player_id, coach_id, 
                winning_mathes, loses_mathes, draw_mathes, goals_scored, goals_conceded;
        }
    }
}

