﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesTransactionPrice4.  ISO2002 ID# _tsWZ4f9iEea3W_f2lS_aiw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Price with notation.
/// </summary>
[DataContract]
[XmlType]
public partial record SecuritiesTransactionPrice4
{
    #nullable enable
    
    /// <summary>
    /// Value of the price.
    /// </summary>
    [DataMember]
    public IsoLongFraction21DecimalNumber? Value { get; init; } 
    /// <summary>
    /// Notation of the price.
    /// </summary>
    [DataMember]
    public IsoMax35Text? Type { get; init; } 
    
    #nullable disable
}
