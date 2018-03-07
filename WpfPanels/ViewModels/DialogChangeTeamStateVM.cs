using System;
using System.Collections.Generic;
using System.Linq;
using Netix.Triceps.Core.Entities;
using WpfPanels.Models;

namespace WpfPanels.ViewModels
{
    public class DialogChangeTeamStateVM : ViewModelBase
    {
        public DialogChangeTeamStateVM()
        {
            IsTimeFromSetNeeded = IsTimeToSetNeeded = IsStateSetNeeded = true;
            TeamStates = TricepsWorkflow.EntityWorkflowStates
                .GetStates(typeof(TricepsWorkflow.Team.States))
                .Select(s => new TeamStateInfo(s));
            State = new TeamStateInfo("scheduled");
        }

        public DateTime TimeFrom
        {
            get => GetVal<DateTime>();
            set => SetVal(value);
        }

        public DateTime TimeTo
        {
            get => GetVal<DateTime>();
            set => SetVal(value);
        }

        public TeamStateInfo State
        {
            get => GetVal<TeamStateInfo>();
            set => SetVal(value);
        }

        public bool IsStateSetNeeded
        {
            get => GetVal<bool>();
            set => SetVal(value);
        }

        public bool IsTimeFromSetNeeded
        {
            get => GetVal<bool>();
            set => SetVal(value);
        }

        public bool IsTimeToSetNeeded
        {
            get => GetVal<bool>();
            set => SetVal(value);
        }

        private Team[] _teams;

        public IEnumerable<TeamStateInfo> TeamStates { get; }

        public Team[] Teams { get => _teams;
            set
            {
                _teams = value;
                if (_teams.Length == 0)
                {
                    return;
                }
                var firstTeam = _teams.First();
                TimeFrom = firstTeam.DateTimeIn;
                TimeTo = firstTeam.DateTimeOut;
                State = TeamStates.FirstOrDefault(t => t.Value == firstTeam.State);
            }
        }
    }
}
