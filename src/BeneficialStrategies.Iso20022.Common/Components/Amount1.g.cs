﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Amount1.  ISO2002 ID# _Ul4kBtp-Ed-ak6NoX_4Aeg_-2038049081.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Margin amount payable by one party to the other party.
/// </summary>
[DataContract]
[XmlType]
public partial record Amount1
{
    #nullable enable
    
    /// <summary>
    /// Undisputed amount of the margin call request.
    /// </summary>
    [DataMember]
    public required IsoActiveCurrencyAndAmount AgreedAmount { get; init; } 
    /// <summary>
    /// Unique identifier for the margin call request.
    /// </summary>
    [DataMember]
    public required IsoMax35Text MarginCallRequestIdentification { get; init; } 
    /// <summary>
    /// Provides additional information related to the margin call amount that has been agreed.
    /// </summary>
    [DataMember]
    public IsoMax210Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
