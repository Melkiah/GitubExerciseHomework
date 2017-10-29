using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamWorkProject
{
    class Team
    {
        public string Name { get; set; }
        public List<string> TeamMembers { get; set; }
        public string CreatorName { get; set; }

        public Team(string name, string creatorName)
        {
            this.Name = name;
            this.TeamMembers = new List<string>();
            this.CreatorName = creatorName;
        }
    }

    class TeamWorkProject
    {
        static void Main(string[] args) // not finished. still only 50/100
        {
            List<Team> Teams = new List<Team>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string creatorName = input[0];
                string teamName = input[1];

                if (TeamAlreadyExists(teamName, Teams))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                else if (UserAlreadyCreatedTeam(creatorName, Teams))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }

                Team newTeam = new Team(teamName, creatorName);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                Teams.Add(newTeam);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0].Equals("end of assignment"))
                {
                    break;
                }

                string playerName = input[0];
                string teamName = input[1];

                if (!TeamAlreadyExists(teamName, Teams))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                else if (PlayerInAnotherTeam(playerName, Teams))
                {
                    Console.WriteLine($"Member {playerName} cannot join team {teamName}!");
                    continue;
                }

                foreach (Team item in Teams)
                {
                    if (item.Name.Equals(teamName))
                    {
                        item.TeamMembers.Add(playerName);
                    }
                }

            }

            List<Team> emptyTeams = new List<Team>();

            for (int i = 0; i < Teams.Count; i++)
            {
                if (Teams[i].TeamMembers.Count == 0)
                {
                    emptyTeams.Add(Teams[i]);
                    Teams.Remove(Teams[i]);
                }
            }


            foreach (Team team in Teams.OrderByDescending(x => x.TeamMembers.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.CreatorName}");
                foreach (string player in team.TeamMembers.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {player}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team team in emptyTeams)
            {
                Console.WriteLine(team.Name);
            }

        }

        public static bool PlayerInAnotherTeam(string playerName, List<Team> teams)
        {
            foreach (Team item in teams)
            {
                if (item.CreatorName.Equals(playerName))
                {
                    return true;
                }

                foreach (string player in item.TeamMembers)
                {
                    if (player.Equals(playerName))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool UserAlreadyCreatedTeam(string creatorName, List<Team> teams)
        {
            foreach (Team item in teams)
            {
                if (item.CreatorName.Equals(creatorName))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool TeamAlreadyExists(string TeamName, List<Team> teams)
        {
            foreach (Team item in teams)
            {
                if (item.Name.Equals(TeamName))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
