using System.Reflection;

namespace Blazor.LazyLoading.Interfaces;

public interface ILazyLoadModules
{                  
    List<Assembly> LazyLoadedAssemblies { get; }
    bool IsLoaded { get; }
    Task LoadAssembliesAsync(Assembly[] assemblysName);
    Task LoadAssembliesAsync(string[] assemblysName);
    Task OnNavigatAsync();
}
