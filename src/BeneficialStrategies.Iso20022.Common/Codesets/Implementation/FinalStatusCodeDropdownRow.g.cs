﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FinalStatusCode.  ISO2002 ID# _an04VNp-Ed-ak6NoX_4Aeg_-1727527994.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the final status of a transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FinalStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IFinalStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_an04VNp-Ed-ak6NoX_4Aeg_-1727527994")]
public partial class FinalStatusCodeDropdownRow : EnumMetadataItem<FinalStatusCode>, IFinalStatusCodeDropdownRow
{
    /// <summary>
    /// Specifies the final status of a transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FinalStatusCodeDropdownRow(FinalStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
