﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for NewSecuritiesIssuanceTypeCode.  ISO2002 ID# _WghhgBHzEeKKuerhIbkpig.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of securities proceeds; whether they are newly issued or not, defeased or non-defeased.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="NewSecuritiesIssuanceTypeCodeDropdownSource"/>.
/// Implements <seealso cref="INewSecuritiesIssuanceTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_WghhgBHzEeKKuerhIbkpig")]
public partial class NewSecuritiesIssuanceTypeCodeDropdownRow : EnumMetadataItem<NewSecuritiesIssuanceTypeCode>, INewSecuritiesIssuanceTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of securities proceeds; whether they are newly issued or not, defeased or non-defeased.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public NewSecuritiesIssuanceTypeCodeDropdownRow(NewSecuritiesIssuanceTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
