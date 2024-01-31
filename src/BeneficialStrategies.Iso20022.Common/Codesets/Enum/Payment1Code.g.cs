﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Payment1Code.  ISO2002 ID# _Zy7Qptp-Ed-ak6NoX_4Aeg_1133077707.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zy7Qptp-Ed-ak6NoX_4Aeg_1133077707")]
[Description(@"Specifies the type of payment.")]
[DerivedFrom(typeof(PaymentCode))]
public enum Payment1Code
{
    /// <summary>
    /// The cash payment occurs or will occur upon receipt of proceeds from the issuer.
    /// Encoded/decoded by serializers as "ACTU".
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_Zy7Qp9p-Ed-ak6NoX_4Aeg_1133077747")]
    [Description(@"The cash payment occurs or will occur upon receipt of proceeds from the issuer.")]
    ActualPayment = PaymentCode.ActualPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer.
    /// Encoded/decoded by serializers as "CONT".
    /// </summary>
    [EnumMember(Value = "CONT")]
    [IsoId("_Zy7QqNp-Ed-ak6NoX_4Aeg_1133077769")]
    [Description(@"The cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer.")]
    ContractualPayment = PaymentCode.ContractualPayment, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Payment1CodeMetadataExtensions
{
    private static readonly Payment1CodeDropdownSource _dropdownSource = new Payment1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPayment1CodeDropdownRow GetMetadata(this Payment1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


