﻿using Swellow.Shared.Dto.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Swellow.Blazor.Services
{
    public class HostService
    {
        private readonly HttpClient _httpClient;

        public HostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // 1 获取所有磁盘 DriveInfo[] driveInfos
        public async Task<IEnumerable<string>> GetDrivesAsync()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<string>>(
                await _httpClient.GetStreamAsync("api/host/drives"),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
        }

        internal async Task<string> GetParentDirectoryAsync(object path)
        {
            StringContent stringContent = new(JsonSerializer.Serialize(path), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync("api/host/directory/parent", stringContent);
            if (response.IsSuccessStatusCode)
            {
                string parentDirectory = await JsonSerializer.DeserializeAsync<string>(
                    await response.Content.ReadAsStreamAsync(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                return parentDirectory;
            }
            return null;
        }

        internal async Task<IEnumerable<string>> GetSubFoldersAsync(string path)
        {
            StringContent stringContent = new(JsonSerializer.Serialize(path), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync("api/host/directory/subfolders", stringContent);
            if (response.IsSuccessStatusCode)
            {
                List<string> subFolders = await JsonSerializer.DeserializeAsync<List<string>>(
                    await response.Content.ReadAsStreamAsync(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                return subFolders;
            }
            return new List<string>();
        }
    }
}

// 2 依据目录path获取当前目录的相关情况
//internal async Task<DirectoryDetail> GetDirectoryDetailAsync(string path)
//{
//    StringContent stringContent = new StringContent(JsonSerializer.Serialize(path), Encoding.UTF8, "application/json");
//    HttpResponseMessage response = await _httpClient.PostAsync("api/host/directory/detail", stringContent);
//    if (response.IsSuccessStatusCode)
//    {
//        DirectoryDetail directory = await JsonSerializer.DeserializeAsync<DirectoryDetail>(
//            await response.Content.ReadAsStreamAsync(),
//            new JsonSerializerOptions
//            {
//                PropertyNameCaseInsensitive = true
//            });
//        //Console.WriteLine($"成功获取指定目录的路径：{directory.SubFolders.ToString()}");
//        return directory;
//    }
//    return null;
//}
