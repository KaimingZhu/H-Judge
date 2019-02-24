﻿using hjudgeWebHost.Data.Identity;
using System;
using System.Collections.Generic;

namespace hjudgeWebHost.Data
{
    public partial class Problem
    {
        public Problem()
        {
            ContestProblemConfig = new HashSet<ContestProblemConfig>();
            Judge = new HashSet<Judge>();
            VotesRecord = new HashSet<VotesRecord>();
            Discussion = new HashSet<Discussion>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
        public int Level { get; set; }
        public string Config { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public bool Hidden { get; set; }
        public int AcceptCount { get; set; }
        public int SubmissionCount { get; set; }
        public string AdditionalInfo { get; set; }
        public int Upvote { get; set; }
        public int Downvote { get; set; }

        public UserInfo UserInfo { get; set; }

        public ICollection<ContestProblemConfig> ContestProblemConfig { get; set; }
        public ICollection<Judge> Judge { get; set; }
        public ICollection<VotesRecord> VotesRecord { get; set; }
        public ICollection<Discussion> Discussion { get; set; }
    }
}