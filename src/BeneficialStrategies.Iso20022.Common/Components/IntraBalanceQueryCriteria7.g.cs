﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IntraBalanceQueryCriteria7.  ISO2002 ID# _sJDt5Tp6EemwKdP955WBJQ.
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
public partial record IntraBalanceQueryCriteria7
{
    #nullable enable
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax35Text> CancellationRequestIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [DataMember]
    public ValueList<CancellationProcessingStatus9Choice_> ProcessingStatus { get; init; } = []; // Warning: Don't know multiplicity.
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
