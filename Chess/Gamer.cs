using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace Chess
{
    class Gamer
    {
        private bool _flagFinish=false;
        TimeSpan _gamersTime = new TimeSpan(0, 5, 0);
        private Action<bool> PassStepTo;
        Action<Gamer> FinishGame;

        public string Name { get; }
        IEnumerable<ChessFigure> _figures { get; }

        public Gamer(string name, IEnumerable<ChessFigure> figures, Action<bool> passStepTo, Action<Gamer> finishGame)
        {
            _figures = figures;
            Name = name;
            PassStepTo = passStepTo;
            FinishGame = finishGame;
        }

        public void Step()
        {
            DateTime start = DateTime.Now;
            Timer timer = new Timer(new TimerCallback(TimeIsEnd), null, _gamersTime, new TimeSpan(1,0,0));
            
            string gamerStep = Console.ReadLine();

            if (_flagFinish)
            {
                timer.Dispose();
                FinishGame(null);
                return;
            }

            timer.Dispose();

            string[] startToEnd = gamerStep.Split('-');

            bool successStep = false;

            foreach (var figure in _figures)
            {
                if (figure.CheckCurrentPosition(startToEnd[0]))
                {
                    startToEnd[1] = startToEnd[1].ToLower();

                    bool isFight = CheckPosition(startToEnd[1], GetColor());

                    if (!figure.Move(startToEnd[1][0], startToEnd[1][1], isFight))
                    {
                        Console.WriteLine("Фигура не может так ходить");
                        PassStepTo.Invoke(GetColor());
                        return;
                    }
                    else
                    {
                        if (isFight)
                            KickFigure(startToEnd[1]);

                        successStep = true;
                    }
                    break;
                }
            }

            if (!successStep)
            {
                Console.WriteLine("Фигура не найдена");
                PassStepTo.Invoke(GetColor());
                return;
            }

            DateTime stop = DateTime.Now;
            TimeSpan delta = stop.Subtract(start);
            _gamersTime = _gamersTime.Subtract(delta);

            Console.Clear();

            PassStepTo.Invoke(!GetColor());
        }

        private void TimeIsEnd(object state)
        {
            _flagFinish = true;
            Console.WriteLine("Game was finished. Please enter any key to continue.");
        }

        public bool GetColor()
        {
            return _figures.FirstOrDefault().Color;
        }
    }
}
