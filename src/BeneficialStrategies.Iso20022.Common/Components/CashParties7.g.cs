﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashParties7.  ISO2002 ID# _K14C--aOEd-q8fx_Zl_34A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment processes required to transfer cash from the debtor to the creditor.
/// </summary>
[DataContract]
[XmlType]
public partial record CashParties7
{
    #nullable enable
    
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [DataMember]
    public PartyIdentificationAndAccount38? Debtor { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [DataMember]
    public PartyIdentificationAndAccount50? DebtorAgent { get; init; } 
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [DataMember]
    public PartyIdentificationAndAccount38? Creditor { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [DataMember]
    public PartyIdentificationAndAccount50? CreditorAgent { get; init; } 
    
    #nullable disable
}
