﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContractModification8.  ISO2002 ID# _kHE90TIBEe2fXedS_ucFOA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the action type.
/// </summary>
[DataContract]
[XmlType]
public partial record ContractModification8
{
    #nullable enable
    
    /// <summary>
    /// Indication of the action type of the transaction.
    /// </summary>
    [DataMember]
    public required TransactionOperationType11Code ActionType { get; init; } 
    
    #nullable disable
}
