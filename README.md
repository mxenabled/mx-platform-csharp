*This project is currently in **Beta**. Please open up an issue [here](https://github.com/mxenabled/mx-platform-csharp/issues) to report issues using the MX Platform C# library.*

# MX Platform C# #

The [MX Platform API](https://www.mx.com/products/platform-api) is a powerful, fully-featured API designed to make aggregating and enhancing financial data easy and reliable. It can seamlessly connect your app or website to tens of thousands of financial institutions.

## Documentation

Examples for the API endpoints can be found [here.](docs/MxPlatformApi.md)

## Requirements
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

### Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;
```

## Getting Started

In order to make requests, you will need to [sign up](https://dashboard.mx.com/sign_up) for the MX Platform API and get a `Client ID` and `API Key`.

Please follow the [installation](#installation) procedure and then run the following code to create your first User:

```csharp
using System;
using MX.Platform.CSharp.Api;
using MX.Platform.CSharp.Client;
using MX.Platform.CSharp.Model;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.DefaultHeaders = new Dictionary<string, string>{{ "Accept", "application/vnd.mx.api.v1+json" }};

            // Configure with your Client ID/API Key from https://dashboard.mx.com
            config.Username = "Your Client ID";
            config.Password = "Your API Key";

            // Configure environment. https://int-api.mx.com for development, https://api.mx.com for production
            config.BasePath = "https://int-api.mx.com";

            var apiInstance = new MxPlatformApi(config);
            var userCreateRequestBody = new UserCreateRequestBody(
                user: new UserCreateRequest(
                    metadata: "Creating a user!"
                )
            );

            try
            {
                UserResponseBody result = apiInstance.CreateUser(userCreateRequestBody);
                Console.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Console.WriteLine("Exception when calling MxPlatformApi.CreateUser: " + e.Message );
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}

```

## Development

This project was generated by the [OpenAPI Generator](https://openapi-generator.tech). To generate this library, verify you have the latest version of the `openapi-generator-cli` found [here.](https://github.com/OpenAPITools/openapi-generator#17---npm)

Running the following command in this repo's directory will generate this library using the [MX Platform API OpenAPI spec](https://github.com/mxenabled/openapi/blob/master/openapi/mx_platform_api.yml) with our [configuration and templates.](https://github.com/mxenabled/mx-platform-ruby/tree/master/openapi)
```shell
openapi-generator-cli generate \
-i https://raw.githubusercontent.com/mxenabled/openapi/master/openapi/mx_platform_api.yml \
-g csharp-netcore \
-c ./openapi/config.yml \
-t ./openapi/templates
```

## Contributing

Please [open an issue](https://github.com/mxenabled/mx-platform-csharp/issues) or [submit a pull request.](https://github.com/mxenabled/mx-platform-csharp/pulls)
