﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Pension2.  ISO2002 ID# _00BtYFKgEeiOGaojF53zIw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of a pension.
/// </summary>
public partial record Pension2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the pension policy, plan or scheme.
    /// </summary>
    public PensionPolicy1? Identification { get; init; } 
    /// <summary>
    /// Type of pension policy, plan or scheme.
    /// </summary>
    public required IPensionSchemeType1Choice Type { get; init; } 
    /// <summary>
    /// Scope of the pension policy, plan or scheme transfer.
    /// </summary>
    public IPensionTransferScope1Choice? TransferScope { get; init; } 
    /// <summary>
    /// Tax reference issued to the pension policy, plan or scheme by a central organisation.
    /// </summary>
    public TaxReference1? TaxReference { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Reference of the drawdown.
    /// </summary>
    public IsoMax35Text? DrawdownTrancheIdentification { get; init; } 
    /// <summary>
    /// Drawdown status of the pension.
    /// </summary>
    public IDrawdownStatus1Choice? DrawdownStatus { get; init; } 
    /// <summary>
    /// Estimated value of the pension policy, plan or scheme.
    /// </summary>
    public DateAndAmount2? EstimatedValue { get; init; } 
    /// <summary>
    /// Indicates whether the transfer forms part of a block transfer.
    /// </summary>
    public IsoYesNoIndicator? BlockTransfer { get; init; } 
    /// <summary>
    /// Indicates whether the tax-free cash is protected when the pension policy, plan or scheme is transferred.
    /// </summary>
    public IsoYesNoIndicator? TaxFreeCashProtection { get; init; } 
    /// <summary>
    /// Amount of cash that is tax free.
    /// </summary>
    public DateAndAmount2? TaxFreeCashAmount { get; init; } 
    /// <summary>
    /// Value of the pension policy, plan or scheme.
    /// </summary>
    public DateAndAmount2? ValueOfPensionPolicyOrPlanOrScheme { get; init; } 
    /// <summary>
    /// Indicates whether the pension policy, plan or scheme has retirement age protection.
    /// </summary>
    public IsoYesNoIndicator? RetirementAgeProtection { get; init; } 
    /// <summary>
    /// Age at which the pension policy, plan or scheme holder retires.
    /// </summary>
    public IsoDecimalNumber? RetirementAge { get; init; } 
    /// <summary>
    /// Indicates whether the pension benefits are shared.
    /// </summary>
    public IsoYesNoIndicator? Sharing { get; init; } 
    /// <summary>
    /// Type of lump sum paid to a member of the pension policy, plan or scheme.
    /// </summary>
    public ILumpSumType1Choice? LumpSumType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Order attached to the pension policy, plan or scheme.
    /// </summary>
    public PensionOrder1? PensionOrder { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates whether assets held within the pension are ring-fenced into specific tranches.
    /// </summary>
    public IsoYesNoIndicator? RingFencedDrawdownAssets { get; init; } 
    /// <summary>
    /// Money Purchase Annual Allowance (MPAA) details.
    /// </summary>
    public MoneyPurchaseAnnualAllowance1? MoneyPurchaseAnnualAllowance { get; init; } 
    /// <summary>
    /// Indicates whether the pension policy, plan or scheme is covered by a safeguard benefit.
    /// </summary>
    public IsoYesNoIndicator? SafeguardBenefit { get; init; } 
    /// <summary>
    /// Indicates whether the pension policy, plan or scheme has lifetime allowance protection.
    /// </summary>
    public IsoYesNoIndicator? LifetimeAllowanceProtection { get; init; } 
    /// <summary>
    /// Additional information about the pension policy, plan or scheme.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
