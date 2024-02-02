﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraBalanceQueryCriteria9.  ISO2002 ID# _VUPx9Tp9EemwKdP955WBJQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria based on which information is included.
/// </summary>
[DataContract]
[XmlType]
public partial record IntraBalanceQueryCriteria9
{
    #nullable enable
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [DataMember]
    public ValueList<References36Choice_> References { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [DataMember]
    public IntraBalanceQueryStatus3? Status { get; init; } 
    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [DataMember]
    public ValueList<AccountIdentificationSearchCriteria2Choice_> CashAccount { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Party that owns the account.
    /// </summary>
    [DataMember]
    public ValueList<SystemPartyIdentification8> CashAccountOwner { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [DataMember]
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
    /// <summary>
    /// Balance to which the amount of money is moved.
    /// </summary>
    [DataMember]
    public ValueList<IntraBalanceType3> BalanceType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Number identifying a lot constituting the sub-balance.
    /// </summary>
    [DataMember]
    public ValueList<GenericIdentification37> CashSubBalanceIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Total amount of money to be settled.
    /// </summary>
    [DataMember]
    public ImpliedCurrencyAmountRange1Choice_? SettlementAmount { get; init; } 
    /// <summary>
    /// Amount of money effectively settled and which will be credited to/debited from the account owner's cash account. It may differ from the instructed settlement amount based on market tolerance level.
    /// </summary>
    [DataMember]
    public ImpliedCurrencyAmountRange1Choice_? SettledAmount { get; init; } 
    /// <summary>
    /// Currency in which the instructed amount is expressed.
    /// </summary>
    [DataMember]
    public ValueList<ActiveOrHistoricCurrencyCode> SettlementCurrency { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Date and time at which the amount of money is intended to be moved.
    /// </summary>
    [DataMember]
    public DateAndDateTimeSearch5Choice_? IntendedSettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which the amount of money is moved.
    /// </summary>
    [DataMember]
    public DateAndDateTimeSearch5Choice_? EffectiveSettlementDate { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [DataMember]
    public ValueList<PriorityNumeric4Choice_> Priority { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [DataMember]
    public ValueList<SystemPartyIdentification8> MessageOriginator { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the creation date/time of the intra-balance movement.
    /// </summary>
    [DataMember]
    public DateAndDateTimeSearch5Choice_? CreationDateTime { get; init; } 
    
    #nullable disable
}
