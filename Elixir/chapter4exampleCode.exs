Chapter 4 - example of using ~r

C:\WINDOWS\system32>iex
Interactive Elixir (1.6.6) - press Ctrl+C to exit (type h() ENTER for help)
iex(1)> Regex.run ~r{[aeiou]}, "caterpillar"
["a"]
iex(2)> Regex.scan ~r{[aeiou]}, "caterpillar"
[["a"], ["e"], ["i"], ["a"]]
iex(3)> Regex.split ~r{[aeiou]}, "caterpillar"
["c", "t", "rp", "ll", "r"]
iex(4)> Regex.replace ~r{[aeiou]}, "caterpillar", "*"
"c*t*rp*ll*r"
iex(5)> Terminate batch job (Y/N)?
^C
