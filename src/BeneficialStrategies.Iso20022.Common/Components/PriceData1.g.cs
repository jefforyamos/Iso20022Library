﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PriceData1.  ISO2002 ID# _hM_uQHizEeqKjIYaFgh_2g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the details of the price applicable to the derivative transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record PriceData1
{
    #nullable enable
    
    /// <summary>
    /// Indicates the price per derivative excluding, where applicable: fees, taxes or commissions.
    /// </summary>
    [DataMember]
    public SecuritiesTransactionPrice17Choice_? Price { get; init; } 
    /// <summary>
    /// Specifies the effective date and end date of the schedule for derivative transactions with prices varying throughout the life of the transaction.
    /// </summary>
    [DataMember]
    public ValueList<Schedule1> PriceSchedule { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the unit of measure in which the price is expressed.
    /// </summary>
    [DataMember]
    public UnitOfMeasure12Code? UnitOfMeasure { get; init; } 
    /// <summary>
    /// Number of units of the underlying instrument represented by a single derivative contract.
    /// </summary>
    [DataMember]
    public IsoLongFraction19DecimalNumber? PriceMultiplier { get; init; } 
    
    #nullable disable
}
