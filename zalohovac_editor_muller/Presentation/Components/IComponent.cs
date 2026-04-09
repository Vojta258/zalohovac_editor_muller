
namespace zalohovac_editor_muller.Presentation.Components
{
    public interface IComponent
    {
        bool Selectable { get; }

        void Render(bool selected);
        void HandleKey(ConsoleKeyInfo keyInfo);
    }
}
