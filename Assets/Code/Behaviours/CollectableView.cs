using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatternsDemo.Behaviours
{
    public class CollectableView : BaseView<CollectableController, CollectableModel>
    {
    
    }
    
    public class CollectableController : BaseController<CollectableModel>
    {
    
    }
    
    [Serializable]
    public class CollectableModel : BaseModel
    {
        [SerializeField]
        private string _modelName = "CollectableModel";
    }
    
}


