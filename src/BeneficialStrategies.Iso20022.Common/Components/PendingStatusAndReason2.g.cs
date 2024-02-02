﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PendingStatusAndReason2.  ISO2002 ID# _Bc6ngeFUEeWIA4E9cYSxxQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of the intra-balance movement status type.
/// </summary>
[DataContract]
[XmlType]
public partial record PendingStatusAndReason2
{
    #nullable enable
    
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [DataMember]
    public ValueList<ProcessingStatus66Choice_> ProcessingStatus { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides the settlement status of a transaction.
    /// </summary>
    [DataMember]
    public ValueList<SettlementStatus16Choice_> SettlementStatus { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
