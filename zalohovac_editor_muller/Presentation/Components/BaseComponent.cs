

namespace zalohovac_editor_muller.Presentation.Components
{
    public abstract class BaseComponent : IComponent
    {
        public bool _inline;
        public abstract bool Selectable { get; }

        protected BaseComponent(bool inline = false)
        {
            _inline = inline;
        }


        public virtual void HandleKey(ConsoleKeyInfo keyInfo)
        {

        }

        public virtual void Render(bool selected)
        {
            if (_inline)
                Console.Write(" ");
            else
                Console.WriteLine();
        }
    }
}
