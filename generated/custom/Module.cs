using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.Graph;
using Microsoft.Graph.Auth;
using System.Threading.Tasks;
using System.Net.Http;

namespace Sample.API
{
    public partial class Module
    {
        string appid, scopes;
        partial void CustomInit()
        {
            //Console.WriteLine("In partial method customInit");
            appid = "";
            scopes = "";
        }

        partial void BeforeCreatePipeline(System.Management.Automation.InvocationInfo invocationInfo, ref Sample.API.Runtime.HttpPipeline pipeline)
        {
            //Console.WriteLine("Inside BeforeCreatePipeline method");
            System.Net.Http.HttpClient client = getHttpClient();
            pipeline = new Sample.API.Runtime.HttpPipeline(new Sample.API.Runtime.HttpClientFactory(client));
        }

        System.Net.Http.HttpClient getHttpClient()
        {
            //string token = System.Environment.GetEnvironmentVariable("accesstoken");
            //Console.WriteLine("Env variable - accesstoken: " + token);

            if(appid == "")
            {
                Console.WriteLine("Enter App ID:");
                appid = Console.ReadLine();
            }
            
            if(scopes == "")
            {
                Console.WriteLine("Enter Scopes:");
                scopes = Console.ReadLine();
            }

            //var app = DeviceCodeProvider.CreateClientApplication("aba757bd-b6d7-43ed-8822-9a259cfb5d38", new FileBasedTokenStorageProvider());
            //scopes = "User.Read, User.ReadWrite, User.ReadBasic.All, User.Read.All, User.ReadWrite.All, Directory.Read.All, Directory.ReadWrite.All, Directory.AccessAsUser.All";

            var app = DeviceCodeProvider.CreateClientApplication(appid, new FileBasedTokenStorageProvider());
            var auth = new DeviceCodeProvider(app, scopes.Split(new char[] { ',', ' ' }));
            var authHandler = new AuthenticationHandler(auth);
            var defaultHandler = new HttpClientHandler();
            authHandler.InnerHandler = defaultHandler;

            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient(authHandler);
            //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            return httpClient;
        }
    }

    public class FileBasedTokenStorageProvider : ITokenStorageProvider
    {
        public Task<byte[]> GetTokenCacheAsync(string cacheId)
        {
            //Console.WriteLine("Inside GetTokenCacheAsync method");
            if (System.IO.File.Exists($"./tokencache.bin"))
            {
                return Task.FromResult(System.IO.File.ReadAllBytes($"./tokencache.bin"));
            }
            else
            {
                return Task.FromResult(new Byte[0]);
            }
        }

        public Task SetTokenCacheAsync(string cacheId, byte[] tokenCache)
        {
            //Console.WriteLine("Inside SetTokenCacheAsync method");
            System.IO.File.WriteAllBytes($"./tokencache.bin", tokenCache);
            return Task.FromResult<object>(null);

        }
    }
}
