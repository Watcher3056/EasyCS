using EasyCS;
using UnityEngine; // Required for CreateAssetMenu

namespace EasyCS.Samples
{
    [CreateAssetMenu(fileName = "ActorDataSharedFactoryProjectilePrefab", menuName = "EasyCS/Actor Data Shared Factories/ActorDataSharedProjectilePrefab")] // Menu name based on base name
    public partial class ActorDataSharedFactoryProjectilePrefab : ActorDataSharedFactory<ActorDataSharedProjectilePrefab> // Use partial
    {
    }
}