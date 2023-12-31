﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalChargeTypeCode.  ISO2002 ID# __92AcJF_EeeBGrZP1w0opg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature, or use, of the charges in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalChargeTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalChargeTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__92AcJF_EeeBGrZP1w0opg")]
public partial class ExternalChargeTypeCodeDropdownRow : EnumMetadataItem<ExternalChargeTypeCode>, IExternalChargeTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the nature, or use, of the charges in the format of character string with a maximum length of 4 characters.
    /// The list of valid codes is an external code set published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalChargeTypeCodeDropdownRow(ExternalChargeTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
