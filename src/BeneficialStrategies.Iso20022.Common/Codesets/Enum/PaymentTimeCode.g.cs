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
public enum PaymentTimeCode
{
    /// <summary>
    /// Code for payment on delivery.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_Z73xRNp-Ed-ak6NoX_4Aeg_-1967166215")]
    [Description(@"Code for payment on delivery.")]
    CASH,
    
    /// <summary>
    /// Code for payment at end of month of delivery.
    /// </summary>
    [EnumMember(Value = "EMTD")]
    [IsoId("_Z73xRdp-Ed-ak6NoX_4Aeg_-1155391143")]
    [Description(@"Code for payment at end of month of delivery.")]
    EMTD,
    
    /// <summary>
    /// Code for payment at end of period after delivery.
    /// </summary>
    [EnumMember(Value = "EPRD")]
    [IsoId("_Z73xRtp-Ed-ak6NoX_4Aeg_-1040874060")]
    [Description(@"Code for payment at end of period after delivery.")]
    EPRD,
    
    /// <summary>
    /// Code for payment at end of period after end of month of delivery.
    /// </summary>
    [EnumMember(Value = "PRMD")]
    [IsoId("_Z73xR9p-Ed-ak6NoX_4Aeg_-765666214")]
    [Description(@"Code for payment at end of period after end of month of delivery.")]
    PRMD,
    
    /// <summary>
    /// Code for payment on receipt of invoice.
    /// </summary>
    [EnumMember(Value = "IREC")]
    [IsoId("_Z73xSNp-Ed-ak6NoX_4Aeg_-292822159")]
    [Description(@"Code for payment on receipt of invoice.")]
    IREC,
    
    /// <summary>
    /// Code for payment at end of period after end of month of receipt of invoice.
    /// </summary>
    [EnumMember(Value = "PRMR")]
    [IsoId("_Z73xSdp-Ed-ak6NoX_4Aeg_-1538322044")]
    [Description(@"Code for payment at end of period after end of month of receipt of invoice.")]
    PRMR,
    
    /// <summary>
    /// Code for payment at end of period after receipt of invoice.
    /// </summary>
    [EnumMember(Value = "EPRR")]
    [IsoId("_Z8A7MNp-Ed-ak6NoX_4Aeg_-1538322027")]
    [Description(@"Code for payment at end of period after receipt of invoice.")]
    EPRR,
    
    /// <summary>
    /// Code for payment at end of month of receipt of invoice.
    /// </summary>
    [EnumMember(Value = "EMTR")]
    [IsoId("_Z8A7Mdp-Ed-ak6NoX_4Aeg_-1538322009")]
    [Description(@"Code for payment at end of month of receipt of invoice.")]
    EMTR,
    
    /// <summary>
    /// Code for payment at end of period after match or mismatch acceptance.
    /// </summary>
    [EnumMember(Value = "EPAM")]
    [IsoId("_Z8A7Mtp-Ed-ak6NoX_4Aeg_-582673899")]
    [Description(@"Code for payment at end of period after match or mismatch acceptance.")]
    EPAM,
    
    /// <summary>
    /// Payment at end of period after shipment date.
    /// </summary>
    [EnumMember(Value = "EPSD")]
    [IsoId("_diO1wNP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after shipment date.")]
    EPSD,
    
    /// <summary>
    /// Payment at end of period after purchase order date.
    /// </summary>
    [EnumMember(Value = "EPPO")]
    [IsoId("_l0Ld0NP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after purchase order date.")]
    EPPO,
    
    /// <summary>
    /// Payment at end of period after baseline establishment date.
    /// </summary>
    [EnumMember(Value = "EPBE")]
    [IsoId("_sXidINP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after baseline establishment date.")]
    EPBE,
    
    /// <summary>
    /// Payment at end of period after invoice date.
    /// </summary>
    [EnumMember(Value = "EPIN")]
    [IsoId("_z9m2oNP7EeK0PPbKncCqzA")]
    [Description(@"Payment at end of period after invoice date.")]
    EPIN,
    
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


