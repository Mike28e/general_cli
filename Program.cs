using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using McMaster.Extensions.CommandLineUtils;
using general_cli.Commands;

namespace general_cli
{
    [Command(Name="general_cli", Description="A general purpose CLI"),
                Subcommand(typeof(SendData)),
                Subcommand(typeof(ReceiveData))]
    class Program
    {
        public static void Main(string[] args)
            => CommandLineApplication.Execute<Program>(args);
        
        private int OnExecute(CommandLineApplication app, IConsole console)
        {
            console.WriteLine("You must specify a subcommand.");
            app.ShowHelp();
            return 1;
        }

    }
}

