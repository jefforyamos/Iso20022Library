﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TaxWithholdingMethod2Code.  ISO2002 ID# _fjSuABKtEeKj15WxqwlXPw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the method by which the tax on the interests is to be processed i.e. either withheld at source or reported to tax authorities or a tax certificate has been provided by the beneficiary.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TaxWithholdingMethod2CodeDropdownSource"/>.
/// Implements <seealso cref="ITaxWithholdingMethod2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_fjSuABKtEeKj15WxqwlXPw")]
public partial class TaxWithholdingMethod2CodeDropdownRow : EnumMetadataItem<TaxWithholdingMethod2Code>, ITaxWithholdingMethod2CodeDropdownRow
{
    /// <summary>
    /// Specifies the method by which the tax on the interests is to be processed i.e. either withheld at source or reported to tax authorities or a tax certificate has been provided by the beneficiary.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TaxWithholdingMethod2CodeDropdownRow(TaxWithholdingMethod2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}