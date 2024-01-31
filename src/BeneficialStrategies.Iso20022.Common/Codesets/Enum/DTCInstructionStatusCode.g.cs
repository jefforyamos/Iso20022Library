﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCInstructionStatusCode.  ISO2002 ID# _12r8hTL3EeKU9IrkkToqcw_504869830.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// DTC (The Depository Trust Company) system status code of instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_12r8hTL3EeKU9IrkkToqcw_504869830")]
[Description(@"DTC (The Depository Trust Company) system status code of instruction.")]
[Derivations(typeof(DTCInstructionStatus1Code),typeof(DTCInstructionStatus2Code),typeof(ProtectInstructionStatus4Code),typeof(DTCProtectInstructionStatus3Code),typeof(ProtectInstructionStatus3Code),typeof(DTCProtectInstructionStatus1Code))]
public enum DTCInstructionStatusCode
{
    /// <summary>
    /// Instruction waiting for position. Instruction will subsequently either become “Made” or “Dropped” by end of day.
    /// Encoded/decoded by serializers as "RECY".
    /// </summary>
    [EnumMember(Value = "RECY")]
    [IsoId("_121tgDL3EeKU9IrkkToqcw_707396272")]
    [Description(@"Instruction waiting for position. Instruction will subsequently either become “Made” or “Dropped” by end of day.")]
    Recycle,
    
    /// <summary>
    /// Fully processed instruction.
    /// Encoded/decoded by serializers as "MADE".
    /// </summary>
    [EnumMember(Value = "MADE")]
    [IsoId("_121tgTL3EeKU9IrkkToqcw_457866440")]
    [Description(@"Fully processed instruction.")]
    Made,
    
    /// <summary>
    /// Instruction dropped due to insufficient position.
    /// Encoded/decoded by serializers as "DROP".
    /// </summary>
    [EnumMember(Value = "DROP")]
    [IsoId("_121tgjL3EeKU9IrkkToqcw_1942174612")]
    [Description(@"Instruction dropped due to insufficient position.")]
    Dropped,
    
    /// <summary>
    /// Transaction rejected.
    /// Encoded/decoded by serializers as "EDRJ".
    /// </summary>
    [EnumMember(Value = "EDRJ")]
    [IsoId("_121tgzL3EeKU9IrkkToqcw_-860185991")]
    [Description(@"Transaction rejected.")]
    EditReject,
    
    /// <summary>
    /// Instruction cancelled by client relating to survivor option event.
    /// Encoded/decoded by serializers as "CANC".
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_rxFPgJITEeaNbfbSYshZYw")]
    [Description(@"Instruction cancelled by client relating to survivor option event.")]
    Cancel,
    
    /// <summary>
    /// Cancellation of conversion instruction upon agent approval only.
    /// Encoded/decoded by serializers as "CCAN".
    /// </summary>
    [EnumMember(Value = "CCAN")]
    [IsoId("_6ZVSUJITEeaNbfbSYshZYw")]
    [Description(@"Cancellation of conversion instruction upon agent approval only.")]
    ConversionCancellation,
    
    /// <summary>
    /// Instruction for CD early redemption awaiting paperwork. Instruction will become MADE when DTC releases instruction upon paperwork.
    /// Encoded/decoded by serializers as "PDOC".
    /// </summary>
    [EnumMember(Value = "PDOC")]
    [IsoId("_Cn2L4JIUEeaNbfbSYshZYw")]
    [Description(@"Instruction for CD early redemption awaiting paperwork. Instruction will become MADE when DTC releases instruction upon paperwork.")]
    PendingDocumentation,
    
    /// <summary>
    /// Instruction pending release or delete from approval function.
    /// Encoded/decoded by serializers as "PENA".
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("_5b_D0JIUEeaNbfbSYshZYw")]
    [Description(@"Instruction pending release or delete from approval function.")]
    PendingApproval,
    
    /// <summary>
    /// Instruction waiting for update after submission.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("__spJkJIUEeaNbfbSYshZYw")]
    [Description(@"Instruction waiting for update after submission.")]
    Pending,
    
    /// <summary>
    /// Instruction or withdrawal rejected by agent relating to survivor option event.
    /// Encoded/decoded by serializers as "REJA".
    /// </summary>
    [EnumMember(Value = "REJA")]
    [IsoId("_Z2XrgJIVEeaNbfbSYshZYw")]
    [Description(@"Instruction or withdrawal rejected by agent relating to survivor option event.")]
    RejectedByAgent,
    
    /// <summary>
    /// Instruction did not pass initial validation.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_muJPMJIVEeaNbfbSYshZYw")]
    [Description(@"Instruction did not pass initial validation.")]
    Reject,
    
    /// <summary>
    /// Previously recycled transactions have been “MADE” and the system is processing the updates.
    /// Encoded/decoded by serializers as "REMD".
    /// </summary>
    [EnumMember(Value = "REMD")]
    [IsoId("_rwP3IJIVEeaNbfbSYshZYw")]
    [Description(@"Previously recycled transactions have been “MADE” and the system is processing the updates.")]
    RecycleMade,
    
    /// <summary>
    /// Rescinded by Issuer.
    /// Encoded/decoded by serializers as "RESC".
    /// </summary>
    [EnumMember(Value = "RESC")]
    [IsoId("_xdML0JIVEeaNbfbSYshZYw")]
    [Description(@"Rescinded by Issuer.")]
    Rescinded,
    
    /// <summary>
    /// Instruction moved from one client account to another for put events.
    /// Encoded/decoded by serializers as "SWUN".
    /// </summary>
    [EnumMember(Value = "SWUN")]
    [IsoId("_1Nd_gJIVEeaNbfbSYshZYw")]
    [Description(@"Instruction moved from one client account to another for put events.")]
    Swung,
    
    /// <summary>
    /// Client instruction withdrawn for events with withdrawal privilege.
    /// Encoded/decoded by serializers as "WITH".
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_CDJ4gJIWEeaNbfbSYshZYw")]
    [Description(@"Client instruction withdrawn for events with withdrawal privilege.")]
    Withdrawn,
    
    /// <summary>
    /// Protect instruction has been fully covered.
    /// Encoded/decoded by serializers as "COVR".
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_wsiGwJIcEeaNbfbSYshZYw")]
    [Description(@"Protect instruction has been fully covered.")]
    FullyCovered,
    
    /// <summary>
    /// Protect instruction has expired.
    /// Encoded/decoded by serializers as "EXPI".
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_2ksM8JIcEeaNbfbSYshZYw")]
    [Description(@"Protect instruction has expired.")]
    Expired,
    
    /// <summary>
    /// Protect instruction which has not been fully covered. Will include partial covers.
    /// Encoded/decoded by serializers as "OPEN".
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_8N5RIJIcEeaNbfbSYshZYw")]
    [Description(@"Protect instruction which has not been fully covered. Will include partial covers.")]
    Open,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCInstructionStatusCodeMetadataExtensions
{
    private static readonly DTCInstructionStatusCodeDropdownSource _dropdownSource = new DTCInstructionStatusCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCInstructionStatusCodeDropdownRow GetMetadata(this DTCInstructionStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


