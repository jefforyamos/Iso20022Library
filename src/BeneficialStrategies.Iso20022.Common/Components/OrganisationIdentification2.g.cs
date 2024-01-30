﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OrganisationIdentification2.  ISO2002 ID# _QQa_pNp-Ed-ak6NoX_4Aeg_-987207025.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
public partial record OrganisationIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial institution by the ISO 9362 Registration Authority as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
    /// </summary>
    public IsoBICIdentifier? BIC { get; init; } 
    /// <summary>
    /// International Business Entity Identifier to uniquely identify business entities playing a role in the lifecycle of and events related to a financial instrument. (tentative - to be confirmed).
    /// </summary>
    public IsoIBEIIdentifier? IBEI { get; init; } 
    /// <summary>
    /// Code allocated to a non-financial institution by the ISO 9362 Registration Authority as described in ISO 9362 "Banking - Banking telecommunication messages - Business identifier code (BIC)".
    /// </summary>
    public IsoBEIIdentifier? BEI { get; init; } 
    /// <summary>
    /// Global Location Number. A non-significant reference number used to identify legal entities, functional entities, or physical entities according to the European Association for Numbering (EAN) numbering scheme rules.The number is used to retrieve detailed information that is linked to it.
    /// </summary>
    public IsoEANGLNIdentifier? EANGLN { get; init; } 
    /// <summary>
    /// (United States) Clearing House Interbank Payments System (CHIPS) Universal Identification (UID) - identifies entities that own accounts at CHIPS participating financial institutions, through which CHIPS payments are effected. The CHIPS UID is assigned by the New York Clearing House.
    /// </summary>
    public IsoCHIPSUniversalIdentifier? CHIPSUniversalIdentification { get; init; } 
    /// <summary>
    /// Data Universal Numbering System. A unique identification number provided by Dun & Bradstreet to identify an organization.
    /// </summary>
    public IsoDunsIdentifier? DUNS { get; init; } 
    /// <summary>
    /// Unique and unambiguous assignment made by a specific bank to identify a relationship as defined between the bank and its client.
    /// </summary>
    public IsoMax35Text? BankPartyIdentification { get; init; } 
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    public IsoMax35Text? TaxIdentificationNumber { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution.
    /// </summary>
    public GenericIdentification3? ProprietaryIdentification { get; init; } 
    
    #nullable disable
}
