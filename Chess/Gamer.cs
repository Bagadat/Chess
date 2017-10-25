using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
namespace Chess
{
    class Gamer
    {
        Game _passToStep;
        TimeSpan _gamersTime = new TimeSpan(0, 5, 0);

        public string Name { get; }
        List<ChessFigure> _figures { get; }

        public Gamer(string name, List<ChessFigure> figures)
        {
            _figures = figures;
            Name = name;
        }

        public void Step()
        {
            
            DateTime start = DateTime.Now;
            string gamerStep = Console.ReadLine();

            string[] startToEnd = gamerStep.Split('-');

            foreach (var figure in _figures)
            {
                if (figure.CheckCurrentPosition(startToEnd[0]))
                {
                    startToEnd[1] = startToEnd[1].ToLower();
                    figure.Move(startToEnd[1][0], startToEnd[1][1]);
                    break;
                }
            }
            DateTime stop = DateTime.Now;
            TimeSpan delta = start - stop;
            long seconds = delta.Seconds;

            TimeSpan newTime = new TimeSpan(seconds);
            _gamersTime = _gamersTime.Subtract(newTime);
            if (_gamersTime != null)
            {
                Action<bool> method = _passToStep.PassStepTo;
                method(GetColor());
            }


        }

        public bool GetColor()
        {
            return _figures.FirstOrDefault().Color;
        }
    }
}
