﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LimitIdentification5.  ISO2002 ID# __vDiZ249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the identification details to uniquely identify a limit within the system.
/// </summary>
[DataContract]
[XmlType]
public partial record LimitIdentification5
{
    #nullable enable
    
    /// <summary>
    /// Identification of a particular cash clearing system.
    /// </summary>
    [DataMember]
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    /// <summary>
    /// Identification of the system member for which the limit is established.
    /// </summary>
    [DataMember]
    public BranchAndFinancialInstitutionIdentification6? BilateralLimitCounterpartyIdentification { get; init; } 
    /// <summary>
    /// Nature of the risk management limit.
    /// </summary>
    [DataMember]
    public required LimitType1Choice_ Type { get; init; } 
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [DataMember]
    public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [DataMember]
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    
    #nullable disable
}
