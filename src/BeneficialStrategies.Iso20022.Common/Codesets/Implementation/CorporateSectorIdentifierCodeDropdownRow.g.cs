﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CorporateSectorIdentifierCode.  ISO2002 ID# _PDxzgVBPEeOenoknK_-H2g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the corporate sector of the counterparty for reporting to trade repositories.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CorporateSectorIdentifierCodeDropdownSource"/>.
/// Implements <seealso cref="ICorporateSectorIdentifierCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_PDxzgVBPEeOenoknK_-H2g")]
public partial class CorporateSectorIdentifierCodeDropdownRow : EnumMetadataItem<CorporateSectorIdentifierCode>, ICorporateSectorIdentifierCodeDropdownRow
{
    /// <summary>
    /// Identifies the corporate sector of the counterparty for reporting to trade repositories.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CorporateSectorIdentifierCodeDropdownRow(CorporateSectorIdentifierCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}