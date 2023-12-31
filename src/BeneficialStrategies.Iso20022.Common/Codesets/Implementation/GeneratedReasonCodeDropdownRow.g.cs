﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for GeneratedReasonCode.  ISO2002 ID# _auFRVdp-Ed-ak6NoX_4Aeg_-239668022.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the transaction was generated.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="GeneratedReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IGeneratedReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_auFRVdp-Ed-ak6NoX_4Aeg_-239668022")]
public partial class GeneratedReasonCodeDropdownRow : EnumMetadataItem<GeneratedReasonCode>, IGeneratedReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the transaction was generated.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public GeneratedReasonCodeDropdownRow(GeneratedReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
