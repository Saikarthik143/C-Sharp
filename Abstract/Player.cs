using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Player
    {
        protected string _name, _teamName;
        protected int _noOfMatches;
        public Player(string name, string team, int match)
        {
            this._name = name;
            this._teamName = team;
            this._noOfMatches = match;
            
        }
        public abstract void DisplayPlayerStatistics();
    }
        class Cricket : Player
        {
            int totalrun, wic;
            public Cricket(string name, string team, int match,int Run, int Wicket):base(name,team,match)
            {
                this.totalrun = Run;
                this.wic = Wicket;
            }
            public override void DisplayPlayerStatistics()
            {
                Console.WriteLine("player name:  "+this._name +"\n he belongs to team :"+this._teamName+"\n no of matches played :"+this._noOfMatches+ "\n total runs scored: " + this.totalrun + "\n wickets taken :" + this.wic);
            }
        }
        class Hockey : Player
        {
        string _pos;
        int noOfgoals;
        public Hockey(string name, string team, int match, string pos,int goal): base(name, team, match)
        {
            this._pos = pos;
            this.noOfgoals = goal;
        }
        public override void DisplayPlayerStatistics()
        {
            Console.WriteLine("player name: "+this._name + "\n he belongs to team " + this._teamName + "\n no of matches played " + this._noOfMatches + "\n the position of a player:" + this._pos + " \n no of goals:" + this.noOfgoals);
        }
    }
}
