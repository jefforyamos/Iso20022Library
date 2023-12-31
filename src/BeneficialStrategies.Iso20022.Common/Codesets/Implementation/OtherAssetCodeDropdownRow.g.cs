﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OtherAssetCode.  ISO2002 ID# _deqTgEyMEeiepssxrmRw1A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of asset.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OtherAssetCodeDropdownSource"/>.
/// Implements <seealso cref="IOtherAssetCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_deqTgEyMEeiepssxrmRw1A")]
public partial class OtherAssetCodeDropdownRow : EnumMetadataItem<OtherAssetCode>, IOtherAssetCodeDropdownRow
{
    /// <summary>
    /// Specifies a type of asset.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OtherAssetCodeDropdownRow(OtherAssetCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
