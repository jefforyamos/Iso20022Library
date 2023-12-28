﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalBalanceSubType1Code.  ISO2002 ID# _amL5k9p-Ed-ak6NoX_4Aeg_-1218783633.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the balance sub-type, as published in an external balance sub-type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalBalanceSubType1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalBalanceSubType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_amL5k9p-Ed-ak6NoX_4Aeg_-1218783633")]
public partial class ExternalBalanceSubType1CodeDropdownRow : EnumMetadataItem<ExternalBalanceSubType1Code>, IExternalBalanceSubType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the balance sub-type, as published in an external balance sub-type code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalBalanceSubType1CodeDropdownRow(ExternalBalanceSubType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}