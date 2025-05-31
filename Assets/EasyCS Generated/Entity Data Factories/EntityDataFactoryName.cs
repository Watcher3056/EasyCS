using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine; // Required for CreateAssetMenu
using TriInspector;

namespace EasyCS
{
    [DrawWithTriInspector]
    [CreateAssetMenu(fileName = "EntityDataFactoryName", menuName = "EasyCS/Entity Data Factories/EntityDataName")]
    public partial class EntityDataFactoryName : EntityDataFactory<EntityDataName>
    {
    }
}