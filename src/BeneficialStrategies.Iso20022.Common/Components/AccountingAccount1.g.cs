﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountingAccount1.  ISO2002 ID# _SmtBUAEcEeCQm6a_G2yO_w_1620788765.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specific trade account for recording debits and credits to general accounting, cost accounting or budget accounting.
/// </summary>
[DataContract]
[XmlType]
public partial record AccountingAccount1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [DataMember]
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Template describing the mask of the structure for the format of the accounting account identifier for example AABBBBCC where AA represents the country, BBBB the service classification, CC the sales area.
    /// </summary>
    [DataMember]
    public IsoMax35Text? CostReferencePattern { get; init; } 
    
    #nullable disable
}
