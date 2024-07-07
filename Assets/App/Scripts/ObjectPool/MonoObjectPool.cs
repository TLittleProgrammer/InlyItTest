﻿using System;
using UnityEngine;

namespace App.Scripts.External.ObjectPool
{
    public class MonoObjectPool<TMono> : ObjectPool<TMono> where TMono : MonoBehaviour
    {
        private readonly Transform _parent;

        public MonoObjectPool(Func<TMono> spawner, int initialSize, Transform parent, string key) : base(spawner)
        {
            _parent = parent;
            Key = key;

            Resize(initialSize);
        }

        protected override void OnItemSpawned(TMono item)
        {
            base.OnItemSpawned(item);
            item.gameObject.SetActive(true);
            item.transform.localPosition = Vector3.zero;
        }

        protected override void OnDespawnItem(TMono targetItem)
        {
            base.OnDespawnItem(targetItem);
            DeactiavateItem(targetItem);
        }

        protected override void OnItemCreated(TMono item)
        {
            base.OnItemCreated(item);
            SetParent(item);
            DeactiavateItem(item);
        }

        private void SetParent(TMono item)
        {
            item.transform.SetParent(_parent);
        }

        private void DeactiavateItem(TMono targetItem)
        {
            targetItem.gameObject.SetActive(false);
        }
    }
}