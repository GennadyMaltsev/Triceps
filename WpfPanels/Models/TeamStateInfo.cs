using Netix.Triceps.Core.Entities;

namespace WpfPanels.Models
{
    public class TeamStateInfo
    {
        public TeamStateInfo(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public string Description
        {
            get
            {
                switch (Value)
                {
                    case TricepsWorkflow.Team.States.Cancelled: return Properties.Resources.TeamState_Cancelled;
                    case TricepsWorkflow.Team.States.Draft: return Properties.Resources.TeamState_Draft;
                    case TricepsWorkflow.Team.States.Executed: return Properties.Resources.TeamState_Executed;
                    case TricepsWorkflow.Team.States.Processing: return Properties.Resources.TeamState_Processing;
                    case TricepsWorkflow.Team.States.Scheduled: return Properties.Resources.TeamState_Scheduled;
                }
                return Properties.Resources.TeamState_Unknown;
            }
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return (obj as TeamStateInfo)?.Value == Value;
        }
    }
}
