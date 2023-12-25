﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FractionDispositionTypeCode.  ISO2002 ID# _arsrs9p-Ed-ak6NoX_4Aeg_1799265079.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates that fractional value should be retained; no rounding.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FractionDispositionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IFractionDispositionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_arsrs9p-Ed-ak6NoX_4Aeg_1799265079")]
public partial class FractionDispositionTypeCodeDropdownRow : EnumMetadataItem<FractionDispositionTypeCode>, IFractionDispositionTypeCodeDropdownRow
{
    /// <summary>
    /// Indicates that fractional value should be retained; no rounding.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FractionDispositionTypeCodeDropdownRow(FractionDispositionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
