using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Management
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private SceneControlManager sceneControlManager;
        [SerializeField] private LevelContainer mainMenu;
        
        private IEnumerator Start()
        {
            yield return sceneControlManager.LoadLevel(mainMenu);
        }
    }

    public class LevelContainer
    {
        //TODO: Add logic to get scene indexes
        public List<int> sceneIds { get; }
    }
}
