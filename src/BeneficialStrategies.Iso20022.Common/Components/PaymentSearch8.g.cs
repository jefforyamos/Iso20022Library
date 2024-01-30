﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentSearch8.  ISO2002 ID# _ANTkoW4-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a payment.
/// </summary>
public partial record PaymentSearch8
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original initiating party, to unambiguously identify the original payment transaction message. |Usage: this is the former transaction reference.
    /// </summary>
    public IsoMax35Text? MessageIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Date and time at which the cash is at the disposal of the credit account owner, or ceases to be at the disposal of the debit account owner.
    /// </summary>
    public IDateAndDateTimeSearch3Choice? RequestedExecutionDate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Unique and unambiguous identifier for a payment instruction, as assigned by the clearing agent or the initiating party.|.
    /// </summary>
    public IPaymentIdentification6Choice? PaymentIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Detailed information about the status of a transfer.||.
    /// </summary>
    public InstructionStatusSearch5? Status { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the instructed amount(s) on which the query is performed.
    /// </summary>
    public IActiveOrHistoricAmountRange2Choice? InstructedAmount { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Currency in which the instructed amount is expressed.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? InstructedAmountCurrency { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates whether the payment instruction is a debit or a credit.|.
    /// </summary>
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies the interbank settlement amount(s) on which the query is performed.
    /// </summary>
    public IActiveAmountRange3Choice? InterbankSettlementAmount { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Currency in which the interbank settlement amount is expressed.
    /// </summary>
    public ActiveCurrencyCode? InterbankSettlementAmountCurrency { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates the message or event from which an instruction has been initiated.
    /// </summary>
    public IPaymentOrigin1Choice? PaymentMethod { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Instruction to pay an amount of money to an ultimate beneficiary, on behalf of an originator. This instruction may have to be forwarded several times to complete the settlement chain.|.
    /// </summary>
    public IPaymentType4Choice? PaymentType { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.|.
    /// </summary>
    public IPriority1Choice? Priority { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Date and time range within which the payment instruction must be processed.|.
    /// </summary>
    public IDateTimePeriod1Choice? ProcessingValidityTime { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Further information related to the processing of the payment instruction. The instruction can relate to a level of service between the bank and the customer, or give instructions to and for specific parties in the payment chain.|.
    /// </summary>
    public Instruction1Code? Instruction { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.|Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.|Usage: this is the former PaymentInstructionReference.
    /// </summary>
    public IsoMax35Text? TransactionIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.|Usage: this is the former InterbankValueDate.
    /// </summary>
    public IsoISODate? InterbankSettlementDate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.|Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction.|It can be included in several messages related to the transaction.|Usage: this is the former RelatedReference.
    /// </summary>
    public IsoMax35Text? EndToEndIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Defines the party fields used to search for a payment.
    /// </summary>
    public PaymentTransactionParty3? Parties { get; init; } 
    
    #nullable disable
}
