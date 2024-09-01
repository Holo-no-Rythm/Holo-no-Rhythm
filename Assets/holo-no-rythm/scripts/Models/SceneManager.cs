using HoyoNoRythm.Core;
using UnityEngine;

namespace HoyoNoRythm.Models
{
    class SceneManager : MonoBehaviour
    {
        public static SceneManager? Instance { get; private set; }

        public HoyoNoRythmModel model = Simulation.GetModel<HoyoNoRythmModel>();

        void Reset() { }

        void Start() { }

        public void OnEnable()
        {
            Instance = this;
        }

        void OnDisable()
        {
            if (Instance == this)
                Instance = null;
        }

        void Update()
        {
            if (Instance == this)
                Simulation.Tick();
        }
    }
}
