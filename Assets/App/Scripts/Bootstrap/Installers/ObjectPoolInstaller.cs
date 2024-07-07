using System.Collections.Generic;
using App.Scripts.Bootstrap.Effects;
using App.Scripts.External.ObjectPool;
using App.Scripts.SceneContainer.Installer;
using App.Scripts.Scenes.GameScene.Features.Effects.ObjectPool;
using UnityEngine;

namespace App.Scripts.Bootstrap.Installers
{
    public class ObjectPoolInstaller : MonoInstaller
    {
        [SerializeField] private List<MonoObjectPoolInfo> _monoObjectPoolInfo;
        
        protected override void OnInstallBindings()
        {
            List<IKeyableObjectPool<EffectView>> keyableObjectPools = new();

            foreach (MonoObjectPoolInfo poolInfo in _monoObjectPoolInfo)
            {
                IKeyableObjectPool<EffectView> objectPool
                    = new MonoObjectPool<EffectView>(
                        () => Instantiate(poolInfo.Prefab).GetComponent<EffectView>(),
                        poolInfo.InitialSize,
                        poolInfo.Parent,
                        poolInfo.Key);
                
                keyableObjectPools.Add(objectPool);
            }

            IKeyObjectPool<EffectView> keyableObjectPool = new KeyObjectPool<EffectView>(keyableObjectPools);
            Container.SetService<IKeyObjectPool<EffectView>, IKeyObjectPool<EffectView>>(keyableObjectPool);
        }
    }
}