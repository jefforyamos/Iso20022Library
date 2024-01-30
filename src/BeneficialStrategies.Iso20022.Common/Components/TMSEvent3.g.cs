﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TMSEvent3.  ISO2002 ID# _7K5rcWpMEeSR-ZWLvO-1dg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of an individual terminal management action performed by the point of interaction.
/// </summary>
public partial record TMSEvent3
{
    #nullable enable
    
    /// <summary>
    /// Date time of the terminal management action performed by the point of interaction.
    /// </summary>
    public required IsoISODateTime TimeStamp { get; init; } 
    /// <summary>
    /// Final result of the processed terminal management action.
    /// </summary>
    public required TerminalManagementActionResult1Code Result { get; init; } 
    /// <summary>
    /// Identification of the terminal management action performed by the point of interaction.
    /// </summary>
    public required TMSActionIdentification3 ActionIdentification { get; init; } 
    /// <summary>
    /// Additional information related to a failure.
    /// </summary>
    public IsoMax70Text? AdditionalErrorInformation { get; init; } 
    
    #nullable disable
}
