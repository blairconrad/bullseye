#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace Bullseye.Internal
{
    public enum Host
    {
        Unknown,
        Appveyor,
        AzurePipelines,
        GitHubActions,
        GitLabCI,
        Travis,
        TeamCity,
        VisualStudioCode,
    }
}
