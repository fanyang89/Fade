using System.Collections.Generic;

namespace Fade.RegularExpressions
{
    public class State
    {
#if DEBUG
        private static int stateCount;
        private readonly int count;
        public override string ToString() {
            return $"s{count}";
        }

        public State() {
            count = stateCount++;
        }
#else
        public State() { }
#endif
        public bool IsFinalStates { get; set; }
        public Dictionary<char, State> Transitions { get; } = new Dictionary<char, State>();
        public HashSet<State> Epsilon { get; } = new HashSet<State>();
    }
}