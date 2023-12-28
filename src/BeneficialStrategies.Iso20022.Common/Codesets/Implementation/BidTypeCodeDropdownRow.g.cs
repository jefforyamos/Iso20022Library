﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BidTypeCode.  ISO2002 ID# _begosNp-Ed-ak6NoX_4Aeg_451517447.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code to identify the type of bid request.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BidTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IBidTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_begosNp-Ed-ak6NoX_4Aeg_451517447")]
public partial class BidTypeCodeDropdownRow : EnumMetadataItem<BidTypeCode>, IBidTypeCodeDropdownRow
{
    /// <summary>
    /// Code to identify the type of bid request.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BidTypeCodeDropdownRow(BidTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}