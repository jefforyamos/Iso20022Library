﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReorganisationWithdrawalTransactionTypeCode.  ISO2002 ID# _FkyZgMYzEeesocHIuVGr7g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of withdrawal reorganisation transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FkyZgMYzEeesocHIuVGr7g")]
[Description(@"Specifies the type of withdrawal reorganisation transaction.")]
public enum ReorganisationWithdrawalTransactionTypeCode
{
    /// <summary>
    /// The reorganisation instruction cancellation is a protect withdrawal transaction.
    /// </summary>
    [EnumMember(Value = "PROW")]
    [IsoId("_P7H7MMYzEeesocHIuVGr7g")]
    [Description(@"The reorganisation instruction cancellation is a protect withdrawal transaction.")]
    PROW,
    
    /// <summary>
    /// The reorganisation instruction cancellation is a withdrawal protect transaction on behalf of another participant.
    /// </summary>
    [EnumMember(Value = "PRPW")]
    [IsoId("_yM7-kMYzEeesocHIuVGr7g")]
    [Description(@"The reorganisation instruction cancellation is a withdrawal protect transaction on behalf of another participant.")]
    PRPW,
    
    /// <summary>
    /// The reorganisation instruction cancellation is a voluntary offer instruction withdrawal transaction.
    /// </summary>
    [EnumMember(Value = "VOIW")]
    [IsoId("_D0o1EMY0EeesocHIuVGr7g")]
    [Description(@"The reorganisation instruction cancellation is a voluntary offer instruction withdrawal transaction.")]
    VOIW,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReorganisationWithdrawalTransactionTypeCodeMetadataExtensions
{
    private static readonly ReorganisationWithdrawalTransactionTypeCodeDropdownSource _dropdownSource = new ReorganisationWithdrawalTransactionTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReorganisationWithdrawalTransactionTypeCodeDropdownRow GetMetadata(this ReorganisationWithdrawalTransactionTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


