﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PriceStatus1Code.  ISO2002 ID# _NtDrcOzYEeSBf_ghFpb9rQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the price of a financial instrument.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PriceStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IPriceStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NtDrcOzYEeSBf_ghFpb9rQ")]
public partial class PriceStatus1CodeDropdownRow : EnumMetadataItem<PriceStatus1Code>, IPriceStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of the price of a financial instrument.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PriceStatus1CodeDropdownRow(PriceStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
