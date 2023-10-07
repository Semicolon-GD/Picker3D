using UnityEngine;

namespace Commands.Level
{
    public class OnLevelLoaderCommand
    {

        private Transform _levelHolder;
        public OnLevelLoaderCommand(Transform levelHolder)
        {
            _levelHolder = levelHolder;
        }
    }
}