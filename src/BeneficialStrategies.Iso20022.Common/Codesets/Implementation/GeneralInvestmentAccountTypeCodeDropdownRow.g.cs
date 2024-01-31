﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for GeneralInvestmentAccountTypeCode.  ISO2002 ID# _pXBs0F2cEeiFXdiLi_Nf4A.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of investment account.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="GeneralInvestmentAccountTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IGeneralInvestmentAccountTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pXBs0F2cEeiFXdiLi_Nf4A")]
public partial class GeneralInvestmentAccountTypeCodeDropdownRow : EnumMetadataItem<GeneralInvestmentAccountTypeCode>, IGeneralInvestmentAccountTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies a type of investment account.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public GeneralInvestmentAccountTypeCodeDropdownRow(GeneralInvestmentAccountTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
