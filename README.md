# Caller argument test

A simple test of the [C# caller argument expression feature](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-10.0/caller-argument-expression).

```csharp
static void DoSomething(string foo) => ArgumentException.ThrowIfNullOrEmpty(foo);

DoSomething(string.Empty);
```

```bash
> dotnet run --project src/CallerArgumentTest/
Unhandled exception. System.ArgumentException: The value cannot be an empty string. (Parameter 'foo')
   at System.ArgumentException.ThrowNullOrEmptyException(String argument, String paramName)
   at System.ArgumentException.ThrowIfNullOrEmpty(String argument, String paramName)
   at Program.<<Main>$>g__DoSomething|0_0(String foo) in /workspaces/caller-argument-test/src/CallerArgumentTest/Program.cs:line 1
   at Program.<Main>$(String[] args) in /workspaces/caller-argument-test/src/CallerArgumentTest/Program.cs:line 3
```
