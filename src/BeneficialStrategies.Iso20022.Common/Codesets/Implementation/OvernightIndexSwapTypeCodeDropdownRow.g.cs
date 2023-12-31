﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OvernightIndexSwapTypeCode.  ISO2002 ID# _yb-YIbu8EeSXxOgurgHGgw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of overnight index swap transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OvernightIndexSwapTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IOvernightIndexSwapTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_yb-YIbu8EeSXxOgurgHGgw")]
public partial class OvernightIndexSwapTypeCodeDropdownRow : EnumMetadataItem<OvernightIndexSwapTypeCode>, IOvernightIndexSwapTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of overnight index swap transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OvernightIndexSwapTypeCodeDropdownRow(OvernightIndexSwapTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
