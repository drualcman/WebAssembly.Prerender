using Blazor.LazyLoading.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Services;
using System.Reflection;

namespace Blazor.LazyLoading.Services;

public class LazyLoadModules : ILazyLoadModules
{
    readonly LazyAssemblyLoader AssemblyLoader;

    public LazyLoadModules(LazyAssemblyLoader assemblyLoader)
    {
        Console.WriteLine($"LazyLoadModules: initialized");
        AssemblyLoader = assemblyLoader;
        AssemblysName = new List<string>
        {
            "Microsoft.AspNetCore.Authorization.dll",
            "Microsoft.AspNetCore.Components.Forms.dll",
            "Microsoft.AspNetCore.Metadata.dll",
            "Microsoft.Extensions.Configuration.Binder.dll",
            "Microsoft.Extensions.Configuration.FileExtensions.dll",
            "Microsoft.Extensions.FileProviders.Abstractions.dll",
            "Microsoft.Extensions.FileProviders.Physical.dll",
            "Microsoft.Extensions.FileSystemGlobbing.dll",
            "System.IO.Pipelines.dll",
            "Microsoft.CSharp.dll",
            "Microsoft.VisualBasic.Core.dll",
            "Microsoft.VisualBasic.dll",
            "Microsoft.Win32.Primitives.dll",
            "Microsoft.Win32.Registry.dll",
            "System.AppContext.dll",
            "System.Buffers.dll",
            "System.Collections.Immutable.dll",
            "System.Collections.NonGeneric.dll",
            "System.Collections.Specialized.dll",
            "System.ComponentModel.Annotations.dll",
            "System.ComponentModel.DataAnnotations.dll",
            "System.ComponentModel.EventBasedAsync.dll",
            "System.ComponentModel.Primitives.dll",
            "System.ComponentModel.TypeConverter.dll",
            "System.Configuration.dll",
            "System.Core.dll",
            "System.Data.Common.dll",
            "System.Data.DataSetExtensions.dll",
            "System.Data.dll",
            "System.Diagnostics.Contracts.dll",
            "System.Diagnostics.Debug.dll",
            "System.Diagnostics.DiagnosticSource.dll",
            "System.Diagnostics.FileVersionInfo.dll",
            "System.Diagnostics.Process.dll",
            "System.Diagnostics.StackTrace.dll",
            "System.Diagnostics.TextWriterTraceListener.dll",
            "System.Diagnostics.Tools.dll",
            "System.Diagnostics.TraceSource.dll",
            "System.Drawing.Primitives.dll",
            "System.Drawing.dll",
            "System.Dynamic.Runtime.dll",
            "System.Formats.Asn1.dll",
            "System.Formats.Tar.dll",
            "System.Globalization.Calendars.dll",
            "System.Globalization.Extensions.dll",
            "System.Globalization.dll",
            "System.IO.Compression.Brotli.dll",
            "System.IO.Compression.FileSystem.dll",
            "System.IO.Compression.ZipFile.dll",
            "System.IO.Compression.dll",
            "System.IO.FileSystem.AccessControl.dll",
            "System.IO.FileSystem.DriveInfo.dll",
            "System.IO.FileSystem.Primitives.dll",
            "System.IO.FileSystem.Watcher.dll",
            "System.IO.FileSystem.dll",
            "System.IO.IsolatedStorage.dll",
            "System.IO.MemoryMappedFiles.dll",
            "System.IO.Pipes.AccessControl.dll",
            "System.IO.Pipes.dll",
            "System.IO.UnmanagedMemoryStream.dll",
            "System.Linq.Expressions.dll",
            "System.Linq.Parallel.dll",
            "System.Linq.Queryable.dll",
            "System.Net.Http.Json.dll",
            "System.Net.HttpListener.dll",
            "System.Net.Mail.dll",
            "System.Net.NameResolution.dll",
            "System.Net.NetworkInformation.dll",
            "System.Net.Ping.dll",
            "System.Net.Quic.dll",
            "System.Net.Requests.dll",
            "System.Net.Security.dll",
            "System.Net.ServicePoint.dll",
            "System.Net.Sockets.dll",
            "System.Net.WebClient.dll",
            "System.Net.WebHeaderCollection.dll",
            "System.Net.WebProxy.dll",
            "System.Net.WebSockets.Client.dll",
            "System.Net.WebSockets.dll",
            "System.Net.dll",
            "System.Numerics.dll",
            "System.ObjectModel.dll",
            "System.Private.DataContractSerialization.dll",
            "System.Private.Xml.Linq.dll",
            "System.Private.Xml.dll",
            "System.Reflection.DispatchProxy.dll",
            "System.Reflection.Emit.dll",
            "System.Reflection.Extensions.dll",
            "System.Reflection.Metadata.dll",
            "System.Reflection.TypeExtensions.dll",
            "System.Reflection.dll",
            "System.Resources.Reader.dll",
            "System.Resources.ResourceManager.dll",
            "System.Resources.Writer.dll",
            "System.Runtime.CompilerServices.Unsafe.dll",
            "System.Runtime.CompilerServices.VisualC.dll",
            "System.Runtime.Extensions.dll",
            "System.Runtime.Handles.dll",
            "System.Runtime.InteropServices.RuntimeInformation.dll",
            "System.Runtime.Numerics.dll",
            "System.Runtime.Serialization.Formatters.dll",
            "System.Runtime.Serialization.Json.dll",
            "System.Runtime.Serialization.Primitives.dll",
            "System.Runtime.Serialization.Xml.dll",
            "System.Runtime.Serialization.dll",
            "System.Security.AccessControl.dll",
            "System.Security.Claims.dll",
            "System.Security.Cryptography.Algorithms.dll",
            "System.Security.Cryptography.Cng.dll",
            "System.Security.Cryptography.Csp.dll",
            "System.Security.Cryptography.OpenSsl.dll",
            "System.Security.Cryptography.Primitives.dll",
            "System.Security.Cryptography.X509Certificates.dll",
            "System.Security.Cryptography.dll",
            "System.Security.Principal.Windows.dll",
            "System.Security.Principal.dll",
            "System.Security.SecureString.dll",
            "System.Security.dll",
            "System.ServiceModel.Web.dll",
            "System.ServiceProcess.dll",
            "System.Text.Encoding.CodePages.dll",
            "System.Text.Encoding.dll",
            "System.Text.Encoding.dll",
            "System.Threading.Channels.dll",
            "System.Threading.Overlapped.dll",
            "System.Threading.Tasks.Dataflow.dll",
            "System.Threading.Tasks.Extensions.dll",
            "System.Threading.Tasks.Parallel.dll",
            "System.Threading.Tasks.dll",
            "System.Threading.Thread.dll",
            "System.Threading.ThreadPool.dll",
            "System.Threading.Timer.dll",
            "System.Transactions.Local.dll",
            "System.Transactions.dll",
            "System.ValueTuple.dll",
            "System.Web.HttpUtility.dll",
            "System.Web.dll",
            "System.Windows.dll",
            "System.Xml.Linq.dll",
            "System.Xml.ReaderWriter.dll",
            "System.Xml.Serialization.dll",
            "System.Xml.XDocument.dll",
            "System.Xml.XPath.XDocument.dll",
            "System.Xml.XPath.dll",
            "System.Xml.XmlDocument.dll",
            "System.Xml.XmlSerializer.dll",
            "System.Xml.dll",
            "System.dll",
            "WindowsBase.dll",
            "mscorlib.dll",
            "netstandard.dll",
        };
        //_ = FisrtLoader();
    }

