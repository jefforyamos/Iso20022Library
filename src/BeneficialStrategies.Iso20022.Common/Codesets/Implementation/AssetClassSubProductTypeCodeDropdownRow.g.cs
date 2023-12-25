﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AssetClassSubProductTypeCode.  ISO2002 ID# _KADecc49EeSc85GUbgBycw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the sub-product types for specific asset classes.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AssetClassSubProductTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IAssetClassSubProductTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_KADecc49EeSc85GUbgBycw")]
public partial class AssetClassSubProductTypeCodeDropdownRow : EnumMetadataItem<AssetClassSubProductTypeCode>, IAssetClassSubProductTypeCodeDropdownRow
{
    /// <summary>
    /// Defines the sub-product types for specific asset classes.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AssetClassSubProductTypeCodeDropdownRow(AssetClassSubProductTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
