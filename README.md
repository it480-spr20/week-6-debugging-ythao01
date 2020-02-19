Breakpoints and Debugging
=========================

This is a lab to learn about, and then practice using, breakpoints.

Part 1
------
Work your way through <https://docs.microsoft.com/en-us/visualstudio/debugger/debugging-absolute-beginners?view=vs-2019>. Follow along with all the actions. When you get to step 15, take a screenshot similar to the shown in that step.

Part 2
------
Next, work through <https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-debugger?toc=%2Fvisualstudio%2Fdebugger%2Ftoc.json&view=vs-2019>. Follow along with all the actions. When you get to step 2 of "Change the execution flow", take a screenshot showing the console window output having run the Console.WriteLine method twice.

Part 3
------

Now we're going to use the skills you just learned to find and fix three small bugs.

 1. Using Visual Studio, create a new Windows console application in Visual C#.
 1. Replace the existing `Main()` function with the following two functions. Note that the `lastZero()` function has a bug in it – it doesn’t do what the comments say that it should do.

```csharp
static void Main(string[] args)
{
    int[] inputArray = new int[] { 0, 1, 0 };
    int result = lastZero(inputArray);
    Console.WriteLine("Expected result is 2, actual result is " + result);
    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
}

// If x==null throw NullPointerException
// else return the index of the last 0 in x.
// If 0 does not occur in x, return -1.
static int lastZero(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] == 0)
        {
            return i;
        }
    }
    return -1;
}
```

 1. Set a breakpoint on the first line of the `Main` function.
 1. Start debugging (`Debug > Start Debugging`, or just `F5`).
 1. Find the debug toolbar that just appeared at the top of the screen.
 1. Keep pressing `F10` to single-step through the code, all the way through to the end. Note how the yellow bar indicating the current statement jumps around. Watch the "Locals" window while you single step, to see how the local variables change. When you get to the end, see how using the `F10` key “stepped over” the call to findLast, so we didn’t investigate the bug!
 1. There are two ways to fix this – either we can use `F11` instead of `F10`, so that we “step into” calls, or we can just set a breakpoint inside findLast, and run up to that breakpoint. Quit debugging (`Debug > Stop`, or `shift-F5`), and try both: repeat the exercise using `F11`, and then repeat it after setting a breakpoint inside findLast.
 1. After you’ve halted execution inside `findLast`, hover the cursor over the `x` in `x[i]`. In the tooltip that appears, click the initial “|>” arrow to expand it and show the contents of the array. Try expanding the same arrow in the “Locals” window at the bottom of the screen!
 1. Hover the cursor over the `==`. What shows up?
 1. Hover over your breakpoint, click the Settings cog that appears, and add a condition so that it only halts when `i == 0`.
 1. In the “Callstack” window, see how the functions are shown in a hierarchical fashion, as `executablename!namespace.classname.methodname(method signature) linenumber`. For example:  `Breakpoints.exe!Breakpoints.Program.findLast(int[] x, int y) Line 27`
 1. What’s the bug in the code? What’s the fix? If you still aren't sure, go back through the exercise again – the process of single-stepping through the code will show you what it *is* doing, and if you compare that to what the comments say it *should* be doing, you can find the error.
 1. Once you've fixed the error, cut-and-paste your working code into a file called `LastZero.cs`

Part 4
------

Repeat Part 3 for the following code – that is, use the features of the debugger, including setting breakpoints and single-stepping through the code, to figure out what the error is and fix it. Cut-and-paste your working code for part 2 into a file called `CountPositive.cs`

```csharp
static void Main(string[] args)
{
    int[] inputArray = new int[] { -4, 2, 0, 2 };
    int result = countPositive(inputArray);
    Console.WriteLine("Expected result is 2, actual result is " + result);
    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
}

// If x==null throw NullPointerException
// else return the number of positive elements in x.
static int countPositive(int[] x)
{
    int count = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] >= 0)
        {
            count++;
        }
    }
    return count;
}
```

Part 5
------

And do the same for this code.
Cut and paste your working code for Part 3 into a file called `OddOrPositive.cs`.

```csharp
static void Main(string[] args)
{
    int[] inputArray = new int[] { -3, -2, 0, 1, 4 };
    int result = oddOrPositive(inputArray);
    Console.WriteLine("Expected result is 3, actual result is " + result);
    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
}

// If x==null throw NullPointerException
// else return the number of elements in x that
// are odd and/or positive
static int oddOrPositive(int[] x)
{
    int count = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] % 2 == 1 || x[i] > 0)
        {
            count++;
        }
    }
    return count;
}
```

What to Submit
-------------

 1. Two screenshots in PNG, GIF, or JPEG format
 1. The three files `LastZero.cs`, `CountPositive.cs` and `OddOrPositive.cs`, WITH THE BUGS FIXED


