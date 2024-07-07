﻿using System;
using UnityEngine;

namespace App.Scripts.Bootstrap.Installers
{
    [Serializable]
    public struct MonoObjectPoolInfo
    {
        public int InitialSize;
        public string Key;
        public Transform Parent;
        public ParticleSystem Prefab;
    }
}