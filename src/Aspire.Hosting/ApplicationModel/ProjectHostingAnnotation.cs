// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Aspire.Hosting.ApplicationModel;

/// <summary>
/// Annotation for the project hosting information.
/// </summary>
/// <param name="key">They key for the annotation.</param>
/// <param name="value">The value for the annotation.</param>
public sealed class ProjectHostingAnnotation(string key, string value) : IResourceAnnotation
{
    /// <summary>
    /// The key for the annotation.
    /// </summary>
    public string Key { get; } = key;

    /// <summary>
    /// The value for the annotation.
    /// </summary>
    public string Value { get; } = value;
}
