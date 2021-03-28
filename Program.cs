using System;

namespace ItemManagerSystem
{
    class Program
    {
        private static Gameloop _gameloop;
        static void Main(string[] args)
        {
            _gameloop = new Gameloop();
            while (true)
            {
                _gameloop.Loop();
            }
        }
    }
}
