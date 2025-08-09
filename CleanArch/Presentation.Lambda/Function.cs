using Amazon.Lambda.Core;
using Application.DTOs;
using Infrastructure;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Presentation.Lambda;

public class Function
{

    
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input">The event for the Lambda function handler to process.</param>
    /// <param name="context">The ILambdaContext that provides methods for logging and describing the Lambda environment.</param>
    /// <returns></returns>
    public async Task<string> FunctionHandler(string input, ILambdaContext context)
    {

        context.Logger.LogLine($"Input: {input}");  
        context.Logger.LogLine($"Context: {context.AwsRequestId}");
        // Here we can call the use case to get the user
        // We need to create a repository that implements IUserRepository
        // and pass it to the use case.
        // This is where we would use Dependency Injection in a real application.
        // For simplicity, we will create an instance of the repository here.

        //var userRepository = new UserRepository(); // This would be your actual repository implementation
        var userRepository = new DynamoUserRepository();
         var useCase = new GetUserUseCase(userRepository);
      
         var user = await useCase.GetUserByIdAsync(input);
        return input.ToUpper();
    }
}
 