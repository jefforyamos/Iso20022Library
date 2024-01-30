﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateRelatedInformation11.  ISO2002 ID# _seR6NWk2Eeanu6HLe77Rkg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details related to a direct debit mandate signed between the creditor and the debtor.
/// </summary>
public partial record MandateRelatedInformation11
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    public IsoMax35Text? MandateIdentification { get; init; } 
    /// <summary>
    /// Date on which the direct debit mandate has been signed by the debtor.
    /// </summary>
    public IsoISODate? DateOfSignature { get; init; } 
    /// <summary>
    /// Indicator notifying whether the underlying mandate is amended or not.
    /// </summary>
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; } 
    /// <summary>
    /// List of mandate elements that have been modified.
    /// </summary>
    public AmendmentInformationDetails11? AmendmentInformationDetails { get; init; } 
    /// <summary>
    /// Additional security provisions, such as a digital signature, as provided by the debtor.
    /// </summary>
    public IsoMax1025Text? ElectronicSignature { get; init; } 
    /// <summary>
    /// Date of the first collection of a direct debit as per the mandate.
    /// </summary>
    public IsoISODate? FirstCollectionDate { get; init; } 
    /// <summary>
    /// Date of the final collection of a direct debit as per the mandate.
    /// </summary>
    public IsoISODate? FinalCollectionDate { get; init; } 
    /// <summary>
    /// Regularity with which direct debit instructions are to be created and processed.
    /// </summary>
    public IFrequency36Choice? Frequency { get; init; } 
    /// <summary>
    /// Reason for the direct debit mandate to allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    public IMandateSetupReason1Choice? Reason { get; init; } 
    /// <summary>
    /// Specifies the number of days the direct debit instruction must be tracked.
    /// </summary>
    public IsoExact2NumericText? TrackingDays { get; init; } 
    
    #nullable disable
}
