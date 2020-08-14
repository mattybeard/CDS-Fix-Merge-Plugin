using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using System;


namespace MBeard
{
    public class MergeFixPlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            var context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if (context.MessageName != "Merge")
                return;

            var mergeReq = new MergeRequest()
            {
                Parameters = context.InputParameters
            };
            mergeReq.PerformParentingChecks = false;
        }
    }
}
