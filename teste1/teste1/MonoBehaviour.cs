﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste1
{

    public abstract class MonoBehaviour
    {
        private Thread t;
        private bool ativo = true;

        public bool visible = false;
        public bool input = false;

        public void Run()
        {
            Awake();
            Start();


            t = new Thread(
                () =>
                {
                    while (ativo)
                    {
                        Update();
                        LateUpdate();
                        Thread.Sleep(50);
                    }
                }
            );

            t.Start();

        }

        public void Stop()
        {
            this.ativo = false;
            OnDestroy();
            t.Join();
        }


        public virtual void Awake() { }
        public virtual void Start() { }
        public virtual void Update() { }    
        public virtual void LateUpdate() { }
        public virtual void OnDestroy() { }
        public abstract void Draw();
    }
}
