# **History of Linux and shell**

Shells or command-line interpreters have a long history, but this discussion begins with the first UNIX shell. Ken Thompson of Bell Labs developed the first shell for UNIX called the V6 shell in 1971. Similar to its predecessor in Multics, this shell (/bin/sh) was an independent user program that executed outside of the kernel. Concepts like globbing (pattern matching for parameter expansion, such as *.txt) were implemented in a separate utility called glob, as was the if command to evaluate conditional expressions. This separation kept the shell small, at under 900 lines of C source.

