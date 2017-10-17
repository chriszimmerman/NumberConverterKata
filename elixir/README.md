# Number Converter (Elixir)

### Install Elixir

Install Elixir on your machine from [https://elixir-lang.org](https://elixir-lang.org/install.html).

### Clone this repository
```bash
$ git clone https://github.com/RappidDevelopment/NumberConverterKata.git
$ cd NumberConverterKata/elixir
```

### Run the Tests, Start Coding! 
Elixir comes with its own unit testing library built in (called ExUnit) so it's easy to get started with running tests.
To run the first failing test, run the following command:
```
$ mix test
```
When your first test is green, make a commit. Refactor if needed and commit again.

When you have a `green` commit, remove the `@tag :skip` from the next test in `number_converter_test.exs`.

### Run Your Program
When all tests are green, you can run your program with the following: 
```
$ iex -S mix
```
This will start iex, Elixir's repl. To call the function, enter the following:
```
iex(1)> NumberConverter.to_words(7)
```

Examples:
```bash
$ iex -S mix
iex(1)> NumberConverter.to_words(6831)
# "six thousand eight hundred thirty-one"
```

```bash
$ iex -S mix
iex(1)> NumberConverter.to_words(932131)
# "nine hundred thirty-two thousand one hundred thirty-one"
```
