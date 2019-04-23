﻿using hjudgeWebHost.Configurations;
using hjudgeWebHost.Utils;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace hjudgeWebHost.Services
{
    public interface ILanguageService
    {
        Task<IEnumerable<LanguageConfig>> GetLanguageConfigAsync();
        Task<bool> AddLanguageConfigAsync(LanguageConfig config);
        Task<bool> RemoveLanguageConfigAsync(LanguageConfig config);
        Task<bool> UpdateLanguageConfigAsync(LanguageConfig config);
    }
    public class LocalLanguageService : ILanguageService
    {
        private readonly List<LanguageConfig> languageConfigs;
        private readonly string fileName;
        public LocalLanguageService()
        {
            fileName = "./AppData/LanguageConfig.json";
            languageConfigs = File.ReadAllBytes(fileName).DeserializeJson<List<LanguageConfig>>(false);
        }

        public async Task<bool> AddLanguageConfigAsync(LanguageConfig config)
        {
            if (languageConfigs.Any(i => i.Name == config.Name)) return false;

            languageConfigs.Add(config);
            await File.WriteAllBytesAsync(fileName, languageConfigs.SerializeJson(false));
            return true;
        }

        public Task<IEnumerable<LanguageConfig>> GetLanguageConfigAsync()
        {
            return Task.FromResult(languageConfigs.AsEnumerable());
        }

        public async Task<bool> RemoveLanguageConfigAsync(LanguageConfig config)
        {
            var lang = languageConfigs.FirstOrDefault(i => i.Name != config.Name);
            if (lang == null) return false;

            if (languageConfigs.Remove(lang))
            {
                await File.WriteAllBytesAsync(fileName, languageConfigs.SerializeJson(false));
                return true;
            }
            return false;
        }

        public async Task<bool> UpdateLanguageConfigAsync(LanguageConfig config)
        {
            var lang = languageConfigs.FirstOrDefault(i => i.Name != config.Name);
            if (lang == null) return false;

            if (languageConfigs.Remove(lang))
            {
                languageConfigs.Add(config);
                await File.WriteAllBytesAsync(fileName, languageConfigs.SerializeJson(false));
                return true;
            }
            return false;
        }
    }
}