using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Savestates
{
    [Serializable]
    public class SaveStateManager
    {
        public SaveState SaveState { get; set; }

        public SaveStateManager()
        {
            SaveState = Vector2.zero;
        }
    }
}
