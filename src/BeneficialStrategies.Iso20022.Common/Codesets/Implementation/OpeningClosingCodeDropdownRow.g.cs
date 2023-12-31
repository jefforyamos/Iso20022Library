﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OpeningClosingCode.  ISO2002 ID# _aO8eQNp-Ed-ak6NoX_4Aeg_492685359.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies additional information relative to the processing of the trade.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OpeningClosingCodeDropdownSource"/>.
/// Implements <seealso cref="IOpeningClosingCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aO8eQNp-Ed-ak6NoX_4Aeg_492685359")]
public partial class OpeningClosingCodeDropdownRow : EnumMetadataItem<OpeningClosingCode>, IOpeningClosingCodeDropdownRow
{
    /// <summary>
    /// Specifies additional information relative to the processing of the trade.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OpeningClosingCodeDropdownRow(OpeningClosingCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
