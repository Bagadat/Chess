using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace Chess
{
    class Gamer
    {
        // Создать флаг окончания игры
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
            Timer timer = new Timer(Hello, null, _gamersTime, new TimeSpan(1,0,0));
            string gamerStep = Console.ReadLine();
       
            //Заюзать флаг окончания игры

            DateTime stop = DateTime.Now;
            TimeSpan delta = stop.Subtract(start);
            _gamersTime = _gamersTime.Subtract(delta);
            timer.Dispose();

            string[] startToEnd = gamerStep.Split('-');

            foreach (var figure in _figures)
            {
                if (figure.CheckCurrentPosition(startToEnd[0]))
                {
                    startToEnd[1] = startToEnd[1].ToLower();
                    figure.Move(startToEnd[1][0], startToEnd[1][1]);
                    break;
                }
                // Обработать случаи:
                // 1) когда фигуры найдено не было
                // 2) когда фтгурой сходить не получилось
                // Только в случае успешного хода мы передаем ход
            }
            

            PassStepTo.Invoke(!GetColor());
        }

        private void Hello(object state)
        {
            // Закончить игру
        }

        public bool GetColor()
        {
            return _figures.FirstOrDefault().Color;
        }
    }
}
