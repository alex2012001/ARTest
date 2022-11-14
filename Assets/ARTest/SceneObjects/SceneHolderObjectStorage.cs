using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ARTest.SceneObjects
{
    public class SceneObjectsStorage
    {
        private readonly Dictionary<Type, SceneObject> _storage = new Dictionary<Type, SceneObject>();

        public void InitAndSpawnObjects(Action onEnd = null)
        {
            var sceneObjects = Resources.LoadAll<SceneObject>("");
            for (int i = 0; i < sceneObjects.Length; i++)
            {
                var sceneObject = Object.Instantiate(sceneObjects[i]);
                _storage.Add(sceneObject.GetType(), sceneObject);
            }
            
            onEnd?.Invoke();
        }
        
        public void Add<T>(T obj) where T : SceneObject
        {
            var type = typeof(T);

            if (_storage.ContainsKey(type))
            {
                return;
            }
            
            _storage.Add(type,obj);
        }
        
        public T Get<T>() where T : SceneObject
        {
            var type = typeof(T);
            
            if (_storage.ContainsKey(type))
            {
                return _storage[type].GetComponent<T>();
            }

            return null;
        }

        public void Delete<T>(T obj) where T : SceneObject
        {
            var type = typeof(T);
            
            if (_storage.ContainsKey(type))
            {
                _storage.Remove(type);
            }
        }
    }
}
