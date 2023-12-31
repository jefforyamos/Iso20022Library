﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalNarrativeType1Code.  ISO2002 ID# _-MYPEG7iEeKo25nLKvGr8w_2503812.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external narrative type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalNarrativeType1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalNarrativeType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-MYPEG7iEeKo25nLKvGr8w_2503812")]
public partial class ExternalNarrativeType1CodeDropdownRow : EnumMetadataItem<ExternalNarrativeType1Code>, IExternalNarrativeType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the external narrative type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalNarrativeType1CodeDropdownRow(ExternalNarrativeType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
