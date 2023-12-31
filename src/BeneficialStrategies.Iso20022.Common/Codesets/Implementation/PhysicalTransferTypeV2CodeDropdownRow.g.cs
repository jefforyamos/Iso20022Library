﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PhysicalTransferTypeV2Code.  ISO2002 ID# _jiYPJYBAEeall68-KLgmUw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the financial instrument is to be physically delivered or is a dematerilized transfer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PhysicalTransferTypeV2CodeDropdownSource"/>.
/// Implements <seealso cref="IPhysicalTransferTypeV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_jiYPJYBAEeall68-KLgmUw")]
public partial class PhysicalTransferTypeV2CodeDropdownRow : EnumMetadataItem<PhysicalTransferTypeV2Code>, IPhysicalTransferTypeV2CodeDropdownRow
{
    /// <summary>
    /// Specifies whether the financial instrument is to be physically delivered or is a dematerilized transfer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PhysicalTransferTypeV2CodeDropdownRow(PhysicalTransferTypeV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
