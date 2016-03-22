using UnityEngine;
using System.Collections;
using Assets;
using Assets.Scripts.Other.TeamClass;
using System;
using System.Collections.Generic;
using System.Linq;

public class AI : MonoBehaviour, IPlayer {

    public int AmmoAmmount;
    public int MyMaxAmmo;
    public Assets.Scripts.Other.TeamEnum.Team TeamColor;

    private GameObject GameController;
    private NavMeshAgent nav;
    private List<Team> OpposingTeams = new List<Team>(); 
    public int Ammo { get; set; }

    public int Health { get; set; }

    public int MaxAmmo { get; set; }

    public Team Team { get; set; }

    public void Movement()
    {
        throw new NotImplementedException();
    }

    public void Shoot()
    {
        throw new NotImplementedException();
    }

    public void TakeDamage(int damage)
    {
        throw new NotImplementedException();
    }

    void Awake()
    {
        GameController = GameObject.FindGameObjectWithTag(Tags.GameController);

        Team = GameController.GetComponent<TeamController>().PossibleTeams.FirstOrDefault(x => x.TeamColor == TeamColor);
        GameController.GetComponent<TeamController>().AddTeam(Team);

        nav = GetComponent<NavMeshAgent>();
    }

    // Use this for initialization
    void Start ()
    {
        var otherTeams = GameController.GetComponent<TeamController>().TeamColor.Where(x => x != Team.TeamColor);
        foreach (var color in otherTeams)
        {
            OpposingTeams.Add(GameController.GetComponent<TeamController>().ActiveTeams[color]);
        }
        var firstTeam = OpposingTeams.FirstOrDefault();
        if (firstTeam != null) nav.SetDestination(firstTeam.Base.position);
    }
	
	// Update is called once per frame
	void Update () {
	    if (Ammo <= 0)
	    {
	        nav.SetDestination(Team.ReloadPoint.position);
	    }
	    else
	    {
            var otherTeams = GameController.GetComponent<TeamController>().TeamColor.Where(x => x != Team.TeamColor);
            foreach (var color in otherTeams)
            {
                OpposingTeams.Add(GameController.GetComponent<TeamController>().ActiveTeams[color]);
            }
            var firstTeam = OpposingTeams.FirstOrDefault();
            if (firstTeam != null) nav.SetDestination(firstTeam.Base.position);
        }
	}
}
