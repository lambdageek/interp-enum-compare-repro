run with

``` console
$ dotnet run --project fafa
x.CompareTo(y) ===>  actual: 0 (expected: 0)
$ MONO_ENV_OPTIONS=--interp dotnet run --project fafa
x.CompareTo(y) ===>  actual: 253 (expected: 0)
```

