﻿using System.Collections.Generic;

namespace hjudge.WebHost.Models.Rank
{
    public class RankContestStatisticsModel
    {
        public int ContestId { get; set; }
        public int GroupId { get; set; }
        /// <summary>
        /// 题目信息，Dictionary&lt;int, RankProblemInfoModel&gt;，key 为 ProblemId
        /// </summary>
        public Dictionary<int, RankProblemInfoModel> ProblemInfos = new Dictionary<int, RankProblemInfoModel>();
        /// <summary>
        /// 用户信息，Dictionary&lt;string, RankUserInfoModel&gt;，key 为 UserId
        /// </summary>
        public Dictionary<string, RankUserInfoModel> UserInfos = new Dictionary<string, RankUserInfoModel>();
        /// <summary>
        /// 排名信息，Dictionary&lt;string, Dictionary&lt;int, RankContestItemModel&gt;&gt;，外部 key 为 UserId，内部 key 为 ProblemId
        /// </summary>
        public Dictionary<string, Dictionary<int, RankContestItemModel>> RankInfos { get; set; } = new Dictionary<string, Dictionary<int, RankContestItemModel>>();
    }
}
