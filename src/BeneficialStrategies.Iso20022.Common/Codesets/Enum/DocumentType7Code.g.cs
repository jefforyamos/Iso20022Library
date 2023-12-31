﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DocumentType7Code.  ISO2002 ID# _bUOYsNxJEeioifFt1dhnJA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of financial or commercial document.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bUOYsNxJEeioifFt1dhnJA")]
[Description(@"Specifies a type of financial or commercial document.")]
[DerivedFrom(typeof(DocumentTypeCode))]
public enum DocumentType7Code
{
    /// <summary>
    /// When the POI or the Sale System wants to store a message on the journal printer or electronic journal of the Sale Terminal (it is sometimes a Sale Logging/Journal Printer).
    /// Encoded/decoded by serializers as "Journal".
    /// </summary>
    [EnumMember(Value = "JNRL")]
    [IsoId("_nHof4NxKEeioifFt1dhnJA")]
    [Description(@"When the POI or the Sale System wants to store a message on the journal printer or electronic journal of the Sale Terminal (it is sometimes a Sale Logging/Journal Printer).")]
    Journal,
    
    /// <summary>
    /// When the Sale System requires	the POI system to print the Customer receipt.
    /// Encoded/decoded by serializers as "CustomerReceipt".
    /// </summary>
    [EnumMember(Value = "CRCP")]
    [IsoId("_nQrHIdxKEeioifFt1dhnJA")]
    [Description(@"When the Sale System requires	the POI system to print the Customer receipt.")]
    CustomerReceipt,
    
    /// <summary>
    /// When the Sale system print the Cashier copy of the Payment receipt.
    /// Encoded/decoded by serializers as "CashierReceipt".
    /// </summary>
    [EnumMember(Value = "HRCP")]
    [IsoId("_nXT6oNxKEeioifFt1dhnJA")]
    [Description(@"When the Sale system print the Cashier copy of the Payment receipt.")]
    CashierReceipt,
    
    /// <summary>
    /// When the Sale System requires the POI system to print the Sale receipt.
    /// Encoded/decoded by serializers as "SaleReceipt".
    /// </summary>
    [EnumMember(Value = "SRCP")]
    [IsoId("_ndpzMdxKEeioifFt1dhnJA")]
    [Description(@"When the Sale System requires the POI system to print the Sale receipt.")]
    SaleReceipt,
    
    /// <summary>
    /// Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario.
    /// Encoded/decoded by serializers as "RelatedPaymentInstruction".
    /// </summary>
    [EnumMember(Value = "RPIN")]
    [IsoId("_pANyIdxKEeioifFt1dhnJA")]
    [Description(@"Document is a linked payment instruction to which the current payment instruction is related, for example, in a cover scenario.")]
    RelatedPaymentInstruction,
    
    /// <summary>
    /// Document is an electronic payment document.
    /// Encoded/decoded by serializers as "Voucher".
    /// </summary>
    [EnumMember(Value = "VCHR")]
    [IsoId("_qXypEdxKEeioifFt1dhnJA")]
    [Description(@"Document is an electronic payment document.")]
    Voucher,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DocumentType7CodeMetadataExtensions
{
    private static readonly DocumentType7CodeDropdownSource _dropdownSource = new DocumentType7CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDocumentType7CodeDropdownRow GetMetadata(this DocumentType7Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


