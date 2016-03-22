using UnityEngine;
using System.Collections;
using Assets;
using System;
using System.Collections.Generic;
using System.Xml;
using Assets.Scripts.Other.TeamClass;
using System.Linq;

public class PlayerController : MonoBehaviour, IPlayer
{
    public int AmmoAmmount;
    public int MyMaxAmmo;
    public Assets.Scripts.Other.TeamEnum.Team TeamColor;

    private Gun Gun;
    private GameObject GameController;
    private List<Team> OpposingTeams = new List<Team>();

    public int Health { get; set; }

    public Team Team { get; set; }

    public int Ammo { get; set; }

    public int MaxAmmo { get; set; }

    public void Movement()
    {
        //intentional
        throw new NotImplementedException();
    }

    public void Shoot()
    {
        if (Ammo > 0)
        {
            Ammo--;
            Gun.Fire();
        }
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
        Debug.Log(Health);
    }

    void Awake()
    {
        Health = 100;
        Ammo = AmmoAmmount;
        Gun = GetComponentInChildren<Gun>();
        MaxAmmo = MyMaxAmmo;
        GameController = GameObject.FindGameObjectWithTag(Tags.GameController);

        Team = GameController.GetComponent<TeamController>().PossibleTeams.FirstOrDefault(x => x.TeamColor == TeamColor);
        GameController.GetComponent<TeamController>().AddTeam(Team);
    }

    // Use this for initialization
    void Start () {
        var otherTeams = GameController.GetComponent<TeamController>().TeamColor.Where(x => x != Team.TeamColor);
        foreach (var color in otherTeams)
        {
            OpposingTeams.Add(GameController.GetComponent<TeamController>().ActiveTeams[color]);
        }
    }
	
	// Update is called once per frame
	//void Update () {
	
	//}

    void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
}
