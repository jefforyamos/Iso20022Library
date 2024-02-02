﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementInformation2.  ISO2002 ID# _QIhn5tp-Ed-ak6NoX_4Aeg_-1159158700.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information required for the settlement the transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record SettlementInformation2
{
    #nullable enable
    
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [DataMember]
    public required SettlementMethod2Code SettlementMethod { get; init; } 
    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [DataMember]
    public CashAccount7? SettlementAccount { get; init; } 
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [DataMember]
    public ClearingSystemIdentification1Choice_? ClearingSystem { get; init; } 
    
    #nullable disable
}
