﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QConsole.classes;

namespace QConsole.commands
{
    class ListCommandsCommand : classes.Command
    {
        public ListCommandsCommand(string name)
        {
            this.SetName(name);
        }

        public override void Run(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder("Commands: \n");
            Command command;
            foreach (string cmdString in Program.GetCommands().Keys)
            {
                command = Program.GetCommands()[cmdString];
                stringBuilder.AppendLine($" • {cmdString}: {command.GetName()}");
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
