﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CashAssetTypeCode.  ISO2002 ID# _gdIMkEyIEeir2sRRVd9XhA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a source of the cash asset.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CashAssetTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ICashAssetTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_gdIMkEyIEeir2sRRVd9XhA")]
public partial class CashAssetTypeCodeDropdownRow : EnumMetadataItem<CashAssetTypeCode>, ICashAssetTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies a source of the cash asset.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CashAssetTypeCodeDropdownRow(CashAssetTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
