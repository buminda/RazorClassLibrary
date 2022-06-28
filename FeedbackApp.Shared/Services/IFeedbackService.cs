using FeedbackApp.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApp.Shared.Services
{
    public interface IFeedbackService
    {
        Task SubmitFeedbackSync(FeedbackData feedbackData);
    }
}
