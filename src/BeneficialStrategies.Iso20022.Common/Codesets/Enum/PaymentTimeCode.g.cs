﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentTimeCode.  ISO2002 ID# _Z73xQ9p-Ed-ak6NoX_4Aeg_-2012418215.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the payment conditions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z73xQ9p-Ed-ak6NoX_4Aeg_-2012418215")]
[Description(@"Specifies the payment conditions.")]
[Derivations(typeof(PaymentTime1Code),typeof(PaymentTime2Code),typeof(PaymentTime3Code),typeof(PaymentTime4Code))]
// External derivations that should be provided by the proper interface are: 
public enum PaymentTimeCode
{
    /// <summary>
    /// Code for payment on delivery.
    /// Encoded/decoded by serializers as "CASH".
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_Z73xRNp-Ed-ak6NoX_4Aeg_-1967166215")]
    [Description(@"Code for payment on delivery.")]
    PaymentOnDelivery,
    
    /// <summary>
    /// Code for payment at end of month of delivery.
    /// Encoded/decoded by serializers as "EMTD".
    /// </summary>
    [EnumMember(Value = "EMTD")]
    [IsoId("_Z73xRdp-Ed-ak6NoX_4Aeg_-1155391143")]
    [Description(@"Code for payment at end of month of delivery.")]
    EndOfMonthOfDelivery,
    
    /// <summary>
    /// Code for payment at end of period after delivery.
    /// Encoded/decoded by serializers as "EPRD".
    /// </summary>
    [EnumMember(Value = "EPRD")]
    [IsoId("_Z73xRtp-Ed-ak6NoX_4Aeg_-1040874060")]
    [Description(@"Code for payment at end of period after delivery.")]
    EndOfPeriodAfterDelivery,
    
    /// <summary>
    /// Code for payment at end of period after end of month of delivery.
    /// Encoded/decoded by serializers as "PRMD".
    /// </summary>
    [EnumMember(Value = "PRMD")]
    [IsoId("_Z73xR9p-Ed-ak6NoX_4Aeg_-765666214")]
    [Description(@"Code for payment at end of period after end of month of delivery.")]
    EndOfPeriodAfterEndOfDeliveryMonth,
    
    /// <summary>
    /// Code for payment on receipt of invoice.
    /// Encoded/decoded by serializers as "IREC".
    /// </summary>
    [EnumMember(Value = "IREC")]
    [IsoId("_Z73xSNp-Ed-ak6NoX_4Aeg_-292822159")]
    [Description(@"Code for payment on receipt of invoice.")]
    PaymentOnReceiptOfInvoice,
    
    /// <summary>
    /// Code for payment at end of period after end of month of receipt of invoice.
    /// Encoded/decoded by serializers as "PRMR".
    /// </summary>
    [EnumMember(Value = "PRMR")]
    [IsoId("_Z73xSdp-Ed-ak6NoX_4Aeg_-1538322044")]
    [Description(@"Code for payment at end of period after end of month of receipt of invoice.")]
    EndOfPeriodAfterEndOfReceiptMonth,
    
    /// <summary>
    /// Code for payment at end of period after receipt of invoice.
    /// Encoded/decoded by serializers as "EPRR".
    /// </summary>
    [EnumMember(Value = "EPRR")]
    [IsoId("_Z8A7MNp-Ed-ak6NoX_4Aeg_-1538322027")]
    [Description(@"Code for payment at end of period after receipt of invoice.")]
    EndOfPeriodAfterReceipt,
    
    /// <summary>
    /// Code for payment at end of month of receipt of invoice.
    /// Encoded/decoded by serializers as "EMTR".
    /// </summary>
    [EnumMember(Value = "EMTR")]
    [IsoId("_Z8A7Mdp-Ed-ak6NoX_4Aeg_-1538322009")]
    [Description(@"Code for payment at end of month of receipt of invoice.")]
    EndOfMonthOfReceipt,
    
    /// <summary>
    /// Code for payment at end of period after match or mismatch acceptance.
    /// Encoded/decoded by serializers as "EPAM".
    /// </summary>
    [EnumMember(Value = "EPAM")]
    [IsoId("_Z8A7Mtp-Ed-ak6NoX_4Aeg_-582673899")]
    [Description(@"Code for payment at end of period after match or mismatch acceptance.")]
    EndOfPeriodAfterMatch,
    
    /// <summary>
    /// Payment at end of period after shipment date.
    /// Encoded/decoded by serializers as "EPSD".
    /// </summary>
    [EnumMember(Value = "EPSD")]
    [IsoId("_diO1wNP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after shipment date.")]
    EndOfPeriodAfterShipmentDate,
    
    /// <summary>
    /// Payment at end of period after purchase order date.
    /// Encoded/decoded by serializers as "EPPO".
    /// </summary>
    [EnumMember(Value = "EPPO")]
    [IsoId("_l0Ld0NP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after purchase order date.")]
    EndOfPeriodAfterPurchaseOrderDate,
    
    /// <summary>
    /// Payment at end of period after baseline establishment date.
    /// Encoded/decoded by serializers as "EPBE".
    /// </summary>
    [EnumMember(Value = "EPBE")]
    [IsoId("_sXidINP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after baseline establishment date.")]
    EndOfPeriodAfterBaselineEstablishment,
    
    /// <summary>
    /// Payment at end of period after invoice date.
    /// Encoded/decoded by serializers as "EPIN".
    /// </summary>
    [EnumMember(Value = "EPIN")]
    [IsoId("_z9m2oNP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after invoice date.")]
    EndOfPeriodAfterInvoiceDate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentTimeCodeMetadataExtensions
{
    private static readonly PaymentTimeCodeDropdownSource _dropdownSource = new PaymentTimeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentTimeCodeDropdownRow GetMetadata(this PaymentTimeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


