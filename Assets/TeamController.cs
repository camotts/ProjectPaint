using UnityEngine;
using System.Collections;
using Assets.Scripts.Other;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Other.TeamClass;
using Debug = System.Diagnostics.Debug;

public class TeamController : MonoBehaviour
{

    public HashSet<Assets.Scripts.Other.TeamEnum.Team> TeamColor = new HashSet<Assets.Scripts.Other.TeamEnum.Team>();
    public Dictionary<Assets.Scripts.Other.TeamEnum.Team, Team> ActiveTeams = new Dictionary<Assets.Scripts.Other.TeamEnum.Team, Team>();
    public Team[] PossibleTeams;

    void Awake()
    {
        foreach (var team in PossibleTeams)
        {
            var bases = GameObject.FindGameObjectsWithTag(Tags.Base);
            var teamCopy = team;
            foreach (var item in bases)
            {
                var color = item.GetComponent<Base>();
                if (color == null || color.Team != teamCopy.TeamColor) continue;
                team.Base = item.transform;
                break;
            }
            var reloads = GameObject.FindGameObjectsWithTag(Tags.Reload);
            foreach (var item in reloads)
            {
                var color = item.GetComponent<ReloadChamber>();
                if (color == null || color.Team != teamCopy.TeamColor) continue;
                team.ReloadPoint = item.transform;
                break;
            }
        }
    }

	// Use this for initialization
	void Start () {
	    
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddTeam(Team team)
    {
        if (TeamColor.Add(team.TeamColor))
        {
            ActiveTeams.Add(team.TeamColor, team);
        }
    }
}
