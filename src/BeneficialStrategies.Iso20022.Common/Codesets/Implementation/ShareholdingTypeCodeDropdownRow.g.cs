﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ShareholdingTypeCode.  ISO2002 ID# _oLAXQD6IEemPvNTzinB5Vw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of shareholding.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ShareholdingTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IShareholdingTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_oLAXQD6IEemPvNTzinB5Vw")]
public partial class ShareholdingTypeCodeDropdownRow : EnumMetadataItem<ShareholdingTypeCode>, IShareholdingTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of shareholding.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ShareholdingTypeCodeDropdownRow(ShareholdingTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
