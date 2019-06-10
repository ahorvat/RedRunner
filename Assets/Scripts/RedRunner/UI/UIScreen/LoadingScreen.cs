using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedRunner.UI
{
    public class LoadingScreen : UIScreen
    {
        private static Singleton<LoadingScreen> _singleton;

        public LoadingScreen()
        {
            _singleton = new Singleton<LoadingScreen>(this);
        }

        public static LoadingScreen GetInstance()
        {
            return _singleton.GetInstance();
        }

        public override void UpdateScreenStatus(bool open)
        {
            base.UpdateScreenStatus(open);
        }
    }

}