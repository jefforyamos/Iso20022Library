﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalTradeTransactionCondition1Code.  ISO2002 ID# __2iXdNojEeC60axPepSq7g_398197023.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external Trade Transaction Condition code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalTradeTransactionCondition1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalTradeTransactionCondition1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__2iXdNojEeC60axPepSq7g_398197023")]
public partial class ExternalTradeTransactionCondition1CodeDropdownRow : EnumMetadataItem<ExternalTradeTransactionCondition1Code>, IExternalTradeTransactionCondition1CodeDropdownRow
{
    /// <summary>
    /// Specifies the external Trade Transaction Condition code in the format of character string with a maximum length of 4 characters.
    /// The list of valid codes is an external code list published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalTradeTransactionCondition1CodeDropdownRow(ExternalTradeTransactionCondition1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
