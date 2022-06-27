﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FeedbackApp.Shared.Models
{
    public class FeedbackEmoji
    {
        public FeedbackEmojiEnum EmojiOptions = FeedbackEmojiEnum.FEEBACK01;

        public enum FeedbackEmojiEnum
        {
            [Display(Name = "VeryDissatisfied")]
            FEEBACK01,
            [Display(Name = "Dissatisfied")]
            FEEBACK02,
            [Display(Name = "Neutral")]
            FEEBACK03,
            [Display(Name = "Satisfied")]
            FEEBACK04,
            [Display(Name = "VerySatisfied")]
            FEEBACK05,
        }
    }
}
