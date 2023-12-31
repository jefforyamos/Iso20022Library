﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalChargeType1Code.  ISO2002 ID# _t9qdIFkyEeGeoaLUQk__nA_-849686320.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature, or use, of the charges in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalChargeType1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalChargeType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_t9qdIFkyEeGeoaLUQk__nA_-849686320")]
public partial class ExternalChargeType1CodeDropdownRow : EnumMetadataItem<ExternalChargeType1Code>, IExternalChargeType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the nature, or use, of the charges in the format of character string with a maximum length of 4 characters.
    /// The list of valid codes is an external code list published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalChargeType1CodeDropdownRow(ExternalChargeType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
