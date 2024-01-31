﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TransferUnmatchedReason1Code.  ISO2002 ID# _Vj32Sdp-Ed-ak6NoX_4Aeg_-661831225.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Encoded/decoded by serializers as "CMIS".
    /// </summary>
    [EnumMember(Value = "CMIS")]
    [IsoId("_VkBnQNp-Ed-ak6NoX_4Aeg_-384771592")]
    [Description(@"No potential match has been found.")]
    NoMatch = TransferUnmatchedReasonCode.NoMatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterparty has cancelled the transaction/instruction.
    /// Encoded/decoded by serializers as "CPCA".
    /// </summary>
    [EnumMember(Value = "CPCA")]
    [IsoId("_VkBnQdp-Ed-ak6NoX_4Aeg_-384771575")]
    [Description(@"Counterparty has cancelled the transaction/instruction.")]
    CounterpartyCancelled = TransferUnmatchedReasonCode.CounterpartyCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Direction of transaction does not match: delivery instead of receipt or vice versa.
    /// Encoded/decoded by serializers as "DELN".
    /// </summary>
    [EnumMember(Value = "DELN")]
    [IsoId("_VkBnQtp-Ed-ak6NoX_4Aeg_-384771557")]
    [Description(@"Direction of transaction does not match: delivery instead of receipt or vice versa.")]
    TransactionDirection = TransferUnmatchedReasonCode.TransactionDirection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument identification does not match or a financial instrument attribute differs.
    /// Encoded/decoded by serializers as "DSEC".
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_VkBnQ9p-Ed-ak6NoX_4Aeg_-384771515")]
    [Description(@"Financial instrument identification does not match or a financial instrument attribute differs.")]
    FinancialInstrument = TransferUnmatchedReasonCode.FinancialInstrument, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement does not match: counterparty's instruction is for physical settlement, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as "PHYS".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_VkBnRNp-Ed-ak6NoX_4Aeg_-384771497")]
    [Description(@"Settlement does not match: counterparty's instruction is for physical settlement, your instruction is not, or vice versa.")]
    PhysicalSettlement = TransferUnmatchedReasonCode.PhysicalSettlement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has not been matched: it is a possible duplicate instruction.
    /// Encoded/decoded by serializers as "PODU".
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("_VkBnRdp-Ed-ak6NoX_4Aeg_-377386836")]
    [Description(@"Instruction has not been matched: it is a possible duplicate instruction.")]
    Duplicate = TransferUnmatchedReasonCode.Duplicate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Place of settlement does not match.
    /// Encoded/decoded by serializers as "DEPT".
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_VkBnRtp-Ed-ak6NoX_4Aeg_-377386819")]
    [Description(@"Place of settlement does not match.")]
    SettlementPlace = TransferUnmatchedReasonCode.SettlementPlace, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement date or transfer date does not match.
    /// Encoded/decoded by serializers as "DDAT".
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_VkBnR9p-Ed-ak6NoX_4Aeg_-377386801")]
    [Description(@"Settlement date or transfer date does not match.")]
    SettlementDate = TransferUnmatchedReasonCode.SettlementDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial instrument quantity does not match.
    /// Encoded/decoded by serializers as "DQUA".
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_VkBnSNp-Ed-ak6NoX_4Aeg_-1926778684")]
    [Description(@"Financial instrument quantity does not match.")]
    FinancialInstrumentQuantity = TransferUnmatchedReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Another unmatched reason.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VkBnSdp-Ed-ak6NoX_4Aeg_-871193861")]
    [Description(@"Another unmatched reason.")]
    Other = TransferUnmatchedReasonCode.Other, // same ordinal as derivation source for type conversions
    
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


