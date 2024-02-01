﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PEPISATransfer7.  ISO2002 ID# _RQ8ogtp-Ed-ak6NoX_4Aeg_1365580031.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a transfer instruction.
/// </summary>
public partial record PEPISATransfer7
{
    #nullable enable
    
    /// <summary>
    /// Information identifying the primary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; } 
    /// <summary>
    /// Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; } 
    /// <summary>
    /// Information identifying the other individual investors, eg, name, address, social security number and date of birth.
    /// </summary>
    public IndividualPerson8[] OtherIndividualInvestor { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Information identifying the primary corporate investor, eg, name and address.
    /// </summary>
    public Organisation4? PrimaryCorporateInvestor { get; init; } 
    /// <summary>
    /// Information identifying the secondary corporate investor, eg, name and address.
    /// </summary>
    public Organisation4? SecondaryCorporateInvestor { get; init; } 
    /// <summary>
    /// Information identifying the other corporate investors, eg, name and address.
    /// </summary>
    public Organisation4[] OtherCorporateInvestor { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of an account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    public required Account5 ClientAccount { get; init; } 
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    public Account6? NomineeAccount { get; init; } 
    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    public required PartyIdentification2Choice_ NewPlanManager { get; init; } 
    /// <summary>
    /// Identification of an account owned by the investor to which a cash entry is made based on the transfer of asset(s).
    /// </summary>
    public CashAccount11? CashAccount { get; init; } 
    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    public PEPISATransfer8[] ProductTransfer { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public Extension1[] Extension { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
