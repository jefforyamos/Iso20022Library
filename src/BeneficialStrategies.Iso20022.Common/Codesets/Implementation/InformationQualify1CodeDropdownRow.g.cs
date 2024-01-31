﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InformationQualify1Code.  ISO2002 ID# _FbE-INwoEeioifFt1dhnJA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Qualification of the information to sent to an output logical device, to display or print to the Cashier or the Customer.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InformationQualify1CodeDropdownSource"/>.
/// Implements <seealso cref="IInformationQualify1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_FbE-INwoEeioifFt1dhnJA")]
public partial class InformationQualify1CodeDropdownRow : EnumMetadataItem<InformationQualify1Code>, IInformationQualify1CodeDropdownRow
{
    /// <summary>
    /// Qualification of the information to sent to an output logical device, to display or print to the Cashier or the Customer.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InformationQualify1CodeDropdownRow(InformationQualify1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
