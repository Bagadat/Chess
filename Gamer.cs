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

        public string Name { get; }
        IEnumerable<ChessFigure> _figures { get; }

        public Gamer(string name, IEnumerable<ChessFigure> figures, Action<bool> passStepTo)
        {
            _figures = figures;
            Name = name;
            PassStepTo = passStepTo;
        }

        public void Step()
        {
            DateTime start = DateTime.Now;
            // Засечь время (таймер или поток)
            TimerCallback timerCallback = new TimerCallback(Hello);
            Timer timer = new Timer(timerCallback, null, _gamersTime, new TimeSpan(1,0,0));
            
            string gamerStep = Console.ReadLine();

            //Заюзать флаг окончания игры


            timer.Dispose();

            string[] startToEnd = gamerStep.Split('-');

            foreach (var figure in _figures)
            {
               
                
                if (figure.CheckCurrentPosition(startToEnd[0]))
                {
                    
                    startToEnd[1] = startToEnd[1].ToLower();
                    if (!figure.Move(startToEnd[1][0], startToEnd[1][1]))
                    {
                        Console.WriteLine("Фигура не может так ходить");
                       
                    }
                    else
                        Console.WriteLine("Фигура может так ходить");

                    break;
                }
               
                
                // Обработать случаи:
                // 1) когда фигуры найдено не было
                // 2) когда фигурой сходить не получилось
                // Только в случае успешного хода мы передаем ход
            }
           // Console.Clear();
            DateTime stop = DateTime.Now;
            TimeSpan delta = stop.Subtract(start);
            _gamersTime = _gamersTime.Subtract(delta);
            PassStepTo.Invoke(!GetColor());
        }

        private void Hello(object state)
        {
            if (_gamersTime.Minutes == 0) ;
            Console.WriteLine("Время истекло");
                
        }

        public bool GetColor()
        {
            return _figures.FirstOrDefault().Color;
        }
    }
}
