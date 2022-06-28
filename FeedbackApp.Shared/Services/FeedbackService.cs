using FeedbackApp.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApp.Shared.Services
{
    public class FeedbackService : IFeedbackService
    {
        public Task SubmitFeedbackSync(FeedbackData feedbackData)
        {
            System.Diagnostics.Debug.Print(feedbackData.Feedback);

            //throw new NotImplementedException();
            return Task.CompletedTask;
        }
    }
}
