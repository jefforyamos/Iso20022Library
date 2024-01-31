﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PurchaseIdentifierTypeCode.  ISO2002 ID# _dsO7g_JOEeiJn9rM2Znz2w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of identifier used in the Purchase Identifier field. 
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dsO7g_JOEeiJn9rM2Znz2w")]
[Description(@"Identifies the type of identifier used in the Purchase Identifier field. ")]
[Derivations(typeof(PurchaseIdentifierType1Code))]
public enum PurchaseIdentifierTypeCode
{
    /// <summary>
    /// Other Purchase Identifier defined at a national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_dsO7kfJOEeiJn9rM2Znz2w")]
    [Description(@"Other Purchase Identifier defined at a national level.")]
    OtherNational,
    
    /// <summary>
    /// Other Purchase Identifier defined at a private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_dsO7iPJOEeiJn9rM2Znz2w")]
    [Description(@"Other Purchase Identifier defined at a private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Supplier Invoice
    /// Encoded/decoded by serializers as "SUIN".
    /// </summary>
    [EnumMember(Value = "SUIN")]
    [IsoId("_dsO7ivJOEeiJn9rM2Znz2w")]
    [Description(@"Supplier Invoice")]
    SupplierInvoice,
    
    /// <summary>
    /// Record Locator
    /// Encoded/decoded by serializers as "RELO".
    /// </summary>
    [EnumMember(Value = "RELO")]
    [IsoId("_dsO7j_JOEeiJn9rM2Znz2w")]
    [Description(@"Record Locator")]
    RecordLocator,
    
    /// <summary>
    /// Invoice Number
    /// Encoded/decoded by serializers as "INNU".
    /// </summary>
    [EnumMember(Value = "INNU")]
    [IsoId("_dsPigfJOEeiJn9rM2Znz2w")]
    [Description(@"Invoice Number")]
    InvoiceNumber,
    
    /// <summary>
    /// Purchase Identification
    /// Encoded/decoded by serializers as "PUID".
    /// </summary>
    [EnumMember(Value = "PUID")]
    [IsoId("_dsO7hPJOEeiJn9rM2Znz2w")]
    [Description(@"Purchase Identification")]
    PurchaseIdentification,
    
    /// <summary>
    /// Rental Number
    /// Encoded/decoded by serializers as "RENU".
    /// </summary>
    [EnumMember(Value = "RENU")]
    [IsoId("_dsPigvJOEeiJn9rM2Znz2w")]
    [Description(@"Rental Number")]
    RentalNumber,
    
    /// <summary>
    /// Reservation Number
    /// Encoded/decoded by serializers as "RSNU".
    /// </summary>
    [EnumMember(Value = "RSNU")]
    [IsoId("_dsO7hvJOEeiJn9rM2Znz2w")]
    [Description(@"Reservation Number")]
    ReservationNumber,
    
    /// <summary>
    /// Ticket Number 
    /// Encoded/decoded by serializers as "TINU".
    /// </summary>
    [EnumMember(Value = "TINU")]
    [IsoId("_dsPigPJOEeiJn9rM2Znz2w")]
    [Description(@"Ticket Number ")]
    TicketNumber,
    
    /// <summary>
    /// Supplier Order
    /// Encoded/decoded by serializers as "SUOR".
    /// </summary>
    [EnumMember(Value = "SUOR")]
    [IsoId("_dsO7ifJOEeiJn9rM2Znz2w")]
    [Description(@"Supplier Order")]
    SupplierOrder,
    
    /// <summary>
    /// Contract Number
    /// Encoded/decoded by serializers as "CONU".
    /// </summary>
    [EnumMember(Value = "CONU")]
    [IsoId("_dsO7hfJOEeiJn9rM2Znz2w")]
    [Description(@"Contract Number")]
    ContractNumber,
    
    /// <summary>
    /// Folio Number
    /// Encoded/decoded by serializers as "FONU".
    /// </summary>
    [EnumMember(Value = "FONU")]
    [IsoId("_dsPig_JOEeiJn9rM2Znz2w")]
    [Description(@"Folio Number")]
    FolioNumber,
    
    /// <summary>
    /// Payment Reference Number
    /// Encoded/decoded by serializers as "PRNU".
    /// </summary>
    [EnumMember(Value = "PRNU")]
    [IsoId("_dsO7i_JOEeiJn9rM2Znz2w")]
    [Description(@"Payment Reference Number")]
    PaymentReferenceNumber,
    
    /// <summary>
    /// Order Number
    /// Encoded/decoded by serializers as "ORNU".
    /// </summary>
    [EnumMember(Value = "ORNU")]
    [IsoId("_dsO7jPJOEeiJn9rM2Znz2w")]
    [Description(@"Order Number")]
    OrderNumber,
    
    /// <summary>
    /// Customer Order
    /// Encoded/decoded by serializers as "CUOR".
    /// </summary>
    [EnumMember(Value = "CUOR")]
    [IsoId("_dsO7jvJOEeiJn9rM2Znz2w")]
    [Description(@"Customer Order")]
    CustomerOrder,
    
    /// <summary>
    /// Customer Purchase Order
    /// Encoded/decoded by serializers as "CUPO".
    /// </summary>
    [EnumMember(Value = "CUPO")]
    [IsoId("_dsO7kPJOEeiJn9rM2Znz2w")]
    [Description(@"Customer Purchase Order")]
    CustomerPurchaseOrder,
    
    /// <summary>
    /// Rental Agreement
    /// Encoded/decoded by serializers as "REAG".
    /// </summary>
    [EnumMember(Value = "REAG")]
    [IsoId("_dsO7h_JOEeiJn9rM2Znz2w")]
    [Description(@"Rental Agreement")]
    RentalAgreement,
    
    /// <summary>
    /// Transaction Identification is a proprietary value provided by the card acceptor or acquirer to uniquely identify a given transaction. 
    /// Encoded/decoded by serializers as "TNID".
    /// </summary>
    [EnumMember(Value = "TNID")]
    [IsoId("_jPodIPJPEeiJn9rM2Znz2w")]
    [Description(@"Transaction Identification is a proprietary value provided by the card acceptor or acquirer to uniquely identify a given transaction. ")]
    TransactionIdentification,
    
    /// <summary>
    /// Tracking Number
    /// Encoded/decoded by serializers as "TRNU".
    /// </summary>
    [EnumMember(Value = "TRNU")]
    [IsoId("_l4c5gPJPEeiJn9rM2Znz2w")]
    [Description(@"Tracking Number")]
    TrackingNumber,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PurchaseIdentifierTypeCodeMetadataExtensions
{
    private static readonly PurchaseIdentifierTypeCodeDropdownSource _dropdownSource = new PurchaseIdentifierTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPurchaseIdentifierTypeCodeDropdownRow GetMetadata(this PurchaseIdentifierTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


