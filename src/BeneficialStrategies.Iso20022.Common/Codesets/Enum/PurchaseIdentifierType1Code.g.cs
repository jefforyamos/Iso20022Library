﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PurchaseIdentifierType1Code.  ISO2002 ID# _e3_SAPJQEeiJn9rM2Znz2w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of identifier used in the Purchase Identifier field. 
/// </summary>
[DataContract]
[Serializable]
[IsoId("_e3_SAPJQEeiJn9rM2Znz2w")]
[Description(@"Identifies the type of identifier used in the Purchase Identifier field. ")]
[DerivedFrom(typeof(PurchaseIdentifierTypeCode))]
public enum PurchaseIdentifierType1Code
{
    /// <summary>
    /// Contract Number
    /// Encoded/decoded by serializers as "ContractNumber".
    /// </summary>
    [EnumMember(Value = "CONU")]
    [IsoId("_gqOrsfJQEeiJn9rM2Znz2w")]
    [Description(@"Contract Number")]
    ContractNumber,
    
    /// <summary>
    /// Customer Order
    /// Encoded/decoded by serializers as "CustomerOrder".
    /// </summary>
    [EnumMember(Value = "CUOR")]
    [IsoId("_gwj9MfJQEeiJn9rM2Znz2w")]
    [Description(@"Customer Order")]
    CustomerOrder,
    
    /// <summary>
    /// Customer Purchase Order
    /// Encoded/decoded by serializers as "CustomerPurchaseOrder".
    /// </summary>
    [EnumMember(Value = "CUPO")]
    [IsoId("_g0ZUUfJQEeiJn9rM2Znz2w")]
    [Description(@"Customer Purchase Order")]
    CustomerPurchaseOrder,
    
    /// <summary>
    /// Folio Number
    /// Encoded/decoded by serializers as "FolioNumber".
    /// </summary>
    [EnumMember(Value = "FONU")]
    [IsoId("_g4ApAfJQEeiJn9rM2Znz2w")]
    [Description(@"Folio Number")]
    FolioNumber,
    
    /// <summary>
    /// Invoice Number
    /// Encoded/decoded by serializers as "InvoiceNumber".
    /// </summary>
    [EnumMember(Value = "INNU")]
    [IsoId("_g7xHofJQEeiJn9rM2Znz2w")]
    [Description(@"Invoice Number")]
    InvoiceNumber,
    
    /// <summary>
    /// Order Number
    /// Encoded/decoded by serializers as "OrderNumber".
    /// </summary>
    [EnumMember(Value = "ORNU")]
    [IsoId("_hAyKgfJQEeiJn9rM2Znz2w")]
    [Description(@"Order Number")]
    OrderNumber,
    
    /// <summary>
    /// Other Purchase Identifier defined at a national level.
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_hSflkfJQEeiJn9rM2Znz2w")]
    [Description(@"Other Purchase Identifier defined at a national level.")]
    OtherNational,
    
    /// <summary>
    /// Other Purchase Identifier defined at a private level.
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_hYff4fJQEeiJn9rM2Znz2w")]
    [Description(@"Other Purchase Identifier defined at a private level.")]
    OtherPrivate,
    
    /// <summary>
    /// Payment Reference Number
    /// Encoded/decoded by serializers as "PaymentReferenceNumber".
    /// </summary>
    [EnumMember(Value = "PRNU")]
    [IsoId("_hb288fJQEeiJn9rM2Znz2w")]
    [Description(@"Payment Reference Number")]
    PaymentReferenceNumber,
    
    /// <summary>
    /// Purchase Identification
    /// Encoded/decoded by serializers as "PurchaseIdentification".
    /// </summary>
    [EnumMember(Value = "PUID")]
    [IsoId("_hfKvofJQEeiJn9rM2Znz2w")]
    [Description(@"Purchase Identification")]
    PurchaseIdentification,
    
    /// <summary>
    /// Record Locator
    /// Encoded/decoded by serializers as "RecordLocator".
    /// </summary>
    [EnumMember(Value = "RELO")]
    [IsoId("_hioTUfJQEeiJn9rM2Znz2w")]
    [Description(@"Record Locator")]
    RecordLocator,
    
    /// <summary>
    /// Rental Agreement
    /// Encoded/decoded by serializers as "RentalAgreement".
    /// </summary>
    [EnumMember(Value = "REAG")]
    [IsoId("_hmAXcfJQEeiJn9rM2Znz2w")]
    [Description(@"Rental Agreement")]
    RentalAgreement,
    
    /// <summary>
    /// Rental Number
    /// Encoded/decoded by serializers as "RentalNumber".
    /// </summary>
    [EnumMember(Value = "RENU")]
    [IsoId("_hpS8AfJQEeiJn9rM2Znz2w")]
    [Description(@"Rental Number")]
    RentalNumber,
    
    /// <summary>
    /// Reservation Number
    /// Encoded/decoded by serializers as "ReservationNumber".
    /// </summary>
    [EnumMember(Value = "RSNU")]
    [IsoId("_hs1_QfJQEeiJn9rM2Znz2w")]
    [Description(@"Reservation Number")]
    ReservationNumber,
    
    /// <summary>
    /// Supplier Order
    /// Encoded/decoded by serializers as "SupplierOrder".
    /// </summary>
    [EnumMember(Value = "SUOR")]
    [IsoId("_hxaWMfJQEeiJn9rM2Znz2w")]
    [Description(@"Supplier Order")]
    SupplierOrder,
    
    /// <summary>
    /// Ticket Number 
    /// Encoded/decoded by serializers as "TicketNumber".
    /// </summary>
    [EnumMember(Value = "TINU")]
    [IsoId("_h0zBYfJQEeiJn9rM2Znz2w")]
    [Description(@"Ticket Number ")]
    TicketNumber,
    
    /// <summary>
    /// Tracking Number
    /// Encoded/decoded by serializers as "TrackingNumber".
    /// </summary>
    [EnumMember(Value = "TRNU")]
    [IsoId("_h4l8QfJQEeiJn9rM2Znz2w")]
    [Description(@"Tracking Number")]
    TrackingNumber,
    
    /// <summary>
    /// Supplier Invoice
    /// Encoded/decoded by serializers as "SupplierInvoice".
    /// </summary>
    [EnumMember(Value = "SUIN")]
    [IsoId("_iJh7QfJQEeiJn9rM2Znz2w")]
    [Description(@"Supplier Invoice")]
    SupplierInvoice,
    
    /// <summary>
    /// Transaction Identification is a proprietary value provided by the card acceptor or acquirer to uniquely identify a given transaction. 
    /// Encoded/decoded by serializers as "TransactionIdentification".
    /// </summary>
    [EnumMember(Value = "TNID")]
    [IsoId("_iPBfQfJQEeiJn9rM2Znz2w")]
    [Description(@"Transaction Identification is a proprietary value provided by the card acceptor or acquirer to uniquely identify a given transaction. ")]
    TransactionIdentification,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PurchaseIdentifierType1CodeMetadataExtensions
{
    private static readonly PurchaseIdentifierType1CodeDropdownSource _dropdownSource = new PurchaseIdentifierType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPurchaseIdentifierType1CodeDropdownRow GetMetadata(this PurchaseIdentifierType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


