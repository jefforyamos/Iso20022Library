﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Statement16.  ISO2002 ID# _QqzOgNp-Ed-ak6NoX_4Aeg_1086698428.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of the statement.
/// </summary>
[DataContract]
[XmlType]
public partial record Statement16
{
    #nullable enable
    
    /// <summary>
    /// Date or period of the statement.
    /// </summary>
    [DataMember]
    public DateAndPeriod1Choice_? StatementDateOrPeriod { get; init; } 
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [DataMember]
    public Frequency4Choice_? Frequency { get; init; } 
    /// <summary>
    /// Indicates whether the statement is complete or contains changes only.
    /// </summary>
    [DataMember]
    public UpdateType2Choice_? UpdateType { get; init; } 
    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [DataMember]
    public StatementBasis3Choice_? StatementBasis { get; init; } 
    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [DataMember]
    public StatementType2Choice_? StatementType { get; init; } 
    
    #nullable disable
}
