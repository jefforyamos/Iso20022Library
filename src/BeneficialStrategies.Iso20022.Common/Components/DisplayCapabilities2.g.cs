﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DisplayCapabilities2.  ISO2002 ID# _OdbxQS9KEeOlZIh7PImd0A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The capabilities of the display components performing the transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record DisplayCapabilities2
{
    #nullable enable
    
    /// <summary>
    /// Type of display (for example merchant or cardholder).
    /// </summary>
    [DataMember]
    public required UserInterface2Code DisplayType { get; init; } 
    /// <summary>
    /// Number of lines of the display component.
    /// </summary>
    [DataMember]
    public required IsoNumber NumberOfLines { get; init; } 
    /// <summary>
    /// Number of columns of the display component.
    /// </summary>
    [DataMember]
    public required IsoNumber LineWidth { get; init; } 
    
    #nullable disable
}
