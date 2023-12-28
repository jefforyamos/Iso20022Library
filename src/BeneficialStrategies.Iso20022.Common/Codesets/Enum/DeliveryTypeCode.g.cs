﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeliveryTypeCode.  ISO2002 ID# _azv0c9p-Ed-ak6NoX_4Aeg_-799855242.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes the delivery or custody arrangement for the underlying securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_azv0c9p-Ed-ak6NoX_4Aeg_-799855242")]
[Description(@"Describes the delivery or custody arrangement for the underlying securities.")]
[Derivations(typeof(DeliveryType1Code))]
// External derivations that should be provided by the proper interface are: 
public enum DeliveryTypeCode
{
    /// <summary>
    /// Indicates that the delivery is against payment.
    /// Encoded/decoded by serializers as "AGPM".
    /// </summary>
    [EnumMember(Value = "AGPM")]
    [IsoId("_azv0dNp-Ed-ak6NoX_4Aeg_-422136688")]
    [Description(@"Indicates that the delivery is against payment.")]
    AgainstPayment,
    
    /// <summary>
    /// Indicates the delivery is free of payment.
    /// Encoded/decoded by serializers as "FREE".
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("_azv0ddp-Ed-ak6NoX_4Aeg_-170014204")]
    [Description(@"Indicates the delivery is free of payment.")]
    Free,
    
    /// <summary>
    /// Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo.
    /// Encoded/decoded by serializers as "TRIP".
    /// </summary>
    [EnumMember(Value = "TRIP")]
    [IsoId("_azv0dtp-Ed-ak6NoX_4Aeg_-140462836")]
    [Description(@"Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo.")]
    Triparty,
    
    /// <summary>
    /// Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender. Rather, it is placed in an internal account ("held in custody") by the borrower, for the lender, throughout the duration of the trade.
    /// Encoded/decoded by serializers as "HOIC".
    /// </summary>
    [EnumMember(Value = "HOIC")]
    [IsoId("_azv0d9p-Ed-ak6NoX_4Aeg_-134919815")]
    [Description(@"Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender. Rather, it is placed in an internal account (""held in custody"") by the borrower, for the lender, throughout the duration of the trade.")]
    HoldInCustody,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DeliveryTypeCodeMetadataExtensions
{
    private static readonly DeliveryTypeCodeDropdownSource _dropdownSource = new DeliveryTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDeliveryTypeCodeDropdownRow GetMetadata(this DeliveryTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


