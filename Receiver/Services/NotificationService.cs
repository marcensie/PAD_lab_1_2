using Grpc.Core;
using GrpcApp;
using System.Threading.Tasks;
using System;

namespace Receiver.Services
{
    public class NotificationService : Notifier.NotifierBase
    {
        public override Task<NotifyReply> Notify(NotifyRequest notify, ServerCallContext callContext)
        {

            Console.WriteLine($"{notify.PublisherName} - {notify.Article} ");

            return Task.FromResult(new NotifyReply()
            {
                IsSuccess = true,
            });
        }
    }
}
