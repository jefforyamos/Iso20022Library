﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalRejectedReason1Code.  ISO2002 ID# _cgC6IFj8EeOgwYxfAV02bg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a rejected status
/// The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalRejectedReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalRejectedReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_cgC6IFj8EeOgwYxfAV02bg")]
public partial class ExternalRejectedReason1CodeDropdownRow : EnumMetadataItem<ExternalRejectedReason1Code>, IExternalRejectedReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for a rejected status
    /// The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalRejectedReason1CodeDropdownRow(ExternalRejectedReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
