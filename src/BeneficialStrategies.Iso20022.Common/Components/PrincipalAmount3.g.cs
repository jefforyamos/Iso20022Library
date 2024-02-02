﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PrincipalAmount3.  ISO2002 ID# _-cnGsa5MEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indication of the cash values to be settled as of the start and maturity date of the transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record PrincipalAmount3
{
    #nullable enable
    
    /// <summary>
    /// Cash value to be settled as of the start date of the transaction.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? ValueDateAmount { get; init; } 
    /// <summary>
    /// Cash value to be settled as of the maturity date of the transaction.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? MaturityDateAmount { get; init; } 
    
    #nullable disable
}
