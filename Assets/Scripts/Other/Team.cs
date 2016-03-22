using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Other.TeamEnum
{
    public enum Team
    {
        Red,
        Blue
    }
}

namespace Assets.Scripts.Other.TeamClass
{

    public class Team: MonoBehaviour
    {
        public Transform Base;
        public Transform ReloadPoint;
        public TeamEnum.Team TeamColor;
    }

}



