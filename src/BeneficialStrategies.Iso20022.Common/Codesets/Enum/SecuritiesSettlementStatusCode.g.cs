﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesSettlementStatusCode.  ISO2002 ID# _ZFx2yNp-Ed-ak6NoX_4Aeg_1133514272.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the status of settlement of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFx2yNp-Ed-ak6NoX_4Aeg_1133514272")]
[Description(@"Provides the status of settlement of an instruction.")]
public enum SecuritiesSettlementStatusCode
{
    /// <summary>
    /// Instruction is pending. Settlement at the instructed settlement date is still possible.
    /// Encoded/decoded by serializers as "PEND".
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZF7AsNp-Ed-ak6NoX_4Aeg_1416111561")]
    [Description(@"Instruction is pending. Settlement at the instructed settlement date is still possible.")]
    Pending,
    
    /// <summary>
    /// Instruction is failing. Settlement at the instructed settlement date is no longer possible.
    /// Encoded/decoded by serializers as "PENF".
    /// </summary>
    [EnumMember(Value = "PENF")]
    [IsoId("_ZF7Asdp-Ed-ak6NoX_4Aeg_1446590809")]
    [Description(@"Instruction is failing. Settlement at the instructed settlement date is no longer possible.")]
    Failing,
    
    /// <summary>
    /// Instruction is unsettled.
    /// Encoded/decoded by serializers as "USET".
    /// </summary>
    [EnumMember(Value = "USET")]
    [IsoId("_mmp9WUABEeCaq78Ig8ATcA")]
    [Description(@"Instruction is unsettled.")]
    Unsettled,
    
    /// <summary>
    /// Part of the instruction remains unsettled.
    /// Encoded/decoded by serializers as "PAIN".
    /// </summary>
    [EnumMember(Value = "PAIN")]
    [IsoId("_OBoIWUABEeCaq78Ig8ATcA")]
    [Description(@"Part of the instruction remains unsettled.")]
    PartialSettlement,
    
    /// <summary>
    /// Full settlement.
    /// Encoded/decoded by serializers as "SETT".
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_iYMY0UABEeCaq78Ig8ATcA")]
    [Description(@"Full settlement.")]
    Settled,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesSettlementStatusCodeMetadataExtensions
{
    private static readonly SecuritiesSettlementStatusCodeDropdownSource _dropdownSource = new SecuritiesSettlementStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesSettlementStatusCodeDropdownRow GetMetadata(this SecuritiesSettlementStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

