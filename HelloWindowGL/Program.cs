

using Silk.NET.SDL;
using Silk.NET.Windowing;
using Window = Silk.NET.Windowing.Window;

var window = Window.Create(WindowOptions.Default with {
   Size = new(800, 600), // Window size in pixels
   Title = "Hello, Window!", // Window title
});

// Window events
window.Load += OnLoad;
window.Render += OnRender;
window.Update += OnUpdate;

window.Run();

return; // End of the main function

static void OnLoad() {
   Console.WriteLine("Window onLoad");
}

static void OnRender(double _) {
   Console.WriteLine("Window onRender");
}

static void OnUpdate(double _) {
   Console.WriteLine("Window onUpdate");
}