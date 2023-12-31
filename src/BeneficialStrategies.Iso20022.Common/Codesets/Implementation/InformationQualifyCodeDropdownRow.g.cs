﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InformationQualifyCode.  ISO2002 ID# _2pcDINuVEeiB5uLfkg9ZJA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Qualification of the information to sent to an output logical device, to display or print to the Cashier or the Customer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InformationQualifyCodeDropdownSource"/>.
/// Implements <seealso cref="IInformationQualifyCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2pcDINuVEeiB5uLfkg9ZJA")]
public partial class InformationQualifyCodeDropdownRow : EnumMetadataItem<InformationQualifyCode>, IInformationQualifyCodeDropdownRow
{
    /// <summary>
    /// Qualification of the information to sent to an output logical device, to display or print to the Cashier or the Customer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InformationQualifyCodeDropdownRow(InformationQualifyCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
