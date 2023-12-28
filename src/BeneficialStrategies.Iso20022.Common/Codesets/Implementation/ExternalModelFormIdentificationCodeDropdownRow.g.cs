﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalModelFormIdentificationCode.  ISO2002 ID# _-MOeFW7iEeKo25nLKvGr8w_769706628.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external model form identification code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalModelFormIdentificationCodeDropdownSource"/>.
/// Implements <seealso cref="IExternalModelFormIdentificationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-MOeFW7iEeKo25nLKvGr8w_769706628")]
public partial class ExternalModelFormIdentificationCodeDropdownRow : EnumMetadataItem<ExternalModelFormIdentificationCode>, IExternalModelFormIdentificationCodeDropdownRow
{
    /// <summary>
    /// Specifies the external model form identification code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalModelFormIdentificationCodeDropdownRow(ExternalModelFormIdentificationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}