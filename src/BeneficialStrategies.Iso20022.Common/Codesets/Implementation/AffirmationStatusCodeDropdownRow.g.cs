﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AffirmationStatusCode.  ISO2002 ID# _bndJUtp-Ed-ak6NoX_4Aeg_693549629.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the affirmation status of a trade.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AffirmationStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IAffirmationStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bndJUtp-Ed-ak6NoX_4Aeg_693549629")]
public partial class AffirmationStatusCodeDropdownRow : EnumMetadataItem<AffirmationStatusCode>, IAffirmationStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the affirmation status of a trade.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AffirmationStatusCodeDropdownRow(AffirmationStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
