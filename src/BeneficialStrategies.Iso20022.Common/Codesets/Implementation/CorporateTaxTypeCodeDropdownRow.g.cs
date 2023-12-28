﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CorporateTaxTypeCode.  ISO2002 ID# _tIBiYP4zEeix6ug6HlF6IQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the corporate tax identification type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CorporateTaxTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ICorporateTaxTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_tIBiYP4zEeix6ug6HlF6IQ")]
public partial class CorporateTaxTypeCodeDropdownRow : EnumMetadataItem<CorporateTaxTypeCode>, ICorporateTaxTypeCodeDropdownRow
{
    /// <summary>
    /// Indicates the corporate tax identification type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CorporateTaxTypeCodeDropdownRow(CorporateTaxTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}