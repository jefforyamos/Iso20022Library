﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OriginalActivationData.  ISO2002 ID# _UPBU8-H7Eeqbls7Gk4-ckA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalActivation2Choice;

/// <summary>
/// Provides the full original activation data.
/// </summary>
public partial record OriginalActivationData : IOriginalActivation2Choice
{
    #nullable enable
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the activation.
    /// Usage:
    /// This element may be used for technical reconciliation purpose.
    /// </summary>
    public IsoMax35Text? DebtorActivationIdentification { get; init; } 
    /// <summary>
    /// Name by which the debtor is known, other than legal name, such as the name to be shown to the creditor. 
    /// </summary>
    public IsoMax140Text? DisplayName { get; init; } 
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public RTPPartyIdentification1? UltimateDebtor { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public required RTPPartyIdentification1 Debtor { get; init; } 
    /// <summary>
    /// Organisation servicing the e-invoicing for the debtor (to which the activation status report must be sent).
    /// </summary>
    public required RTPPartyIdentification1 DebtorSolutionProvider { get; init; } 
    /// <summary>
    /// Unique identifier of the debtor required by the creditor, for example  the reference number or customer number. Unique identification provided by the web bank or web payment services user, with which the creditor may identify the debtor in its system.
    /// </summary>
    public IParty49Choice? CustomerIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Document format type supported to exchange the contracts.
    /// </summary>
    public IDocumentFormat2Choice? ContractFormatType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Code choice external/prop
    /// Description
    /// identical to the Instruction for Debtor
    /// </summary>
    public ContractReference1? ContractReference { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    public required RTPPartyIdentification1 Creditor { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    public RTPPartyIdentification1? UltimateCreditor { get; init; } 
    /// <summary>
    /// Creditor's service provider address to which the debtor activation has to be delivered.
    /// </summary>
    public RTPPartyIdentification1? ActivationRequestDeliveryParty { get; init; } 
    /// <summary>
    /// Date and time at which the debtor activation will be activated.
    /// </summary>
    public IDateAndDateTime2Choice? StartDate { get; init; } 
    /// <summary>
    /// Date and time at which the debtor activation will be deactivated.
    /// </summary>
    public IDateAndDateTime2Choice? EndDate { get; init; } 
    /// <summary>
    /// Unique, one-time code that a creditor may require from a debtor for activation purposes, and which is known only by the creditor and the debtor.
    /// </summary>
    public IsoMax35Text? DedicatedActivationCode { get; init; } 
    #nullable disable
}
