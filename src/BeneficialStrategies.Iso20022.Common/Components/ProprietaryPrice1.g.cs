﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProprietaryPrice1.  ISO2002 ID# _RUhg89p-Ed-ak6NoX_4Aeg_1544655401.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements to identify a proprietary price.
/// </summary>
[DataContract]
[XmlType]
public partial record ProprietaryPrice1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of price reported.
    /// </summary>
    [DataMember]
    public required IsoMax35Text Type { get; init; } 
    /// <summary>
    /// Proprietary price specification related to the underlying transaction.
    /// </summary>
    [DataMember]
    public required IsoCurrencyAndAmount Price { get; init; } 
    
    #nullable disable
}
