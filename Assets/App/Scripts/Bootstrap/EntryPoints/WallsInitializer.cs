using System;
using App.Scripts.Map;
using App.Scripts.SceneContainer.Installer;
using App.Scripts.Walls;
using UnityEngine;
using Object = UnityEngine.Object;

namespace App.Scripts.Bootstrap.EntryPoints
{
    public class WallsInitializer : IInitializable
    {
        private readonly IMap _map;
        private readonly WallView _wallPrefab;
        private readonly Transform _wallParentPrefab;

        public WallsInitializer(IMap map, WallView wallPrefab, Transform wallParentPrefab)
        {
            _map = map;
            _wallPrefab = wallPrefab;
            _wallParentPrefab = wallParentPrefab;
        }
        
        public void Initialize()
        {
            Vector3 mapPosition = _map.GetPosition();
            Vector3 mapSize = _map.GetSizeInUniMetres();
            Vector3 prefabScale = _wallPrefab.transform.localScale;
            
            float yPosition = prefabScale.y / 2f;

            Vector3 rightWall = mapPosition + new Vector3(mapSize.x / 2f, yPosition, 0f);
            Vector3 leftWall = mapPosition  + new Vector3(-mapSize.x / 2f, yPosition, 0f);
            Vector3 upWall = mapPosition    + new Vector3(0f, yPosition, mapSize.z / 2f);
            Vector3 downWall = mapPosition  + new Vector3(0f, yPosition, -mapSize.z / 2f);
            
            Vector3 horizontalSize = new Vector3(prefabScale.x, prefabScale.y, mapSize.z);
            Vector3 verticalSize   = new Vector3(mapSize.x, prefabScale.y, prefabScale.z);
            
            CreateWall(rightWall, horizontalSize);
            CreateWall(leftWall, horizontalSize);
            CreateWall(downWall, verticalSize);
            CreateWall(upWall, verticalSize);
        }

        private void CreateWall(Vector3 position, Vector3 scale)
        {
            WallView wallView = Object.Instantiate(_wallPrefab, _wallParentPrefab);

            var transform = wallView.transform;
            
            transform.position = position;
            transform.localScale = new Vector3(scale.x, transform.localScale.y, scale.z);
        }
    }
}