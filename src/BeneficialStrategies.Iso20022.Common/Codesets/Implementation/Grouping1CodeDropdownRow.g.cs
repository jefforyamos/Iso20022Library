﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Grouping1Code.  ISO2002 ID# _auruSNp-Ed-ak6NoX_4Aeg_-1275607506.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the grouping options of the payment transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Grouping1CodeDropdownSource"/>.
/// Implements <seealso cref="IGrouping1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_auruSNp-Ed-ak6NoX_4Aeg_-1275607506")]
public partial class Grouping1CodeDropdownRow : EnumMetadataItem<Grouping1Code>, IGrouping1CodeDropdownRow
{
    /// <summary>
    /// Specifies the grouping options of the payment transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Grouping1CodeDropdownRow(Grouping1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
