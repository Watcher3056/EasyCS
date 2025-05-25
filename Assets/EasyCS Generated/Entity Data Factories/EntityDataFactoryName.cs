using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine; // Required for CreateAssetMenu

namespace EasyCS
{
    [CreateAssetMenu(fileName = "EntityDataFactoryName", menuName = "EasyCS/Entity Data Factories/EntityDataName")] // Menu name based on base name
    public partial class EntityDataFactoryName : EntityDataFactory<EntityDataName> // Use partial
    {
    }
}