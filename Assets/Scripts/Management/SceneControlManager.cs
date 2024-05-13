using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Management
{
    public class SceneControlManager : MonoBehaviour
    {
        public IEnumerator LoadLevel(LevelContainer level)
        {
            foreach (var sceneId in level.sceneIds)
            {
                AsyncOperation loadOperation = SceneManager.LoadSceneAsync(sceneId, LoadSceneMode.Additive);
                yield return new WaitUntil(() => loadOperation.isDone);
                
            }

            yield break;
        }

        public bool IsActive() { return true; }
        public bool IsActive2() => true;
        public int Age { get; } = 2;
        public int Age2 { get; private set; } = 2;

        private void HappyBirthday()
        {
            Age2++;
            Debug.Log($"{name}: my age is now {Age2}");
        }
    }
}
