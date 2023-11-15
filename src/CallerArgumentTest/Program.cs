static void DoSomething(string foo) => ArgumentException.ThrowIfNullOrEmpty(foo);

DoSomething(string.Empty);
