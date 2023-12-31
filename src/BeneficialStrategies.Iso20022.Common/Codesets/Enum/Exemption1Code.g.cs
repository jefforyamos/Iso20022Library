﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Exemption1Code.  ISO2002 ID# _JK8y8Ax1Eeqdx6buGpCCQw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Strong customer authentication exemption.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JK8y8Ax1Eeqdx6buGpCCQw")]
[Description(@"Strong customer authentication exemption.")]
[DerivedFrom(typeof(ExemptionCode))]
public enum Exemption1Code
{
    /// <summary>
    /// Transaction's amount is low and could be processed without strong customer authentication.
    /// Encoded/decoded by serializers as "LowAmountExemption".
    /// </summary>
    [EnumMember(Value = "LOWA")]
    [IsoId("_PN0UUQx1Eeqdx6buGpCCQw")]
    [Description(@"Transaction's amount is low and could be processed without strong customer authentication.")]
    LowAmountExemption,
    
    /// <summary>
    /// Transaction is initiated by the Card Acceptor.
    /// Encoded/decoded by serializers as "MerchantInitiatedTransaction".
    /// </summary>
    [EnumMember(Value = "MINT")]
    [IsoId("_PR5jEQx1Eeqdx6buGpCCQw")]
    [Description(@"Transaction is initiated by the Card Acceptor.")]
    MerchantInitiatedTransaction,
    
    /// <summary>
    /// Transaction is one of a series of recurring payment.
    /// Encoded/decoded by serializers as "RecurringPayment".
    /// </summary>
    [EnumMember(Value = "RECP")]
    [IsoId("_PV2O8Qx1Eeqdx6buGpCCQw")]
    [Description(@"Transaction is one of a series of recurring payment.")]
    RecurringPayment,
    
    /// <summary>
    /// Transaction is a secure corporate payment.
    /// Encoded/decoded by serializers as "SecureCorporatePaymentExemption".
    /// </summary>
    [EnumMember(Value = "SCPE")]
    [IsoId("_PZupYQx1Eeqdx6buGpCCQw")]
    [Description(@"Transaction is a secure corporate payment.")]
    SecureCorporatePaymentExemption,
    
    /// <summary>
    /// Card Acceptor is a strong customer authentication delegate.
    /// Encoded/decoded by serializers as "StrongCustomerAuthenticationDelegation".
    /// </summary>
    [EnumMember(Value = "SCAD")]
    [IsoId("_PdoR8Qx1Eeqdx6buGpCCQw")]
    [Description(@"Card Acceptor is a strong customer authentication delegate.")]
    StrongCustomerAuthenticationDelegation,
    
    /// <summary>
    /// According to the transaction risk analysis the strong customer authentication is not mandated.
    /// Encoded/decoded by serializers as "TransactionRiskAnalysisExemption".
    /// </summary>
    [EnumMember(Value = "TRAE")]
    [IsoId("_PhGcsQx1Eeqdx6buGpCCQw")]
    [Description(@"According to the transaction risk analysis the strong customer authentication is not mandated.")]
    TransactionRiskAnalysisExemption,
    
    /// <summary>
    /// Payment is processed in a environment where strong customer authentication is inappropriate.
    /// Encoded/decoded by serializers as "TransportFareOrParkingFeeUnattendedPaymentExemption".
    /// </summary>
    [EnumMember(Value = "PKGE")]
    [IsoId("_Pkpf8Qx1Eeqdx6buGpCCQw")]
    [Description(@"Payment is processed in a environment where strong customer authentication is inappropriate.")]
    TransportFareOrParkingFeeUnattendedPaymentExemption,
    
    /// <summary>
    /// Cardholder has enrolled the Card Acceptor in the exemption list of strong customer authentication.
    /// Encoded/decoded by serializers as "TrustedMerchantBeneficiaryExemption".
    /// </summary>
    [EnumMember(Value = "TMBE")]
    [IsoId("_PolkwQx1Eeqdx6buGpCCQw")]
    [Description(@"Cardholder has enrolled the Card Acceptor in the exemption list of strong customer authentication.")]
    TrustedMerchantBeneficiaryExemption,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Exemption1CodeMetadataExtensions
{
    private static readonly Exemption1CodeDropdownSource _dropdownSource = new Exemption1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExemption1CodeDropdownRow GetMetadata(this Exemption1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


