using Lesson18.Interfaces;
using Lesson18.Interfaces.Game;

namespace Lesson18;

internal class Program
{
    static void Main (string[] args)
    {
        InterfacesDemo.Show();
        GameEngine.Play();
    }
}
