﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RepurchaseType7Code.  ISO2002 ID# __vrhg9ojEeC60axPepSq7g_1563954315.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of repurchase transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RepurchaseType7CodeDropdownSource"/>.
/// Implements <seealso cref="IRepurchaseType7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__vrhg9ojEeC60axPepSq7g_1563954315")]
public partial class RepurchaseType7CodeDropdownRow : EnumMetadataItem<RepurchaseType7Code>, IRepurchaseType7CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of repurchase transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RepurchaseType7CodeDropdownRow(RepurchaseType7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
