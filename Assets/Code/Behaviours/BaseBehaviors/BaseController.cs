using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatternsDemo.Behaviours
{
    public class BaseController<M> : MonoBehaviour
    {
        private M _model;
        
        public void Setup(M model)
        {
            _model = model;
        }
        
    }    
}

