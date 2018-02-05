using System;

namespace Microsoft.Azure.WebJobs
{
    /// <summary>
    /// Use this attribute to tell MSBuild to ignore auto generation
    /// of function.json for a given function. This is useful if you
    /// would like to bring in your own function.json for any given function
    /// </summary>
    public sealed class SkipAutoGenAttribute : Attribute
    {
    }
}
