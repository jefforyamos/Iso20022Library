﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalReceivedReason1Code.  ISO2002 ID# _BRBXUFjsEeOnqqBHs8Gasw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for a received status.|
/// The list of valid codes is an external code list published separately. 
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalReceivedReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalReceivedReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_BRBXUFjsEeOnqqBHs8Gasw")]
public partial class ExternalReceivedReason1CodeDropdownRow : EnumMetadataItem<ExternalReceivedReason1Code>, IExternalReceivedReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for a received status.|
    /// The list of valid codes is an external code list published separately. 
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalReceivedReason1CodeDropdownRow(ExternalReceivedReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
