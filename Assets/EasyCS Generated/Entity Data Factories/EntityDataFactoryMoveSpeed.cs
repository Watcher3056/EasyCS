using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine;
using TriInspector;

namespace EasyCS.Samples
{
    [DrawWithTriInspector]
    [CreateAssetMenu(fileName = "EntityDataFactoryMoveSpeed", menuName = "EasyCS/Entity Data Factories/EntityDataMoveSpeed")]
    public partial class EntityDataFactoryMoveSpeed : EntityDataFactory<EntityDataMoveSpeed>
    {
    }
}