using UnityEngine;
using System.Collections;
using Assets;
using Assets.Scripts.Other.TeamClass;
using JetBrains.Annotations;

namespace Assets
{

    public interface IPlayer
    {
        int Health { get; set; }
        Team Team { get; set; }
        int Ammo { get; set; }
        int MaxAmmo { get; set; }
        void Movement();
        void Shoot();
        void TakeDamage(int damage);
    }
}
