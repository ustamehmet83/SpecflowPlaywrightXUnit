﻿using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Framework.Config;

public static class ConfigReader
{
    public static TestSettings ReadConfig()
    {
        var configFile = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/appsettings.json");

        var jsonSerializerSettings = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };

        jsonSerializerSettings.Converters.Add(new JsonStringEnumConverter());

        return JsonSerializer.Deserialize<TestSettings>(configFile, jsonSerializerSettings);

    }
}