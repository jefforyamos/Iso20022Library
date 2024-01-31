﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for InvestorProfileStatus1Code.  ISO2002 ID# _t6X6sCDREeWCLu74WLgP4w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the investor profile.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="InvestorProfileStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IInvestorProfileStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_t6X6sCDREeWCLu74WLgP4w")]
public partial class InvestorProfileStatus1CodeDropdownRow : EnumMetadataItem<InvestorProfileStatus1Code>, IInvestorProfileStatus1CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of the investor profile.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public InvestorProfileStatus1CodeDropdownRow(InvestorProfileStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
