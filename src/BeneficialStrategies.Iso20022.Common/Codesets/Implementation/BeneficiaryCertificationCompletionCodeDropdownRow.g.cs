﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BeneficiaryCertificationCompletionCode.  ISO2002 ID# _bdn359p-Ed-ak6NoX_4Aeg_-1583381957.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of certification completion required for a beneficiary.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BeneficiaryCertificationCompletionCodeDropdownSource"/>.
/// Implements <seealso cref="IBeneficiaryCertificationCompletionCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bdn359p-Ed-ak6NoX_4Aeg_-1583381957")]
public partial class BeneficiaryCertificationCompletionCodeDropdownRow : EnumMetadataItem<BeneficiaryCertificationCompletionCode>, IBeneficiaryCertificationCompletionCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of certification completion required for a beneficiary.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BeneficiaryCertificationCompletionCodeDropdownRow(BeneficiaryCertificationCompletionCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
