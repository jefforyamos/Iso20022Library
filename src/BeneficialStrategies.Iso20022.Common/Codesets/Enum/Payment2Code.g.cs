﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Payment2Code.  ISO2002 ID# _-qqGELXOEeiTob_PrFFUxA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-qqGELXOEeiTob_PrFFUxA")]
[Description(@"Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.")]
[DerivedFrom(typeof(PaymentCode))]
public enum Payment2Code
{
    /// <summary>
    /// The cash payment occurs or will occur upon receipt of proceeds from the issuer.
    /// Encoded/decoded by serializers as "ACTU".
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_KIs2sbXPEeiTob_PrFFUxA")]
    [Description(@"The cash payment occurs or will occur upon receipt of proceeds from the issuer.")]
    ActualPayment = PaymentCode.ActualPayment, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Payment2CodeMetadataExtensions
{
    private static readonly Payment2CodeDropdownSource _dropdownSource = new Payment2CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPayment2CodeDropdownRow GetMetadata(this Payment2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


