﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransferUnmatchedReason1Code.  ISO2002 ID# _Vj32Sdp-Ed-ak6NoX_4Aeg_-661831225.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a transfer or settlement instruction unmatched status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vj32Sdp-Ed-ak6NoX_4Aeg_-661831225")]
[Description(@"Specifies the reason for a transfer or settlement instruction unmatched status.")]
[DerivedFrom(typeof(TransferUnmatchedReasonCode))]
public enum TransferUnmatchedReason1Code
{
    /// <summary>
    /// No potential match has been found.
    /// Encoded/decoded by serializers as "NoMatch".
    /// </summary>
    [EnumMember(Value = "CMIS")]
    [IsoId("_VkBnQNp-Ed-ak6NoX_4Aeg_-384771592")]
    [Description(@"No potential match has been found.")]
    NoMatch,
    
    /// <summary>
    /// Counterparty has cancelled the transaction/instruction.
    /// Encoded/decoded by serializers as "CounterpartyCancelled".
    /// </summary>
    [EnumMember(Value = "CPCA")]
    [IsoId("_VkBnQdp-Ed-ak6NoX_4Aeg_-384771575")]
    [Description(@"Counterparty has cancelled the transaction/instruction.")]
    CounterpartyCancelled,
    
    /// <summary>
    /// Direction of transaction does not match: delivery instead of receipt or vice versa.
    /// Encoded/decoded by serializers as "TransactionDirection".
    /// </summary>
    [EnumMember(Value = "DELN")]
    [IsoId("_VkBnQtp-Ed-ak6NoX_4Aeg_-384771557")]
    [Description(@"Direction of transaction does not match: delivery instead of receipt or vice versa.")]
    TransactionDirection,
    
    /// <summary>
    /// Financial instrument identification does not match or a financial instrument attribute differs.
    /// Encoded/decoded by serializers as "FinancialInstrument".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_VkBnQ9p-Ed-ak6NoX_4Aeg_-384771515")]
    [Description(@"Financial instrument identification does not match or a financial instrument attribute differs.")]
    FinancialInstrument,
    
    /// <summary>
    /// Settlement does not match: counterparty's instruction is for physical settlement, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as "PhysicalSettlement".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_VkBnRNp-Ed-ak6NoX_4Aeg_-384771497")]
    [Description(@"Settlement does not match: counterparty's instruction is for physical settlement, your instruction is not, or vice versa.")]
    PhysicalSettlement,
    
    /// <summary>
    /// Instruction has not been matched: it is a possible duplicate instruction.
    /// Encoded/decoded by serializers as "Duplicate".
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("_VkBnRdp-Ed-ak6NoX_4Aeg_-377386836")]
    [Description(@"Instruction has not been matched: it is a possible duplicate instruction.")]
    Duplicate,
    
    /// <summary>
    /// Place of settlement does not match.
    /// Encoded/decoded by serializers as "SettlementPlace".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_VkBnRtp-Ed-ak6NoX_4Aeg_-377386819")]
    [Description(@"Place of settlement does not match.")]
    SettlementPlace,
    
    /// <summary>
    /// Settlement date or transfer date does not match.
    /// Encoded/decoded by serializers as "SettlementDate".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_VkBnR9p-Ed-ak6NoX_4Aeg_-377386801")]
    [Description(@"Settlement date or transfer date does not match.")]
    SettlementDate,
    
    /// <summary>
    /// Financial instrument quantity does not match.
    /// Encoded/decoded by serializers as "FinancialInstrumentQuantity".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_VkBnSNp-Ed-ak6NoX_4Aeg_-1926778684")]
    [Description(@"Financial instrument quantity does not match.")]
    FinancialInstrumentQuantity,
    
    /// <summary>
    /// Another unmatched reason.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VkBnSdp-Ed-ak6NoX_4Aeg_-871193861")]
    [Description(@"Another unmatched reason.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TransferUnmatchedReason1CodeMetadataExtensions
{
    private static readonly TransferUnmatchedReason1CodeDropdownSource _dropdownSource = new TransferUnmatchedReason1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITransferUnmatchedReason1CodeDropdownRow GetMetadata(this TransferUnmatchedReason1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


