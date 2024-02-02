﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccount21.  ISO2002 ID# _RxSVdtp-Ed-ak6NoX_4Aeg_-792130403.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
[DataContract]
[XmlType]
public partial record InvestmentAccount21
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [DataMember]
    public required AccountIdentification1 AccountIdentification { get; init; } 
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [DataMember]
    public IsoMax35Text? AccountName { get; init; } 
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [DataMember]
    public IsoMax35Text? AccountDesignation { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [DataMember]
    public ValueList<PartyIdentification2Choice_> OwnerIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [DataMember]
    public PartyIdentification2Choice_? AccountServicer { get; init; } 
    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    [DataMember]
    public OrderOriginatorEligibility1Code? OrderOriginatorEligibility { get; init; } 
    /// <summary>
    /// Sub-accounts that are grouped in a master or omnibus account.
    /// </summary>
    [DataMember]
    public SubAccount1? SubAccountDetails { get; init; } 
    
    #nullable disable
}
