﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesTransactionType11Code.  ISO2002 ID# _ha_UsWliEeGaMcKyqKNRfQ_-489593390.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies underlying information regarding the type of settlement transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ha_UsWliEeGaMcKyqKNRfQ_-489593390")]
[Description(@"Specifies underlying information regarding the type of settlement transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeCode))]
public enum SecuritiesTransactionType11Code
{
    /// <summary>
    /// Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.
    /// Encoded/decoded by serializers as "NonSyndicated".
    /// </summary>
    [EnumMember(Value = "NSYN")]
    [IsoId("_ha_UsmliEeGaMcKyqKNRfQ_-1686330340")]
    [Description(@"Relates to the issue of medium and short term paper (CP, CD, MTN, notes.) under a program and without syndication arrangement.")]
    NonSyndicated,
    
    /// <summary>
    /// Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.
    /// Encoded/decoded by serializers as "SyndicateUnderwriters".
    /// </summary>
    [EnumMember(Value = "SYND")]
    [IsoId("_ha_Us2liEeGaMcKyqKNRfQ_835025507")]
    [Description(@"Relates to the issue of financial instruments through a syndicate of underwriters and a lead manager.")]
    SyndicateUnderwriters,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesTransactionType11CodeMetadataExtensions
{
    private static readonly SecuritiesTransactionType11CodeDropdownSource _dropdownSource = new SecuritiesTransactionType11CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesTransactionType11CodeDropdownRow GetMetadata(this SecuritiesTransactionType11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


