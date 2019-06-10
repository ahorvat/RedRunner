using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Savestates
{
    [Serializable]
    public class SaveState 
    {
        public Vector2 Position { get; private set; }

        public SaveState(Vector2 position)
        {
            Position = position;
        }

        public static implicit operator SaveState(Vector2 position)
        {
            return new SaveState(position);
        }
        public static implicit operator Vector2(SaveState saveState)
        {
            return saveState.Position;
        }
    }
}
