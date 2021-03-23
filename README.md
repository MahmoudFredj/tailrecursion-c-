# tailrecursion-c-
how to deal with memory overflow from recursion in c#

the idea is to take the recursion and make it iterative as shown in execute method 
and to allocate calls in heap not the stack to let c# garbage collector deal with it.
