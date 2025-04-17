using System.Text;

namespace Lesson15.Nested
{
    public class HtmlBuilder
    {
        private readonly Element _root;

        public HtmlBuilder (string rootName)
        {
            _root = new Element(rootName);
        }

        public HtmlBuilder AddChild (string childName, string childText)
        {
            var e = new Element(childName, childText);
            _root.AddChild(e);

            return this; // поддержка цепочек вызовов
        }

        public override string ToString ()
        {
            return _root.ToString();
        }

        private class Element
        {
            public string Name { get; }
            public string Text { get; }
            public List<Element> Children { get; } = new();

            private const int IndentSize = 2;

            public Element (string name, string text = "")
            {
                Name = name;
                Text = text;
            }

            public void AddChild (Element child)
            {
                Children.Add(child);
            }

            public string ToStringImpl (int indent)
            {
                var sb = new StringBuilder();

                string i = new(' ', IndentSize * indent);
                sb.AppendLine($"{i}<{Name}>");

                if (!string.IsNullOrWhiteSpace(Text))
                    sb.AppendLine($"{new string(' ', IndentSize * (indent + 1))}{Text}");

                foreach (var child in Children)
                    sb.Append(child.ToStringImpl(indent + 1));

                sb.AppendLine($"{i}</{Name}>");
                return sb.ToString();
            }

            public override string ToString () => ToStringImpl(0);
        }
    }

    class HtmlHelper
    {
        public void Run ()
        {
            var builder = new HtmlBuilder("ul");

            builder
                .AddChild("li", "Apple")
                .AddChild("li", "Banana");

            Console.WriteLine(builder);
        }
    }
}
