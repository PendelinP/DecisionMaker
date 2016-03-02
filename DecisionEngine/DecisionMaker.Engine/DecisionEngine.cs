using System;
using System.Collections.Generic;
using System.Linq;

namespace DecisionMaker.Engine
{
    public class DecisionEngine
    {
        /// <summary>
        /// predefined list of decisions
        /// </summary>
        private List<string> decisions = new List<string>
        {
            "Ja",
            "Nein",
            "Klar",
            "Sicher nicht",
            "Sicherlich",
            "Frag Mutti",
            "Jein",
        };

        /// <summary>
        /// Make a decision based on a predefined set of possible outcomes.
        /// </summary>
        /// <returns>The decision.</returns>
        public string MakeDecision()
        {
            return this.decisions.OrderBy(d => Guid.NewGuid()).First();
        }

        /// <summary>
        /// Make a decision based on a given set of possible outcomes.
        /// </summary>
        /// <param name="decisions">Possible decisions to make.</param>
        /// <returns>The decision.</returns>
        public string MakeDecision(IEnumerable<string> decisions)
        {
            return decisions.OrderBy(d => Guid.NewGuid()).First();
        }
    }
}
