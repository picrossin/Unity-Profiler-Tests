Jaden Goter and Camden Obertop

# Testing and Formal Verification Final Project Examples

## Good Example
The good example is helpful at showing when the Unity Profiler works as intended. For this, we will first use the Rendering Profiler. The Rendering Profiler module allows you to display statistics about what the CPU and GPU do to render the scene each frame. It can be used to diagnose problems where graphics are causing slowdowns. Some telltale signs of slowdowns could involve either high amounts of SetPass calls, or a high number of vertices/triangles.

The GoodExample scene originally had many dynamically batched cubes originally in the scene. When the analysis was performed on it, we could see that we could have it use static batching instead. We could also combine the geometry of all the cubes together into one mesh. This improves performance, and was done so by analyzing it with the Unity Profiler.

## Bad Example
The bad example shows when the Unity Profiler might not be very helpful at finding problems. One tool of the profiler that we can use is "deep profiling." Enabling deep profiling allows the user to view entire call stacks to further analyze their method calls. Deep profiling needs to commit these function calls to memory. This can be useful, except for in a few cases. First, whenever function calls are in long chains. Next, for complex functions that run every frame. Both of these can cause crashes in Unity with deep profiling due to a memory storage

The BadExample scene contains a simple gameObject with a script attached. The script in question takes an input size variable, and runs a for loop that will execute a chain of other functions. It can be seen when the game is run with deep profiling enabled that the fps will plummet from good quality to unbearably bad quality. This shows a case when not to use Unity Profiler's features to their fullest extent.