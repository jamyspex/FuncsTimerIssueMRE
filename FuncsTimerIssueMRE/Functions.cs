using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace FuncsTimerIssueMRE
{
    #region Usings

    #endregion

    public class Functions
    {
        [FunctionName("Test")]
        public Task TriggerTest([TimerTrigger("%TestCron%")] TimerInfo timerInfo)
        {
            return Task.CompletedTask;
        }
    }
}
