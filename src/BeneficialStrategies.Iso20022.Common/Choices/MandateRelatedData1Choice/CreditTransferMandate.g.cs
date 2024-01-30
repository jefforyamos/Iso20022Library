﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CreditTransferMandate.  ISO2002 ID# _2_Hf4clxEem0vqvvoqYsqQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData1Choice;

/// <summary>
/// Specific credit transfer mandate data.
/// </summary>
public partial record CreditTransferMandate : IMandateRelatedData1Choice
{
    #nullable enable
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    public IsoMax35Text? MandateIdentification { get; init; } 
    /// <summary>
    /// Specifies the type of mandate, such as paper, electronic or scheme.
    /// </summary>
    public MandateTypeInformation2? Type { get; init; } 
    /// <summary>
    /// Date on which the credit transfer mandate has been signed by the debtor.
    /// </summary>
    public IsoISODate? DateOfSignature { get; init; } 
    /// <summary>
    /// Date on which the credit transfer mandate has been verified.
    /// </summary>
    public IsoISODateTime? DateOfVerification { get; init; } 
    /// <summary>
    /// Additional security provisions, such as a digital signature, as provided by the debtor.
    /// </summary>
    public IsoMax10KBinary? ElectronicSignature { get; init; } 
    /// <summary>
    /// Date of the first payment of a recurrent credit transfer as per the mandate.
    /// </summary>
    public IsoISODate? FirstPaymentDate { get; init; } 
    /// <summary>
    /// Date of the final payment of a recurrent credit transfer as per the mandate.
    /// </summary>
    public IsoISODate? FinalPaymentDate { get; init; } 
    /// <summary>
    /// Regularity with which credit transfer instructions are to be created and processed.
    /// </summary>
    public IFrequency36Choice? Frequency { get; init; } 
    /// <summary>
    /// Reason for the setup of the credit transfer mandate.
    /// Usage: 
    /// The reason will allow the user to distinguish between different mandates for the same creditor.
    /// </summary>
    public IMandateSetupReason1Choice? Reason { get; init; } 
    #nullable disable
}
