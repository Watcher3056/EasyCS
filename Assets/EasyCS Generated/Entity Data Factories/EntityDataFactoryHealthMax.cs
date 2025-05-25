using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine; // Required for CreateAssetMenu

namespace EasyCS.Samples
{
    [CreateAssetMenu(fileName = "EntityDataFactoryHealthMax", menuName = "EasyCS/Entity Data Factories/EntityDataHealthMax")] // Menu name based on base name
    public partial class EntityDataFactoryHealthMax : EntityDataFactory<EntityDataHealthMax> // Use partial
    {
    }
}