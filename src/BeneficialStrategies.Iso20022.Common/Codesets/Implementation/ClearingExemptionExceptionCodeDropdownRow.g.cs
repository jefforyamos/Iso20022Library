﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ClearingExemptionExceptionCode.  ISO2002 ID# _vMoZsIJTEeuDe9SyRl5qeg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the list of codes applicable to the clearing exemptions or exceptions.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ClearingExemptionExceptionCodeDropdownSource"/>.
/// Implements <seealso cref="IClearingExemptionExceptionCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_vMoZsIJTEeuDe9SyRl5qeg")]
public partial class ClearingExemptionExceptionCodeDropdownRow : EnumMetadataItem<ClearingExemptionExceptionCode>, IClearingExemptionExceptionCodeDropdownRow
{
    /// <summary>
    /// Specifies the list of codes applicable to the clearing exemptions or exceptions.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ClearingExemptionExceptionCodeDropdownRow(ClearingExemptionExceptionCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}