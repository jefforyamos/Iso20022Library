﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SignedQuantityFormat12.  ISO2002 ID# _peYOSTi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signed quantity of security formats.
/// </summary>
[DataContract]
[XmlType]
public partial record SignedQuantityFormat12
{
    #nullable enable
    
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    [DataMember]
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [DataMember]
    public required Quantity53Choice_ QuantityChoice { get; init; } 
    
    #nullable disable
}
