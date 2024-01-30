﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalIdentification1.  ISO2002 ID# _0eiKZPJVEeiJn9rM2Znz2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional identification details of additional card acceptor data. 
/// </summary>
public partial record AdditionalIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Type of additional identification.
    /// </summary>
    public required AdditionalIdentificationType1Code Type { get; init; } 
    /// <summary>
    /// Other Additional Identification applied to the transaction.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Additional identification value.
    /// </summary>
    public required IsoMax35Text Value { get; init; } 
    
    #nullable disable
}
