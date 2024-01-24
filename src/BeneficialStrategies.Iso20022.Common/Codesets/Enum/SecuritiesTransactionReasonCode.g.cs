﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesTransactionReasonCode.  ISO2002 ID# _ZGOisNp-Ed-ak6NoX_4Aeg_464976126.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the reason why the transaction has a specific status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZGOisNp-Ed-ak6NoX_4Aeg_464976126")]
[Description(@"Identifies the reason why the transaction has a specific status.")]
[Derivations(typeof(SecuritiesTransactionReason1Code))]
public enum SecuritiesTransactionReasonCode
{
    /// <summary>
    /// Specifies the reason why the instruction is cancelled.
    /// Encoded/decoded by serializers as "CAND".
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_ZGOisdp-Ed-ak6NoX_4Aeg_-1565978521")]
    [Description(@"Specifies the reason why the instruction is cancelled.")]
    Cancellation,
    
    /// <summary>
    /// Specifies the reason why a cancellation request sent for the related instruction is pending.
    /// Encoded/decoded by serializers as "CANP".
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_ZGOistp-Ed-ak6NoX_4Aeg_-1538271512")]
    [Description(@"Specifies the reason why a cancellation request sent for the related instruction is pending.")]
    PendingCancellation,
    
    /// <summary>
    /// Specifies the reason why the transaction was generated.
    /// Encoded/decoded by serializers as "CGEN".
    /// </summary>
    [EnumMember(Value = "CGEN")]
    [IsoId("_ZGOis9p-Ed-ak6NoX_4Aeg_-1537348292")]
    [Description(@"Specifies the reason why the transaction was generated.")]
    Generated,
    
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// Encoded/decoded by serializers as "NMAT".
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_ZGOitNp-Ed-ak6NoX_4Aeg_-1536425172")]
    [Description(@"Specifies the reason why the instruction has an unmatched status.")]
    Unmatched,
    
    /// <summary>
    /// Specifies additional information about the processed instruction.
    /// Encoded/decoded by serializers as "PACK".
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ZGOitdp-Ed-ak6NoX_4Aeg_-1535502205")]
    [Description(@"Specifies additional information about the processed instruction.")]
    Acknowledgement,
    
    /// <summary>
    /// Specifies the reason why the instruction has a pending status.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZGOittp-Ed-ak6NoX_4Aeg_-1534577760")]
    [Description(@"Specifies the reason why the instruction has a pending status.")]
    Pending,
    
    /// <summary>
    /// Specifies the reason why the instruction has a failing settlement status.
    /// Encoded/decoded by serializers as "PENF".
    /// </summary>
    [EnumMember(Value = "PENF")]
    [IsoId("_ZGOit9p-Ed-ak6NoX_4Aeg_-1526266040")]
    [Description(@"Specifies the reason why the instruction has a failing settlement status.")]
    Failing,
    
    /// <summary>
    /// Specifies the reason why the instruction has a pending processing status.
    /// Encoded/decoded by serializers as "PPRC".
    /// </summary>
    [EnumMember(Value = "PPRC")]
    [IsoId("_ZGOiuNp-Ed-ak6NoX_4Aeg_-1525342519")]
    [Description(@"Specifies the reason why the instruction has a pending processing status.")]
    PendingProcessing,
    
    /// <summary>
    /// Specifies the reason why the instruction is in repair.
    /// Encoded/decoded by serializers as "REPR".
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_ZGOiudp-Ed-ak6NoX_4Aeg_-1524418998")]
    [Description(@"Specifies the reason why the instruction is in repair.")]
    Repair,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesTransactionReasonCodeMetadataExtensions
{
    private static readonly SecuritiesTransactionReasonCodeDropdownSource _dropdownSource = new SecuritiesTransactionReasonCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesTransactionReasonCodeDropdownRow GetMetadata(this SecuritiesTransactionReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


