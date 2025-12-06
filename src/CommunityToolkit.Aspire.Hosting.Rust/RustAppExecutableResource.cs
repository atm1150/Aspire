namespace Aspire.Hosting.ApplicationModel;

/// <summary>
/// A resource that represents a Rust application.
/// </summary>
/// <param name="name">The name of the resource.</param>
/// <param name="workingDirectory">The working directory to use for the command.</param>
/// <param name="command">The build tool command used to execute the Rust application.</param>
public class RustAppExecutableResource(string name, string workingDirectory, string command = "cargo")
    : ExecutableResource(name, command, workingDirectory), IResourceWithServiceDiscovery
{

}

/// <summary>
/// Options for specifying the Rust build tool and any required arguments.
/// </summary>
public class RustBuildOptions
{
    /// <summary>
    /// The build tool command used to execute the Rust application.
    /// </summary>
    public string Tool { get; set; } = "cargo";
    /// <summary>
    /// The command arguments to pass to the build tool.
    /// </summary>
    public string[] BuildArgs { get; set; } = ["run"];
}
