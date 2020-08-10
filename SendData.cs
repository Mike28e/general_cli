using McMaster.Extensions.CommandLineUtils;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace general_cli.Commands
{
    [HelpOption("-h|--help")]
    [Command(Name="send",Description="Send data for processing.")]
    public class SendData
    {
        // [Required(ErrorMessage="You must choose whether the data is personal.")]
        [Option("-pii|--personal",Description = "Personal")]
        public bool personal {get;}

        private async Task<int> OnExecute(IConsole console)
        {
            if(personal) console.WriteLine("You chose to send PERSONAL data.");
            else console.WriteLine("You chose to send GENERAL data.");

            return 0;
        }
    }
}