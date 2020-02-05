﻿using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Collections.Generic;

namespace Nethereum.Commerce.ContractDeployments.IntegrationTests.Config
{
    public static class ConfigurationUtils
    {
        public static Exception CreateKeyNotFoundException(string key)
        {
            return new InvalidOperationException($"Value for configuration key '{key}' is empty - ensure it is set in appsettings.json OR appsettings.{{environment}}.json OR environment variables OR command line args OR user secrets");
        }

        private const string AspnetcoreEnvironment = "ASPNETCORE_ENVIRONMENT";

        static string RecurseUntilFound(string directory, string fileToFind)
        {
            if (Directory.GetFiles(directory, fileToFind).Length > 0)
            {
                return directory;
            }

            var parent = Directory.GetParent(directory);
            if (parent == null)
                return null;

            return RecurseUntilFound(parent.FullName, fileToFind);
        }

        static string FindAppSettingsDirectory(string appSettingsFileName)
        {
            var assemblyFilePath = Directory.GetCurrentDirectory();
            var startingDirectory = Path.GetDirectoryName(assemblyFilePath);
            return RecurseUntilFound(startingDirectory, appSettingsFileName);
        }

        public static void SetEnvironment(string environment)
        {
            Environment.SetEnvironmentVariable(AspnetcoreEnvironment, environment);
        }

        public static IConfigurationRoot Build(string appSettingsFileName = "appsettings.json")
        {
            string path = FindAppSettingsDirectory(appSettingsFileName);

            if (path == null && File.Exists(Path.Combine(Environment.CurrentDirectory, appSettingsFileName)))
                path = Environment.CurrentDirectory;

            if (path == null)
                throw new Exception($"Failed to find the appsettings.json file.  Please ensure it is in somewhere within the path of the executable.  Working Directory: {Environment.CurrentDirectory}");

            var config = new ConfigurationBuilder()
                .SetBasePath(path)
                .AddJsonFile(appSettingsFileName, optional: true, reloadOnChange: false)
                .AddEnvironmentVariables()
                .Build();

            return config;
        }

        public static IConfigurationRoot Build(string[] args, string userSecretsId = null)
        {
            var environmentBuilder = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddCommandLine(args ?? new string[] { })
                .Build();

            var environment = environmentBuilder[AspnetcoreEnvironment] ?? string.Empty;

            var baseJsonFile = "appsettings.json";
            var environmentJsonFile = $"appsettings.{environment}.json";

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(baseJsonFile, optional: true, reloadOnChange: false)
                .AddJsonFile(environmentJsonFile, optional: true, reloadOnChange: false);

            if (userSecretsId != null && environment.Equals("development", StringComparison.OrdinalIgnoreCase))
                builder.AddUserSecrets(userSecretsId);

            builder
                .AddEnvironmentVariables()
                .AddCommandLine(args ?? new string[] { });

            return builder.Build();
        }



        public static string GetOrThrow(this Dictionary<string,string> config, string key)
        {
            var val = config[key];

            if (string.IsNullOrEmpty(val))
                throw CreateKeyNotFoundException(key);

            return val;
        }

        public static ulong UlongGetOrThrow(this Dictionary<string, string> config, string key)
        {
            string configValue = ConfigurationUtils.GetOrThrow(config, key);
            bool parsedOK = ulong.TryParse(configValue, out ulong ul);
            if (parsedOK)
            {
                return ul;
            }
            else
            {
                throw ConfigurationUtils.CreateKeyNotFoundException(key);
            }
        }

        public static uint UintGetOrThrow(this Dictionary<string, string> config, string key)
        {
            string configValue = ConfigurationUtils.GetOrThrow(config, key);
            bool parsedOK = uint.TryParse(configValue, out uint i);
            if (parsedOK)
            {
                return i;
            }
            else
            {
                throw ConfigurationUtils.CreateKeyNotFoundException(key);
            }
        }

        public static string GetOrThrow(this IConfigurationRoot config, string key)
        {
            var val = config[key];

            if (string.IsNullOrEmpty(val))
                throw CreateKeyNotFoundException(key);

            return val;
        }

        public static ulong UlongGetOrThrow(IConfigurationRoot config, string key)
        {
            string configValue = ConfigurationUtils.GetOrThrow(config, key);
            bool parsedOK = ulong.TryParse(configValue, out ulong ul);
            if (parsedOK)
            {
                return ul;
            }
            else
            {
                throw ConfigurationUtils.CreateKeyNotFoundException(key);
            }
        }

        public static uint UintGetOrThrow(IConfigurationRoot config, string key)
        {
            string configValue = ConfigurationUtils.GetOrThrow(config, key);
            bool parsedOK = uint.TryParse(configValue, out uint i);
            if (parsedOK)
            {
                return i;
            }
            else
            {
                throw ConfigurationUtils.CreateKeyNotFoundException(key);
            }
        }
    }
}
