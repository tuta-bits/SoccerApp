using SoccerApp.Models;
using SoccerApp.RestClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp.Services
{
    public class TeamServices
    {


        /// <summary>Gets the teams asynchronous.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public async Task<List<Team>> GetTeamsAsync()
        {

            RestClient<Team> restClient = new RestClient<Team>();

            var teamsList = await restClient.GetAsync();

            return teamsList;


            /* var list = new List<Team>
             {
                   new Team
                   {
                       Name = "Arsenal",
                       Home = "Emirates Stadium",
                       StadiumInfo = "Arsenal relocated just down the street to the state-of-the-art Emirates Stadium in 2006, despite having spent 93 years at Highbury. The Emirates holds almost 60,000 supporters, greatly surpassing the 38,000 at Highbury, and the Gunners made their debut there on July 22, 2006, with club veteran Dennis Bergkamp's testimonial."
                   },
                   new Team
                   {
                       Name = "Aston Villa",
                       Home = "Villa Park",
                       StadiumInfo = "Villa Park, Aston Villa's home since 1897, is one of a select few venues that have hosted international matches over three centuries, with the first senior international match taking place in 1899. Before the FA Cup semi-finals were transferred to Wembley, it was also a regular location for them."
                   },
                   new Team
                   {
                       Name = "Brentford",
                       Home = "Brentford Community Stadium",
                       StadiumInfo = "Brentford relocated just under a mile to the state-of-the-art Brentford Community Stadium in 2020, after having spent 116 years at Griffin Park. Brentford Football Club's new stadium is among the most momentous and thrilling events in the club's history."
                   },
                   new Team
                   {
                       Name = "Brighton and Hove Albion",
                       Home = "American Express Community Stadium",
                       StadiumInfo = "Brighton & Hove Albion transitioned into their newly constructed stadium in 2011, with a friendly match against Tottenham Hotspur on July 30, 2011. Following their final home encounter of the 2016/17 Championship season, the stadium, commonly nicknamed as The Amex Stadium, set a new record attendance of 30,338."
                   },
                   new Team
                   {
                       Name = "Burnley",
                       Home = "Turf Moor",
                       StadiumInfo = "Burnley, formerly a rugby club, switched to fooball in the nineteenth century. They were one of the original founders of the Football League and have won the Premier League twice (1920/21 and 1959/60), as well as the FA Cup once (1914). The Turfites, Moorites, and Royalites have all been names for them, but they are currently known as the Clarets."
                   },
                   new Team
                   {
                       Name = "Chelsea",
                       Home = "Stamford Bridge",
                       StadiumInfo = "Stamford Bridge is the Premier League's oldest stadium, having opened in 1887 and gone through many changes from its humble origins as the home of London Athletic Club in the nineteenth century. The stadium was first offered to Fulham FC, but after they declined, Chelsea moved in a few months after its formation in March 1905."
                   },
                   new Team
                   {
                       Name = "Crystal Palace",
                       Home = "Selhurst Park",
                       StadiumInfo = "Since its inception, Selhurst Park has undergone various modifications, the most recent of which was the erection of the two-tiered Holmesdale Road Stand in 1995. The stadium has a long and illustrious history, having hosted an England against Wales encounter as well as two Olympic matches in 1948."
                   },
                   new Team
                   {
                       Name = "Everton",
                       Home = "Goodison Park",
                       StadiumInfo = "Goodison Park was the country's first purpose-built football stadium, and the Toffees have called it home for 125 years. This is one of England's oldest and most well-known venue."
                   },
                   new Team
                   {
                       Name = "Leeds United",
                       Home = "Elland Road",
                       StadiumInfo = " Built in 1897, Elland Road is a football stadium located in the West Yorkshire city of Leeds. Home to Leeds United since the club’s formation in 1919, the ground has a capacity of 37,890. Elland Road is dominated by the East Stand on one side of the stadium. This huge stand which holds around 15,000 supporters was opened in the 1992-93 season, and is at least twice the size of the other three stands at Elland Road."
                   },
                   new Team
                   {
                       Name = "Leicester City",
                       Home = "King Power Stadium",
                       StadiumInfo = "After 111 years at Filbert Street, Leicester City relocated to the King Power Stadium in 2002. Ex Leicester and England attacker Gary Lineker officially launched the new stadium on July 23, 2002, with a match against Athletic Club de Bilbao."
                   },
                   new Team
                   {
                       Name = "Liverpool",
                       Home = "Anfield",
                       StadiumInfo = "Liverpool Football Club has called Anfield home since its inception in 1892. The Reds, on the other hand, were not the first team to play at the venue. Everton played at Anfield for eight years before ending their tenancy. The Kop was remodelled in 1928 to accommodate 30,000 standing supporters and quickly had a reputation for being one of the loudest football stands in the country. The Main Stand was renovated at the start of the 2016/17 season, increasing the capacity by 8,000 seats."
                   },
                   new Team
                   {
                       Name = "Manchester City",
                       Home = "Etihad Stadium",
                       StadiumInfo = "After 80 years at Maine Road, Manchester City relocated into the Etihad Stadium, previously known as the City of Manchester Stadium, in 2003. The Etihad Stadium, located in Manchester's eastern district, first opened its doors in 2002 as the Athletics Stadium for the 2002 Commonwealth Games."
                   },
                   new Team
                   {
                       Name = "Mancheter United",
                       Home = "Old Trafford",
                       StadiumInfo = "Old Trafford is England's largest Premiership stadium and one of the most famous football stadiums in the world. The stadium was built near to the Bridgewater Canal in 1910, and it has been Man Utd's home ever since, with the exception of an eight-year break due to bomb damage experienced during WWII. There are several tributes to the club's great past throughout the stadium, including statues of Sir Matt Busby, Sir Alex Ferguson, and the 'Holy Trinity' of Denis Law, Sir Bobby Charlton, and George Best positioned throughout the 'Theatre of Dreams.'"
                   },
                   new Team
                   {
                       Name = "NewCastle United",
                       Home = "St. James' Park",
                       StadiumInfo = "Newcastle United has called St. James' Park home since 1982, and it has undergone numerous renovations since then. Upon the most recent major renovation, which was completed in 2000, the stadium now holds over 52,000 supporters, making it the UK's 11th largest stadium."
                   },
                   new Team
                   {
                       Name = "Norwich City",
                       Home = "Carrow Road",
                       StadiumInfo = "Norwich City's official home ground is Carrow Road, a football stadium with a capacity of 26,034. The stadium, which is located between Norwich train station and the river Wensum, has underwent various renovations during its history."
                   },
                   new Team
                   {
                       Name = "Southampton",
                       Home = "St Mary's Stadium",
                       StadiumInfo = "After 103 years at the Dell, Southampton relocated to St Mary's in 2001. Southampton were formed by members of the St Mary's Church Young Men's Association, therefore the relocation was in accordance with the club's tradition."
                   },
                   new Team
                   {
                       Name = "Tottenham Hotspur",
                       Home = "Tottenham Hotspur Stadium",
                       StadiumInfo = "Built on the site of their 118-year White Hart Lane home, Tottenham Hotspur Stadium was opened during the 2018/19 season."
                   },
                   new Team
                   {
                       Name = "Watford",
                       Home = "Vicarage Road",
                       StadiumInfo = "Watford's home since moving from Cassio Road in 1922 has been Vicarage Road, affectionately known as The Vic among Hornets fans. The two Main Stands honour club legends Sir Elton John and Graham Taylor, who served as owner and manager during the club's most prosperous era."
                   },
             };

             return list; */
        }



        /// <summary>Posts the teams asynchronous.</summary>
        /// <param name="team">The team.</param>
        public async Task PostTeamsAsync(Team team)
        {

            RestClient<Team> restClient = new RestClient<Team>();

            var teamsList = await restClient.PostAsync(team);
        }


        /// <summary>Puts the teams asynchronous.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="team">The team.</param>
        public async Task PutTeamsAsync(int id, Team team)
        {

            RestClient<Team> restClient = new RestClient<Team>();

            var teamsList = await restClient.PutAsync(id, team);
        }



        /// <summary>Deletes the teams asynchronous.</summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteTeamsAsync(int id)
        {

            RestClient<Team> restClient = new RestClient<Team>();

            var teamsList = await restClient.DeleteAsync(id);
        }

    }
}

