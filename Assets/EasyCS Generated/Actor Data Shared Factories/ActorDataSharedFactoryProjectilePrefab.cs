using EasyCS;
using UnityEngine; // Required for CreateAssetMenu
using TriInspector;

namespace EasyCS.Samples
{
    [DrawWithTriInspector]
    [CreateAssetMenu(fileName = "ActorDataSharedFactoryProjectilePrefab", menuName = "EasyCS/Actor Data Shared Factories/ActorDataSharedProjectilePrefab")]
    public partial class ActorDataSharedFactoryProjectilePrefab : ActorDataSharedFactory<ActorDataSharedProjectilePrefab>
    {
    }
}