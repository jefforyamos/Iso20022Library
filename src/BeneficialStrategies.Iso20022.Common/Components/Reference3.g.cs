﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Reference3.  ISO2002 ID# _Q_N_V9p-Ed-ak6NoX_4Aeg_1962550066.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the quote.
/// </summary>
[DataContract]
[XmlType]
public partial record Reference3
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for quote request.
    /// </summary>
    [DataMember]
    public IsoMax35Text? QuoteRequestIdentification { get; init; } 
    /// <summary>
    /// Unique identifier for quote response.
    /// </summary>
    [DataMember]
    public IsoMax35Text? QuoteResponseIdentification { get; init; } 
    
    #nullable disable
}
