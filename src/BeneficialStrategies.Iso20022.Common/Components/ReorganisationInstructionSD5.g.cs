﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReorganisationInstructionSD5.  ISO2002 ID# _oDfBQecYEei5aPS232E3Mw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action reorganisation instruction details.
/// </summary>
public partial record ReorganisationInstructionSD5
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Identifies the reorganisation transaction type.
    /// </summary>
    public ReorganisationTransactionType2Code? TransactionType { get; init; } 
    /// <summary>
    /// Enable input of multiple voluntary instructions for rights or voluntary puts events via a single instruction message through using Transaction Sequence Number.
    /// </summary>
    // public IReadOnlyCollection<InstructionsTransactionsSequence1> TransactionSequence { get; init; }
    /// <summary>
    /// Total oversubscription quantity of all transaction sequence instructions.
    /// </summary>
    public FinancialInstrumentQuantity4? TotalOversubscriptionQuantity { get; init; } 
    /// <summary>
    /// Acknowledgement information relative to corporate action reorganisation instructions.
    /// </summary>
    public CorporateActionAcknowledgementSD1? AcknowledgementDetails { get; init; } 
    /// <summary>
    /// Party contact information for the given instruction; required for voluntary offer instruction transaction (VOIT), protect transaction (PROT) and protect on behalf of another participant transaction (PROP); not required for cover protect instructions like cover protect transaction (COVR), cover protect directly to agent transaction (COVA) and cover protect on behalf of another participant transaction (COVP).
    /// </summary>
    public ContactIdentification5? ContactPerson { get; init; } 
    /// <summary>
    /// Unique identification of the transaction used by the transmitting party.
    /// </summary>
    public IsoMax6Text? UserReferenceNumber { get; init; } 
    /// <summary>
    /// Warrant subscription amount entered by client when instructing on a warrant exercise instruction.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? WarrantSubscriptionChargeAmount { get; init; } 
    /// <summary>
    /// Indicates whether DTC participant is willing to accept penalties as a result of processing instructions prior to maturity of CD redemptions events.
    /// Yes: participant accepts penalties.
    /// No: participant does not accept penalties.
    /// </summary>
    public IsoYesNoIndicator? NonExemptInstructionsAllowedIndicator { get; init; } 
    /// <summary>
    /// Indicates whether there is a solicitation fee on the event. This fee is paid soliciting dealer.
    /// Yes: there is a solicitation fee.
    /// No: there is not a solicitation fee.
    /// </summary>
    public IsoYesNoIndicator? SolicitationFeeIndicator { get; init; } 
    /// <summary>
    /// Certificate information for a given instruction.
    /// </summary>
    public CorporateActionCertificateSD1? Certificate { get; init; } 
    /// <summary>
    /// Beneficial owner information related to CD early redemption instructions.
    /// </summary>
    public DeceasedStatusSD1? DeceasedBeneficialOwnerDetails { get; init; } 
    
    #nullable disable
}
