﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Cheque6.  ISO2002 ID# _QbwF6dp-Ed-ak6NoX_4Aeg_666058434.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to a cheque instruction, such as cheque type or cheque number.
/// </summary>
public partial record Cheque6
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of cheque to be issued.
    /// </summary>
    public ChequeType2Code? ChequeType { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the agent.
    /// </summary>
    public IsoMax35Text? ChequeNumber { get; init; } 
    /// <summary>
    /// Identifies the party that ordered the issuance of the cheque.
    /// </summary>
    public NameAndAddress10? ChequeFrom { get; init; } 
    /// <summary>
    /// Specifies the delivery method of the cheque by the debtor's agent.
    /// </summary>
    public ChequeDeliveryMethod1Choice_? DeliveryMethod { get; init; } 
    /// <summary>
    /// Party to whom the debtor's agent needs to send the cheque.
    /// </summary>
    public NameAndAddress10? DeliverTo { get; init; } 
    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.
    /// </summary>
    public Priority2Code? InstructionPriority { get; init; } 
    /// <summary>
    /// Date when the draft becomes payable and the debtor's account is debited.
    /// </summary>
    public IsoISODate? ChequeMaturityDate { get; init; } 
    /// <summary>
    /// Identifies, in a coded form, the cheque layout, company logo and digitised signature to be used to print the cheque, as agreed between the initiating party and the debtor's agent.
    /// </summary>
    public IsoMax35Text? FormsCode { get; init; } 
    /// <summary>
    /// Information that needs to be printed on a cheque, used by the payer to add miscellaneous information.
    /// </summary>
    public IsoMax35Text[] MemoField { get; init; } = [];
    /// <summary>
    /// Regional area in which the cheque can be cleared, when a country has no nation-wide cheque clearing organisation.
    /// </summary>
    public IsoMax35Text? RegionalClearingZone { get; init; } 
    /// <summary>
    /// Specifies the print location of the cheque.
    /// </summary>
    public IsoMax35Text? PrintLocation { get; init; } 
    
    #nullable disable
}
