﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalUnitOfMeasure1Code.  ISO2002 ID# _nN1oMDNmEe2UWZuK9pqFtg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external unit of measure by means of a code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalUnitOfMeasure1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalUnitOfMeasure1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nN1oMDNmEe2UWZuK9pqFtg")]
public partial class ExternalUnitOfMeasure1CodeDropdownRow : EnumMetadataItem<ExternalUnitOfMeasure1Code>, IExternalUnitOfMeasure1CodeDropdownRow
{
    /// <summary>
    /// Specifies the external unit of measure by means of a code in the format of character string with a maximum length of 4 characters.
    /// The list of valid codes is an external code list published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalUnitOfMeasure1CodeDropdownRow(ExternalUnitOfMeasure1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
