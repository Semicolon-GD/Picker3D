using System;
using Commands.Level;
using UnityEngine;

namespace Managers
{
    public class LevelManager : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private Transform levelHolder;
        [SerializeField] private byte totalLevelCount;
        

        #endregion

        #region Private Variables

        private OnLevelLoaderCommand _levelLoaderCommand;
        private OnLevelDestroyerCommand _levelDestroyerCommand;

        private byte _currentLevel;
        private LevelData _levelData;

        #endregion

        #endregion


        private void Awake()
        {
            _levelData=GetLevelData();
            _currentLevel=GetActiveLevel();
        }

        void Init()
        {
            _levelLoaderCommand = new OnLevelLoaderCommand(levelHolder);
            _levelDestroyerCommand = new OnLevelDestroyerCommand(levelHolder);
        }

        private byte GetActiveLevel()
        {
            throw new NotImplementedException();
        }

        private LevelData GetLevelData()
        {
            throw new NotImplementedException();
        }
    }
}