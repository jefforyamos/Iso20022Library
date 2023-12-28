﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ElectionType1Code.  ISO2002 ID# _ag-CZ9p-Ed-ak6NoX_4Aeg_-1602987297.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of election.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ElectionType1CodeDropdownSource"/>.
/// Implements <seealso cref="IElectionType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ag-CZ9p-Ed-ak6NoX_4Aeg_-1602987297")]
public partial class ElectionType1CodeDropdownRow : EnumMetadataItem<ElectionType1Code>, IElectionType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of election.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ElectionType1CodeDropdownRow(ElectionType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}