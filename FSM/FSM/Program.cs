using System;

namespace FSM
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p = new Process();
            Random rnd = new Random();
            Array values = Enum.GetValues(typeof(Transition));

            for (var i = 0; i < 20; i++)
            {
                Transition mark = (Transition)values.GetValue(rnd.Next(values.Length));
                Console.WriteLine($"{mark}: " + PrintAction(p.MoveNext(mark)));
                
            }
            Console.ReadLine();
        }

        private static string PrintAction(Action act)
        {
            switch (act)
            {
                case Action.Y0:
                    return "Action 1";
                case Action.Y1:
                    return "Action 2";
                case Action.Y2:
                    return "Action 3";
                case Action.Y3:
                    return "Action 4";
                case Action.Y4:
                    return "Action 5";
                case Action.Y5:
                    return "Action 6";
                default:
                    throw new ArgumentOutOfRangeException(nameof(act), act, null);
            }
        }
    }
}
