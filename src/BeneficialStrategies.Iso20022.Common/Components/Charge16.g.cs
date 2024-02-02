﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Charge16.  ISO2002 ID# _RuTS79p-Ed-ak6NoX_4Aeg_758291100.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[DataContract]
[XmlType]
public partial record Charge16
{
    #nullable enable
    
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [DataMember]
    public required ChargeType10Code Type { get; init; } 
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [DataMember]
    public required IsoExtended350Code ExtendedType { get; init; } 
    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [DataMember]
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    [DataMember]
    public required IsoPercentageRate Rate { get; init; } 
    
    #nullable disable
}
