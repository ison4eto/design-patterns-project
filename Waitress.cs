using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Waitress
    {
        Command command;

        public void takeOrder(Command c)
        {
            command = c;
            command.orderUp();
        }
    }
}
