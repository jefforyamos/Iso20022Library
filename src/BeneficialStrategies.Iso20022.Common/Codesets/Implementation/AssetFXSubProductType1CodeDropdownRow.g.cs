﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AssetFXSubProductType1Code.  ISO2002 ID# _IWuWENDjEeSv_Pll20DdbA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the allowed foreign exchange types for foreign exchange derivatives.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AssetFXSubProductType1CodeDropdownSource"/>.
/// Implements <seealso cref="IAssetFXSubProductType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_IWuWENDjEeSv_Pll20DdbA")]
public partial class AssetFXSubProductType1CodeDropdownRow : EnumMetadataItem<AssetFXSubProductType1Code>, IAssetFXSubProductType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the allowed foreign exchange types for foreign exchange derivatives.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AssetFXSubProductType1CodeDropdownRow(AssetFXSubProductType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
