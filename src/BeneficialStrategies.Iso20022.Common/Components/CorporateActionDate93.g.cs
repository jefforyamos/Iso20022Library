﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate93.  ISO2002 ID# _Ts3lL199Ee262vCSVgjImg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateActionDate93
{
    #nullable enable
    
    /// <summary>
    /// Date/time at which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    [DataMember]
    public DateFormat41Choice_? RecordDate { get; init; } 
    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    [DataMember]
    public DateFormat41Choice_? ExDividendDate { get; init; } 
    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder's positions. This is also applicable to partial calls.
    /// </summary>
    [DataMember]
    public DateFormat41Choice_? LotteryDate { get; init; } 
    
    #nullable disable
}
