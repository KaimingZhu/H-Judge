﻿using EFSecondLevelCache.Core;
using hjudge.WebHost.Data;
using hjudge.WebHost.Data.Identity;
using hjudge.WebHost.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace hjudge.WebHost.Services
{
    public interface IContestService
    {
        Task<IQueryable<Contest>> QueryContestAsync(string? userId);
        Task<IQueryable<Contest>> QueryContestAsync(string? userId, int groupId);
        Task<Contest?> GetContestAsync(int contestId);
        Task<int> CreateContestAsync(Contest contest);
        Task UpdateContestAsync(Contest contest);
        Task RemoveContestAsync(int contestId);
        Task UpdateContestProblemAsync(int contestId, IEnumerable<int> problems);
    }
    public class ContestService : IContestService
    {
        private readonly CachedUserManager<UserInfo> userManager;
        private readonly IGroupService groupService;
        private readonly WebHostDbContext dbContext;

        public ContestService(CachedUserManager<UserInfo> userManager,
            IGroupService groupService,
            WebHostDbContext dbContext)
        {
            this.userManager = userManager;
            this.groupService = groupService;
            this.dbContext = dbContext;
        }

        public async Task<int> CreateContestAsync(Contest contest)
        {
            await dbContext.Contest.AddAsync(contest);
            await dbContext.SaveChangesAsync();
            return contest.Id;
        }

        public async Task<Contest?> GetContestAsync(int contestId)
        {
            var result = await dbContext.Contest
                .Include(i => i.UserInfo)
                .Where(i => i.Id == contestId)
                .Cacheable().FirstOrDefaultAsync();
            if (result != null)
            {
                dbContext.Entry(result).State = EntityState.Detached;
            }
            return result;
        }

        public async Task<IQueryable<Contest>> QueryContestAsync(string? userId)
        {
            var user = await userManager.FindByIdAsync(userId);

            IQueryable<Contest> contests = dbContext.Contest.Include(i => i.ContestRegister);

            if (!Utils.PrivilegeHelper.IsTeacher(user?.Privilege))
            {
                contests = contests.Where(i => !i.Hidden || (i.SpecifyCompetitors && i.ContestRegister.Any(j => j.ContestId == i.Id && j.UserId == userId)));
            }
            return contests;
        }

        public async Task<IQueryable<Contest>> QueryContestAsync(string? userId, int groupId)
        {
            var user = await userManager.FindByIdAsync(userId);

            var group = await groupService.GetGroupAsync(groupId);
            if (group == null) throw new NotFoundException("找不到该小组");

            if (!Utils.PrivilegeHelper.IsTeacher(user?.Privilege))
            {
                if (group.IsPrivate)
                {
                    if (!dbContext.GroupJoin.Any(i => i.GroupId == groupId && i.UserId == userId)) throw new ForbiddenException("未参加该小组");
                }
            }

            IQueryable<Contest> contests = dbContext.GroupContestConfig
                .Include(i => i.Contest).Where(i => i.GroupId == groupId).OrderByDescending(i => i.Id).Select(i => i.Contest);

            return contests;
        }

        public async Task RemoveContestAsync(int contestId)
        {
            var contest = await GetContestAsync(contestId);
            dbContext.Contest.Remove(contest);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateContestAsync(Contest contest)
        {
            dbContext.Contest.Update(contest);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateContestProblemAsync(int contestId, IEnumerable<int> problems)
        {
            var oldProblems = await dbContext.ContestProblemConfig.Where(i => i.ContestId == contestId).ToListAsync();
            dbContext.ContestProblemConfig.RemoveRange(oldProblems);
            await dbContext.SaveChangesAsync();

            var dict = new Dictionary<int, ContestProblemConfig>();
            foreach (var i in oldProblems)
            {
                if (!dict.ContainsKey(i.ProblemId)) dict[i.ProblemId] = i;
            }

            foreach (var i in problems.Distinct())
            {
                if (dict.ContainsKey(i))
                {
                    dict[i].Id = 0;
                    await dbContext.ContestProblemConfig.AddAsync(dict[i]);
                }
                else
                {
                    await dbContext.ContestProblemConfig.AddAsync(new ContestProblemConfig
                    {
                        ProblemId = i,
                        ContestId = contestId,
                        AcceptCount = 0,
                        SubmissionCount = 0
                    });
                }
            }
            await dbContext.SaveChangesAsync();
        }
    }
}
