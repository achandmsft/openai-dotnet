// SAMPLE: Generate text with messages using different roles
#:package OpenAI@2.2.*-*
#:property PublishAot=false

using OpenAI.Chat; 

string key = Environment.GetEnvironmentVariable("OPENAI_KEY")!;
ChatClient client = new("gpt-4.1", key);
ChatCompletion acompletion = client.CompleteChat([
    ChatMessage.CreateDeveloperMessage("Talk like a pirate."),
    ChatMessage.CreateUserMessage("Are semicolons optional in JavaScript?")
]);
Console.WriteLine(acompletion.Content[0].Text);