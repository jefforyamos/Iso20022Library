﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalCashAccountType1Code.  ISO2002 ID# _t7bogVkyEeGeoaLUQk__nA_-2034002224.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature, or use, of the cash account in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalCashAccountType1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalCashAccountType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_t7bogVkyEeGeoaLUQk__nA_-2034002224")]
public partial class ExternalCashAccountType1CodeDropdownRow : EnumMetadataItem<ExternalCashAccountType1Code>, IExternalCashAccountType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the nature, or use, of the cash account in the format of character string with a maximum length of 4 characters.
    /// The list of valid codes is an external code list published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalCashAccountType1CodeDropdownRow(ExternalCashAccountType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
