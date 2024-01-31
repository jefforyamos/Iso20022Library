﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ProtectTransactionType3Code.  ISO2002 ID# _Hq0xkLpaEeilsanBGAzy4A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of protect instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ProtectTransactionType3CodeDropdownSource"/>.
/// Implements <seealso cref="IProtectTransactionType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Hq0xkLpaEeilsanBGAzy4A")]
public partial class ProtectTransactionType3CodeDropdownRow : EnumMetadataItem<ProtectTransactionType3Code>, IProtectTransactionType3CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of protect instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ProtectTransactionType3CodeDropdownRow(ProtectTransactionType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