    public List<Assembly> LazyLoadedAssemblies { get; } = new();
    public bool IsLoaded { get; private set; }

    public bool FirstLoadDone;
    List<string> AssemblysName;


    public async Task LoadAssembliesAsync(Assembly[] assemblysName)
    {       
        Console.WriteLine($"LoadAssembliesAsync 1.1: IsLoaded => {IsLoaded}");
        string[] names = assemblysName.Select(a => a.GetName().Name).ToArray()!;
        await LoadAssembliesAsync(names);  
        Console.WriteLine($"LoadAssembliesAsync 1.2: IsLoaded => {IsLoaded}");
    }

    public async Task LoadAssembliesAsync(string[] assemblysName)
    {          
        Console.WriteLine($"LoadAssembliesAsync 2.1: IsLoaded => {IsLoaded}");
        IsLoaded = false;   
        Console.WriteLine($"LoadAssembliesAsync 2.2: IsLoaded => {IsLoaded}");
        AssemblysName.AddRange(assemblysName);
        await OnNavigatAsync();
        IsLoaded = true;     
        Console.WriteLine($"LoadAssembliesAsync 2.3: IsLoaded => {IsLoaded}");
    }

    void ResetAssemblyList() =>
        AssemblysName = AssemblysName.Distinct().ToList();


    async Task FisrtLoader()
    {
        Console.WriteLine($"LazyLoadModules: OnAddModuleAsync");
        Console.WriteLine($"LazyLoadModules: LazyLoadedAssemblies = {LazyLoadedAssemblies.Count}");
        Console.WriteLine($"LazyLoadModules: 1");
        try
        {
            ResetAssemblyList();
            IEnumerable<Assembly> assemblies = await AssemblyLoader.LoadAssembliesAsync(AssemblysName);

            Console.WriteLine($"LazyLoadModules: 2");
            // new[] { "BlazorBasics.InputFileExtended.dll" });  
            Console.WriteLine($"LazyLoadModules: assemblies = {assemblies.Count()}");
            LazyLoadedAssemblies.AddRange(assemblies);
            Console.WriteLine($"LazyLoadModules: 3");
            Console.WriteLine($"LazyLoadModules: LazyLoadedAssemblies = {LazyLoadedAssemblies.Count}");
            FirstLoadDone = true;
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public async Task OnNavigatAsync()
    {
        Console.WriteLine($"LazyLoadModules: OnAddModuleAsync");
        Console.WriteLine($"LazyLoadModules: LazyLoadedAssemblies = {LazyLoadedAssemblies.Count}");
        Console.WriteLine($"LazyLoadModules: 1");
        try
        {
            ResetAssemblyList();
            IEnumerable<Assembly> assemblies = await AssemblyLoader.LoadAssembliesAsync(AssemblysName);

            Console.WriteLine($"LazyLoadModules: 2");
            // new[] { "BlazorBasics.InputFileExtended.dll" });  
            Console.WriteLine($"LazyLoadModules: assemblies = {assemblies.Count()}");
            LazyLoadedAssemblies.AddRange(assemblies);
            Console.WriteLine($"LazyLoadModules: 3");
            Console.WriteLine($"LazyLoadModules: LazyLoadedAssemblies = {LazyLoadedAssemblies.Count}");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
