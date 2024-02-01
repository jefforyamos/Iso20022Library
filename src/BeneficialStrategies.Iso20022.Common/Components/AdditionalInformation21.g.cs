﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalInformation21.  ISO2002 ID# _kIe6gVBBEeedyPuM0kK2EQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information relevant to the destination.
/// </summary>
public partial record AdditionalInformation21
{
    #nullable enable
    
    /// <summary>
    /// Recipient of the additional information to display, print, send or store.
    /// </summary>
    public PartyType23Code? Recipient { get; init; } 
    /// <summary>
    /// Target of the additional information to print, display, send or store.
    /// </summary>
    public UserInterface7Code[] Target { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Format of the additional information.
    /// </summary>
    public OutputFormat4Code? Format { get; init; } 
    /// <summary>
    /// Content of or reference to the message.
    /// </summary>
    public required IsoMax20KText Value { get; init; } 
    
    #nullable disable
}
