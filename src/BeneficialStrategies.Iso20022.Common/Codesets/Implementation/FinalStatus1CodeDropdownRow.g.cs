﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FinalStatus1Code.  ISO2002 ID# _8PRUJKMgEeCJ6YNENx4h-w_881009565.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the final status of a transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FinalStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IFinalStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8PRUJKMgEeCJ6YNENx4h-w_881009565")]
public partial class FinalStatus1CodeDropdownRow : EnumMetadataItem<FinalStatus1Code>, IFinalStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the final status of a transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FinalStatus1CodeDropdownRow(FinalStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}