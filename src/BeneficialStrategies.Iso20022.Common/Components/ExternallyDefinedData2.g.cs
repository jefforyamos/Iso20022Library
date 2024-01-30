﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ExternallyDefinedData2.  ISO2002 ID# _XOg3sS8lEeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data container to exchange data elements defined by another standard.
/// </summary>
public partial record ExternallyDefinedData2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the set of data to exchange.
    /// </summary>
    public required IsoMax1025Text Identification { get; init; } 
    /// <summary>
    /// Data to exchange according to an external standard.
    /// </summary>
    public IsoMax100KBinary? Value { get; init; } 
    /// <summary>
    /// Protection of the values to exchange.
    /// </summary>
    public ContentInformationType26? ProtectedValue { get; init; } 
    /// <summary>
    /// Identification of the standard used to encode the values to exchange.
    /// </summary>
    public IsoMax1025Text? Type { get; init; } 
    
    #nullable disable
}
