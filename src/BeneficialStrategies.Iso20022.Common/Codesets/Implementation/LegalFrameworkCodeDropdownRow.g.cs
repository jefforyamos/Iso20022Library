﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LegalFrameworkCode.  ISO2002 ID# _ad115dp-Ed-ak6NoX_4Aeg_-859807356.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the legal framework of the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LegalFrameworkCodeDropdownSource"/>.
/// Implements <seealso cref="ILegalFrameworkCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ad115dp-Ed-ak6NoX_4Aeg_-859807356")]
public partial class LegalFrameworkCodeDropdownRow : EnumMetadataItem<LegalFrameworkCode>, ILegalFrameworkCodeDropdownRow
{
    /// <summary>
    /// Identifies the legal framework of the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LegalFrameworkCodeDropdownRow(LegalFrameworkCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}