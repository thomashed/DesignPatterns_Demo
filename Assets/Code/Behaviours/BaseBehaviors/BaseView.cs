using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatternsDemo.Behaviours
{
    public class BaseView<C,M> : MonoBehaviour 
    where C : BaseController<M>, new()
    where M : BaseModel
    {
        private C _controller;
        public M _model;
        
        private void Awake()
        {
            _controller = new C();
            _controller.Setup(_model);
        }
    }    
}


