using ARTest.SceneObjects.Effects.Realization;

namespace ARTest.SceneObjects.Realization
{
    public interface IObjectWithEffects
    {
        OutlineEffect OutlineEffect { get; }
        SetColorEffect SetColorEffect { get; }
    }
}