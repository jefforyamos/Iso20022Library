﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccountOpening2.  ISO2002 ID# _KlCNQSFfEeW9XJWqfgXIIA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the type of opening instruction and identification of the application request.
/// </summary>
[DataContract]
[XmlType]
public partial record InvestmentAccountOpening2
{
    #nullable enable
    
    /// <summary>
    /// Specifies if the account opening instruction is about a newly created account or a supplementary account.
    /// </summary>
    [DataMember]
    public required AccountOpeningType1Code OpeningType { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of the account opening request at application level.
    /// </summary>
    [DataMember]
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of a transaction, for example, a transfer, as assigned by the investor or account owner.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction, for example, a transfer, as allocated by the counterparty.
    /// </summary>
    [DataMember]
    public AdditionalReference6? CounterpartyReference { get; init; } 
    /// <summary>
    /// Account to which the account opening is related.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ExistingAccountIdentification { get; init; } 
    
    #nullable disable
}
