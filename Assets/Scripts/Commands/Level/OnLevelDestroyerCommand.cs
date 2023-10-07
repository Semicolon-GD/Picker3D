using UnityEngine;

namespace Commands.Level
{
    public class OnLevelDestroyerCommand
    {
        private Transform _levelHolder;
        public OnLevelDestroyerCommand(Transform levelHolder)
        {
            _levelHolder = levelHolder;
        }
    }
}