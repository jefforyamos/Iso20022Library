﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InterestPaymentSchedule1.  ISO2002 ID# _Vexc0bJVEeuX8-p7DPhoRw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies an interest payment schedule, that is an amount that must be paid no sooner than the expected payment date and no later than the due date.
/// </summary>
[DataContract]
[XmlType]
public partial record InterestPaymentSchedule1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the interest payment schedule.
    /// </summary>
    [DataMember]
    public IsoMax35Text? InterestScheduleIdentification { get; init; } 
    /// <summary>
    /// Interest amount that must be paid at due date.
    /// </summary>
    [DataMember]
    public IsoActiveCurrencyAndAmount? Amount { get; init; } 
    /// <summary>
    /// Expected interest payment date.
    /// </summary>
    [DataMember]
    public IsoISODate? ExpectedDate { get; init; } 
    /// <summary>
    /// Latest date whereby the interest must be paid.
    /// </summary>
    [DataMember]
    public IsoISODate? DueDate { get; init; } 
    /// <summary>
    /// Further details on the interest payments.
    /// </summary>
    [DataMember]
    public IsoMax1025Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
