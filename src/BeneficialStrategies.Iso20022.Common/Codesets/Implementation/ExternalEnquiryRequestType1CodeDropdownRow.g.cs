﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExternalEnquiryRequestType1Code.  ISO2002 ID# _I3nyYJIhEeect698_YsnIA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external request type code for the enquiry on a position in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExternalEnquiryRequestType1CodeDropdownSource"/>.
/// Implements <seealso cref="IExternalEnquiryRequestType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_I3nyYJIhEeect698_YsnIA")]
public partial class ExternalEnquiryRequestType1CodeDropdownRow : EnumMetadataItem<ExternalEnquiryRequestType1Code>, IExternalEnquiryRequestType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the external request type code for the enquiry on a position in the format of character string with a maximum length of 4 characters.
    /// The list of valid codes is an external code set published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExternalEnquiryRequestType1CodeDropdownRow(ExternalEnquiryRequestType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
