﻿using hjudgeWebHost.Data.Identity;
using System;

namespace hjudgeWebHost.Data
{
    public class Discussion
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int? ProblemId { get; set; }
        public int? ContestId { get; set; }
        public int? GroupId { get; set; }
        public DateTime SubmitTime { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ReplyId { get; set; }

        public UserInfo UserInfo { get; set; }
        public Contest Contest { get; set; }
        public Group Group { get; set; }
        public Problem Problem { get; set; }
    }
}
