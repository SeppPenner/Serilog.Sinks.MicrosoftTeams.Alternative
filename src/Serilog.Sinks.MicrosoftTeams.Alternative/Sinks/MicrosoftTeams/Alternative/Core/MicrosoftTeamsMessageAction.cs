// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MicrosoftTeamsMessageAction.cs" company="SeppPenner and the Serilog contributors">
// The project is licensed under the MIT license.
// </copyright>
// <summary>
//   The Microsoft Teams message action class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Serilog.Sinks.MicrosoftTeams.Alternative.Core;

/// <summary>
/// The Microsoft Teams message action class.
/// </summary>
public class MicrosoftTeamsMessageAction
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MicrosoftTeamsMessageAction"/> class.
    /// </summary>
    /// <param name="type">The type.</param>
    /// <param name="name">The name.</param>
    /// <param name="target">The target.</param>
    public MicrosoftTeamsMessageAction(string type, string name, MicrosoftTeamsMessageActionTarget target)
    {
        this.Type = type;
        this.Name = name;
        this.Targets = [target];
    }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    [JsonProperty("@type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the targets.
    /// </summary>
    [JsonProperty("targets")]
    public IList<MicrosoftTeamsMessageActionTarget> Targets { get; set; }
}
