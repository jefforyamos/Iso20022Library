﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalProxyAccountType1Code.  ISO2002 ID# _ioPgonh3EeidzqjNEfehPg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external proxy account type code, as published in the proxy account type external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalProxyAccountType1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalProxyAccountType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ioPgonh3EeidzqjNEfehPg")]
public partial class ExternalProxyAccountType1CodeDropdownRow : EnumMetadataItem<ExternalProxyAccountType1Code>, IExternalProxyAccountType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the external proxy account type code, as published in the proxy account type external code set.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalProxyAccountType1CodeDropdownRow(ExternalProxyAccountType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
