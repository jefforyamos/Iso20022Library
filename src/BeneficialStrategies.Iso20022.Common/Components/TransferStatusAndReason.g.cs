﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferStatusAndReason.  ISO2002 ID# _UzmP6dp-Ed-ak6NoX_4Aeg_-2005620583.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the status of a transfer instruction and its reason.
/// </summary>
[IsoId("_UzmP6dp-Ed-ak6NoX_4Aeg_-2005620583")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Transfer Status And Reason")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferStatusAndReason
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransferStatusAndReason instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferStatusAndReason( System.String reqTransferReference,TransferInstructionStatus reqStatus,PendingSettlementStatusChoice_ reqPendingSettlement,TransferUnmatchedStatus reqUnmatched,InRepairStatus2Choice_ reqInRepair,RejectedStatus3Choice_ reqRejected )
    {
        TransferReference = reqTransferReference;
        Status = reqStatus;
        PendingSettlement = reqPendingSettlement;
        Unmatched = reqUnmatched;
        InRepair = reqInRepair;
        Rejected = reqRejected;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Business reference of the transfer instruction.
    /// </summary>
    [IsoId("_UzmP6tp-Ed-ak6NoX_4Aeg_-1918809978")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transfer Reference")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransferReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String TransferReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransferReference { get; init; } 
    #else
    public System.String TransferReference { get; set; } 
    #endif
    
    /// <summary>
    /// Instruction status and the reason for the status.
    /// </summary>
    [IsoId("_UzvZ0Np-Ed-ak6NoX_4Aeg_-1559464937")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferInstructionStatus Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TransferInstructionStatus Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferInstructionStatus Status { get; init; } 
    #else
    public TransferInstructionStatus Status { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer instruction is pending settlement.
    /// </summary>
    [IsoId("_UzvZ0dp-Ed-ak6NoX_4Aeg_-1496751882")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pending Settlement")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PendingSettlementStatusChoice_ PendingSettlement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PendingSettlementStatusChoice_ PendingSettlement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PendingSettlementStatusChoice_ PendingSettlement { get; init; } 
    #else
    public PendingSettlementStatusChoice_ PendingSettlement { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer instruction is unmatched.
    /// </summary>
    [IsoId("_UzvZ0tp-Ed-ak6NoX_4Aeg_-1839191")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unmatched")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferUnmatchedStatus Unmatched { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TransferUnmatchedStatus Unmatched { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferUnmatchedStatus Unmatched { get; init; } 
    #else
    public TransferUnmatchedStatus Unmatched { get; set; } 
    #endif
    
    /// <summary>
    /// Status is in repair.
    /// </summary>
    [IsoId("_UzvZ09p-Ed-ak6NoX_4Aeg_-1844925356")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("In Repair")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InRepairStatus2Choice_ InRepair { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public InRepairStatus2Choice_ InRepair { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InRepairStatus2Choice_ InRepair { get; init; } 
    #else
    public InRepairStatus2Choice_ InRepair { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer instructed is rejected.
    /// </summary>
    [IsoId("_UzvZ1Np-Ed-ak6NoX_4Aeg_-1634364494")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rejected")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectedStatus3Choice_ Rejected { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public RejectedStatus3Choice_ Rejected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectedStatus3Choice_ Rejected { get; init; } 
    #else
    public RejectedStatus3Choice_ Rejected { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    [IsoId("_UzvZ1dp-Ed-ak6NoX_4Aeg_933459085")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Status Initiator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification1Choice_? StatusInitiator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification1Choice_? StatusInitiator { get; init; } 
    #else
    public PartyIdentification1Choice_? StatusInitiator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
