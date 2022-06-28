using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApp.Shared.Models
{
    public class FeedbackModel
    {
        public FeedbackEmoji feedBackEmoji { get; set; } = new FeedbackEmoji();
        public int FeedbackId { get; set; }
        public string Feedback { get; set; }
    }
}
